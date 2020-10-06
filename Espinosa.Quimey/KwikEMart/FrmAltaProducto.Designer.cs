namespace KwikEMart
{
    partial class FrmAltaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaProducto));
            this.txt_NumArticuloProducto = new System.Windows.Forms.TextBox();
            this.txt_DescripcionProducto = new System.Windows.Forms.TextBox();
            this.txt_StockProducto = new System.Windows.Forms.TextBox();
            this.txt_PrecioProducto = new System.Windows.Forms.TextBox();
            this.lbl_NumArticuloProducto = new System.Windows.Forms.Label();
            this.lbl_DescripcionProducto = new System.Windows.Forms.Label();
            this.lbl_PrecioProducto = new System.Windows.Forms.Label();
            this.lbl_StockProducto = new System.Windows.Forms.Label();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.btn_CancelarAgregarProducto = new System.Windows.Forms.Button();
            this.cmb_TipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_TipoProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NumArticuloProducto
            // 
            this.txt_NumArticuloProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_NumArticuloProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumArticuloProducto.ForeColor = System.Drawing.Color.White;
            this.txt_NumArticuloProducto.Location = new System.Drawing.Point(107, 13);
            this.txt_NumArticuloProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NumArticuloProducto.Name = "txt_NumArticuloProducto";
            this.txt_NumArticuloProducto.Size = new System.Drawing.Size(191, 21);
            this.txt_NumArticuloProducto.TabIndex = 0;
            this.txt_NumArticuloProducto.Leave += new System.EventHandler(this.txt_NumArticuloProducto_Leave);
            // 
            // txt_DescripcionProducto
            // 
            this.txt_DescripcionProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_DescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.txt_DescripcionProducto.Location = new System.Drawing.Point(107, 42);
            this.txt_DescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DescripcionProducto.Name = "txt_DescripcionProducto";
            this.txt_DescripcionProducto.Size = new System.Drawing.Size(191, 21);
            this.txt_DescripcionProducto.TabIndex = 2;
            this.txt_DescripcionProducto.Leave += new System.EventHandler(this.txt_DescripcionProducto_Leave);
            // 
            // txt_StockProducto
            // 
            this.txt_StockProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_StockProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StockProducto.ForeColor = System.Drawing.Color.White;
            this.txt_StockProducto.Location = new System.Drawing.Point(107, 100);
            this.txt_StockProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_StockProducto.Name = "txt_StockProducto";
            this.txt_StockProducto.Size = new System.Drawing.Size(191, 21);
            this.txt_StockProducto.TabIndex = 4;
            this.txt_StockProducto.Leave += new System.EventHandler(this.txt_StockProducto_Leave);
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_PrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PrecioProducto.ForeColor = System.Drawing.Color.White;
            this.txt_PrecioProducto.Location = new System.Drawing.Point(107, 71);
            this.txt_PrecioProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(191, 21);
            this.txt_PrecioProducto.TabIndex = 3;
            this.txt_PrecioProducto.Leave += new System.EventHandler(this.txt_PrecioProducto_Leave);
            // 
            // lbl_NumArticuloProducto
            // 
            this.lbl_NumArticuloProducto.AutoSize = true;
            this.lbl_NumArticuloProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumArticuloProducto.Location = new System.Drawing.Point(25, 14);
            this.lbl_NumArticuloProducto.Name = "lbl_NumArticuloProducto";
            this.lbl_NumArticuloProducto.Size = new System.Drawing.Size(76, 17);
            this.lbl_NumArticuloProducto.TabIndex = 7;
            this.lbl_NumArticuloProducto.Text = "N° articulo";
            // 
            // lbl_DescripcionProducto
            // 
            this.lbl_DescripcionProducto.AutoSize = true;
            this.lbl_DescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescripcionProducto.Location = new System.Drawing.Point(18, 43);
            this.lbl_DescripcionProducto.Name = "lbl_DescripcionProducto";
            this.lbl_DescripcionProducto.Size = new System.Drawing.Size(83, 17);
            this.lbl_DescripcionProducto.TabIndex = 9;
            this.lbl_DescripcionProducto.Text = "Descripción";
            // 
            // lbl_PrecioProducto
            // 
            this.lbl_PrecioProducto.AutoSize = true;
            this.lbl_PrecioProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioProducto.Location = new System.Drawing.Point(53, 72);
            this.lbl_PrecioProducto.Name = "lbl_PrecioProducto";
            this.lbl_PrecioProducto.Size = new System.Drawing.Size(48, 17);
            this.lbl_PrecioProducto.TabIndex = 10;
            this.lbl_PrecioProducto.Text = "Precio";
            // 
            // lbl_StockProducto
            // 
            this.lbl_StockProducto.AutoSize = true;
            this.lbl_StockProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockProducto.Location = new System.Drawing.Point(58, 101);
            this.lbl_StockProducto.Name = "lbl_StockProducto";
            this.lbl_StockProducto.Size = new System.Drawing.Size(43, 17);
            this.lbl_StockProducto.TabIndex = 11;
            this.lbl_StockProducto.Text = "Stock";
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarProducto.Location = new System.Drawing.Point(181, 179);
            this.btn_AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_AgregarProducto.TabIndex = 5;
            this.btn_AgregarProducto.Text = "Agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // btn_CancelarAgregarProducto
            // 
            this.btn_CancelarAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_CancelarAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarAgregarProducto.Location = new System.Drawing.Point(12, 179);
            this.btn_CancelarAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CancelarAgregarProducto.Name = "btn_CancelarAgregarProducto";
            this.btn_CancelarAgregarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_CancelarAgregarProducto.TabIndex = 6;
            this.btn_CancelarAgregarProducto.Text = "Cancelar";
            this.btn_CancelarAgregarProducto.UseVisualStyleBackColor = false;
            this.btn_CancelarAgregarProducto.Click += new System.EventHandler(this.btn_CancelarAgregarProducto_Click);
            // 
            // cmb_TipoProducto
            // 
            this.cmb_TipoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.cmb_TipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TipoProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoProducto.ForeColor = System.Drawing.Color.White;
            this.cmb_TipoProducto.FormattingEnabled = true;
            this.cmb_TipoProducto.Location = new System.Drawing.Point(107, 128);
            this.cmb_TipoProducto.Name = "cmb_TipoProducto";
            this.cmb_TipoProducto.Size = new System.Drawing.Size(191, 23);
            this.cmb_TipoProducto.TabIndex = 12;
            // 
            // lbl_TipoProducto
            // 
            this.lbl_TipoProducto.AutoSize = true;
            this.lbl_TipoProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoProducto.Location = new System.Drawing.Point(67, 130);
            this.lbl_TipoProducto.Name = "lbl_TipoProducto";
            this.lbl_TipoProducto.Size = new System.Drawing.Size(34, 17);
            this.lbl_TipoProducto.TabIndex = 13;
            this.lbl_TipoProducto.Text = "Tipo";
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(310, 220);
            this.Controls.Add(this.lbl_TipoProducto);
            this.Controls.Add(this.cmb_TipoProducto);
            this.Controls.Add(this.btn_CancelarAgregarProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.lbl_StockProducto);
            this.Controls.Add(this.lbl_PrecioProducto);
            this.Controls.Add(this.lbl_DescripcionProducto);
            this.Controls.Add(this.lbl_NumArticuloProducto);
            this.Controls.Add(this.txt_PrecioProducto);
            this.Controls.Add(this.txt_StockProducto);
            this.Controls.Add(this.txt_DescripcionProducto);
            this.Controls.Add(this.txt_NumArticuloProducto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Producto";
            this.Load += new System.EventHandler(this.FrmAltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NumArticuloProducto;
        private System.Windows.Forms.TextBox txt_DescripcionProducto;
        private System.Windows.Forms.TextBox txt_StockProducto;
        private System.Windows.Forms.TextBox txt_PrecioProducto;
        private System.Windows.Forms.Label lbl_NumArticuloProducto;
        private System.Windows.Forms.Label lbl_DescripcionProducto;
        private System.Windows.Forms.Label lbl_PrecioProducto;
        private System.Windows.Forms.Label lbl_StockProducto;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Button btn_CancelarAgregarProducto;
        private System.Windows.Forms.ComboBox cmb_TipoProducto;
        private System.Windows.Forms.Label lbl_TipoProducto;
    }
}