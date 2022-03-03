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
    public partial class FrmLogin : Form
    {
        Menú llamado;
        SqlConnection conn = new SqlConnection("server=Dain; database=Licorera; integrated security= true");

        Clases.C_Usuario user = new Clases.C_Usuario();

        public FrmLogin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    
                    conn.Open();
                    string Consulta = "Select * from Usuarios where (Usuario = '"+txtUsuario.Text+"' and Clave = '"+txtPassword.Text+"')";
                    SqlCommand Comando = new SqlCommand(Consulta, conn);
                    SqlDataAdapter Adaptador = new SqlDataAdapter();
                    Adaptador.SelectCommand = Comando;
                    DataTable Resultado = new DataTable();
                    Adaptador.Fill(Resultado);
                    SqlDataReader leer = Comando.ExecuteReader();
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
                    conn.Close();
                    if (Resultado.Rows.Count==1)
                    {
                        conn.Open();                        
                        llamado = new Menú();
                        llamado.Show();
                        this.Hide();                        
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta, verifique por favor");
                    }                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }else
                MessageBox.Show("Debe llenar ambos campos");
        }
            
    

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
