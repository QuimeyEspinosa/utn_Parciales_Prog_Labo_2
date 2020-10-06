using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FrmNuevaVenta : Form
    {
        private List<Producto> auxListaProductos;
        private double auxPrecioTotal;
        private Cliente clienteComprador;
        private Empleado empleadoVendedor;

        public FrmNuevaVenta()
        {
            InitializeComponent();
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            auxListaProductos = new List<Producto>();
            RefrescarDgvProductosVenta(Comercio.ProductosEnStock());
            RefrescarDgvClientesVenta(Comercio.MisClientes);
        }
        private void dgv_ProductosVenta_DoubleClick(object sender, EventArgs e)
        {
            Producto auxProductoCompra;
            FrmCantidadAComprar frmCantidadAComprar = new FrmCantidadAComprar();
            int auxCantidad;
            //obtengo el numero de articulo del producto seleccionado
            int auxNumArtProducto = (int)dgv_ProductosVenta.CurrentRow.Cells["NumArticulo"].Value;
            //obtengo el indice del articulo seleccionado en base a su id del producto
            int auxIndiceProducto = Comercio.GetIndiceProductoByIdProducto(auxNumArtProducto);
            //Producto.ETipo auxTipoProducto = (Producto.ETipo)dgv_ProductosVenta.CurrentRow.Cells["Tipo"].Value;
            string auxTipoProducto = dgv_ProductosVenta.CurrentRow.Cells["Tipo"].Value.ToString();

            frmCantidadAComprar.IndiceProducto = auxIndiceProducto;

            if (frmCantidadAComprar.ShowDialog() == DialogResult.OK)
            {
                auxCantidad = frmCantidadAComprar.CantidadAComprar;

                switch (auxTipoProducto)
                {
                    case "Almacen":
                        auxProductoCompra = new ProductoAlmacen(auxNumArtProducto, Comercio.MisProductos[auxIndiceProducto].Descripcion, Comercio.MisProductos[auxIndiceProducto].PrecioUnitario, auxCantidad, Producto.ETipo.Almacen);

                        if (auxProductoCompra == auxListaProductos)
                        {
                            for (int i = 0; i < auxListaProductos.Count; i++)
                            {
                                if (auxListaProductos[i].NumArticulo == auxProductoCompra.NumArticulo)
                                {
                                    auxListaProductos[i].Unidades += auxCantidad;
                                }
                            }
                        }
                        else
                        {
                            if(auxListaProductos + auxProductoCompra)
                            {
                            }
                        }
                        auxPrecioTotal += auxProductoCompra.PrecioUnitario * auxProductoCompra.Unidades;
                        break;

                    case "Refrigerado":
                        auxProductoCompra = new ProductoRefrigerado(auxNumArtProducto, Comercio.MisProductos[auxIndiceProducto].Descripcion, Comercio.MisProductos[auxIndiceProducto].PrecioUnitario, auxCantidad, Producto.ETipo.Refrigerado);
                        
                        if (auxProductoCompra == auxListaProductos)
                        {
                            for (int i = 0; i < auxListaProductos.Count; i++)
                            {
                                if (auxListaProductos[i].NumArticulo == auxProductoCompra.NumArticulo)
                                {
                                    auxListaProductos[i].Unidades += auxCantidad;
                                }
                            }
                        }
                        else
                        {
                            if (auxListaProductos + auxProductoCompra)
                            {
                            }
                        }
                        auxPrecioTotal += auxProductoCompra.PrecioUnitario * auxProductoCompra.Unidades;
                        break;

                    case "Revista":
                        auxProductoCompra = new ProductoRevista(auxNumArtProducto, Comercio.MisProductos[auxIndiceProducto].Descripcion, Comercio.MisProductos[auxIndiceProducto].PrecioUnitario, auxCantidad, Producto.ETipo.Revista);

                        if (auxProductoCompra == auxListaProductos)
                        {
                            for (int i = 0; i < auxListaProductos.Count; i++)
                            {
                                if (auxListaProductos[i].NumArticulo == auxProductoCompra.NumArticulo)
                                {
                                    auxListaProductos[i].Unidades += auxCantidad;
                                }
                            }
                        }
                        else
                        {
                            if (auxListaProductos + auxProductoCompra)
                            {
                            }
                        }
                        auxPrecioTotal += auxProductoCompra.PrecioUnitario * auxProductoCompra.Unidades;
                        break;
                }



                lbl_MontoTotal.Text = auxPrecioTotal.ToString();
                RefrescarDgvCarritoVenta(auxListaProductos);
                RefrescarDgvProductosVenta(Comercio.ProductosEnStock());
            }
        }

        private void dgv_CarritoVenta_DoubleClick(object sender, EventArgs e)
        {
            if (!(dgv_CarritoVenta.DataSource is null || auxListaProductos is null))
            {
                int auxNumArtProducto = (int)dgv_CarritoVenta.CurrentRow.Cells["NumArticulo"].Value;

                for (int i = 0; i < auxListaProductos.Count; i++)
                {
                    if (auxListaProductos[i].NumArticulo == auxNumArtProducto)
                    {
                        MessageBox.Show($"{auxListaProductos[i].ToString()}",
                                            "Detalle de producto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay productos asignados para mostrar su detalle",
                                            "Detalle de producto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
            }
        }

        private void btn_VaciarCarrito_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Comercio.MisProductos.Count; i++)
            {
                for (int j = 0; j < auxListaProductos.Count; j++)
                {
                    if (Comercio.MisProductos[i].NumArticulo == auxListaProductos[j].NumArticulo)
                    {
                        Comercio.MisProductos[i].Unidades += auxListaProductos[j].Unidades;
                    }
                }
            }

            RefrescarDgvProductosVenta(Comercio.MisProductos);
            auxListaProductos.Clear();
            dgv_CarritoVenta.DataSource = null;
            auxPrecioTotal = 0;
            lbl_MontoTotal.Text = auxPrecioTotal.ToString();
        }

        private void dgv_ClientesNuevaVenta_DoubleClick(object sender, EventArgs e)
        {
            int auxDniCliente = (int)dgv_ClientesNuevaVenta.CurrentRow.Cells["Dni"].Value;

            for (int i = 0; i < Comercio.MisClientes.Count; i++)
            {
                if (auxDniCliente == Comercio.MisClientes[i].Dni)
                {
                    clienteComprador = Comercio.MisClientes[i];
                }
            }

            lbl_ClienteComprador.Text = clienteComprador.Nombre + " " + clienteComprador.Apellido;
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Comercio.MisEmpleados.Count; i++)
            {
                if (Comercio.NombreUsuarioLog == Comercio.MisEmpleados[i].Usuario)
                {
                    empleadoVendedor = Comercio.MisEmpleados[i];
                }
            }

            if (!(clienteComprador is null))
            {
                if (!(empleadoVendedor is null))
                {
                    if (!(auxListaProductos is null))
                    {
                        if (auxPrecioTotal > 0)
                        {
                            if (clienteComprador.Apellido == "Simpson")
                            {
                                double precioSinDescuento = auxPrecioTotal;
                                auxPrecioTotal = auxPrecioTotal * 0.87;
                                MessageBox.Show($"Por ser miembro de la familia Simpson obtiene un 13% de descuento sobre el monto total! \n Precio total sin descuento: uS${precioSinDescuento} \n Precio total con descuento: uS${this.auxPrecioTotal}",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            }

                            //Creo una venta auxiliar y la agrego a la lista de ventas de Comercio
                            Venta auxVenta = new Venta(empleadoVendedor, clienteComprador, auxListaProductos, auxPrecioTotal);

                            if (Comercio.AgregarVenta(auxVenta))
                            {
                                if (checkbox_GenerarTicket.Checked)
                                {
                                    Comercio.GenerarTicketCompra(auxVenta);
                                }

                                SoundPlayer marioBrosCoin = new SoundPlayer(Path.Combine(Application.StartupPath, "sound\\Super Mario Bros - Coin Sound Effect.wav"));
                                marioBrosCoin.Play();

                                MessageBox.Show("Compra realizada con éxitos!!, Gracias!! Vuelva prontosss",
                                        "Compra Exitosa",
                                        MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("No pudo realizarse la venta",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                            }

                            this.empleadoVendedor = null;
                            this.clienteComprador = null;
                            this.auxListaProductos.Clear();
                            this.auxPrecioTotal = 0;
                            dgv_CarritoVenta.DataSource = null;
                            this.lbl_ClienteComprador.Text = null;
                            this.lbl_MontoTotal.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Deben asignarse productos para vender",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se han asignado productos para comprar",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha asignado un empleado",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se ha asignado un cliente",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }


        private void linklbl_AgregarNuevoClienteVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();

            if (frmAltaCliente.ShowDialog() == DialogResult.OK)
            {
                if (!Comercio.AgregarCliente(frmAltaCliente.MiCliente))
                {
                    MessageBox.Show("No se puede agregar un cliente con un número de dni ya existente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Se agregó correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            RefrescarDgvClientesVenta(Comercio.MisClientes);
        }

        private void RefrescarDgvClientesVenta(List<Cliente> clientes)
        {
            dgv_ClientesNuevaVenta.DataSource = null;
            dgv_ClientesNuevaVenta.DataSource = clientes;
            dgv_ClientesNuevaVenta.Columns["NombreYApellido"].Visible = false;
        }

        private void RefrescarDgvProductosVenta(List<Producto> productos)
        {
            dgv_ProductosVenta.DataSource = null;
            dgv_ProductosVenta.DataSource = productos;
        }

        private void RefrescarDgvCarritoVenta(List<Producto> productosCarrito)
        {
            dgv_CarritoVenta.DataSource = null;
            dgv_CarritoVenta.DataSource = productosCarrito;
        }

        private void dgv_ProductosVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_ProductosVenta.Columns[e.ColumnIndex].Name == "Unidades")
            {
                if (Convert.ToInt32(e.Value) == 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Black;
                }
                else if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }

            if (this.dgv_ProductosVenta.Columns[e.ColumnIndex].Name == "PrecioUnitario")
            {
                e.Value = "$ " + e.Value;
            }
        }

        private void dgv_CarritoVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_ProductosVenta.Columns[e.ColumnIndex].Name == "PrecioUnitario")
            {
                e.Value = "$ " + e.Value;
            }
        }
    }
}
