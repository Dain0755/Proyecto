using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licorera
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
            NombreUsuario.Text = $"Bienvenid@\n {Clases.C_Usuario.NombreUsuario}";
            if (Clases.C_Usuario.Cod == "2")
            {
                btnNewUser.Enabled = false;
                btnProveedores.Enabled = false;
            }
        }
        private void brirForm(Form formHijo)
        {
            //panelMenu.Width = 70; // disminuye el tamaño del menú y  solo muestra el icono
            //si el formulario/instancia no existe
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(formHijo);
            formHijo.Show();

        }
        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NuevoUsuario botonLLamdo = new NuevoUsuario();
            brirForm(botonLLamdo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos botonLLamdo = new Productos();
            brirForm(botonLLamdo);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores botonLlamado = new Proveedores();
            brirForm(botonLlamado);
        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Factura botonLLamado = new Factura();
            brirForm(botonLLamado);
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
            FrmLogin botonLlamado = new FrmLogin();
            brirForm(botonLlamado);
        }
    }
}
