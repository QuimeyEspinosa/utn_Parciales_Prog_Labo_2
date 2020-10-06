namespace KwikEMart
{
    partial class FrmNuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaVenta));
            this.btn_Vender = new System.Windows.Forms.Button();
            this.dgv_ProductosVenta = new System.Windows.Forms.DataGridView();
            this.dgv_CarritoVenta = new System.Windows.Forms.DataGridView();
            this.dgv_ClientesNuevaVenta = new System.Windows.Forms.DataGridView();
            this.linklbl_AgregarNuevoClienteVenta = new System.Windows.Forms.LinkLabel();
            this.lbl_ListaProductosVenta = new System.Windows.Forms.Label();
            this.lbl_CarritoCompras = new System.Windows.Forms.Label();
            this.pb_LogoCarritoCompras = new System.Windows.Forms.PictureBox();
            this.pb_LogoProductos = new System.Windows.Forms.PictureBox();
            this.checkbox_GenerarTicket = new System.Windows.Forms.CheckBox();
            this.lbl_MontoTotal = new System.Windows.Forms.Label();
            this.lbl_InformeCompra = new System.Windows.Forms.Label();
            this.lbl_ClienteComprador = new System.Windows.Forms.Label();
            this.lbl_ClientesRegistrados = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_TotalUsd = new System.Windows.Forms.Label();
            this.btn_VaciarCarrito = new System.Windows.Forms.Button();
            this.lbl_DobleClickAgregarCarrito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CarritoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientesNuevaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoCarritoCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Vender
            // 
            this.btn_Vender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Vender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vender.ForeColor = System.Drawing.Color.White;
            this.btn_Vender.Location = new System.Drawing.Point(710, 475);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(215, 26);
            this.btn_Vender.TabIndex = 1;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = false;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // dgv_ProductosVenta
            // 
            this.dgv_ProductosVenta.AllowUserToAddRows = false;
            this.dgv_ProductosVenta.AllowUserToDeleteRows = false;
            this.dgv_ProductosVenta.AllowUserToResizeColumns = false;
            this.dgv_ProductosVenta.AllowUserToResizeRows = false;
            this.dgv_ProductosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_ProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProductosVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProductosVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.dgv_ProductosVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProductosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProductosVenta.ColumnHeadersHeight = 25;
            this.dgv_ProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProductosVenta.EnableHeadersVisualStyles = false;
            this.dgv_ProductosVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_ProductosVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_ProductosVenta.Location = new System.Drawing.Point(12, 31);
            this.dgv_ProductosVenta.MultiSelect = false;
            this.dgv_ProductosVenta.Name = "dgv_ProductosVenta";
            this.dgv_ProductosVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductosVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ProductosVenta.RowHeadersVisible = false;
            this.dgv_ProductosVenta.RowTemplate.ReadOnly = true;
            this.dgv_ProductosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductosVenta.Size = new System.Drawing.Size(477, 192);
            this.dgv_ProductosVenta.TabIndex = 4;
            this.dgv_ProductosVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ProductosVenta_CellFormatting);
            this.dgv_ProductosVenta.DoubleClick += new System.EventHandler(this.dgv_ProductosVenta_DoubleClick);
            // 
            // dgv_CarritoVenta
            // 
            this.dgv_CarritoVenta.AllowUserToAddRows = false;
            this.dgv_CarritoVenta.AllowUserToDeleteRows = false;
            this.dgv_CarritoVenta.AllowUserToResizeColumns = false;
            this.dgv_CarritoVenta.AllowUserToResizeRows = false;
            this.dgv_CarritoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CarritoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CarritoVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_CarritoVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.dgv_CarritoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CarritoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CarritoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CarritoVenta.ColumnHeadersHeight = 25;
            this.dgv_CarritoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CarritoVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CarritoVenta.EnableHeadersVisualStyles = false;
            this.dgv_CarritoVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_CarritoVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_CarritoVenta.Location = new System.Drawing.Point(495, 31);
            this.dgv_CarritoVenta.MultiSelect = false;
            this.dgv_CarritoVenta.Name = "dgv_CarritoVenta";
            this.dgv_CarritoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CarritoVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_CarritoVenta.RowHeadersVisible = false;
            this.dgv_CarritoVenta.RowTemplate.ReadOnly = true;
            this.dgv_CarritoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CarritoVenta.Size = new System.Drawing.Size(430, 192);
            this.dgv_CarritoVenta.TabIndex = 5;
            this.dgv_CarritoVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CarritoVenta_CellFormatting);
            this.dgv_CarritoVenta.Click += new System.EventHandler(this.dgv_CarritoVenta_DoubleClick);
            this.dgv_CarritoVenta.DoubleClick += new System.EventHandler(this.dgv_CarritoVenta_DoubleClick);
            // 
            // dgv_ClientesNuevaVenta
            // 
            this.dgv_ClientesNuevaVenta.AllowUserToAddRows = false;
            this.dgv_ClientesNuevaVenta.AllowUserToDeleteRows = false;
            this.dgv_ClientesNuevaVenta.AllowUserToResizeColumns = false;
            this.dgv_ClientesNuevaVenta.AllowUserToResizeRows = false;
            this.dgv_ClientesNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ClientesNuevaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClientesNuevaVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ClientesNuevaVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.dgv_ClientesNuevaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ClientesNuevaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientesNuevaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ClientesNuevaVenta.ColumnHeadersHeight = 25;
            this.dgv_ClientesNuevaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClientesNuevaVenta.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ClientesNuevaVenta.EnableHeadersVisualStyles = false;
            this.dgv_ClientesNuevaVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.dgv_ClientesNuevaVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_ClientesNuevaVenta.Location = new System.Drawing.Point(12, 285);
            this.dgv_ClientesNuevaVenta.MultiSelect = false;
            this.dgv_ClientesNuevaVenta.Name = "dgv_ClientesNuevaVenta";
            this.dgv_ClientesNuevaVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientesNuevaVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ClientesNuevaVenta.RowHeadersVisible = false;
            this.dgv_ClientesNuevaVenta.RowTemplate.ReadOnly = true;
            this.dgv_ClientesNuevaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientesNuevaVenta.Size = new System.Drawing.Size(477, 180);
            this.dgv_ClientesNuevaVenta.TabIndex = 8;
            this.dgv_ClientesNuevaVenta.DoubleClick += new System.EventHandler(this.dgv_ClientesNuevaVenta_DoubleClick);
            // 
            // linklbl_AgregarNuevoClienteVenta
            // 
            this.linklbl_AgregarNuevoClienteVenta.ActiveLinkColor = System.Drawing.Color.White;
            this.linklbl_AgregarNuevoClienteVenta.AutoSize = true;
            this.linklbl_AgregarNuevoClienteVenta.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linklbl_AgregarNuevoClienteVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_AgregarNuevoClienteVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.linklbl_AgregarNuevoClienteVenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.linklbl_AgregarNuevoClienteVenta.Location = new System.Drawing.Point(12, 480);
            this.linklbl_AgregarNuevoClienteVenta.Name = "linklbl_AgregarNuevoClienteVenta";
            this.linklbl_AgregarNuevoClienteVenta.Size = new System.Drawing.Size(213, 16);
            this.linklbl_AgregarNuevoClienteVenta.TabIndex = 12;
            this.linklbl_AgregarNuevoClienteVenta.TabStop = true;
            this.linklbl_AgregarNuevoClienteVenta.Text = "¿El cliente no existe? Click aquí";
            this.linklbl_AgregarNuevoClienteVenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_AgregarNuevoClienteVenta_LinkClicked);
            // 
            // lbl_ListaProductosVenta
            // 
            this.lbl_ListaProductosVenta.AutoSize = true;
            this.lbl_ListaProductosVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaProductosVenta.Location = new System.Drawing.Point(188, 11);
            this.lbl_ListaProductosVenta.Name = "lbl_ListaProductosVenta";
            this.lbl_ListaProductosVenta.Size = new System.Drawing.Size(153, 19);
            this.lbl_ListaProductosVenta.TabIndex = 15;
            this.lbl_ListaProductosVenta.Text = "Productos en Stock";
            // 
            // lbl_CarritoCompras
            // 
            this.lbl_CarritoCompras.AutoSize = true;
            this.lbl_CarritoCompras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarritoCompras.Location = new System.Drawing.Point(647, 11);
            this.lbl_CarritoCompras.Name = "lbl_CarritoCompras";
            this.lbl_CarritoCompras.Size = new System.Drawing.Size(160, 19);
            this.lbl_CarritoCompras.TabIndex = 16;
            this.lbl_CarritoCompras.Text = "Carrito de Compras";
            // 
            // pb_LogoCarritoCompras
            // 
            this.pb_LogoCarritoCompras.Image = ((System.Drawing.Image)(resources.GetObject("pb_LogoCarritoCompras.Image")));
            this.pb_LogoCarritoCompras.Location = new System.Drawing.Point(617, 9);
            this.pb_LogoCarritoCompras.Name = "pb_LogoCarritoCompras";
            this.pb_LogoCarritoCompras.Size = new System.Drawing.Size(24, 22);
            this.pb_LogoCarritoCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_LogoCarritoCompras.TabIndex = 17;
            this.pb_LogoCarritoCompras.TabStop = false;
            // 
            // pb_LogoProductos
            // 
            this.pb_LogoProductos.Image = ((System.Drawing.Image)(resources.GetObject("pb_LogoProductos.Image")));
            this.pb_LogoProductos.Location = new System.Drawing.Point(158, 9);
            this.pb_LogoProductos.Name = "pb_LogoProductos";
            this.pb_LogoProductos.Size = new System.Drawing.Size(24, 22);
            this.pb_LogoProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_LogoProductos.TabIndex = 18;
            this.pb_LogoProductos.TabStop = false;
            // 
            // checkbox_GenerarTicket
            // 
            this.checkbox_GenerarTicket.AutoSize = true;
            this.checkbox_GenerarTicket.Checked = true;
            this.checkbox_GenerarTicket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_GenerarTicket.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_GenerarTicket.Location = new System.Drawing.Point(514, 479);
            this.checkbox_GenerarTicket.Name = "checkbox_GenerarTicket";
            this.checkbox_GenerarTicket.Size = new System.Drawing.Size(184, 20);
            this.checkbox_GenerarTicket.TabIndex = 22;
            this.checkbox_GenerarTicket.Text = "Generar Ticket de Compra";
            this.checkbox_GenerarTicket.UseVisualStyleBackColor = true;
            // 
            // lbl_MontoTotal
            // 
            this.lbl_MontoTotal.AutoSize = true;
            this.lbl_MontoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MontoTotal.Location = new System.Drawing.Point(614, 442);
            this.lbl_MontoTotal.Name = "lbl_MontoTotal";
            this.lbl_MontoTotal.Size = new System.Drawing.Size(0, 19);
            this.lbl_MontoTotal.TabIndex = 23;
            // 
            // lbl_InformeCompra
            // 
            this.lbl_InformeCompra.AutoSize = true;
            this.lbl_InformeCompra.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InformeCompra.Location = new System.Drawing.Point(647, 320);
            this.lbl_InformeCompra.Name = "lbl_InformeCompra";
            this.lbl_InformeCompra.Size = new System.Drawing.Size(144, 19);
            this.lbl_InformeCompra.TabIndex = 24;
            this.lbl_InformeCompra.Text = "Informe Compra";
            // 
            // lbl_ClienteComprador
            // 
            this.lbl_ClienteComprador.AutoSize = true;
            this.lbl_ClienteComprador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClienteComprador.Location = new System.Drawing.Point(577, 414);
            this.lbl_ClienteComprador.Name = "lbl_ClienteComprador";
            this.lbl_ClienteComprador.Size = new System.Drawing.Size(0, 19);
            this.lbl_ClienteComprador.TabIndex = 25;
            // 
            // lbl_ClientesRegistrados
            // 
            this.lbl_ClientesRegistrados.AutoSize = true;
            this.lbl_ClientesRegistrados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientesRegistrados.Location = new System.Drawing.Point(171, 263);
            this.lbl_ClientesRegistrados.Name = "lbl_ClientesRegistrados";
            this.lbl_ClientesRegistrados.Size = new System.Drawing.Size(160, 19);
            this.lbl_ClientesRegistrados.TabIndex = 26;
            this.lbl_ClientesRegistrados.Text = "Clientes Registrados";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(510, 414);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(67, 19);
            this.lbl_Cliente.TabIndex = 28;
            this.lbl_Cliente.Text = "Cliente:";
            // 
            // lbl_TotalUsd
            // 
            this.lbl_TotalUsd.AutoSize = true;
            this.lbl_TotalUsd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalUsd.Location = new System.Drawing.Point(510, 442);
            this.lbl_TotalUsd.Name = "lbl_TotalUsd";
            this.lbl_TotalUsd.Size = new System.Drawing.Size(104, 19);
            this.lbl_TotalUsd.TabIndex = 29;
            this.lbl_TotalUsd.Text = "Total en US$:";
            // 
            // btn_VaciarCarrito
            // 
            this.btn_VaciarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(154)))), ((int)(((byte)(113)))));
            this.btn_VaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VaciarCarrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VaciarCarrito.ForeColor = System.Drawing.Color.White;
            this.btn_VaciarCarrito.Location = new System.Drawing.Point(710, 226);
            this.btn_VaciarCarrito.Name = "btn_VaciarCarrito";
            this.btn_VaciarCarrito.Size = new System.Drawing.Size(215, 26);
            this.btn_VaciarCarrito.TabIndex = 30;
            this.btn_VaciarCarrito.Text = "Vaciar Carrito";
            this.btn_VaciarCarrito.UseVisualStyleBackColor = false;
            this.btn_VaciarCarrito.Click += new System.EventHandler(this.btn_VaciarCarrito_Click);
            // 
            // lbl_DobleClickAgregarCarrito
            // 
            this.lbl_DobleClickAgregarCarrito.AutoSize = true;
            this.lbl_DobleClickAgregarCarrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DobleClickAgregarCarrito.Location = new System.Drawing.Point(132, 231);
            this.lbl_DobleClickAgregarCarrito.Name = "lbl_DobleClickAgregarCarrito";
            this.lbl_DobleClickAgregarCarrito.Size = new System.Drawing.Size(240, 16);
            this.lbl_DobleClickAgregarCarrito.TabIndex = 31;
            this.lbl_DobleClickAgregarCarrito.Text = "Doble click para agregar al carrito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Click para ver la descripción";
            // 
            // FrmNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(937, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DobleClickAgregarCarrito);
            this.Controls.Add(this.btn_VaciarCarrito);
            this.Controls.Add(this.lbl_TotalUsd);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.lbl_ClientesRegistrados);
            this.Controls.Add(this.lbl_ClienteComprador);
            this.Controls.Add(this.lbl_InformeCompra);
            this.Controls.Add(this.lbl_MontoTotal);
            this.Controls.Add(this.checkbox_GenerarTicket);
            this.Controls.Add(this.pb_LogoProductos);
            this.Controls.Add(this.pb_LogoCarritoCompras);
            this.Controls.Add(this.lbl_CarritoCompras);
            this.Controls.Add(this.lbl_ListaProductosVenta);
            this.Controls.Add(this.linklbl_AgregarNuevoClienteVenta);
            this.Controls.Add(this.dgv_ClientesNuevaVenta);
            this.Controls.Add(this.dgv_CarritoVenta);
            this.Controls.Add(this.dgv_ProductosVenta);
            this.Controls.Add(this.btn_Vender);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.FrmNuevaVenta_Load);
            this.Leave += new System.EventHandler(this.btn_VaciarCarrito_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CarritoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientesNuevaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoCarritoCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.DataGridView dgv_ProductosVenta;
        private System.Windows.Forms.DataGridView dgv_CarritoVenta;
        private System.Windows.Forms.DataGridView dgv_ClientesNuevaVenta;
        private System.Windows.Forms.LinkLabel linklbl_AgregarNuevoClienteVenta;
        private System.Windows.Forms.Label lbl_ListaProductosVenta;
        private System.Windows.Forms.Label lbl_CarritoCompras;
        private System.Windows.Forms.PictureBox pb_LogoCarritoCompras;
        private System.Windows.Forms.PictureBox pb_LogoProductos;
        private System.Windows.Forms.CheckBox checkbox_GenerarTicket;
        private System.Windows.Forms.Label lbl_MontoTotal;
        private System.Windows.Forms.Label lbl_InformeCompra;
        private System.Windows.Forms.Label lbl_ClienteComprador;
        private System.Windows.Forms.Label lbl_ClientesRegistrados;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_TotalUsd;
        private System.Windows.Forms.Button btn_VaciarCarrito;
        private System.Windows.Forms.Label lbl_DobleClickAgregarCarrito;
        private System.Windows.Forms.Label label1;
    }
}