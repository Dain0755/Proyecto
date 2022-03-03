using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Licorera
{
    public partial class NuevoUsuario : Form
    {
        int rol = 0;
        int rolNuevo = 0;
        SqlConnection conn = new SqlConnection("server=Dain; database=Licorera; integrated security= true");
        
        
        public NuevoUsuario()
        {
            InitializeComponent();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conexion DB :( \n" + ex.Message);
            }
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int numerico;
            if ((txtID.Text == "") || (txtNombre.Text == "") || (Rb1.Checked == false) && (Rb2.Checked == false) || (txtCorreo.Text == "") || (txtUsuario.Text == "") || (txtPassword.Text == "") || (txtConfiPass.Text == ""))
            {
                MessageBox.Show("LLena los campos obligatorios", "MENSAJE DE ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (txtPassword.Text != txtConfiPass.Text)
                {
                    MessageBox.Show("La contraseña no coincide", "intentalo de nuevo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (txtCorreo.Text.IndexOf('@') < 0)
                    {
                        MessageBox.Show("Correo con formato invalido", "MENSAJE DE ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(txtTelefono.Text, out numerico))
                        {
                            if (Rb1.Checked == true)
                            {
                                rol = 1;
                            }
                            else
                            {
                                rol = 2;
                            }
                            try
                            {
                                conn.Open();
                                string Consulta = "Select * from Usuarios where Id_Usuario = '" + txtID.Text + "'";
                                SqlCommand Comando = new SqlCommand(Consulta, conn);
                                SqlDataAdapter Adaptador = new SqlDataAdapter();
                                Adaptador.SelectCommand = Comando;
                                DataTable Resultado = new DataTable();
                                Adaptador.Fill(Resultado);
                                conn.Close();
                                if (Resultado.Rows.Count == 0)
                                {
                                    conn.Open();
                                    Consulta = "Insert into Usuarios values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                                    SqlCommand comando = new SqlCommand(Consulta, conn);
                                    comando.Parameters.AddWithValue("p1", txtID.Text);
                                    comando.Parameters.AddWithValue("p2", txtUsuario.Text);
                                    comando.Parameters.AddWithValue("p3", rol);
                                    comando.Parameters.AddWithValue("p4", txtPassword.Text);
                                    comando.Parameters.AddWithValue("p5", txtNombre.Text);
                                    comando.Parameters.AddWithValue("p6", txtCorreo.Text);
                                    comando.Parameters.AddWithValue("p7", txtTelefono.Text);
                                    comando.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Registro exitoso, bienvenid@ : " + txtNombre.Text);
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya se encuentra registrado");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            txtID.Clear();
                            txtNombre.Clear();
                            txtPassword.Clear();
                            txtUsuario.Clear();
                            txtTelefono.Clear();
                            txtConfiPass.Clear();
                            txtCorreo.Clear();
                            rol = 0;
                        }
                        else
                        {
                            MessageBox.Show("Formato de teléfono invalido, intente de nuevo");
                        }
                    }
                }
            }         
            
            
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Modificar_Click_1(object sender, EventArgs e)
        {
            int numerico;
            if ((txtID.Text == "") || (txtNombre.Text == "") || (Rb1.Checked == false) && (Rb2.Checked == false) || (txtCorreo.Text == "") || (txtUsuario.Text == "") || (txtPassword.Text == "") || (txtConfiPass.Text == ""))
            {
                MessageBox.Show("LLena los campos obligatorios", "MENSAJE DE ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (txtPassword.Text != txtConfiPass.Text)
                {
                    MessageBox.Show("La contraseña no coincide", "intentalo de nuevo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (txtCorreo.Text.IndexOf('@') < 0)
                    {
                        MessageBox.Show("Correo con formato invalido", "MENSAJE DE ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(txtTelefono.Text, out numerico))
                        {
                            if (Rb1.Checked == true)
                            {
                                rolNuevo = 1;
                            }
                            else
                            {
                                rolNuevo = 2;
                            }
                            if (txtID.Text != "")
                            {


                                try
                                {
                                    string dato = Clases.C_Usuario.Id;
                                    Clases.C_Usuario.Id = txtID.Text;
                                    Clases.C_Usuario.Usuario = txtUsuario.Text;
                                    Clases.C_Usuario.Cod = rolNuevo.ToString();
                                    Clases.C_Usuario.Clave = txtPassword.Text;
                                    Clases.C_Usuario.NombreUsuario = txtNombre.Text;
                                    Clases.C_Usuario.Correo = txtCorreo.Text;
                                    Clases.C_Usuario.Telefono = Convert.ToInt32(txtTelefono.Text);

                                    conn.Open();
                                    string consulta = $"update Usuarios set Id_Usuario=@p1, Usuario = @p2, Cod_Rol = @p3, Clave = @p4, Nombres_Usuario = @p5, Correo = @p6, Teléfono = @p7 where Id_Usuario = '{txtID.Text}'";
                                    SqlCommand comando = new SqlCommand(consulta, conn);
                                    comando.Parameters.AddWithValue("p1", Clases.C_Usuario.Id);
                                    comando.Parameters.AddWithValue("p2", Clases.C_Usuario.Usuario);
                                    comando.Parameters.AddWithValue("p3", Clases.C_Usuario.Cod);
                                    comando.Parameters.AddWithValue("p4", Clases.C_Usuario.Clave);
                                    comando.Parameters.AddWithValue("p5", Clases.C_Usuario.NombreUsuario);
                                    comando.Parameters.AddWithValue("p6", Clases.C_Usuario.Correo);
                                    comando.Parameters.AddWithValue("p7", Clases.C_Usuario.Telefono);
                                    comando.ExecuteNonQuery();
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    conn.Close();
                                    MessageBox.Show(ex.Message);
                                }
                                txtID.Clear();
                                txtUsuario.Clear();
                                txtPassword.Clear();
                                txtNombre.Clear();
                                txtCorreo.Clear();
                                txtConfiPass.Clear();
                                txtTelefono.Clear();
                                rolNuevo = 0;
                                txtBuscar.Clear();
                                MessageBox.Show("Datos actualizados!");
                            }
                        }

                        else
                        {
                            MessageBox.Show("El valor ingresado no es numerico, intenta nuevamente");
                        }
                    }
                }
                
            }       
                  
                        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clases.C_Usuario.Id = txtBuscar.Text;
            try
            {
                if (txtBuscar.Text != "")
                {
                    conn.Open();
                    string consulta = $"SELECT * FROM Usuarios where Id_Usuario = '{Clases.C_Usuario.Id}'";
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    SqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        Clases.C_Usuario.Id = leer[0].ToString();
                        Clases.C_Usuario.Usuario = leer[1].ToString();
                        Clases.C_Usuario.Cod = leer[2].ToString();
                        Clases.C_Usuario.Clave = leer[3].ToString();
                        Clases.C_Usuario.NombreUsuario = leer[4].ToString();
                        Clases.C_Usuario.Correo = leer[5].ToString();
                        Clases.C_Usuario.Telefono = Convert.ToInt32(leer[6]);
                    }
                    if (Clases.C_Usuario.Cod != "")
                    {
                        txtID.Text = Clases.C_Usuario.Id;
                        txtUsuario.Text = Clases.C_Usuario.Usuario;
                        txtPassword.Text = Clases.C_Usuario.Clave;
                        txtNombre.Text = Clases.C_Usuario.NombreUsuario;
                        txtCorreo.Text = Clases.C_Usuario.Correo;
                        txtTelefono.Text = Clases.C_Usuario.Telefono.ToString();
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Ingresa un documento para buscar");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
