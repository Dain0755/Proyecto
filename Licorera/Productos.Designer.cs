
namespace Licorera
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CrearProducto = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.EliminarProducto = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.CodigoProducto = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.Label();
            this.PrecioProducto = new System.Windows.Forms.Label();
            this.PrecioVenta = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CrearProducto
            // 
            this.CrearProducto.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearProducto.Location = new System.Drawing.Point(30, 183);
            this.CrearProducto.Name = "CrearProducto";
            this.CrearProducto.Size = new System.Drawing.Size(113, 38);
            this.CrearProducto.TabIndex = 1;
            this.CrearProducto.Text = "Crear";
            this.CrearProducto.UseVisualStyleBackColor = true;
            this.CrearProducto.Click += new System.EventHandler(this.CrearProducto_Click);
            // 
            // Modificar
            // 
            this.Modificar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(186, 183);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(113, 38);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // EliminarProducto
            // 
            this.EliminarProducto.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProducto.Location = new System.Drawing.Point(368, 183);
            this.EliminarProducto.Name = "EliminarProducto";
            this.EliminarProducto.Size = new System.Drawing.Size(113, 38);
            this.EliminarProducto.TabIndex = 4;
            this.EliminarProducto.Text = "Eliminar";
            this.EliminarProducto.UseVisualStyleBackColor = true;
            this.EliminarProducto.Click += new System.EventHandler(this.EliminarProducto_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(533, 180);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(156, 41);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(30, 134);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(113, 25);
            this.txtCodPro.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(162, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 25);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(368, 134);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(113, 25);
            this.txtPrecioCompra.TabIndex = 8;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(533, 134);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(84, 25);
            this.txtPrecioVenta.TabIndex = 9;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.AutoSize = true;
            this.CodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.CodigoProducto.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.Location = new System.Drawing.Point(29, 91);
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(118, 19);
            this.CodigoProducto.TabIndex = 10;
            this.CodigoProducto.Text = "Código Producto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSize = true;
            this.NombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.NombreProducto.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.Location = new System.Drawing.Point(158, 91);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(128, 19);
            this.NombreProducto.TabIndex = 11;
            this.NombreProducto.Text = "Nombre(detallado)";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSize = true;
            this.PrecioProducto.BackColor = System.Drawing.Color.Transparent;
            this.PrecioProducto.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProducto.Location = new System.Drawing.Point(364, 91);
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(111, 19);
            this.PrecioProducto.TabIndex = 12;
            this.PrecioProducto.Text = "Precio Producto";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSize = true;
            this.PrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.PrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioVenta.Location = new System.Drawing.Point(529, 91);
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Size = new System.Drawing.Size(87, 19);
            this.PrecioVenta.TabIndex = 13;
            this.PrecioVenta.Text = "Precio Venta";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(33, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(527, 25);
            this.txtBuscar.TabIndex = 15;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.Location = new System.Drawing.Point(584, 36);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(128, 27);
            this.Buscar.TabIndex = 16;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(659, 91);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(68, 19);
            this.lblUnidades.TabIndex = 17;
            this.lblUnidades.Text = "Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Location = new System.Drawing.Point(662, 134);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 25);
            this.txtUnidades.TabIndex = 18;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.PrecioVenta);
            this.Controls.Add(this.PrecioProducto);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.CodigoProducto);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.EliminarProducto);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.CrearProducto);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CrearProducto;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button EliminarProducto;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label CodigoProducto;
        private System.Windows.Forms.Label NombreProducto;
        private System.Windows.Forms.Label PrecioProducto;
        private System.Windows.Forms.Label PrecioVenta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.TextBox txtUnidades;
    }
}