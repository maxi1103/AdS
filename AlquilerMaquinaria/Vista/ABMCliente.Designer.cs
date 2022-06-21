namespace Vista
{
    partial class ABMCliente
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
            this.gpbAltaCliente = new System.Windows.Forms.GroupBox();
            this.lblErrorCod = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorRznSocial = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCdPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblRznSocial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusq = new System.Windows.Forms.Label();
            this.lblTitBusq = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbAltaCliente.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAltaCliente
            // 
            this.gpbAltaCliente.Controls.Add(this.lblErrorCod);
            this.gpbAltaCliente.Controls.Add(this.lblErrorDireccion);
            this.gpbAltaCliente.Controls.Add(this.lblErrorRznSocial);
            this.gpbAltaCliente.Controls.Add(this.txtIdCliente);
            this.gpbAltaCliente.Controls.Add(this.txtCdPostal);
            this.gpbAltaCliente.Controls.Add(this.txtDireccion);
            this.gpbAltaCliente.Controls.Add(this.txtRazonSocial);
            this.gpbAltaCliente.Controls.Add(this.btnCancelar);
            this.gpbAltaCliente.Controls.Add(this.btnAceptar);
            this.gpbAltaCliente.Controls.Add(this.lblDireccion);
            this.gpbAltaCliente.Controls.Add(this.lblCodigoPostal);
            this.gpbAltaCliente.Controls.Add(this.lblRznSocial);
            this.gpbAltaCliente.Controls.Add(this.lblTitulo);
            this.gpbAltaCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAltaCliente.Location = new System.Drawing.Point(21, 80);
            this.gpbAltaCliente.Name = "gpbAltaCliente";
            this.gpbAltaCliente.Size = new System.Drawing.Size(559, 409);
            this.gpbAltaCliente.TabIndex = 0;
            this.gpbAltaCliente.TabStop = false;
            // 
            // lblErrorCod
            // 
            this.lblErrorCod.AutoSize = true;
            this.lblErrorCod.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCod.Location = new System.Drawing.Point(219, 282);
            this.lblErrorCod.Name = "lblErrorCod";
            this.lblErrorCod.Size = new System.Drawing.Size(0, 25);
            this.lblErrorCod.TabIndex = 15;
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDireccion.Location = new System.Drawing.Point(219, 217);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(0, 25);
            this.lblErrorDireccion.TabIndex = 14;
            // 
            // lblErrorRznSocial
            // 
            this.lblErrorRznSocial.AutoSize = true;
            this.lblErrorRznSocial.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRznSocial.Location = new System.Drawing.Point(219, 151);
            this.lblErrorRznSocial.Name = "lblErrorRznSocial";
            this.lblErrorRznSocial.Size = new System.Drawing.Size(0, 25);
            this.lblErrorRznSocial.TabIndex = 13;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(479, 25);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(53, 32);
            this.txtIdCliente.TabIndex = 12;
            this.txtIdCliente.Visible = false;
            // 
            // txtCdPostal
            // 
            this.txtCdPostal.Location = new System.Drawing.Point(224, 245);
            this.txtCdPostal.Name = "txtCdPostal";
            this.txtCdPostal.Size = new System.Drawing.Size(265, 32);
            this.txtCdPostal.TabIndex = 3;
            this.txtCdPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCdPostal_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(224, 180);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(265, 32);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(224, 116);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(265, 32);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(391, 338);
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
            this.btnAceptar.Location = new System.Drawing.Point(214, 338);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 43);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Location = new System.Drawing.Point(30, 183);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 25);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigoPostal.Location = new System.Drawing.Point(30, 248);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(147, 25);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // lblRznSocial
            // 
            this.lblRznSocial.AutoSize = true;
            this.lblRznSocial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRznSocial.Location = new System.Drawing.Point(30, 119);
            this.lblRznSocial.Name = "lblRznSocial";
            this.lblRznSocial.Size = new System.Drawing.Size(141, 25);
            this.lblRznSocial.TabIndex = 1;
            this.lblRznSocial.Text = "Razón Social";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(177, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO CLIENTE";
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.dgvCliente);
            this.gpbBusqueda.Controls.Add(this.cmbBusqueda);
            this.gpbBusqueda.Controls.Add(this.txtBusqueda);
            this.gpbBusqueda.Controls.Add(this.btnModificar);
            this.gpbBusqueda.Controls.Add(this.btnEliminar);
            this.gpbBusqueda.Controls.Add(this.lblBusq);
            this.gpbBusqueda.Controls.Add(this.lblTitBusq);
            this.gpbBusqueda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusqueda.Location = new System.Drawing.Point(596, 80);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(655, 409);
            this.gpbBusqueda.TabIndex = 8;
            this.gpbBusqueda.TabStop = false;
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(26, 94);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(603, 221);
            this.dgvCliente.TabIndex = 14;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Razon Social",
            "Direccion"});
            this.cmbBusqueda.Location = new System.Drawing.Point(152, 44);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(206, 33);
            this.cmbBusqueda.TabIndex = 13;
            this.cmbBusqueda.Text = "Seleccionar";
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            this.cmbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBusqueda_KeyPress);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(364, 44);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(265, 32);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.Location = new System.Drawing.Point(474, 338);
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
            this.btnEliminar.Location = new System.Drawing.Point(305, 338);
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
            this.lblBusq.Location = new System.Drawing.Point(21, 47);
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
            this.lblTitBusq.Location = new System.Drawing.Point(268, 0);
            this.lblTitBusq.Name = "lblTitBusq";
            this.lblTitBusq.Size = new System.Drawing.Size(128, 25);
            this.lblTitBusq.TabIndex = 0;
            this.lblTitBusq.Text = "BUSQUEDA";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Teal;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(21, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 43);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1273, 509);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbBusqueda);
            this.Controls.Add(this.gpbAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMCliente";
            this.Load += new System.EventHandler(this.ABMCliente_Load);
            this.gpbAltaCliente.ResumeLayout(false);
            this.gpbAltaCliente.PerformLayout();
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAltaCliente;
        private System.Windows.Forms.TextBox txtCdPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblRznSocial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBusq;
        private System.Windows.Forms.Label lblTitBusq;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblErrorCod;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.Label lblErrorRznSocial;
        private System.Windows.Forms.Button btnVolver;
    }
}