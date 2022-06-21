namespace Vista
{
    partial class ABMMaquinaria
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
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.dgvMaquinaria = new System.Windows.Forms.DataGridView();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusq = new System.Windows.Forms.Label();
            this.lblTitBusq = new System.Windows.Forms.Label();
            this.gpbAltaMaq = new System.Windows.Forms.GroupBox();
            this.lblErrorCod = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblErrorEstado = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFechaAdq = new System.Windows.Forms.Label();
            this.lblErrorTipo = new System.Windows.Forms.Label();
            this.lblErrorModelo = new System.Windows.Forms.Label();
            this.lblErrorMarca = new System.Windows.Forms.Label();
            this.txtIdMaq = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).BeginInit();
            this.gpbAltaMaq.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.dgvMaquinaria);
            this.gpbBusqueda.Controls.Add(this.cmbBusqueda);
            this.gpbBusqueda.Controls.Add(this.txtBusqueda);
            this.gpbBusqueda.Controls.Add(this.btnModificar);
            this.gpbBusqueda.Controls.Add(this.btnEliminar);
            this.gpbBusqueda.Controls.Add(this.lblBusq);
            this.gpbBusqueda.Controls.Add(this.lblTitBusq);
            this.gpbBusqueda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusqueda.Location = new System.Drawing.Point(615, 81);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(699, 567);
            this.gpbBusqueda.TabIndex = 10;
            this.gpbBusqueda.TabStop = false;
            // 
            // dgvMaquinaria
            // 
            this.dgvMaquinaria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinaria.Location = new System.Drawing.Point(26, 128);
            this.dgvMaquinaria.Name = "dgvMaquinaria";
            this.dgvMaquinaria.RowTemplate.Height = 24;
            this.dgvMaquinaria.Size = new System.Drawing.Size(649, 339);
            this.dgvMaquinaria.TabIndex = 14;
            this.dgvMaquinaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinaria_CellClick);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Tipo",
            "Marca",
            "Modelo",
            "Codigo"});
            this.cmbBusqueda.Location = new System.Drawing.Point(147, 62);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(206, 33);
            this.cmbBusqueda.TabIndex = 13;
            this.cmbBusqueda.Text = "Seleccionar";
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            this.cmbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBusqueda_KeyPress);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(364, 63);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(311, 32);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.Location = new System.Drawing.Point(520, 504);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 43);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.Location = new System.Drawing.Point(333, 504);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 43);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBusq
            // 
            this.lblBusq.AutoSize = true;
            this.lblBusq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBusq.Location = new System.Drawing.Point(21, 63);
            this.lblBusq.Name = "lblBusq";
            this.lblBusq.Size = new System.Drawing.Size(110, 25);
            this.lblBusq.TabIndex = 5;
            this.lblBusq.Text = "Busqueda";
            // 
            // lblTitBusq
            // 
            this.lblTitBusq.AutoSize = true;
            this.lblTitBusq.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitBusq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitBusq.Location = new System.Drawing.Point(300, 0);
            this.lblTitBusq.Name = "lblTitBusq";
            this.lblTitBusq.Size = new System.Drawing.Size(128, 25);
            this.lblTitBusq.TabIndex = 0;
            this.lblTitBusq.Text = "BUSQUEDA";
            // 
            // gpbAltaMaq
            // 
            this.gpbAltaMaq.Controls.Add(this.lblErrorCod);
            this.gpbAltaMaq.Controls.Add(this.lblCodigo);
            this.gpbAltaMaq.Controls.Add(this.txtCodigo);
            this.gpbAltaMaq.Controls.Add(this.lblErrorFecha);
            this.gpbAltaMaq.Controls.Add(this.dtpFecha);
            this.gpbAltaMaq.Controls.Add(this.lblErrorEstado);
            this.gpbAltaMaq.Controls.Add(this.lblErrorPrecio);
            this.gpbAltaMaq.Controls.Add(this.cmbEstado);
            this.gpbAltaMaq.Controls.Add(this.txtPrecio);
            this.gpbAltaMaq.Controls.Add(this.lblEstado);
            this.gpbAltaMaq.Controls.Add(this.lblPrecio);
            this.gpbAltaMaq.Controls.Add(this.lblFechaAdq);
            this.gpbAltaMaq.Controls.Add(this.lblErrorTipo);
            this.gpbAltaMaq.Controls.Add(this.lblErrorModelo);
            this.gpbAltaMaq.Controls.Add(this.lblErrorMarca);
            this.gpbAltaMaq.Controls.Add(this.txtIdMaq);
            this.gpbAltaMaq.Controls.Add(this.txtTipo);
            this.gpbAltaMaq.Controls.Add(this.txtModelo);
            this.gpbAltaMaq.Controls.Add(this.txtMarca);
            this.gpbAltaMaq.Controls.Add(this.btnCancelar);
            this.gpbAltaMaq.Controls.Add(this.btnAceptar);
            this.gpbAltaMaq.Controls.Add(this.lblModelo);
            this.gpbAltaMaq.Controls.Add(this.lblTipo);
            this.gpbAltaMaq.Controls.Add(this.lblMarca);
            this.gpbAltaMaq.Controls.Add(this.lblTitulo);
            this.gpbAltaMaq.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAltaMaq.Location = new System.Drawing.Point(25, 81);
            this.gpbAltaMaq.Name = "gpbAltaMaq";
            this.gpbAltaMaq.Size = new System.Drawing.Size(559, 567);
            this.gpbAltaMaq.TabIndex = 9;
            this.gpbAltaMaq.TabStop = false;
            // 
            // lblErrorCod
            // 
            this.lblErrorCod.AutoSize = true;
            this.lblErrorCod.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCod.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCod.Location = new System.Drawing.Point(249, 98);
            this.lblErrorCod.Name = "lblErrorCod";
            this.lblErrorCod.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCod.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigo.Location = new System.Drawing.Point(167, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 25);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(253, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(265, 32);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFecha.Location = new System.Drawing.Point(249, 347);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(0, 20);
            this.lblErrorFecha.TabIndex = 24;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(253, 312);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFecha.Size = new System.Drawing.Size(265, 32);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblErrorEstado
            // 
            this.lblErrorEstado.AutoSize = true;
            this.lblErrorEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEstado.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEstado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEstado.Location = new System.Drawing.Point(249, 470);
            this.lblErrorEstado.Name = "lblErrorEstado";
            this.lblErrorEstado.Size = new System.Drawing.Size(0, 20);
            this.lblErrorEstado.TabIndex = 22;
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(249, 407);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblErrorPrecio.TabIndex = 21;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ALQUILADA",
            "RESERVADA",
            "EN REPARACION",
            "DISPONIBLE"});
            this.cmbEstado.Location = new System.Drawing.Point(253, 434);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(265, 33);
            this.cmbEstado.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(253, 372);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(265, 32);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(159, 437);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(81, 375);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(157, 25);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio Vigente";
            // 
            // lblFechaAdq
            // 
            this.lblFechaAdq.AutoSize = true;
            this.lblFechaAdq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaAdq.Location = new System.Drawing.Point(6, 318);
            this.lblFechaAdq.Name = "lblFechaAdq";
            this.lblFechaAdq.Size = new System.Drawing.Size(223, 25);
            this.lblFechaAdq.TabIndex = 16;
            this.lblFechaAdq.Text = "Fecha de Adquisición";
            // 
            // lblErrorTipo
            // 
            this.lblErrorTipo.AutoSize = true;
            this.lblErrorTipo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipo.Location = new System.Drawing.Point(249, 286);
            this.lblErrorTipo.Name = "lblErrorTipo";
            this.lblErrorTipo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTipo.TabIndex = 15;
            // 
            // lblErrorModelo
            // 
            this.lblErrorModelo.AutoSize = true;
            this.lblErrorModelo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorModelo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorModelo.Location = new System.Drawing.Point(249, 222);
            this.lblErrorModelo.Name = "lblErrorModelo";
            this.lblErrorModelo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorModelo.TabIndex = 14;
            // 
            // lblErrorMarca
            // 
            this.lblErrorMarca.AutoSize = true;
            this.lblErrorMarca.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMarca.Location = new System.Drawing.Point(249, 160);
            this.lblErrorMarca.Name = "lblErrorMarca";
            this.lblErrorMarca.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMarca.TabIndex = 13;
            // 
            // txtIdMaq
            // 
            this.txtIdMaq.Location = new System.Drawing.Point(489, 25);
            this.txtIdMaq.Name = "txtIdMaq";
            this.txtIdMaq.Size = new System.Drawing.Size(53, 32);
            this.txtIdMaq.TabIndex = 12;
            this.txtIdMaq.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(253, 251);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(265, 32);
            this.txtTipo.TabIndex = 4;
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(253, 187);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(265, 32);
            this.txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(253, 125);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(265, 32);
            this.txtMarca.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(377, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.Location = new System.Drawing.Point(198, 504);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 43);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblModelo.Location = new System.Drawing.Point(164, 190);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 25);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipo.Location = new System.Drawing.Point(193, 254);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 25);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(175, 128);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(147, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO MAQUINARIA";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Teal;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(25, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 43);
            this.btnVolver.TabIndex = 37;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ABMMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1336, 660);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbBusqueda);
            this.Controls.Add(this.gpbAltaMaq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMMaquinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMMaquinaria";
            this.Load += new System.EventHandler(this.ABMMaquinaria_Load);
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).EndInit();
            this.gpbAltaMaq.ResumeLayout(false);
            this.gpbAltaMaq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.DataGridView dgvMaquinaria;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBusq;
        private System.Windows.Forms.Label lblTitBusq;
        private System.Windows.Forms.GroupBox gpbAltaMaq;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblErrorEstado;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFechaAdq;
        private System.Windows.Forms.Label lblErrorTipo;
        private System.Windows.Forms.Label lblErrorModelo;
        private System.Windows.Forms.Label lblErrorMarca;
        private System.Windows.Forms.TextBox txtIdMaq;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErrorCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnVolver;
    }
}