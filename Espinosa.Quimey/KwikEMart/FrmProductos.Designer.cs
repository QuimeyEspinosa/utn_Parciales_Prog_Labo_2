namespace KwikEMart
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.btn_ProductosBajoStock = new System.Windows.Forms.Button();
            this.btn_TodosProductos = new System.Windows.Forms.Button();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_DescripcionProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SoloProductosStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarProducto.Location = new System.Drawing.Point(315, 12);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(157, 27);
            this.btn_AgregarProducto.TabIndex = 0;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.AllowUserToResizeColumns = false;
            this.dgv_Productos.AllowUserToResizeRows = false;
            this.dgv_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.dgv_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Productos.ColumnHeadersHeight = 25;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Productos.EnableHeadersVisualStyles = false;
            this.dgv_Productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_Productos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_Productos.Location = new System.Drawing.Point(315, 45);
            this.dgv_Productos.MultiSelect = false;
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Productos.RowHeadersVisible = false;
            this.dgv_Productos.RowTemplate.ReadOnly = true;
            this.dgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos.Size = new System.Drawing.Size(610, 428);
            this.dgv_Productos.TabIndex = 3;
            this.dgv_Productos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Productos_CellFormatting);
            this.dgv_Productos.Click += new System.EventHandler(this.dgv_Productos_Click);
            this.dgv_Productos.DoubleClick += new System.EventHandler(this.dgv_Productos_DoubleClick);
            // 
            // btn_ProductosBajoStock
            // 
            this.btn_ProductosBajoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductosBajoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_ProductosBajoStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ProductosBajoStock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductosBajoStock.ForeColor = System.Drawing.Color.White;
            this.btn_ProductosBajoStock.Location = new System.Drawing.Point(780, 12);
            this.btn_ProductosBajoStock.Name = "btn_ProductosBajoStock";
            this.btn_ProductosBajoStock.Size = new System.Drawing.Size(145, 27);
            this.btn_ProductosBajoStock.TabIndex = 4;
            this.btn_ProductosBajoStock.Text = "Productos Bajo Stock";
            this.btn_ProductosBajoStock.UseVisualStyleBackColor = false;
            this.btn_ProductosBajoStock.Click += new System.EventHandler(this.btn_ProductosBajoStock_Click);
            // 
            // btn_TodosProductos
            // 
            this.btn_TodosProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TodosProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_TodosProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TodosProductos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TodosProductos.ForeColor = System.Drawing.Color.White;
            this.btn_TodosProductos.Location = new System.Drawing.Point(478, 12);
            this.btn_TodosProductos.Name = "btn_TodosProductos";
            this.btn_TodosProductos.Size = new System.Drawing.Size(145, 27);
            this.btn_TodosProductos.TabIndex = 5;
            this.btn_TodosProductos.Text = "Todos los productos";
            this.btn_TodosProductos.UseVisualStyleBackColor = false;
            this.btn_TodosProductos.Click += new System.EventHandler(this.btn_TodosProductos_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(432, 476);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(387, 18);
            this.lbl_Cliente.TabIndex = 29;
            this.lbl_Cliente.Text = "Doble click en un producto para modificar su stock";
            // 
            // lbl_DescripcionProd
            // 
            this.lbl_DescripcionProd.AutoSize = true;
            this.lbl_DescripcionProd.Location = new System.Drawing.Point(12, 45);
            this.lbl_DescripcionProd.Name = "lbl_DescripcionProd";
            this.lbl_DescripcionProd.Size = new System.Drawing.Size(0, 15);
            this.lbl_DescripcionProd.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descripción producto";
            // 
            // btn_SoloProductosStock
            // 
            this.btn_SoloProductosStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SoloProductosStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_SoloProductosStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SoloProductosStock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoloProductosStock.ForeColor = System.Drawing.Color.White;
            this.btn_SoloProductosStock.Location = new System.Drawing.Point(629, 12);
            this.btn_SoloProductosStock.Name = "btn_SoloProductosStock";
            this.btn_SoloProductosStock.Size = new System.Drawing.Size(145, 27);
            this.btn_SoloProductosStock.TabIndex = 32;
            this.btn_SoloProductosStock.Text = "Solo productos en Stock";
            this.btn_SoloProductosStock.UseVisualStyleBackColor = false;
            this.btn_SoloProductosStock.Click += new System.EventHandler(this.btn_SoloProductosStock_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(937, 513);
            this.Controls.Add(this.btn_SoloProductosStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DescripcionProd);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.btn_TodosProductos);
            this.Controls.Add(this.btn_ProductosBajoStock);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.Button btn_ProductosBajoStock;
        private System.Windows.Forms.Button btn_TodosProductos;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_DescripcionProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SoloProductosStock;
    }
}