namespace Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblPedidosEnPreparacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_EnPreparacion = new System.Windows.Forms.RichTextBox();
            this.rtxt_ListosParaRetirar = new System.Windows.Forms.RichTextBox();
            this.rtxt_PedidosEntregados = new System.Windows.Forms.RichTextBox();
            this.lbl_PedidosEntregados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevoPedido.Location = new System.Drawing.Point(12, 474);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(226, 40);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "Generar nuevo pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPedidos.Location = new System.Drawing.Point(428, 9);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(92, 25);
            this.lblPedidos.TabIndex = 1;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblPedidosEnPreparacion
            // 
            this.lblPedidosEnPreparacion.AutoSize = true;
            this.lblPedidosEnPreparacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidosEnPreparacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosEnPreparacion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPedidosEnPreparacion.Location = new System.Drawing.Point(63, 42);
            this.lblPedidosEnPreparacion.Name = "lblPedidosEnPreparacion";
            this.lblPedidosEnPreparacion.Size = new System.Drawing.Size(109, 16);
            this.lblPedidosEnPreparacion.TabIndex = 2;
            this.lblPedidosEnPreparacion.Text = "En preparación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(410, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Listos para retirar";
            // 
            // rtxt_EnPreparacion
            // 
            this.rtxt_EnPreparacion.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.rtxt_EnPreparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_EnPreparacion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtxt_EnPreparacion.Location = new System.Drawing.Point(12, 61);
            this.rtxt_EnPreparacion.Name = "rtxt_EnPreparacion";
            this.rtxt_EnPreparacion.ReadOnly = true;
            this.rtxt_EnPreparacion.Size = new System.Drawing.Size(226, 407);
            this.rtxt_EnPreparacion.TabIndex = 4;
            this.rtxt_EnPreparacion.Text = "";
            // 
            // rtxt_ListosParaRetirar
            // 
            this.rtxt_ListosParaRetirar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.rtxt_ListosParaRetirar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_ListosParaRetirar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtxt_ListosParaRetirar.Location = new System.Drawing.Point(357, 61);
            this.rtxt_ListosParaRetirar.Name = "rtxt_ListosParaRetirar";
            this.rtxt_ListosParaRetirar.ReadOnly = true;
            this.rtxt_ListosParaRetirar.Size = new System.Drawing.Size(233, 453);
            this.rtxt_ListosParaRetirar.TabIndex = 5;
            this.rtxt_ListosParaRetirar.Text = "";
            // 
            // rtxt_PedidosEntregados
            // 
            this.rtxt_PedidosEntregados.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.rtxt_PedidosEntregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_PedidosEntregados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtxt_PedidosEntregados.Location = new System.Drawing.Point(703, 61);
            this.rtxt_PedidosEntregados.Name = "rtxt_PedidosEntregados";
            this.rtxt_PedidosEntregados.ReadOnly = true;
            this.rtxt_PedidosEntregados.Size = new System.Drawing.Size(233, 453);
            this.rtxt_PedidosEntregados.TabIndex = 6;
            this.rtxt_PedidosEntregados.Text = "";
            // 
            // lbl_PedidosEntregados
            // 
            this.lbl_PedidosEntregados.AutoSize = true;
            this.lbl_PedidosEntregados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PedidosEntregados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PedidosEntregados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_PedidosEntregados.Location = new System.Drawing.Point(781, 42);
            this.lbl_PedidosEntregados.Name = "lbl_PedidosEntregados";
            this.lbl_PedidosEntregados.Size = new System.Drawing.Size(81, 16);
            this.lbl_PedidosEntregados.TabIndex = 7;
            this.lbl_PedidosEntregados.Text = "Entregados";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 526);
            this.Controls.Add(this.lbl_PedidosEntregados);
            this.Controls.Add(this.rtxt_PedidosEntregados);
            this.Controls.Add(this.rtxt_ListosParaRetirar);
            this.Controls.Add(this.rtxt_EnPreparacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPedidosEnPreparacion);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.btnNuevoPedido);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crustaceo Cascarudo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblPedidosEnPreparacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_EnPreparacion;
        private System.Windows.Forms.RichTextBox rtxt_ListosParaRetirar;
        private System.Windows.Forms.RichTextBox rtxt_PedidosEntregados;
        private System.Windows.Forms.Label lbl_PedidosEntregados;
    }
}