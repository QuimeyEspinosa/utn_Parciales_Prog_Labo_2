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
    public partial class FrmLogin : Form
    {
        string nombreUsuario;
        string claveUsuario;

        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
        }

        public string ClaveUsuario
        {
            get { return this.claveUsuario; }
        }


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string auxNombreUsuario = txt_LoginUsuario.Text;
            string auxContraseña = txt_LoginContraseña.Text;

            if (Comercio.LoginEmpleadoValido(auxNombreUsuario, auxContraseña))
            {
                nombreUsuario = auxNombreUsuario;
                claveUsuario = auxContraseña;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No existe un usuario con los datos ingresados",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }


        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            StringBuilder usuarios = new StringBuilder();

            usuarios.AppendLine("Usuario: Apusin");
            usuarios.AppendLine("Contraseña: apusote123");
            usuarios.AppendLine("");
            usuarios.AppendLine("Usuario: Sanjasin");
            usuarios.AppendLine("Contraseña: sanjasote123");
            usuarios.AppendLine("");
            usuarios.AppendLine("Usuario: Lucas1234");
            usuarios.AppendLine("Contraseña: lucas1234");
            usuarios.AppendLine("");
            usuarios.AppendLine("Usuario: Eze1234");
            usuarios.AppendLine("Contraseña: ezequiel1234");

            MessageBox.Show($"{usuarios}",
                                            "Solo con fines didácticos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
        }
        private void btn_LoginSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
