namespace JohanGutierrezPractico1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cbEsEmpresa = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadFacturas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroUltimaFactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoUltimaFactura = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblValorUF = new System.Windows.Forms.Label();
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(713, 15);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(956, 761);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUT:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(324, 15);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(265, 22);
            this.txtRut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(324, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ES EMPRESA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "TELEFONO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(324, 191);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 22);
            this.txtTelefono.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "DIRECCION:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(324, 235);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(265, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "FECHA DE REGISTRO:";
            // 
            // datePickerFechaRegistro
            // 
            this.datePickerFechaRegistro.Location = new System.Drawing.Point(324, 287);
            this.datePickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerFechaRegistro.Name = "datePickerFechaRegistro";
            this.datePickerFechaRegistro.Size = new System.Drawing.Size(265, 22);
            this.datePickerFechaRegistro.TabIndex = 4;
            // 
            // cbEsEmpresa
            // 
            this.cbEsEmpresa.AccessibleDescription = "";
            this.cbEsEmpresa.AccessibleName = "";
            this.cbEsEmpresa.FormattingEnabled = true;
            this.cbEsEmpresa.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cbEsEmpresa.Location = new System.Drawing.Point(324, 129);
            this.cbEsEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbEsEmpresa.Name = "cbEsEmpresa";
            this.cbEsEmpresa.Size = new System.Drawing.Size(265, 24);
            this.cbEsEmpresa.TabIndex = 5;
            this.cbEsEmpresa.Text = "SELECCIONE UNA OPCION";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(195, 506);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "AGREGAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "CANTIDAD DE FACTURAS:";
            // 
            // txtCantidadFacturas
            // 
            this.txtCantidadFacturas.Location = new System.Drawing.Point(324, 343);
            this.txtCantidadFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadFacturas.Name = "txtCantidadFacturas";
            this.txtCantidadFacturas.Size = new System.Drawing.Size(265, 22);
            this.txtCantidadFacturas.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "NUMERO ULTIMA FACTURA:";
            // 
            // txtNumeroUltimaFactura
            // 
            this.txtNumeroUltimaFactura.Location = new System.Drawing.Point(324, 380);
            this.txtNumeroUltimaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroUltimaFactura.Name = "txtNumeroUltimaFactura";
            this.txtNumeroUltimaFactura.Size = new System.Drawing.Size(265, 22);
            this.txtNumeroUltimaFactura.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "MONTO ULTIMA FACTURA:";
            // 
            // txtMontoUltimaFactura
            // 
            this.txtMontoUltimaFactura.Location = new System.Drawing.Point(324, 422);
            this.txtMontoUltimaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoUltimaFactura.Name = "txtMontoUltimaFactura";
            this.txtMontoUltimaFactura.Size = new System.Drawing.Size(265, 22);
            this.txtMontoUltimaFactura.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(605, 15);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(605, 50);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblValorUF
            // 
            this.lblValorUF.AutoSize = true;
            this.lblValorUF.Location = new System.Drawing.Point(16, 604);
            this.lblValorUF.Name = "lblValorUF";
            this.lblValorUF.Size = new System.Drawing.Size(25, 16);
            this.lblValorUF.TabIndex = 8;
            this.lblValorUF.Text = "UF";
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(321, 604);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(53, 16);
            this.lblValorDolar.TabIndex = 8;
            this.lblValorDolar.Text = "DOLAR";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(141, 648);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "FECHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 790);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblValorDolar);
            this.Controls.Add(this.lblValorUF);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEsEmpresa);
            this.Controls.Add(this.datePickerFechaRegistro);
            this.Controls.Add(this.txtMontoUltimaFactura);
            this.Controls.Add(this.txtNumeroUltimaFactura);
            this.Controls.Add(this.txtCantidadFacturas);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerFechaRegistro;
        private System.Windows.Forms.ComboBox cbEsEmpresa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadFacturas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroUltimaFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoUltimaFactura;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblValorUF;
        private System.Windows.Forms.Label lblValorDolar;
        private System.Windows.Forms.Label lblFecha;
    }
}

