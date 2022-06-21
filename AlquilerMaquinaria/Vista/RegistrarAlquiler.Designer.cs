namespace Vista
{
    partial class RegistrarAlquiler
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBusquedaCli = new System.Windows.Forms.TextBox();
            this.lblBusqCli = new System.Windows.Forms.Label();
            this.lblTitCliente = new System.Windows.Forms.Label();
            this.gpbAltaAlq = new System.Windows.Forms.GroupBox();
            this.lblErrorCont = new System.Windows.Forms.Label();
            this.lblErrorFecAlq = new System.Windows.Forms.Label();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.dtpFechaAlq = new System.Windows.Forms.DateTimePicker();
            this.lblContacto = new System.Windows.Forms.Label();
            this.cmbContactos = new System.Windows.Forms.ComboBox();
            this.lblErrorCli = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.lblErrorFechaDev = new System.Windows.Forms.Label();
            this.dtpFechaDev = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlq = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.lblErrorMaq = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMaq = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMaq = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbMaquinaria = new System.Windows.Forms.GroupBox();
            this.dgvMaquinarias = new System.Windows.Forms.DataGridView();
            this.txtBusquedaMaq = new System.Windows.Forms.TextBox();
            this.lblBusqMaq = new System.Windows.Forms.Label();
            this.lblTitMaquinaria = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbAltaAlq.SuspendLayout();
            this.gpbMaquinaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinarias)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.dgvClientes);
            this.gpbCliente.Controls.Add(this.txtBusquedaCli);
            this.gpbCliente.Controls.Add(this.lblBusqCli);
            this.gpbCliente.Controls.Add(this.lblTitCliente);
            this.gpbCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(763, 362);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(661, 321);
            this.gpbCliente.TabIndex = 12;
            this.gpbCliente.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(20, 96);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(626, 203);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtBusquedaCli
            // 
            this.txtBusquedaCli.Location = new System.Drawing.Point(170, 44);
            this.txtBusquedaCli.Name = "txtBusquedaCli";
            this.txtBusquedaCli.Size = new System.Drawing.Size(476, 32);
            this.txtBusquedaCli.TabIndex = 12;
            this.txtBusquedaCli.TextChanged += new System.EventHandler(this.txtBusquedaCli_TextChanged);
            // 
            // lblBusqCli
            // 
            this.lblBusqCli.AutoSize = true;
            this.lblBusqCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBusqCli.Location = new System.Drawing.Point(16, 51);
            this.lblBusqCli.Name = "lblBusqCli";
            this.lblBusqCli.Size = new System.Drawing.Size(141, 25);
            this.lblBusqCli.TabIndex = 5;
            this.lblBusqCli.Text = "Razón Social";
            // 
            // lblTitCliente
            // 
            this.lblTitCliente.AutoSize = true;
            this.lblTitCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitCliente.Location = new System.Drawing.Point(230, 0);
            this.lblTitCliente.Name = "lblTitCliente";
            this.lblTitCliente.Size = new System.Drawing.Size(243, 25);
            this.lblTitCliente.TabIndex = 0;
            this.lblTitCliente.Text = "LISTADO DE CLIENTES";
            // 
            // gpbAltaAlq
            // 
            this.gpbAltaAlq.Controls.Add(this.lblErrorCont);
            this.gpbAltaAlq.Controls.Add(this.lblErrorFecAlq);
            this.gpbAltaAlq.Controls.Add(this.lblFechaDev);
            this.gpbAltaAlq.Controls.Add(this.dtpFechaAlq);
            this.gpbAltaAlq.Controls.Add(this.lblContacto);
            this.gpbAltaAlq.Controls.Add(this.cmbContactos);
            this.gpbAltaAlq.Controls.Add(this.lblErrorCli);
            this.gpbAltaAlq.Controls.Add(this.lblCli);
            this.gpbAltaAlq.Controls.Add(this.txtCli);
            this.gpbAltaAlq.Controls.Add(this.lblErrorFechaDev);
            this.gpbAltaAlq.Controls.Add(this.dtpFechaDev);
            this.gpbAltaAlq.Controls.Add(this.lblFechaAlq);
            this.gpbAltaAlq.Controls.Add(this.lblErrorPrecio);
            this.gpbAltaAlq.Controls.Add(this.lblErrorMaq);
            this.gpbAltaAlq.Controls.Add(this.txtPrecio);
            this.gpbAltaAlq.Controls.Add(this.txtMaq);
            this.gpbAltaAlq.Controls.Add(this.btnAceptar);
            this.gpbAltaAlq.Controls.Add(this.lblPrecio);
            this.gpbAltaAlq.Controls.Add(this.lblMaq);
            this.gpbAltaAlq.Controls.Add(this.lblTitulo);
            this.gpbAltaAlq.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAltaAlq.Location = new System.Drawing.Point(22, 78);
            this.gpbAltaAlq.Name = "gpbAltaAlq";
            this.gpbAltaAlq.Size = new System.Drawing.Size(1400, 268);
            this.gpbAltaAlq.TabIndex = 11;
            this.gpbAltaAlq.TabStop = false;
            // 
            // lblErrorCont
            // 
            this.lblErrorCont.AutoSize = true;
            this.lblErrorCont.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCont.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCont.Location = new System.Drawing.Point(904, 192);
            this.lblErrorCont.Name = "lblErrorCont";
            this.lblErrorCont.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCont.TabIndex = 35;
            // 
            // lblErrorFecAlq
            // 
            this.lblErrorFecAlq.AutoSize = true;
            this.lblErrorFecAlq.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFecAlq.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFecAlq.Location = new System.Drawing.Point(907, 76);
            this.lblErrorFecAlq.Name = "lblErrorFecAlq";
            this.lblErrorFecAlq.Size = new System.Drawing.Size(0, 20);
            this.lblErrorFecAlq.TabIndex = 34;
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaDev.Location = new System.Drawing.Point(669, 105);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(220, 25);
            this.lblFechaDev.TabIndex = 33;
            this.lblFechaDev.Text = "Fecha de Devolución";
            // 
            // dtpFechaAlq
            // 
            this.dtpFechaAlq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlq.Location = new System.Drawing.Point(911, 41);
            this.dtpFechaAlq.Name = "dtpFechaAlq";
            this.dtpFechaAlq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaAlq.Size = new System.Drawing.Size(280, 32);
            this.dtpFechaAlq.TabIndex = 32;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContacto.Location = new System.Drawing.Point(797, 159);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(101, 25);
            this.lblContacto.TabIndex = 31;
            this.lblContacto.Text = "Contacto";
            // 
            // cmbContactos
            // 
            this.cmbContactos.DropDownWidth = 300;
            this.cmbContactos.FormattingEnabled = true;
            this.cmbContactos.Location = new System.Drawing.Point(908, 157);
            this.cmbContactos.Name = "cmbContactos";
            this.cmbContactos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbContactos.Size = new System.Drawing.Size(283, 33);
            this.cmbContactos.TabIndex = 30;
            this.cmbContactos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbContactos_KeyPress);
            // 
            // lblErrorCli
            // 
            this.lblErrorCli.AutoSize = true;
            this.lblErrorCli.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCli.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCli.Location = new System.Drawing.Point(320, 75);
            this.lblErrorCli.Name = "lblErrorCli";
            this.lblErrorCli.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCli.TabIndex = 27;
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCli.Location = new System.Drawing.Point(219, 43);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(83, 25);
            this.lblCli.TabIndex = 26;
            this.lblCli.Text = "Cliente";
            // 
            // txtCli
            // 
            this.txtCli.Enabled = false;
            this.txtCli.Location = new System.Drawing.Point(320, 40);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(280, 32);
            this.txtCli.TabIndex = 25;
            // 
            // lblErrorFechaDev
            // 
            this.lblErrorFechaDev.AutoSize = true;
            this.lblErrorFechaDev.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFechaDev.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaDev.Location = new System.Drawing.Point(907, 133);
            this.lblErrorFechaDev.Name = "lblErrorFechaDev";
            this.lblErrorFechaDev.Size = new System.Drawing.Size(0, 20);
            this.lblErrorFechaDev.TabIndex = 24;
            // 
            // dtpFechaDev
            // 
            this.dtpFechaDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDev.Location = new System.Drawing.Point(908, 99);
            this.dtpFechaDev.Name = "dtpFechaDev";
            this.dtpFechaDev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDev.Size = new System.Drawing.Size(280, 32);
            this.dtpFechaDev.TabIndex = 23;
            // 
            // lblFechaAlq
            // 
            this.lblFechaAlq.AutoSize = true;
            this.lblFechaAlq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaAlq.Location = new System.Drawing.Point(711, 47);
            this.lblFechaAlq.Name = "lblFechaAlq";
            this.lblFechaAlq.Size = new System.Drawing.Size(187, 25);
            this.lblFechaAlq.TabIndex = 16;
            this.lblFechaAlq.Text = "Fecha de Alquiler";
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(320, 192);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblErrorPrecio.TabIndex = 14;
            // 
            // lblErrorMaq
            // 
            this.lblErrorMaq.AutoSize = true;
            this.lblErrorMaq.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMaq.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMaq.Location = new System.Drawing.Point(320, 134);
            this.lblErrorMaq.Name = "lblErrorMaq";
            this.lblErrorMaq.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMaq.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(320, 157);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(280, 32);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtMaq
            // 
            this.txtMaq.Enabled = false;
            this.txtMaq.Location = new System.Drawing.Point(320, 98);
            this.txtMaq.Name = "txtMaq";
            this.txtMaq.Size = new System.Drawing.Size(280, 32);
            this.txtMaq.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.Location = new System.Drawing.Point(620, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 43);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(129, 160);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(173, 25);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio Acordado";
            // 
            // lblMaq
            // 
            this.lblMaq.AutoSize = true;
            this.lblMaq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaq.Location = new System.Drawing.Point(178, 101);
            this.lblMaq.Name = "lblMaq";
            this.lblMaq.Size = new System.Drawing.Size(124, 25);
            this.lblMaq.TabIndex = 1;
            this.lblMaq.Text = "Maquinaria";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(580, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO ALQUILER";
            // 
            // gpbMaquinaria
            // 
            this.gpbMaquinaria.Controls.Add(this.dgvMaquinarias);
            this.gpbMaquinaria.Controls.Add(this.txtBusquedaMaq);
            this.gpbMaquinaria.Controls.Add(this.lblBusqMaq);
            this.gpbMaquinaria.Controls.Add(this.lblTitMaquinaria);
            this.gpbMaquinaria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMaquinaria.Location = new System.Drawing.Point(22, 362);
            this.gpbMaquinaria.Name = "gpbMaquinaria";
            this.gpbMaquinaria.Size = new System.Drawing.Size(735, 323);
            this.gpbMaquinaria.TabIndex = 15;
            this.gpbMaquinaria.TabStop = false;
            // 
            // dgvMaquinarias
            // 
            this.dgvMaquinarias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMaquinarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinarias.Location = new System.Drawing.Point(18, 98);
            this.dgvMaquinarias.Name = "dgvMaquinarias";
            this.dgvMaquinarias.RowTemplate.Height = 24;
            this.dgvMaquinarias.Size = new System.Drawing.Size(698, 203);
            this.dgvMaquinarias.TabIndex = 14;
            this.dgvMaquinarias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinarias_CellClick);
            // 
            // txtBusquedaMaq
            // 
            this.txtBusquedaMaq.Location = new System.Drawing.Point(239, 46);
            this.txtBusquedaMaq.Name = "txtBusquedaMaq";
            this.txtBusquedaMaq.Size = new System.Drawing.Size(477, 32);
            this.txtBusquedaMaq.TabIndex = 12;
            this.txtBusquedaMaq.TextChanged += new System.EventHandler(this.txtBusquedaMaq_TextChanged);
            // 
            // lblBusqMaq
            // 
            this.lblBusqMaq.AutoSize = true;
            this.lblBusqMaq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBusqMaq.Location = new System.Drawing.Point(22, 49);
            this.lblBusqMaq.Name = "lblBusqMaq";
            this.lblBusqMaq.Size = new System.Drawing.Size(199, 25);
            this.lblBusqMaq.TabIndex = 5;
            this.lblBusqMaq.Text = "Codigo Maquinaria";
            // 
            // lblTitMaquinaria
            // 
            this.lblTitMaquinaria.AutoSize = true;
            this.lblTitMaquinaria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitMaquinaria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitMaquinaria.Location = new System.Drawing.Point(219, 0);
            this.lblTitMaquinaria.Name = "lblTitMaquinaria";
            this.lblTitMaquinaria.Size = new System.Drawing.Size(308, 25);
            this.lblTitMaquinaria.TabIndex = 0;
            this.lblTitMaquinaria.Text = "MAQUINARIAS DISPONIBLES";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Teal;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(22, 29);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 43);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RegistrarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1434, 705);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbMaquinaria);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.gpbAltaAlq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarAlquiler";
            this.Load += new System.EventHandler(this.RegistrarAlquiler_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbAltaAlq.ResumeLayout(false);
            this.gpbAltaAlq.PerformLayout();
            this.gpbMaquinaria.ResumeLayout(false);
            this.gpbMaquinaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBusquedaCli;
        private System.Windows.Forms.Label lblBusqCli;
        private System.Windows.Forms.Label lblTitCliente;
        private System.Windows.Forms.GroupBox gpbAltaAlq;
        private System.Windows.Forms.Label lblErrorCli;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label lblErrorFechaDev;
        private System.Windows.Forms.DateTimePicker dtpFechaDev;
        private System.Windows.Forms.Label lblFechaAlq;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Label lblErrorMaq;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMaq;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMaq;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbMaquinaria;
        private System.Windows.Forms.DataGridView dgvMaquinarias;
        private System.Windows.Forms.TextBox txtBusquedaMaq;
        private System.Windows.Forms.Label lblBusqMaq;
        private System.Windows.Forms.Label lblTitMaquinaria;
        private System.Windows.Forms.ComboBox cmbContactos;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblErrorFecAlq;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.DateTimePicker dtpFechaAlq;
        private System.Windows.Forms.Label lblErrorCont;
        private System.Windows.Forms.Button btnVolver;
    }
}