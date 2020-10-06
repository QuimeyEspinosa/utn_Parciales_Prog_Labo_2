namespace KwikEMart
{
    partial class FrmDescripcionVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDescripcionVenta));
            this.dgv_ProductosVendidos = new System.Windows.Forms.DataGridView();
            this.lbl_ProductosVendidos = new System.Windows.Forms.Label();
            this.btn_VolverProdVendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductosVendidos
            // 
            this.dgv_ProductosVendidos.AllowUserToAddRows = false;
            this.dgv_ProductosVendidos.AllowUserToDeleteRows = false;
            this.dgv_ProductosVendidos.AllowUserToResizeColumns = false;
            this.dgv_ProductosVendidos.AllowUserToResizeRows = false;
            this.dgv_ProductosVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProductosVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProductosVendidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProductosVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.dgv_ProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProductosVendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductosVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProductosVendidos.ColumnHeadersHeight = 25;
            this.dgv_ProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductosVendidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProductosVendidos.EnableHeadersVisualStyles = false;
            this.dgv_ProductosVendidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_ProductosVendidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_ProductosVendidos.Location = new System.Drawing.Point(12, 31);
            this.dgv_ProductosVendidos.MultiSelect = false;
            this.dgv_ProductosVendidos.Name = "dgv_ProductosVendidos";
            this.dgv_ProductosVendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductosVendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ProductosVendidos.RowHeadersVisible = false;
            this.dgv_ProductosVendidos.RowTemplate.ReadOnly = true;
            this.dgv_ProductosVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductosVendidos.Size = new System.Drawing.Size(580, 268);
            this.dgv_ProductosVendidos.TabIndex = 19;
            this.dgv_ProductosVendidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ProductosVendidos_CellFormatting);
            // 
            // lbl_ProductosVendidos
            // 
            this.lbl_ProductosVendidos.AutoSize = true;
            this.lbl_ProductosVendidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.lbl_ProductosVendidos.Location = new System.Drawing.Point(218, 9);
            this.lbl_ProductosVendidos.Name = "lbl_ProductosVendidos";
            this.lbl_ProductosVendidos.Size = new System.Drawing.Size(161, 19);
            this.lbl_ProductosVendidos.TabIndex = 20;
            this.lbl_ProductosVendidos.Text = "Productos Vendidos";
            // 
            // btn_VolverProdVendidos
            // 
            this.btn_VolverProdVendidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_VolverProdVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_VolverProdVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VolverProdVendidos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverProdVendidos.ForeColor = System.Drawing.Color.White;
            this.btn_VolverProdVendidos.Location = new System.Drawing.Point(235, 313);
            this.btn_VolverProdVendidos.Name = "btn_VolverProdVendidos";
            this.btn_VolverProdVendidos.Size = new System.Drawing.Size(130, 27);
            this.btn_VolverProdVendidos.TabIndex = 21;
            this.btn_VolverProdVendidos.Text = "Volver";
            this.btn_VolverProdVendidos.UseVisualStyleBackColor = false;
            this.btn_VolverProdVendidos.Click += new System.EventHandler(this.btn_VolverProdVendidos_Click);
            // 
            // FrmDescripcionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(604, 352);
            this.Controls.Add(this.btn_VolverProdVendidos);
            this.Controls.Add(this.lbl_ProductosVendidos);
            this.Controls.Add(this.dgv_ProductosVendidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDescripcionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDescripcionVenta";
            this.Load += new System.EventHandler(this.FrmDescripcionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProductosVendidos;
        private System.Windows.Forms.Label lbl_ProductosVendidos;
        private System.Windows.Forms.Button btn_VolverProdVendidos;
    }
}