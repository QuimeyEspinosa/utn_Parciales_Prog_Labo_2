namespace KwikEMart
{
    partial class FrmModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProducto));
            this.lbl_StockProducto = new System.Windows.Forms.Label();
            this.txt_StockProducto = new System.Windows.Forms.TextBox();
            this.btn_CancelarAgregarProducto = new System.Windows.Forms.Button();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StockProducto
            // 
            this.lbl_StockProducto.AutoSize = true;
            this.lbl_StockProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockProducto.ForeColor = System.Drawing.Color.White;
            this.lbl_StockProducto.Location = new System.Drawing.Point(30, 13);
            this.lbl_StockProducto.Name = "lbl_StockProducto";
            this.lbl_StockProducto.Size = new System.Drawing.Size(43, 17);
            this.lbl_StockProducto.TabIndex = 15;
            this.lbl_StockProducto.Text = "Stock";
            // 
            // txt_StockProducto
            // 
            this.txt_StockProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_StockProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StockProducto.ForeColor = System.Drawing.Color.White;
            this.txt_StockProducto.Location = new System.Drawing.Point(97, 13);
            this.txt_StockProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_StockProducto.Name = "txt_StockProducto";
            this.txt_StockProducto.Size = new System.Drawing.Size(191, 20);
            this.txt_StockProducto.TabIndex = 13;
            // 
            // btn_CancelarAgregarProducto
            // 
            this.btn_CancelarAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_CancelarAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarAgregarProducto.Location = new System.Drawing.Point(12, 54);
            this.btn_CancelarAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CancelarAgregarProducto.Name = "btn_CancelarAgregarProducto";
            this.btn_CancelarAgregarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_CancelarAgregarProducto.TabIndex = 17;
            this.btn_CancelarAgregarProducto.Text = "Cancelar";
            this.btn_CancelarAgregarProducto.UseVisualStyleBackColor = false;
            this.btn_CancelarAgregarProducto.Click += new System.EventHandler(this.btn_CancelarAgregarProducto_Click);
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_ModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModificarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_ModificarProducto.Location = new System.Drawing.Point(171, 54);
            this.btn_ModificarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_ModificarProducto.TabIndex = 16;
            this.btn_ModificarProducto.Text = "Modificar";
            this.btn_ModificarProducto.UseVisualStyleBackColor = false;
            this.btn_ModificarProducto.Click += new System.EventHandler(this.btn_ModificarProducto_Click);
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(300, 95);
            this.Controls.Add(this.btn_CancelarAgregarProducto);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.lbl_StockProducto);
            this.Controls.Add(this.txt_StockProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FrmModificarProducto_Load);
            this.Enter += new System.EventHandler(this.btn_ModificarProducto_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StockProducto;
        private System.Windows.Forms.TextBox txt_StockProducto;
        private System.Windows.Forms.Button btn_CancelarAgregarProducto;
        private System.Windows.Forms.Button btn_ModificarProducto;
    }
}