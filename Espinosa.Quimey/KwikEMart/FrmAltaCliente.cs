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
    public partial class FrmAltaCliente : Form
    {
        private Cliente miCliente;

        public Cliente MiCliente
        {
            get { return this.miCliente; }
            set { miCliente = value; }
        }

        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            int auxIdCliente;

            //Si los datos son validos
            if (int.TryParse(this.txt_DniCliente.Text, out auxIdCliente) &&
                !string.IsNullOrEmpty(this.txt_NombreCliente.Text) &&
                !string.IsNullOrEmpty(this.txt_ApellidoCliente.Text))
            {
                //Creo un nuevo cliente
                miCliente = new Cliente(auxIdCliente, this.txt_NombreCliente.Text, this.txt_ApellidoCliente.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void txt_NombreCliente_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveString(((TextBox)sender).Text.Trim());
        }

        private void txt_ApellidoCliente_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveString(((TextBox)sender).Text.Trim());
        }

        private void txt_DniCliente_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = Validaciones.AsignarLeaveStringNumero(((TextBox)sender).Text.Trim());
        }

        private void btn_CancelarAgregarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
