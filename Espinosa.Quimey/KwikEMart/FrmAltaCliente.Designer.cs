namespace KwikEMart
{
    partial class FrmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            this.lbl_ApellidoCliente = new System.Windows.Forms.Label();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_DniCliente = new System.Windows.Forms.Label();
            this.txt_DniCliente = new System.Windows.Forms.TextBox();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.btn_CancelarAgregarProducto = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ApellidoCliente
            // 
            this.lbl_ApellidoCliente.AutoSize = true;
            this.lbl_ApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoCliente.ForeColor = System.Drawing.Color.White;
            this.lbl_ApellidoCliente.Location = new System.Drawing.Point(29, 41);
            this.lbl_ApellidoCliente.Name = "lbl_ApellidoCliente";
            this.lbl_ApellidoCliente.Size = new System.Drawing.Size(61, 17);
            this.lbl_ApellidoCliente.TabIndex = 16;
            this.lbl_ApellidoCliente.Text = "Apellido";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreCliente.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(29, 13);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(61, 17);
            this.lbl_NombreCliente.TabIndex = 15;
            this.lbl_NombreCliente.Text = "Nombre";
            // 
            // lbl_DniCliente
            // 
            this.lbl_DniCliente.AutoSize = true;
            this.lbl_DniCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DniCliente.ForeColor = System.Drawing.Color.White;
            this.lbl_DniCliente.Location = new System.Drawing.Point(42, 69);
            this.lbl_DniCliente.Name = "lbl_DniCliente";
            this.lbl_DniCliente.Size = new System.Drawing.Size(48, 17);
            this.lbl_DniCliente.TabIndex = 14;
            this.lbl_DniCliente.Text = "N° Dni";
            // 
            // txt_DniCliente
            // 
            this.txt_DniCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_DniCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DniCliente.ForeColor = System.Drawing.Color.White;
            this.txt_DniCliente.Location = new System.Drawing.Point(107, 69);
            this.txt_DniCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DniCliente.Name = "txt_DniCliente";
            this.txt_DniCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_DniCliente.TabIndex = 13;
            this.txt_DniCliente.Leave += new System.EventHandler(this.txt_DniCliente_Leave);
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_ApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ApellidoCliente.ForeColor = System.Drawing.Color.White;
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(107, 41);
            this.txt_ApellidoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_ApellidoCliente.TabIndex = 12;
            this.txt_ApellidoCliente.Leave += new System.EventHandler(this.txt_ApellidoCliente_Leave);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreCliente.ForeColor = System.Drawing.Color.White;
            this.txt_NombreCliente.Location = new System.Drawing.Point(107, 13);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_NombreCliente.TabIndex = 11;
            this.txt_NombreCliente.Leave += new System.EventHandler(this.txt_NombreCliente_Leave);
            // 
            // btn_CancelarAgregarProducto
            // 
            this.btn_CancelarAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CancelarAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_CancelarAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarAgregarProducto.Location = new System.Drawing.Point(12, 110);
            this.btn_CancelarAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CancelarAgregarProducto.Name = "btn_CancelarAgregarProducto";
            this.btn_CancelarAgregarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_CancelarAgregarProducto.TabIndex = 18;
            this.btn_CancelarAgregarProducto.Text = "Cancelar";
            this.btn_CancelarAgregarProducto.UseVisualStyleBackColor = false;
            this.btn_CancelarAgregarProducto.Click += new System.EventHandler(this.btn_CancelarAgregarProducto_Click);
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarProducto.Location = new System.Drawing.Point(179, 110);
            this.btn_AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(117, 28);
            this.btn_AgregarProducto.TabIndex = 17;
            this.btn_AgregarProducto.Text = "Agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(310, 151);
            this.Controls.Add(this.btn_CancelarAgregarProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.lbl_ApellidoCliente);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.lbl_DniCliente);
            this.Controls.Add(this.txt_DniCliente);
            this.Controls.Add(this.txt_ApellidoCliente);
            this.Controls.Add(this.txt_NombreCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ApellidoCliente;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label lbl_DniCliente;
        private System.Windows.Forms.TextBox txt_DniCliente;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Button btn_CancelarAgregarProducto;
        private System.Windows.Forms.Button btn_AgregarProducto;
    }
}