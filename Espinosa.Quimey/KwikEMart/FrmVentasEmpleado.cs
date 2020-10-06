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
    public partial class FrmVentasEmpleado : Form
    {
        int idEmpleado;
        public int IdEmpleado
        {
            set { this.idEmpleado = value; }
        }

        public FrmVentasEmpleado()
        {
            InitializeComponent();
        }

        private void FrmVentasEmpleado_Load(object sender, EventArgs e)
        {
            List<Venta> susVentas = new List<Venta>();

            for (int i = 0; i < Comercio.MisVentas.Count; i++)
            {
                if(Comercio.MisVentas[i].IdEmpleado == idEmpleado)
                {
                    susVentas.Add(Comercio.MisVentas[i]);
                }
            }

            dgv_VentasPorEmpleado.DataSource = null;
            dgv_VentasPorEmpleado.DataSource = susVentas;
        }

        private void dgv_VentasPorEmpleado_DoubleClick(object sender, EventArgs e)
        {
            FrmDescripcionVenta frmDescripcionVenta = new FrmDescripcionVenta();
            frmDescripcionVenta.IdVenta = (int)dgv_VentasPorEmpleado.CurrentRow.Cells["IdVenta"].Value;

            frmDescripcionVenta.ShowDialog();
        }
        private void btn_VolverProdVendidos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_VentasPorEmpleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_VentasPorEmpleado.Columns[e.ColumnIndex].Name == "PrecioTotal")
            {
                e.Value = "$ " + e.Value;
            }
        }
    }
}
