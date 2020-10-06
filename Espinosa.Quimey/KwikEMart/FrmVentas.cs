using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwikEMart
{  
    public partial class FrmVentas : Form
    {     
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            RefrescarDgvEmpleadosVenta(Comercio.MisEmpleados);
            RefrescarDgvVentas(Comercio.MisVentas);
        }      

        private void dgv_Ventas_DoubleClick(object sender, EventArgs e)
        {
            FrmDescripcionVenta frmDescripcionVenta = new FrmDescripcionVenta();
            frmDescripcionVenta.IdVenta = (int)dgv_Ventas.CurrentRow.Cells["IdVenta"].Value;

            frmDescripcionVenta.ShowDialog();
        }
        private void dgv_Empleados_DoubleClick(object sender, EventArgs e)
        {
            FrmVentasEmpleado frmVentasEmpleado = new FrmVentasEmpleado();
            frmVentasEmpleado.IdEmpleado = (int)dgv_Empleados.CurrentRow.Cells["Id"].Value;

            frmVentasEmpleado.ShowDialog();
        }

        private void RefrescarDgvVentas(List<Venta> ventas)
        {
            dgv_Ventas.DataSource = null;
            dgv_Ventas.DataSource = ventas;
            dgv_Ventas.Columns["IdEmpleado"].Visible = false;

        }
        private void RefrescarDgvEmpleadosVenta(List<Empleado> empleados)
        {
            dgv_Empleados.DataSource = null;
            dgv_Empleados.DataSource = empleados;
            dgv_Empleados.Columns["Contraseña"].Visible = false;
            dgv_Empleados.Columns["NombreYApellido"].Visible = false;
            dgv_Empleados.Columns["Sueldo"].Visible = false;
            dgv_Empleados.Columns["Usuario"].Visible = false;
        }

        private void dgv_Ventas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_Ventas.Columns[e.ColumnIndex].Name == "PrecioTotal")
            {
                e.Value = "$ " + e.Value;
            }
        }
    }
}
