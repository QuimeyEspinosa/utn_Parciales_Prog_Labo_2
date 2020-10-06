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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            RefrescarDgvEmpleados(Comercio.MisEmpleados);
        }

        private void RefrescarDgvEmpleados(List<Empleado> empleados)
        {
            dgv_Empleados.DataSource = null;
            dgv_Empleados.DataSource = empleados;
            dgv_Empleados.Columns[3].Visible = false;
            dgv_Empleados.Columns[4].Visible = false;
        }
    }
}
