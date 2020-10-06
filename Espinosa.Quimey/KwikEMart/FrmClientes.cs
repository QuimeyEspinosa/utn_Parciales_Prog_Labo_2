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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            RefrescarDgvClientes(Comercio.MisClientes);
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
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

            RefrescarDgvClientes(Comercio.MisClientes);
        }

        private void RefrescarDgvClientes(List<Cliente> clientes)
        {
            dgv_Clientes.DataSource = null;
            dgv_Clientes.DataSource = clientes;
            dgv_Clientes.Columns[1].Visible = false;
        }

    }
}
