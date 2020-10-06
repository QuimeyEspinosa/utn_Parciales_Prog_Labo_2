namespace KwikEMart
{
    partial class FrmVentasEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasEmpleado));
            this.dgv_VentasPorEmpleado = new System.Windows.Forms.DataGridView();
            this.lbl_DobleClickDescripcion = new System.Windows.Forms.Label();
            this.lbl_VentasPorEmpleado = new System.Windows.Forms.Label();
            this.btn_VolverProdVendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VentasPorEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VentasPorEmpleado
            // 
            this.dgv_VentasPorEmpleado.AllowUserToAddRows = false;
            this.dgv_VentasPorEmpleado.AllowUserToDeleteRows = false;
            this.dgv_VentasPorEmpleado.AllowUserToResizeColumns = false;
            this.dgv_VentasPorEmpleado.AllowUserToResizeRows = false;
            this.dgv_VentasPorEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_VentasPorEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VentasPorEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_VentasPorEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.dgv_VentasPorEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_VentasPorEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VentasPorEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VentasPorEmpleado.ColumnHeadersHeight = 25;
            this.dgv_VentasPorEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VentasPorEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VentasPorEmpleado.EnableHeadersVisualStyles = false;
            this.dgv_VentasPorEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_VentasPorEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_VentasPorEmpleado.Location = new System.Drawing.Point(12, 31);
            this.dgv_VentasPorEmpleado.MultiSelect = false;
            this.dgv_VentasPorEmpleado.Name = "dgv_VentasPorEmpleado";
            this.dgv_VentasPorEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VentasPorEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VentasPorEmpleado.RowHeadersVisible = false;
            this.dgv_VentasPorEmpleado.RowTemplate.ReadOnly = true;
            this.dgv_VentasPorEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VentasPorEmpleado.Size = new System.Drawing.Size(564, 219);
            this.dgv_VentasPorEmpleado.TabIndex = 19;
            this.dgv_VentasPorEmpleado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_VentasPorEmpleado_CellFormatting);
            this.dgv_VentasPorEmpleado.DoubleClick += new System.EventHandler(this.dgv_VentasPorEmpleado_DoubleClick);
            // 
            // lbl_DobleClickDescripcion
            // 
            this.lbl_DobleClickDescripcion.AutoSize = true;
            this.lbl_DobleClickDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DobleClickDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_DobleClickDescripcion.Location = new System.Drawing.Point(105, 253);
            this.lbl_DobleClickDescripcion.Name = "lbl_DobleClickDescripcion";
            this.lbl_DobleClickDescripcion.Size = new System.Drawing.Size(378, 16);
            this.lbl_DobleClickDescripcion.TabIndex = 22;
            this.lbl_DobleClickDescripcion.Text = "Doble click en una venta para acceder a su descripción";
            // 
            // lbl_VentasPorEmpleado
            // 
            this.lbl_VentasPorEmpleado.AutoSize = true;
            this.lbl_VentasPorEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasPorEmpleado.ForeColor = System.Drawing.Color.White;
            this.lbl_VentasPorEmpleado.Location = new System.Drawing.Point(197, 9);
            this.lbl_VentasPorEmpleado.Name = "lbl_VentasPorEmpleado";
            this.lbl_VentasPorEmpleado.Size = new System.Drawing.Size(176, 19);
            this.lbl_VentasPorEmpleado.TabIndex = 23;
            this.lbl_VentasPorEmpleado.Text = "Ventas por Empleado";
            // 
            // btn_VolverProdVendidos
            // 
            this.btn_VolverProdVendidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_VolverProdVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_VolverProdVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VolverProdVendidos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverProdVendidos.ForeColor = System.Drawing.Color.White;
            this.btn_VolverProdVendidos.Location = new System.Drawing.Point(222, 274);
            this.btn_VolverProdVendidos.Name = "btn_VolverProdVendidos";
            this.btn_VolverProdVendidos.Size = new System.Drawing.Size(130, 27);
            this.btn_VolverProdVendidos.TabIndex = 24;
            this.btn_VolverProdVendidos.Text = "Volver";
            this.btn_VolverProdVendidos.UseVisualStyleBackColor = false;
            this.btn_VolverProdVendidos.Click += new System.EventHandler(this.btn_VolverProdVendidos_Click);
            // 
            // FrmVentasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(588, 313);
            this.Controls.Add(this.btn_VolverProdVendidos);
            this.Controls.Add(this.lbl_VentasPorEmpleado);
            this.Controls.Add(this.lbl_DobleClickDescripcion);
            this.Controls.Add(this.dgv_VentasPorEmpleado);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentasEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentasEmpleado";
            this.Load += new System.EventHandler(this.FrmVentasEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VentasPorEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VentasPorEmpleado;
        private System.Windows.Forms.Label lbl_DobleClickDescripcion;
        private System.Windows.Forms.Label lbl_VentasPorEmpleado;
        private System.Windows.Forms.Button btn_VolverProdVendidos;
    }
}