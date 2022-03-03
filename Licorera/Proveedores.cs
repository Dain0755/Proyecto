using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Licorera
{
    public partial class Proveedores : Form
    {
        SqlConnection conn = new SqlConnection("server = Dain; database=Licorera; integrated security = true");
        Clases.Proveedores Provee = new Clases.Proveedores();
        int ban = 0;
        public Proveedores()
        {
            InitializeComponent();
            Leer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Leer()
        {
            conn.Open();
            string consulta = "SELECT * FROM Proveedores";
            SqlCommand comando = new SqlCommand(consulta, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            dataGridView1.DataSource = resultado;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            ban = 2;
            panel2.Visible = true;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            ban = 1;
            panel2.Visible = true;
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            try
            {
                if(txtNit.Text != "" || txtNombre.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "" || txtEmail.Text != "")
                {
                    int numerico;
                    if (int.TryParse(txtNit.Text, out numerico))
                    {
                        if (int.TryParse(txtTelefono.Text, out numerico))
                        {
                            if (txtEmail.Text.IndexOf('@') > 0)
                            {
                                if (ban == 1)
                                {
                                    Provee.Nit = txtNit.Text;
                                    Provee.Nombre = txtNombre.Text;
                                    Provee.Telefono = Convert.ToInt32(txtTelefono.Text);
                                    Provee.Dirección = txtDireccion.Text;
                                    Provee.Email = txtEmail.Text;

                                    conn.Open();
                                    string consulta = "INSERT INTO Proveedores VALUES (@p1,@p2,@p3,@p4,@p5)";
                                    SqlCommand comando = new SqlCommand(consulta, conn);
                                    comando.Parameters.AddWithValue("p1", Provee.Nit);
                                    comando.Parameters.AddWithValue("p2", Provee.Nombre);
                                    comando.Parameters.AddWithValue("p3", Provee.Telefono);
                                    comando.Parameters.AddWithValue("p4", Provee.Dirección);
                                    comando.Parameters.AddWithValue("p5", Provee.Email);
                                    comando.ExecuteNonQuery();
                                    conn.Close();

                                    Leer();
                                }

                                if (Provee.Nit != "")
                                {
                                    string dato = Provee.Nit;
                                    Provee.Nit = txtNit.Text;
                                    Provee.Nombre = txtNombre.Text;
                                    Provee.Telefono = Convert.ToInt32(txtTelefono.Text);
                                    Provee.Dirección = txtDireccion.Text;
                                    Provee.Email = txtEmail.Text;

                                    try
                                    {

                                        conn.Open();
                                        string consulta = $"update Proveedores set Nit=@p1, Nombre_Proveedor = @p2, Telefono = @p3, Dirección = @p4 , Email = @p5 where Nit = '{dato}'";
                                        SqlCommand comando = new SqlCommand(consulta, conn);
                                        comando.Parameters.AddWithValue("p1", Provee.Nit);
                                        comando.Parameters.AddWithValue("p2", Provee.Nombre);
                                        comando.Parameters.AddWithValue("p3", Provee.Telefono);
                                        comando.Parameters.AddWithValue("p4", Provee.Dirección);
                                        comando.Parameters.AddWithValue("p5", Provee.Email);
                                        comando.ExecuteNonQuery();
                                        conn.Close();
                                        MessageBox.Show("Datos almacenados correctamente");
                                        Leer();
                                    }
                                    catch
                                    {
                                        conn.Close();
                                    }

                                }

                                else
                                {

                                    txtNit.Text = "";
                                    txtNombre.Text = "";
                                    txtTelefono.Text = "";
                                    txtDireccion.Text = "";
                                    txtEmail.Text = "";
                                }
                                txtbuscar.Clear();
                                txtNit.Clear();
                                txtNombre.Clear();
                                txtTelefono.Clear();
                                txtDireccion.Clear();
                                txtEmail.Clear();
                                Leer();
                                panel2.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("El formato de correo es invalido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El teléfono requiere un valor numérico");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del nit debe ser numérico");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }

                



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {

            conn.Open();
            string consulta = "delete from Proveedores where Nit = @p1";
            SqlCommand Comando = new SqlCommand(consulta, conn);
            Comando.Parameters.AddWithValue("p1", Provee.Nit);
            Comando.ExecuteNonQuery();
            conn.Close();
            Leer();

            txtbuscar.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filas = this.dataGridView1.Rows[e.RowIndex];
                try
                {
                    Provee.Nit = filas.Cells[0].Value.ToString();
                    Provee.Nombre = filas.Cells[1].Value.ToString();
                    Provee.Telefono = Convert.ToInt32(filas.Cells[2].Value.ToString());
                    Provee.Dirección = filas.Cells[3].Value.ToString();
                    Provee.Email = filas.Cells[4].Value.ToString();

                    txtNit.Text = Provee.Nit;
                    txtNombre.Text = Provee.Nombre;
                    txtTelefono.Text = Convert.ToString(Provee.Telefono);
                    txtDireccion.Text = Provee.Dirección;
                    txtEmail.Text = Provee.Email;
                }
                catch (Exception)
                {


                }

            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Provee.Nit = txtbuscar.Text;
            try
            {
                conn.Open();
                string consulta = $"SELECT * FROM Proveedores where Nit like '%{Provee.Nit}%'";
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridView1.DataSource = resultado;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
