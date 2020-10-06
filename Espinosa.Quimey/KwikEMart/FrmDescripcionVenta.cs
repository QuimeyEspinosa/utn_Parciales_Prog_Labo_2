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
    public partial class FrmDescripcionVenta : Form
    {
        int idVenta;
        public int IdVenta
        {
            set { this.idVenta = value; }
        }

        public FrmDescripcionVenta()
        {
            InitializeComponent();
        }

        private void FrmDescripcionVenta_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Comercio.MisVentas.Count; i++)
            {
                if(idVenta == Comercio.MisVentas[i].IdVenta)
                {
                    dgv_ProductosVendidos.DataSource = Comercio.MisVentas[i].ProductosVendidos;
                }
            }
        }

        private void btn_VolverProdVendidos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ProductosVendidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_ProductosVendidos.Columns[e.ColumnIndex].Name == "PrecioUnitario")
            {
                e.Value = "$ " + e.Value;
            }
        }
    }
}
