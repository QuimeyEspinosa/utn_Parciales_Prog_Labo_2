using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLoginUsuario = new FrmLogin();

            Comercio.HardcodeKeM();

            if (frmLoginUsuario.ShowDialog() == DialogResult.OK)
            {
                Comercio.AsignarUsuarioLogueado(frmLoginUsuario.NombreUsuario);
                FrmProductos frmProductosInicio = new FrmProductos();
                SetFormYPanel(this.panel_Forms, frmProductosInicio);
                frmProductosInicio.Show();
            }
            else
            {
                this.Close();
            }

            lbl_UsuarioLogueado.Text = lbl_UsuarioLogueado.Text + " " + Comercio.NombreUsuarioLog;

        }


        private void btn_NuevaVenta_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta frmNuevaVenta = new FrmNuevaVenta();

            SetFormYPanel(this.panel_Forms, frmNuevaVenta);

            frmNuevaVenta.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();

            SetFormYPanel(this.panel_Forms, frmProductos);

            frmProductos.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();

            SetFormYPanel(this.panel_Forms, frmVentas);

            frmVentas.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();

            SetFormYPanel(this.panel_Forms, frmClientes);

            frmClientes.Show();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();

            SetFormYPanel(this.panel_Forms, frmEmpleados);

            frmEmpleados.Show();
        }

        private void SetFormYPanel(Panel miPanel, Form miForm)
        {
            if (miPanel.Controls.Count > 0)
            {
                miPanel.Controls.RemoveAt(0);
            }
            miForm.TopLevel = false;
            miForm.Dock = DockStyle.Fill;
            miPanel.Controls.Add(miForm);
            miPanel.Tag = miForm;
        }


        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Los tickets de compra se generan automáticamente en una carpeta en el escritorio\n" +
                "-Doble click en un producto para modificar su Stock\n" +
                "-Doble click en una venta para acceder a su descripción\n" +
                "-Doble click en un empleado (sector ventas) para acceder a sus ventas\n" +
                "-Al efectuar una compra se ejecuta el sonido de Mario Bros",
                            "Información sobre funcionalidad del programa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void pb_Apu_Click(object sender, EventArgs e)
        {
            SoundPlayer apuSeVa = new SoundPlayer(Path.Combine(Application.StartupPath, "sound\\ApuSeVa.wav"));
            apuSeVa.Play();
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
