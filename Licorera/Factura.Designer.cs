
namespace Licorera
{
    partial class Factura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalDinero = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtVerificar = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.txtDirección = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDireccionCli = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombresCli = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.lblDatoCambio = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.btnProdúctos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Código_Prodúcto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vr_Unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal_Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDatoFactura = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.lblTotalDinero);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Insertar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblDatoCambio);
            this.panel1.Controls.Add(this.lblCambio);
            this.panel1.Controls.Add(this.txtDinero);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtUnidades);
            this.panel1.Controls.Add(this.lblUnidades);
            this.panel1.Controls.Add(this.btnProdúctos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.lblDatoFactura);
            this.panel1.Controls.Add(this.lblFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 794);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalDinero
            // 
            this.lblTotalDinero.AutoSize = true;
            this.lblTotalDinero.Location = new System.Drawing.Point(795, 461);
            this.lblTotalDinero.Name = "lblTotalDinero";
            this.lblTotalDinero.Size = new System.Drawing.Size(20, 17);
            this.lblTotalDinero.TabIndex = 32;
            this.lblTotalDinero.Text = "...";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(518, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "EliminarFila";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Datos Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Efectivo";
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(348, 319);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 28;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.txtVerificar);
            this.panel3.Controls.Add(this.Verificar);
            this.panel3.Controls.Add(this.txtDirección);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblTelefono);
            this.panel3.Controls.Add(this.txtNombres);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.txtDireccionCli);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtNombresCli);
            this.panel3.Controls.Add(this.txtIdentificacion);
            this.panel3.Controls.Add(this.Agregar);
            this.panel3.Location = new System.Drawing.Point(653, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 359);
            this.panel3.TabIndex = 27;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(189, 311);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 29);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtVerificar
            // 
            this.txtVerificar.Location = new System.Drawing.Point(37, 25);
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.Size = new System.Drawing.Size(100, 22);
            this.txtVerificar.TabIndex = 13;
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(189, 25);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(100, 23);
            this.Verificar.TabIndex = 12;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // txtDirección
            // 
            this.txtDirección.AutoSize = true;
            this.txtDirección.Location = new System.Drawing.Point(43, 258);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(67, 17);
            this.txtDirección.TabIndex = 11;
            this.txtDirección.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(43, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Location = new System.Drawing.Point(43, 127);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(65, 17);
            this.txtNombres.TabIndex = 8;
            this.txtNombres.Text = "Nombres";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 17);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Identificacion";
            // 
            // txtDireccionCli
            // 
            this.txtDireccionCli.Location = new System.Drawing.Point(189, 254);
            this.txtDireccionCli.Name = "txtDireccionCli";
            this.txtDireccionCli.Size = new System.Drawing.Size(100, 22);
            this.txtDireccionCli.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(189, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtNombresCli
            // 
            this.txtNombresCli.Location = new System.Drawing.Point(189, 122);
            this.txtNombresCli.Name = "txtNombresCli";
            this.txtNombresCli.Size = new System.Drawing.Size(100, 22);
            this.txtNombresCli.TabIndex = 3;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(189, 74);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 22);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(60, 311);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 29);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // lblDatoCambio
            // 
            this.lblDatoCambio.AutoSize = true;
            this.lblDatoCambio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoCambio.Location = new System.Drawing.Point(808, 677);
            this.lblDatoCambio.Name = "lblDatoCambio";
            this.lblDatoCambio.Size = new System.Drawing.Size(27, 27);
            this.lblDatoCambio.TabIndex = 26;
            this.lblDatoCambio.Text = "...";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(677, 677);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(83, 27);
            this.lblCambio.TabIndex = 24;
            this.lblCambio.Text = "Cambio";
            this.lblCambio.Click += new System.EventHandler(this.lblCambio_Click);
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(798, 509);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(128, 22);
            this.txtDinero.TabIndex = 23;
            this.txtDinero.TextChanged += new System.EventHandler(this.txtDinero_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(733, 582);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(200, 42);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(710, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(242, 320);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 22);
            this.txtUnidades.TabIndex = 15;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(159, 321);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(68, 17);
            this.lblUnidades.TabIndex = 14;
            this.lblUnidades.Text = "Unidades";
            // 
            // btnProdúctos
            // 
            this.btnProdúctos.Location = new System.Drawing.Point(23, 318);
            this.btnProdúctos.Name = "btnProdúctos";
            this.btnProdúctos.Size = new System.Drawing.Size(117, 23);
            this.btnProdúctos.TabIndex = 12;
            this.btnProdúctos.Text = "Prodúctos";
            this.btnProdúctos.UseVisualStyleBackColor = true;
            this.btnProdúctos.Click += new System.EventHandler(this.btnProdúctos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 384);
            this.panel2.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(109, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(3, 17);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 22);
            this.txtFiltrar.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.items,
            this.Código_Prodúcto,
            this.Nombre,
            this.Unidades,
            this.Vr_Unitario,
            this.Subtotal_Producto});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 271);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.Text = "Items";
            this.items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.items.Width = 50;
            // 
            // Código_Prodúcto
            // 
            this.Código_Prodúcto.Text = "Código_Producto";
            this.Código_Prodúcto.Width = 84;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Width = 149;
            // 
            // Unidades
            // 
            this.Unidades.Text = "Unidades";
            this.Unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Unidades.Width = 99;
            // 
            // Vr_Unitario
            // 
            this.Vr_Unitario.Text = "Vr_Unitario";
            this.Vr_Unitario.Width = 82;
            // 
            // Subtotal_Producto
            // 
            this.Subtotal_Producto.Text = "Subtotal_Producto";
            this.Subtotal_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Subtotal_Producto.Width = 143;
            // 
            // lblDatoFactura
            // 
            this.lblDatoFactura.AutoSize = true;
            this.lblDatoFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatoFactura.Location = new System.Drawing.Point(118, 9);
            this.lblDatoFactura.Name = "lblDatoFactura";
            this.lblDatoFactura.Size = new System.Drawing.Size(22, 19);
            this.lblDatoFactura.TabIndex = 7;
            this.lblDatoFactura.Text = "...";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(13, 9);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(68, 17);
            this.lblFactura.TabIndex = 6;
            this.lblFactura.Text = "# Factura";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 794);
            this.Controls.Add(this.panel1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtVerificar;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Label txtDirección;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDireccionCli;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombresCli;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label lblDatoCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Button btnProdúctos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Código_Prodúcto;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Unidades;
        private System.Windows.Forms.ColumnHeader Subtotal_Producto;
        private System.Windows.Forms.Label lblDatoFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.ColumnHeader items;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ColumnHeader Vr_Unitario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotalDinero;
        private System.Windows.Forms.Button btnActualizar;
    }
}