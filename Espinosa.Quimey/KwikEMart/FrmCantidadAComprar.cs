using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FrmCantidadAComprar : Form
    {
        int cantCompra;
        int indiceProducto;

        public int CantidadAComprar
        {
            get { return this.cantCompra; }
        }

        public int IndiceProducto
        {
            set { this.indiceProducto = value; }
        }


        public FrmCantidadAComprar()
        {
            InitializeComponent();
        }
        private void FrmCantidadAComprar_Load(object sender, EventArgs e)
        {
            txt_CantidadAComprar.Text = "1";
        }


        private void btn_AsignarCantidad_Click(object sender, EventArgs e)
        {
            int auxCantidad;

            if(int.TryParse(txt_CantidadAComprar.Text, out auxCantidad))
            {
                if(Validaciones.EsPositivo(auxCantidad))
                {
                    if(auxCantidad > 0)
                    {
                        if (Comercio.DescontarStock(indiceProducto, auxCantidad))
                        {
                            cantCompra = auxCantidad;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("El numero ingresado excede a la cantidad de stock",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un numero mayor a cero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero positivo",
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

        private void btn_CancelarCantidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
