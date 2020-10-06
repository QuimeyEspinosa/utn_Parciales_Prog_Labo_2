namespace KwikEMart
{
    partial class FrmCantidadAComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantidadAComprar));
            this.txt_CantidadAComprar = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.btn_AsignarCantidad = new System.Windows.Forms.Button();
            this.btn_CancelarCantidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_CantidadAComprar
            // 
            this.txt_CantidadAComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txt_CantidadAComprar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CantidadAComprar.ForeColor = System.Drawing.Color.White;
            this.txt_CantidadAComprar.Location = new System.Drawing.Point(124, 40);
            this.txt_CantidadAComprar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CantidadAComprar.Name = "txt_CantidadAComprar";
            this.txt_CantidadAComprar.Size = new System.Drawing.Size(221, 20);
            this.txt_CantidadAComprar.TabIndex = 10;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_Cantidad.Location = new System.Drawing.Point(68, 9);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(340, 18);
            this.lbl_Cantidad.TabIndex = 14;
            this.lbl_Cantidad.Text = "Ingrese cantidad del producto seleccionado";
            // 
            // btn_AsignarCantidad
            // 
            this.btn_AsignarCantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_AsignarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_AsignarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AsignarCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AsignarCantidad.ForeColor = System.Drawing.Color.White;
            this.btn_AsignarCantidad.Location = new System.Drawing.Point(278, 75);
            this.btn_AsignarCantidad.Name = "btn_AsignarCantidad";
            this.btn_AsignarCantidad.Size = new System.Drawing.Size(173, 25);
            this.btn_AsignarCantidad.TabIndex = 15;
            this.btn_AsignarCantidad.Text = "Asignar cantidad";
            this.btn_AsignarCantidad.UseVisualStyleBackColor = false;
            this.btn_AsignarCantidad.Click += new System.EventHandler(this.btn_AsignarCantidad_Click);
            // 
            // btn_CancelarCantidad
            // 
            this.btn_CancelarCantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_CancelarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_CancelarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarCantidad.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarCantidad.Location = new System.Drawing.Point(20, 75);
            this.btn_CancelarCantidad.Name = "btn_CancelarCantidad";
            this.btn_CancelarCantidad.Size = new System.Drawing.Size(165, 25);
            this.btn_CancelarCantidad.TabIndex = 16;
            this.btn_CancelarCantidad.Text = "Cancelar";
            this.btn_CancelarCantidad.UseVisualStyleBackColor = false;
            this.btn_CancelarCantidad.Click += new System.EventHandler(this.btn_CancelarCantidad_Click);
            // 
            // FrmCantidadAComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(470, 112);
            this.Controls.Add(this.btn_CancelarCantidad);
            this.Controls.Add(this.btn_AsignarCantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_CantidadAComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCantidadAComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCantidadAComprar";
            this.Load += new System.EventHandler(this.FrmCantidadAComprar_Load);
            this.Enter += new System.EventHandler(this.btn_AsignarCantidad_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CantidadAComprar;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Button btn_AsignarCantidad;
        private System.Windows.Forms.Button btn_CancelarCantidad;
    }
}