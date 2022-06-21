namespace Vista
{
    partial class Principal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmMaquinaria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.msPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.msPrincipal.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMaquinaria,
            this.tsmCliente,
            this.tsmAlquiler});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(15, 30, 0, 4);
            this.msPrincipal.Size = new System.Drawing.Size(226, 346);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmMaquinaria
            // 
            this.tsmMaquinaria.ForeColor = System.Drawing.Color.Black;
            this.tsmMaquinaria.Name = "tsmMaquinaria";
            this.tsmMaquinaria.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tsmMaquinaria.Size = new System.Drawing.Size(211, 44);
            this.tsmMaquinaria.Text = "Gestion Maquinarias";
            this.tsmMaquinaria.Click += new System.EventHandler(this.tsmMaquinaria_Click);
            // 
            // tsmAlquiler
            // 
            this.tsmAlquiler.ForeColor = System.Drawing.Color.Black;
            this.tsmAlquiler.Name = "tsmAlquiler";
            this.tsmAlquiler.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tsmAlquiler.Size = new System.Drawing.Size(181, 44);
            this.tsmAlquiler.Text = "Registrar Alquiler";
            this.tsmAlquiler.Click += new System.EventHandler(this.tsmAlquiler_Click);
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.Location = new System.Drawing.Point(278, 283);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(161, 23);
            this.lblTituloUsuario.TabIndex = 13;
            this.lblTituloUsuario.Text = "Usuario: Juan Perez";
            this.lblTituloUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(351, 73);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(440, 91);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.Text = "Bienvenido";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(417, 134);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            this.lblUser.TabIndex = 7;
            // 
            // tsmCliente
            // 
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(174, 32);
            this.tsmCliente.Text = "Gestion Clientes";
            this.tsmCliente.Click += new System.EventHandler(this.tsmCliente_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(931, 346);
            this.Controls.Add(this.lblTituloUsuario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.msPrincipal);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmMaquinaria;
        private System.Windows.Forms.ToolStripMenuItem tsmAlquiler;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
    }
}