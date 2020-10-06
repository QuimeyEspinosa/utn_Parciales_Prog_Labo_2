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
    public partial class FrmModificarProducto : Form
    {
        int auxNumArticulo;

        public int NumArticulo
        {
            set { this.auxNumArticulo = value; }
        }


        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            int auxNuevoStock;

            if(int.TryParse(txt_StockProducto.Text, out auxNuevoStock))
            {
                if(auxNuevoStock >= 0)
                {
                    for (int i = 0; i < Comercio.MisProductos.Count; i++)
                    {
                        if (Comercio.MisProductos[i].NumArticulo == this.auxNumArticulo)
                        {
                            Comercio.MisProductos[i].Unidades = auxNuevoStock;
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El número ingresado debe ser positivo",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dato inválido",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void btn_CancelarAgregarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
