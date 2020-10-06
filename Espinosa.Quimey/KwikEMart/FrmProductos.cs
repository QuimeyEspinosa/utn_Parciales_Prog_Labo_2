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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            RefrescarDgvProductos(Comercio.MisProductos);
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto frmAltaProducto = new FrmAltaProducto();

            if (frmAltaProducto.ShowDialog() == DialogResult.OK)
            {
                if (!Comercio.AgregarProducto(frmAltaProducto.MiProducto))
                {
                    MessageBox.Show("No se puede agregar un producto con un número de artículo ya existente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Se agregó correctamente el artículo: \n\n {frmAltaProducto.MiProducto.ToString()}",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            RefrescarDgvProductos(Comercio.MisProductos);
        }

        private void dgv_Productos_DoubleClick(object sender, EventArgs e)
        {
            FrmModificarProducto frmModificarProducto = new FrmModificarProducto();

            frmModificarProducto.NumArticulo = (int)dgv_Productos.CurrentRow.Cells["NumArticulo"].Value;

            if (frmModificarProducto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se modificó correctamente",
                         "Éxito",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }

            RefrescarDgvProductos(Comercio.MisProductos);
            lbl_DescripcionProd.Text = "";
        }



        private void btn_TodosProductos_Click(object sender, EventArgs e)
        {
            RefrescarDgvProductos(Comercio.MisProductos);
        }
        private void btn_SoloProductosStock_Click(object sender, EventArgs e)
        {
            RefrescarDgvProductos(Comercio.ProductosEnStock());
        }

        private void btn_ProductosBajoStock_Click(object sender, EventArgs e)
        {
            RefrescarDgvProductos(Comercio.ProductosBajoStock());
        }

        private void RefrescarDgvProductos(List<Producto> productos)
        {
            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = productos;
        }

        private void dgv_Productos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dgv_Productos.Columns[3].Name = "Precio Unitario";
            this.dgv_Productos.Columns[4].Name = "Stock";

            if (this.dgv_Productos.Columns[e.ColumnIndex].Name == "Precio Unitario")
            {                
                e.Value = "$ " + e.Value;
            }

            if (this.dgv_Productos.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (Convert.ToInt32(e.Value) == 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Black;
                }
                else if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }

        }

        private void dgv_Productos_Click(object sender, EventArgs e)
        {
            int auxNumArt = (int)dgv_Productos.CurrentRow.Cells["NumArticulo"].Value;

            for (int i = 0; i < Comercio.MisProductos.Count; i++)
            {
                if (Comercio.MisProductos[i].NumArticulo == auxNumArt)
                {
                    lbl_DescripcionProd.Text = "";
                    lbl_DescripcionProd.Text = Comercio.MisProductos[i].ToString();
                }
            }          
            
        }

    }
}
