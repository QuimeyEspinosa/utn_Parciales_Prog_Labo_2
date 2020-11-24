using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public delegate bool MiTransaccion(Pedido miPedido);

    public static class Comercio
    {
        static public event MiTransaccion RealizarPedido;

        static List<Hamburguesa> misHamburguesas;
        static Queue<Pedido> pedidosEnPreparacion;
        static Queue<Pedido> pedidosListosParaRetirar;
        static Queue<Pedido> pedidosEntregados;

        #region Constructores

        /// <summary>
        /// Constructor estático de Comercio
        /// Asigna los manejadores de los eventos e instancia las listas/queues
        /// </summary>
        static Comercio()
        {
            misHamburguesas = DAO.GetHamburguesas(); //cargo las hamburguesas de la base
            pedidosEnPreparacion = new Queue<Pedido>(); //acá iria la carga del xml
            pedidosListosParaRetirar = new Queue<Pedido>();
            pedidosEntregados = new Queue<Pedido>();

            RealizarPedido += DAO.InsertarPedido;
            RealizarPedido += GenerarDeliveryTxt;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Get y Set de las hamburguesas del comercio
        /// </summary>
        public static List<Hamburguesa> MisHamburguesas { get => misHamburguesas; set => misHamburguesas = value; }

        /// <summary>
        /// Get y Set de los pedidos en preparación del comercio
        /// </summary>
        public static Queue<Pedido> PedidosEnPreparacion { get => pedidosEnPreparacion; set => pedidosEnPreparacion = value; }

        /// <summary>
        /// Get y Set de los pedidos listos para retirar del comercio
        /// </summary>
        public static Queue<Pedido> PedidosListosParaRetirar { get => pedidosListosParaRetirar; set => pedidosListosParaRetirar = value; }

        /// <summary>
        /// Get y Set de los pedidos entregados del comercio
        /// </summary>
        public static Queue<Pedido> PedidosEntregados { get => pedidosEntregados; set => pedidosEntregados = value; }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que ejecutan los threads.
        /// Simula preparar un pedido
        /// </summary>
        public static void Preparar()
        {
            if (PedidosEnPreparacion.Count > 0)
            {
                PedidosListosParaRetirar.Enqueue(PedidosEnPreparacion.Dequeue());
            }
        }

        /// <summary>
        /// Método que ejecutan los threads.
        /// Simula entregar un pedido
        /// </summary>
        public static void Entregar()
        {
            if (PedidosListosParaRetirar.Count > 0)
            {
                PedidosEntregados.Enqueue(PedidosListosParaRetirar.Dequeue());
            }
        }

        #region Ventas

        /// <summary>
        /// Genera una nueva lista de hamburguesas aleatoria
        /// </summary>
        /// <returns>Lista de hamburguesas aleatoria</returns>
        private static List<Hamburguesa> GetProductosRandom()
        {
            Random randProd = new Random(DateTime.Now.Millisecond);
            int cantProductos = randProd.Next(1, 6);
            List<Hamburguesa> auxBurguers = new List<Hamburguesa>();

            do
            {
                switch (randProd.Next(1, 4))
                {
                    case 1:
                        auxBurguers.Add(new Hamburguesa(1, "Simple", 250));
                        break;
                    case 2:
                        auxBurguers.Add(new Hamburguesa(2, "Doble", 375));
                        break;
                    case 3:
                        auxBurguers.Add(new Hamburguesa(3, "Triple", 450));
                        break;
                }

                cantProductos--;
            } while (cantProductos > 0);

            return auxBurguers;
        }

        /// <summary>
        /// Genera un nuevo pedido aleatorio con una lista de productos aleatoria
        /// </summary>
        /// <returns></returns>
        public static Pedido NuevoPedidoRandom()
        {
            List<Hamburguesa> auxCB = GetProductosRandom();
            Pedido auxPedido;
            int ultimoPedido;
            bool delivery = RandomElement.Boolean();
            float auxMontoTotal = 0;

            foreach (Hamburguesa item in auxCB)
            {
                auxMontoTotal += item.Precio;
            }

            ultimoPedido = DAO.GetIdUltimoPedido();

            if (delivery)
            {
                auxPedido = new Pedido(RandomElement.Nombre(), auxCB, ultimoPedido + 1, delivery, RandomElement.Calle(), auxMontoTotal);
            }
            else
            {
                auxPedido = new Pedido(RandomElement.Nombre(), auxCB, ultimoPedido + 1, delivery, auxMontoTotal);
            }

            return auxPedido;
        }

        /// <summary>
        /// Realiza el pedido pasado por parámetro e invoca al evento RealizarPedido
        /// </summary>
        /// <param name="nuevoPedido">Pedido a realizar</param>
        /// <returns></returns>
        public static bool ConfirmarPedido(Pedido nuevoPedido)
        {
            bool confirma = false;
            try
            {
                if (!(nuevoPedido is null))
                {
                    RealizarPedido.Invoke(nuevoPedido);
                    PedidosEnPreparacion.Enqueue(nuevoPedido);
                    confirma = true;
                }
                else
                {
                    throw new NuevoPedidoException("No se pudo concretar el pedido");
                }
            }
            catch (Exception ex)
            {
                throw new NuevoPedidoException("No se pudo concretar el pedido" + ex.Message);
            }

            return confirma;
        }

        /// <summary>
        /// Genera un ticket con la información del pedido y de donde debe entregarlo el delivery
        /// </summary>
        /// <param name="miPedido"></param>
        /// <returns></returns>
        private static bool GenerarDeliveryTxt(Pedido miPedido)
        {
            Texto txt = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory;

            if(miPedido.TieneDelivery)
            {
                return txt.Guardar(path + "\\Pedidos\\" + $"Pedido N{miPedido.NumPedido}.txt", miPedido.ToString());
            }
            else
            {
                return false;
            }            
        }

        /// <summary>
        /// Carga los pedidos en preparacion de un archivo Xml a la queue correspondiente
        /// </summary>
        public static void CargarPedidosXml()
        {
            Xml<List<Pedido>> auxArchivo = new Xml<List<Pedido>>();
            string path = AppDomain.CurrentDomain.BaseDirectory;

            if (auxArchivo.Leer(path + @"PedidosEnPreparacion.xml", out List<Pedido> auxLista))
            {
                for (int i = 0; i < auxLista.Count; i++)
                {
                    PedidosEnPreparacion.Enqueue(auxLista[i]);
                }
            }
        }

        /// <summary>
        /// Guarda los pedidos en preparacion en un archivo Xml
        /// </summary>
        public static void GuardarPedidosEnPreparacionXml()
        {
            List<Pedido> auxPedidos = new List<Pedido>();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Xml<List<Pedido>> auxArchivo = new Xml<List<Pedido>>();

            while (PedidosEnPreparacion.Count != 0)
            {
                auxPedidos.Add(PedidosEnPreparacion.Dequeue());
            }

            auxArchivo.Guardar(path + @"PedidosEnPreparacion.xml", auxPedidos);
        }

        #endregion

        #endregion


        //Consultar duda----
        /*
        public static void Preparar()
        {
            do
            {
                if (PedidosEnPreparacion.Count > 0)
                {
                    PedidosListosParaRetirar.Enqueue(PedidosEnPreparacion.Dequeue());
                    Thread.Sleep(RandomElement.TiempoPreparacionRandom());
                }
                else
                {
                    Thread.Sleep(RandomElement.TiempoPreparacionRandom());
                }

            } while (true);
        }
        public static void Entregar()
        {
            do
            {
                if (PedidosListosParaRetirar.Count > 0)
                {
                    PedidosEntregados.Enqueue(PedidosListosParaRetirar.Dequeue());
                    Thread.Sleep(RandomElement.TiempoEntregaRandom());
                }
                else
                {
                    Thread.Sleep(RandomElement.TiempoEntregaRandom());
                }

            } while (true);
        }
        */
    }
}
