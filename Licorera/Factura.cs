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
    public partial class Factura : Form
    {
        SqlConnection conn = new SqlConnection("server = Dain; database=Licorera; integrated security = true");
        Clases.Productos facturaProducto = new Clases.Productos();
        Clases.Cliente NewCliente = new Clases.Cliente();
        ListViewItem Productos = new ListViewItem();
        Clases.Factura NewFactura = new Clases.Factura();
        Clases.Detalle_Factura NewDetalleFac = new Clases.Detalle_Factura();
        int i = 1, cantidad = 0, numFactura = 0;
        double subttal = 0;
        double total = 0;
        
        public Factura()
        {
            InitializeComponent();
            NumFactura();
        }
        public void NumFactura()
        {
            try
            {
                conn.Open();
                string consulta = ("select count (*) Numero_Factura from Factura");
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    numFactura = Convert.ToInt32(leer[0].ToString());                    
                }

                conn.Close();
                numFactura++;
                lblDatoFactura.Text = numFactura.ToString();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            
            
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

        private void btnProdúctos_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Leer();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filas = this.dataGridView1.Rows[e.RowIndex];
                try
                {
                    facturaProducto.Cod = filas.Cells[0].Value.ToString();
                    facturaProducto.Nombre = filas.Cells[1].Value.ToString();
                    facturaProducto.PrecioVenta = Convert.ToDouble(filas.Cells[3].Value.ToString());
                    facturaProducto.Unidades = Convert.ToInt32(filas.Cells[4].Value.ToString());
                }
                catch (Exception)
                {


                }

            }
        }
        
        

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = 0;
                
              
                if (facturaProducto.Cod != "")
                {
                    conn.Open();
                    string consulta = $"select Unidades from Productos where Cod_Productos = '{facturaProducto.Cod}'";
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    SqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        cantidad = Convert.ToInt32(leer[0].ToString());
                        
                    }
                    conn.Close();
                    if (cantidad < 0)
                    {
                        MessageBox.Show("El producto seleccionado no tiene unidades en stock");
                        txtUnidades.Clear();
                    }
                    else
                    {

                        if (cantidad < Convert.ToInt32(txtUnidades.Text))
                        {
                            MessageBox.Show("La cantidad ingresada es mayor que el stock");
                            txtUnidades.Clear();

                        }
                        else
                        {
                            cantidad = Convert.ToInt32(txtUnidades.Text);
                            subttal = facturaProducto.PrecioVenta * cantidad;
                            total += subttal;
                            ListViewItem Productos = new ListViewItem(i.ToString());
                            Productos.SubItems.Add(facturaProducto.Cod);
                            Productos.SubItems.Add(facturaProducto.Nombre);
                            Productos.SubItems.Add(Convert.ToString(txtUnidades.Text));
                            Productos.SubItems.Add(Convert.ToString(facturaProducto.PrecioVenta));
                            Productos.SubItems.Add(subttal.ToString());
                            i++;
                            listView1.Items.AddRange(new ListViewItem[] { Productos });
                            Total();
                            txtUnidades.Clear();
                            
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }
                facturaProducto.Cod = "";
                
            }catch (Exception ex)
            {
               
                MessageBox.Show("Debe ingresar valores numericos","Error", MessageBoxButtons.OK);
                conn.Close();
            }
            

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            facturaProducto.Nombre = txtFiltrar.Text;
            try
            {
                conn.Open();
                string consulta = $"SELECT * FROM Productos where Nombre like '%{facturaProducto.Nombre}%'";
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
            txtFiltrar.Clear();
        }
        public void Limpiar()
        {
            listView1.Items.Clear();
            panel2.Visible = false;
            txtVerificar.Clear();
            txtIdentificacion.Clear();
            txtNombresCli.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccionCli.Clear();
            lblTotalDinero.Text = "...";
            txtDinero.Clear();
            NewCliente.ID = null;
            NewCliente.Nombres = null;
            NewCliente.Telefono = 0;
            NewCliente.Email = null;
            NewCliente.Direccion = null;
        }

        public void actualizar()
        {
            try
            {
                int cantidad = 1;
                for (int H = 0; H < listView1.Items.Count; H++)
                {
                    listView1.Items[H].Text = cantidad.ToString();
                    cantidad++;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Productos in listView1.SelectedItems)
            {
                Productos.Remove();
                string Dato = Productos.SubItems[5].Text;
                total = total - Convert.ToDouble(Dato);
                Total();
                i--;
                
            }

            actualizar();

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta = $"SELECT * FROM Cliente where Cédula_Cliente like '%{txtVerificar.Text}%'";
            SqlCommand comando = new SqlCommand(consulta, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            SqlDataReader leer = comando.ExecuteReader();

            if (resultado.Rows.Count == 1)
            {
                while (leer.Read())
                {
                    NewCliente.ID = leer[0].ToString();
                    NewCliente.Nombres = leer[1].ToString();
                    NewCliente.Telefono = Convert.ToInt32(leer[2].ToString());
                    NewCliente.Email = leer[3].ToString();
                    NewCliente.Direccion = leer[4].ToString();

                    txtIdentificacion.Text = NewCliente.ID;
                    txtNombresCli.Text = NewCliente.Nombres;
                    txtTelefono.Text = NewCliente.Telefono.ToString();
                    txtEmail.Text = NewCliente.Email;
                    txtDireccionCli.Text = NewCliente.Direccion;
                }

            }
            else
            { MessageBox.Show("Cliente no registrado"); }
            txtVerificar.Clear();
            conn.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Consulta = "Insert into Cliente values (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand comando = new SqlCommand(Consulta, conn);
                comando.Parameters.AddWithValue("p1", Convert.ToInt32(txtIdentificacion.Text));
                comando.Parameters.AddWithValue("p2", txtNombresCli.Text);
                comando.Parameters.AddWithValue("p3", Convert.ToInt32(txtTelefono.Text));
                comando.Parameters.AddWithValue("p4", txtEmail.Text);
                comando.Parameters.AddWithValue("p5", txtDireccionCli.Text);
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro exitoso, bienvenid@ : " + txtNombresCli.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            txtIdentificacion.Clear();
            txtNombresCli.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccionCli.Clear();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text != "")
            {
                string dato = NewCliente.ID;
                NewCliente.ID = txtIdentificacion.Text;
                NewCliente.Nombres = txtNombresCli.Text;
                NewCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                NewCliente.Email = txtEmail.Text;
                NewCliente.Direccion = txtDireccionCli.Text;

                try
                {

                    conn.Open();
                    string consulta = $"update Cliente set Cédula_Cliente=@p1, Nombres_Cliente = @p2, Telefono = @p3, Email = @p4, Dirección = @p5 where Cédula_Cliente = '{txtIdentificacion.Text}'";
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    comando.Parameters.AddWithValue("p1", NewCliente.ID);
                    comando.Parameters.AddWithValue("p2", NewCliente.Nombres);
                    comando.Parameters.AddWithValue("p3", NewCliente.Telefono);
                    comando.Parameters.AddWithValue("p4", NewCliente.Email);
                    comando.Parameters.AddWithValue("p5", NewCliente.Direccion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void txtDinero_TextChanged(object sender, EventArgs e)
        {
            if (txtDinero.Text != "")
            {
                lblDatoCambio.Text = Convert.ToString(Convert.ToInt32(txtDinero.Text) - total);
            }
            else
                lblDatoCambio.Text = "...";
            
        }

        private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCambio_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if(txtIdentificacion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la información del cliente", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (txtDinero.Text != "")
                    {
                        if (Convert.ToInt32(txtDinero.Text) >= Convert.ToInt32(lblTotalDinero.Text))
                        {
                            conn.Open();
                            NewFactura.Numfac = numFactura.ToString();
                            NewFactura.Fecha = DateTime.Now.ToString();
                            NewFactura.total = total.ToString();
                            NewFactura.IdClien = NewCliente.ID;
                            NewFactura.IdUser = Clases.C_Usuario.Id;
                            string consulta = "Insert into Factura values (@p1, @p2, @p3, @p4, @p5)";
                            SqlCommand comando = new SqlCommand(consulta, conn);
                            comando.Parameters.AddWithValue("p1", Convert.ToInt32(NewFactura.Numfac));
                            comando.Parameters.AddWithValue("p2", Convert.ToDateTime(NewFactura.Fecha));
                            comando.Parameters.AddWithValue("p3", Convert.ToDecimal(NewFactura.total));
                            comando.Parameters.AddWithValue("p4", Convert.ToInt32(NewFactura.IdClien));
                            comando.Parameters.AddWithValue("p5", Convert.ToInt32(NewFactura.IdUser));
                            comando.ExecuteNonQuery();

                            MessageBox.Show("Factura generada correctamente, aquí iría un pdf pero el profesor nunca lo mandó");

                            Limpiar();
                            conn.Close();
                            try
                            {
                                for (int i = 0; i < listView1.Items.Count; i++)
                                {
                                    conn.Open();
                                    NewDetalleFac.CodProd = listView1.Items[i].SubItems[1].Text;
                                    NewDetalleFac.Numfact = numFactura.ToString();
                                    NewDetalleFac.Cantidad = listView1.Items[i].SubItems[3].Text;
                                    NewDetalleFac.ValorUnidad = listView1.Items[i].SubItems[4].Text;
                                    string consulta1 = "Insert into Detalle_factura values (@p1, @p2, @p3, @p4)";
                                    SqlCommand comando1 = new SqlCommand(consulta1, conn);
                                    comando1.Parameters.AddWithValue("p1", NewDetalleFac.CodProd.ToString());
                                    comando1.Parameters.AddWithValue("p2", Convert.ToInt32(NewDetalleFac.Numfact));
                                    comando1.Parameters.AddWithValue("p3", Convert.ToInt32(NewDetalleFac.Cantidad));
                                    comando1.Parameters.AddWithValue("p4", Convert.ToDecimal(NewDetalleFac.ValorUnidad));
                                    comando1.ExecuteNonQuery();

                                    conn.Close();
                                    ActualizarProducto();

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                conn.Close();
                            }
                            NumFactura();
                        }
                        else
                        {
                            MessageBox.Show("El valor ingresado debe ser mayor o igual al total a pagar", "Error", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el monto recibido", "Error", MessageBoxButtons.OK);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        public void Total()
        {
            lblTotalDinero.Text = total.ToString();
        }

        public void ActualizarProducto()
        {
            int cant = 0;
            try
            {
                conn.Open();
                string consulta1 = $"SELECT Unidades FROM Productos where Cod_Productos = '{NewDetalleFac.CodProd}'";
                SqlCommand comando1 = new SqlCommand(consulta1, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando1;                
                SqlDataReader leer = comando1.ExecuteReader();
                while (leer.Read())
                {
                    cant = Convert.ToInt32(leer[0].ToString());
                }
                conn.Close();
                facturaProducto.Unidades = cant - Convert.ToInt32(NewDetalleFac.Cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            try
            {
                conn.Open();
                string consulta = $"update Productos set Unidades =@p1 where Cod_Productos = '{NewDetalleFac.CodProd}'";
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("p1", facturaProducto.Unidades);
                comando.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }
        
    }
        
}
