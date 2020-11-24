using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using Archivos;

namespace Formularios
{
    public delegate void MiApp();

    public partial class FrmPrincipal : Form
    {
        public event MiApp IniciarApp;
        Thread thPrincipal;
        Thread thPreparador;
        Thread thDelivery;

        public FrmPrincipal()
        {
            InitializeComponent();
            IniciarApp += Comercio.CargarPedidosXml;
            IniciarApp += AgregarThreads;
            IniciarApp += AbrirNegocio;
        }

        /// <summary>
        /// Invoca al evento IniciarApp y carga el rtxt de PedidosEnPreparacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                thPrincipal = new Thread(IniciarApp.Invoke);
                thPrincipal.Start();
                rtxt_EnPreparacion.Text = string.Empty;
                foreach (Pedido item in Comercio.PedidosEnPreparacion)
                {
                    rtxt_EnPreparacion.Text += item.ToString();
                }
            }
            catch (ArchivoException miEx)
            {
                MessageBox.Show(miEx.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                ex.Guardar();
            }
        }


        /// <summary>
        /// Asigna los métodos que van a ejecutar los threads
        /// </summary>
        private void AgregarThreads()
        {
            //Asigno métodos a los threads
            thPreparador = new Thread(Preparar);
            thDelivery = new Thread(Entregar);
            //thPreparador = new Thread(Comercio.Preparar);
            //thDelivery = new Thread(Comercio.Entregar);
        }

        /// <summary>
        /// Inicia los threads
        /// </summary>
        private void AbrirNegocio()
        {
            //inicio los threads
            try
            {
                thPreparador.Start();
                thDelivery.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Guardar();
            }
        }

        /// <summary>
        /// Simula el tiempo de preparación de los pedidos entre 4 y 7 segundos
        /// Actualiza los rtxt correspondientes
        /// </summary>
        private void Preparar()
        {
            try
            {
                //preparo constantemente
                while (true)
                {
                    Thread.Sleep(1000);
                    if (Comercio.PedidosEnPreparacion.Count > 0)
                    {
                        Comercio.Preparar();

                        if (this.rtxt_EnPreparacion.InvokeRequired)
                        {
                            this.rtxt_EnPreparacion.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.rtxt_EnPreparacion.Text = string.Empty;
                                foreach (Pedido item in Comercio.PedidosEnPreparacion)
                                {
                                    this.rtxt_EnPreparacion.Text += item.ToString();
                                }
                            });
                        }
                        if (this.rtxt_ListosParaRetirar.InvokeRequired)
                        {
                            this.rtxt_ListosParaRetirar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.rtxt_ListosParaRetirar.Text = string.Empty;
                                foreach (Pedido item in Comercio.PedidosListosParaRetirar)
                                {
                                    this.rtxt_ListosParaRetirar.Text += item.ToString();
                                }
                            });
                        }
                    }
                    Thread.Sleep(RandomElement.TiempoPreparacionRandom());
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ex.Guardar();
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Guardar();
            }

        }

        /// <summary>
        /// Simula el tiempo de entrega de los pedidos entre 7,2 y 11 segundos
        /// </summary>
        private void Entregar()
        {
            try
            {
                while (true)
                {                   
                    Thread.Sleep(RandomElement.TiempoEntregaRandom());
                    if (Comercio.PedidosListosParaRetirar.Count > 0)
                    {
                        Comercio.Entregar();

                        if (this.rtxt_ListosParaRetirar.InvokeRequired)
                        {
                            this.rtxt_ListosParaRetirar.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.rtxt_ListosParaRetirar.Text = string.Empty;
                                foreach (Pedido item in Comercio.PedidosListosParaRetirar)
                                {
                                    this.rtxt_ListosParaRetirar.Text += item.ToString();
                                }
                            });
                        }
                        if (this.rtxt_PedidosEntregados.InvokeRequired)
                        {
                            this.rtxt_PedidosEntregados.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.rtxt_PedidosEntregados.Text = string.Empty;
                                foreach (Pedido item in Comercio.PedidosEntregados)
                                {
                                    this.rtxt_PedidosEntregados.Text += item.ToString();
                                }
                            });
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ex.Guardar();
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Guardar();
            }
        }

        /// <summary>
        /// Aborta los hilos
        /// </summary>
        private void CerrarNegocio()
        {
            thPreparador.Abort();
            thDelivery.Abort();
            thPrincipal.Abort();
        }


        /// <summary>
        /// Genera un pedido aleatorio y la agrega al comercio y a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nuevoPedido = Comercio.NuevoPedidoRandom();

                if(Comercio.ConfirmarPedido(nuevoPedido))
                {
                    this.rtxt_EnPreparacion.Text += nuevoPedido.ToString();
                }                
            }
            catch (NuevoPedidoException miEx)
            {
                MessageBox.Show(miEx.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                ex.Guardar();
            }
        }


        /// <summary>
        /// Al cerrar el formulario aborta los hilos y guarda las Ventas pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CerrarNegocio();
                Comercio.GuardarPedidosEnPreparacionXml();
            }
            catch (ArchivoException miEx)
            {
                MessageBox.Show(miEx.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (ThreadAbortException miEx)
            {
                MessageBox.Show("Finalizó el programa con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                ex.Guardar();
            }
        }


        /*
        private void Actualizar()
        {
            try
            {
                //actualizo constantemente
                while (true)
                {
                    Thread.Sleep(1000);
                    //si el rtxt pertenece a otro hilo...
                    if (this.rtxt_EnPreparacion.InvokeRequired)
                    {
                        this.rtxt_EnPreparacion.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.rtxt_EnPreparacion.Text = string.Empty;
                            foreach (Pedido item in Comercio.PedidosEnPreparacion)
                            {
                                this.rtxt_EnPreparacion.Text += item.ToString();
                            }
                        });
                    }
                    if (this.rtxt_ListosParaRetirar.InvokeRequired)
                    {
                        this.rtxt_ListosParaRetirar.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.rtxt_ListosParaRetirar.Text = string.Empty;
                            foreach (Pedido item in Comercio.PedidosListosParaRetirar)
                            {
                                this.rtxt_ListosParaRetirar.Text += item.ToString();
                            }
                        });
                    }
                    if (this.rtxt_PedidosEntregados.InvokeRequired)
                    {
                        this.rtxt_PedidosEntregados.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.rtxt_PedidosEntregados.Text = string.Empty;
                            foreach (Pedido item in Comercio.PedidosEntregados)
                            {
                                this.rtxt_PedidosEntregados.Text += item.ToString();
                            }
                        });
                    }
                    Thread.Sleep(2800);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ex.Guardar();
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Finalizó el programa con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Guardar();
            }
        }
        */
    }
}
