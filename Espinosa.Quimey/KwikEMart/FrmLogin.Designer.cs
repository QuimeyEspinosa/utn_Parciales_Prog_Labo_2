namespace KwikEMart
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_LoginSalir = new System.Windows.Forms.Button();
            this.txt_LoginUsuario = new System.Windows.Forms.TextBox();
            this.txt_LoginContraseña = new System.Windows.Forms.TextBox();
            this.lbl_LoginUsuario = new System.Windows.Forms.Label();
            this.lbl_LoginContraseña = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(174, 272);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(79, 31);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_LoginSalir
            // 
            this.btn_LoginSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_LoginSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoginSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginSalir.ForeColor = System.Drawing.Color.White;
            this.btn_LoginSalir.Location = new System.Drawing.Point(12, 272);
            this.btn_LoginSalir.Name = "btn_LoginSalir";
            this.btn_LoginSalir.Size = new System.Drawing.Size(77, 31);
            this.btn_LoginSalir.TabIndex = 1;
            this.btn_LoginSalir.Text = "Salir";
            this.btn_LoginSalir.UseVisualStyleBackColor = false;
            this.btn_LoginSalir.Click += new System.EventHandler(this.btn_LoginSalir_Click);
            // 
            // txt_LoginUsuario
            // 
            this.txt_LoginUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_LoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoginUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginUsuario.ForeColor = System.Drawing.Color.White;
            this.txt_LoginUsuario.Location = new System.Drawing.Point(113, 61);
            this.txt_LoginUsuario.Name = "txt_LoginUsuario";
            this.txt_LoginUsuario.Size = new System.Drawing.Size(120, 21);
            this.txt_LoginUsuario.TabIndex = 2;
            // 
            // txt_LoginContraseña
            // 
            this.txt_LoginContraseña.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_LoginContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoginContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginContraseña.ForeColor = System.Drawing.Color.White;
            this.txt_LoginContraseña.Location = new System.Drawing.Point(113, 104);
            this.txt_LoginContraseña.Name = "txt_LoginContraseña";
            this.txt_LoginContraseña.PasswordChar = '*';
            this.txt_LoginContraseña.Size = new System.Drawing.Size(120, 21);
            this.txt_LoginContraseña.TabIndex = 3;
            // 
            // lbl_LoginUsuario
            // 
            this.lbl_LoginUsuario.AutoSize = true;
            this.lbl_LoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoginUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginUsuario.Location = new System.Drawing.Point(51, 61);
            this.lbl_LoginUsuario.Name = "lbl_LoginUsuario";
            this.lbl_LoginUsuario.Size = new System.Drawing.Size(56, 16);
            this.lbl_LoginUsuario.TabIndex = 4;
            this.lbl_LoginUsuario.Text = "Usuario";
            // 
            // lbl_LoginContraseña
            // 
            this.lbl_LoginContraseña.AutoSize = true;
            this.lbl_LoginContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoginContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginContraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginContraseña.Location = new System.Drawing.Point(24, 104);
            this.lbl_LoginContraseña.Name = "lbl_LoginContraseña";
            this.lbl_LoginContraseña.Size = new System.Drawing.Size(83, 16);
            this.lbl_LoginContraseña.TabIndex = 6;
            this.lbl_LoginContraseña.Text = "Contraseña";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.Black;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ayuda.ForeColor = System.Drawing.Color.Red;
            this.btn_Ayuda.Location = new System.Drawing.Point(12, 12);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(31, 24);
            this.btn_Ayuda.TabIndex = 7;
            this.btn_Ayuda.Text = "?";
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(265, 315);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.lbl_LoginContraseña);
            this.Controls.Add(this.lbl_LoginUsuario);
            this.Controls.Add(this.txt_LoginContraseña);
            this.Controls.Add(this.txt_LoginUsuario);
            this.Controls.Add(this.btn_LoginSalir);
            this.Controls.Add(this.btn_Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Enter += new System.EventHandler(this.btn_Login_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_LoginSalir;
        private System.Windows.Forms.TextBox txt_LoginUsuario;
        private System.Windows.Forms.TextBox txt_LoginContraseña;
        private System.Windows.Forms.Label lbl_LoginUsuario;
        private System.Windows.Forms.Label lbl_LoginContraseña;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}