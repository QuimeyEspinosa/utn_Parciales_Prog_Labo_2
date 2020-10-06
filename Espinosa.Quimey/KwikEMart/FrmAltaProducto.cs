using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwikEMart
{
    public partial class FrmAltaProducto : Form
    {
        private Producto miProducto;

        public Producto MiProducto
        {
            get { return miProducto; }
            set { miProducto = value; }
        }

        public FrmAltaProducto()
        {
            InitializeComponent();
        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            this.cmb_TipoProducto.DataSource = Enum.GetValues(typeof(Producto.ETipo));
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            int auxNumArticulo;
            double auxPrecioProducto;
            int auxStock;

            //Si los datos son validos
            if (int.TryParse(this.txt_NumArticuloProducto.Text, out auxNumArticulo))
            {
                if (!string.IsNullOrEmpty(this.txt_DescripcionProducto.Text))
                {
                    if (double.TryParse(this.txt_PrecioProducto.Text, out auxPrecioProducto))
                    {
                        if (int.TryParse(this.txt_StockProducto.Text, out auxStock))
                        {
                            switch (cmb_TipoProducto.SelectedValue.ToString())
                            {
                                case "Almacen":
                                    miProducto = new ProductoAlmacen(auxNumArticulo, this.txt_DescripcionProducto.Text, auxPrecioProducto, auxStock, Producto.ETipo.Almacen);
                                    this.DialogResult = DialogResult.OK;
                                    break;
                                case "Refrigerado":
                                    miProducto = new ProductoRefrigerado(auxNumArticulo, this.txt_DescripcionProducto.Text, auxPrecioProducto, auxStock, Producto.ETipo.Refrigerado);
                                    this.DialogResult = DialogResult.OK;
                                    break;
                                case "Revista":
                                    miProducto = new ProductoRevista(auxNumArticulo, this.txt_DescripcionProducto.Text, auxPrecioProducto, auxStock, Producto.ETipo.Revista);
                                    this.DialogResult = DialogResult.OK;
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha ingresado un stock válido",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado un precio válido",
                           "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha ingresado una descripción válida",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número de artículo válido",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }


        private void txt_NumArticuloProducto_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveStringNumero(((TextBox)sender).Text.Trim());
        }

        private void txt_MarcaProducto_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveString(((TextBox)sender).Text.Trim());
        }

        private void txt_DescripcionProducto_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveString(((TextBox)sender).Text.Trim());
        }

        private void txt_PrecioProducto_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveStringNumero(((TextBox)sender).Text.Trim());
        }

        private void txt_StockProducto_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveStringNumero(((TextBox)sender).Text.Trim());
        }

        private void btn_CancelarAgregarProducto_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
