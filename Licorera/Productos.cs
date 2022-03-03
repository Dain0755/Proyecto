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
    public partial class Productos : Form
    {
        SqlConnection conn = new SqlConnection("server = Dain; database=Licorera; integrated security = true");
        Clases.Productos ObjetosProductos = new Clases.Productos();
        public Productos()
        {
            InitializeComponent();
            if (Clases.C_Usuario.Cod == "2")
            {
                CrearProducto.Enabled = false;
                EliminarProducto.Enabled = false;
                Modificar.Enabled = false;
                txtCodPro.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtUnidades.Enabled = false;
            }
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conexion DB :( \n" + ex.Message);
            }
            conn.Close();

            Leer();
            
        }
        public void Leer()
        {
            conn.Open();
            string consulta = "SELECT * FROM Productos";
            SqlCommand comando = new SqlCommand(consulta, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            dataGridView1.DataSource = resultado;
            conn.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void CrearProducto_Click(object sender, EventArgs e)
        {
            if (txtCodPro.Text != "" && txtNombre.Text != "" && txtPrecioCompra.Text != "" && txtPrecioVenta.Text != "" && txtUnidades.Text != "")
            {
                int numericos;
                if (int.TryParse(txtPrecioCompra.Text, out numericos)&& int.TryParse(txtPrecioVenta.Text, out numericos) && int.TryParse(txtUnidades.Text, out numericos))
                {
                    ObjetosProductos.Cod = txtCodPro.Text;
                    ObjetosProductos.Nombre = txtNombre.Text;
                    ObjetosProductos.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                    ObjetosProductos.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                    ObjetosProductos.Unidades = Convert.ToInt32(txtUnidades.Text);

                    conn.Open();
                    string consulta = "INSERT INTO Productos VALUES (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    comando.Parameters.AddWithValue("p1", ObjetosProductos.Cod);
                    comando.Parameters.AddWithValue("p2", ObjetosProductos.Nombre);
                    comando.Parameters.AddWithValue("p3", ObjetosProductos.PrecioCompra);
                    comando.Parameters.AddWithValue("p4", ObjetosProductos.PrecioVenta);
                    comando.Parameters.AddWithValue("p5", ObjetosProductos.Unidades);
                    comando.ExecuteNonQuery();
                    conn.Close();

                    Leer();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Debes ingresar valores numéricos", "Error", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK);
            }
           
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
                        

            
            if (ObjetosProductos.Cod != "" && txtCodPro.Text != "" && txtNombre.Text != "" && txtPrecioCompra.Text != "" && txtPrecioVenta.Text != "" && txtUnidades.Text != "")
            {
                int numericos;
                if (int.TryParse(txtPrecioCompra.Text, out numericos) && int.TryParse(txtPrecioVenta.Text, out numericos) && int.TryParse(txtUnidades.Text, out numericos))
                {
                    if (MessageBox.Show("Confirmar cambios","Confirmar",MessageBoxButtons.YesNo) == DialogResult.Yes) 
                    {
                        string dato = ObjetosProductos.Cod;
                        ObjetosProductos.Cod = txtCodPro.Text;
                        ObjetosProductos.Nombre = txtNombre.Text;
                        ObjetosProductos.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                        ObjetosProductos.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                        ObjetosProductos.Unidades = Convert.ToInt32(txtUnidades.Text);

                        try
                        {

                            conn.Open();
                            string consulta = $"update Productos set Cod_Productos=@p1, Nombre = @p2, Precio_Compra = @p3, Precio_Venta = @p4 , Unidades = @p5 where Cod_Productos = '{dato}'";
                            SqlCommand comando = new SqlCommand(consulta, conn);
                            comando.Parameters.AddWithValue("p1", ObjetosProductos.Cod);
                            comando.Parameters.AddWithValue("p2", ObjetosProductos.Nombre);
                            comando.Parameters.AddWithValue("p3", ObjetosProductos.PrecioCompra);
                            comando.Parameters.AddWithValue("p4", ObjetosProductos.PrecioVenta);
                            comando.Parameters.AddWithValue("p5", ObjetosProductos.Unidades);
                            comando.ExecuteNonQuery();
                            conn.Close();

                            Leer();
                            Limpiar();
                        }
                        catch
                        {
                            conn.Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe ingresar valores numericos", "Error", MessageBoxButtons.OK);
                }
            }

            else
            {
                MessageBox.Show("Ningún campo debe quedar vacío", "Error", MessageBoxButtons.OK);
                
            }
            Limpiar();
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro deseas eliminar el producto?", "ALERTA!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string consulta = "delete from Productos where Cod_Productos = @p1";
                    SqlCommand Comando = new SqlCommand(consulta, conn);
                    Comando.Parameters.AddWithValue("p1", ObjetosProductos.Cod);
                    Comando.ExecuteNonQuery();
                    conn.Close();
                    Leer();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
                
            }         
                       
        }

        public void Limpiar()
        {
            txtCodPro.Clear();
            txtNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtUnidades.Clear();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filas = this.dataGridView1.Rows[e.RowIndex];
                try
                {
                    ObjetosProductos.Cod = filas.Cells[0].Value.ToString();
                    ObjetosProductos.Nombre = filas.Cells[1].Value.ToString();
                    ObjetosProductos.PrecioCompra = Convert.ToDouble(filas.Cells[2].Value.ToString());
                    ObjetosProductos.PrecioVenta = Convert.ToDouble(filas.Cells[3].Value.ToString());
                    ObjetosProductos.Unidades = Convert.ToInt32(filas.Cells[4].Value.ToString());

                    txtCodPro.Text = ObjetosProductos.Cod;
                    txtNombre.Text = ObjetosProductos.Nombre;
                    txtPrecioCompra.Text = Convert.ToString(ObjetosProductos.PrecioCompra);
                    txtPrecioVenta.Text = Convert.ToString(ObjetosProductos.PrecioVenta);
                    txtUnidades.Text = Convert.ToString(ObjetosProductos.Unidades);
                }
                catch (Exception)
                {

                    
                }

            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ObjetosProductos.Nombre = txtBuscar.Text;
            try
            {
                conn.Open();
                string consulta = $"SELECT * FROM Productos where Nombre like '%{ObjetosProductos.Nombre}%'";
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridView1.DataSource = resultado;
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
