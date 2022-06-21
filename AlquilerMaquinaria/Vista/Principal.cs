using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tsmMaquinaria_Click(object sender, EventArgs e)
        {
            ABMMaquinaria maquinaria = new ABMMaquinaria();
            this.Hide();
            maquinaria.ShowDialog();
            this.Close();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
            ABMCliente cliente = new ABMCliente();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }

        private void tsmAlquiler_Click(object sender, EventArgs e)
        {
            RegistrarAlquiler alquiler = new RegistrarAlquiler();
            this.Hide();
            alquiler.ShowDialog();
            this.Close();
        }

     
    }
}
