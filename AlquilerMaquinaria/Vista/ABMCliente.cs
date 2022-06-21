using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using Util;
namespace Vista
{
    public partial class ABMCliente : Form
    {
        bool selBtnModificar = false;
        bool rznModificada = false;
        bool activado = false;
        Label[] error;
        Control[] campos;
        public ABMCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validacion de Campos para evitar campos vacios
        /// </summary>
        /// <param name="vacios"></param>
        private void controlCamposVacios(ref bool vacios)
        {
            this.error = new Label[] { lblErrorRznSocial, lblErrorDireccion, lblErrorCod };
            this.campos = new Control[] { txtRazonSocial, txtDireccion, txtCdPostal };
            ToolsForm.mostrarErrores(this.error, this.campos);
            if (txtRazonSocial.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtCdPostal.Text.Trim() == "")
            {
                MessageBox.Show("No puede tener campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vacios = true;
            }
        }

        /// <summary>
        /// Metodo para acticar o desactivar los botones segun la necesidad
        /// </summary>
        /// <param name="visible"></param>
        private void determinarEnabled(bool visible)
        {
            btnEliminar.Enabled = visible;
            btnModificar.Enabled = visible;
            txtBusqueda.Enabled = visible;
        }

        /// <summary>
        /// Carga el DGV Cliente
        /// </summary>
        private void load_Clientes()
        {
            dgvCliente.DataSource = ControladorCliente.list_clientes();
            dgvCliente.Columns["cli_id"].Visible = false;
            dgvCliente.ClearSelection();
        }

        private void modificarCliente(Cliente oCliente) {
            oCliente.Cli_Id = Convert.ToInt32(txtIdCliente.Text);
            ControladorCliente.ABM_cliente(oCliente, 2);
            MessageBox.Show("CLIENTE MODIFICADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar.Visible = false;
            ToolsForm.limpiarCampos(gpbAltaCliente);
            determinarEnabled(true);
            selBtnModificar = false;
            rznModificada = false;
        }
        private bool verificarCliente(Cliente oCliente) {
            bool verificar = true;
            DataTable clienteEncontrado = ControladorCliente.buscar_cliente(oCliente, 0);
            if (clienteEncontrado.Rows.Count != 0 && clienteEncontrado.Rows[0]["cli_id"].ToString() != txtIdCliente.Text)
            {
                MessageBox.Show("El cliente: " + txtRazonSocial.Text + ", se encuentra registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificar = false;
            }
            return verificar;
        }

        private void agregarNuevoCliente(Cliente cliente){
            if (verificarCliente(cliente) == true)
            {
                ControladorCliente.ABM_cliente(cliente,1);
                MessageBox.Show("CLIENTE AGREGADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToolsForm.limpiarCampos(gpbAltaCliente);
                determinarEnabled(true);
            }
        }

        private Cliente crearCliente() {
            Cliente oCliente = new Cliente();
            oCliente.Cli_RazonSocial = txtRazonSocial.Text;
            oCliente.Cli_Direccion = txtDireccion.Text;
            oCliente.Cli_CodigoPostal =Convert.ToInt32(txtCdPostal.Text.ToString());
            oCliente.Cli_FechaAlta = DateTime.Now;
            return oCliente;
        }
        /// <summary>
        /// Agregar Cliente en caso de no estar registrado aun, de otra forma Modificarlo
        /// </summary>
        private void insertarCliente()
        {
            Cliente oCliente = crearCliente();
            if (txtIdCliente.Text == "")
                agregarNuevoCliente(oCliente);
            else
            {
                if (verificarCliente(oCliente) == true)
                    modificarCliente(oCliente);
            }
        }

        private void razonSocialRepetida(ref bool razonSocial){
            Cliente oCli = new Cliente();
                oCli.Cli_RazonSocial = txtRazonSocial.Text.ToString();
                oCli.Cli_CodigoPostal =Convert.ToInt32( txtCdPostal.Text.ToString());
                oCli.Cli_Direccion = txtDireccion.Text.ToString();
            DataTable dt = ControladorCliente.buscar_cliente(oCli,0);
            if (dt.Rows.Count != 0)
                razonSocial = true;
        }

        private void controlModificarRazonSocial(ref bool respuesta){
            if (selBtnModificar==true && rznModificada==true){
                DialogResult Result = MessageBox.Show("Realmente desea modificar la razon Social ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                    respuesta = true;
                else
                    respuesta = false;
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool camposVacios = false, rznSocialrepetida=false,respuesta=false;
            controlCamposVacios(ref camposVacios);
            controlModificarRazonSocial(ref respuesta);
            if (respuesta==true)
                razonSocialRepetida(ref rznSocialrepetida);
            if (txtCdPostal.Text.ToString().Length <= 10)
            {
                if (rznSocialrepetida == false)
                {
                    if (camposVacios == false)
                    {
                        DialogResult Result = MessageBox.Show("Guardar los campos?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Result == DialogResult.OK)
                            insertarCliente();
                        load_Clientes();
                        this.activado = false;
                        dgvCliente.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("La Razon Social ya se encuentra registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else {
                MessageBox.Show("Codigo Postal se permite maximo 10 digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text != "Seleccionar")
            {
                int opcion = cmbBusqueda.SelectedIndex;
                Cliente oCliente = new Cliente();
                oCliente.Cli_RazonSocial = txtBusqueda.Text;
                oCliente.Cli_Direccion = txtBusqueda.Text.ToUpper().Trim();
                if (txtBusqueda.Text != "")
                    dgvCliente.DataSource = ControladorCliente.buscar_cliente(oCliente, opcion);
                else
                    load_Clientes();
                dgvCliente.ClearSelection();
            }
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            load_Clientes();
            ToolsForm.limpiarCampos(gpbAltaCliente);
            dgvCliente.ClearSelection();
        }

        private void cmbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        /// <summary>
        /// Eliminar Cliente con previa confirmacion
        /// </summary>
        private void eliminarCliente()
        {
            DialogResult Result = MessageBox.Show("Esta seguro que desea eliminar el cliente: " + dgvCliente.CurrentRow.Cells["Razon Social"].Value.ToString() + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                int eliminar = Convert.ToInt32(dgvCliente.CurrentRow.Cells["cli_id"].Value.ToString());
                Cliente oCli = new Cliente();
                oCli.Cli_Id = eliminar;
                oCli.Cli_RazonSocial = dgvCliente.CurrentRow.Cells["Razon Social"].Value.ToString();
                oCli.Cli_CodigoPostal =Convert.ToInt32( dgvCliente.CurrentRow.Cells["Codigo Postal"].Value.ToString());
                oCli.Cli_Direccion = dgvCliente.CurrentRow.Cells["Dirección"].Value.ToString();
                oCli.Cli_FechaAlta =Convert.ToDateTime( dgvCliente.CurrentRow.Cells["Fecha de Alta"].Value.ToString());
                ControladorCliente.ABM_cliente(oCli,3);
                load_Clientes();
                MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCliente.ClearSelection();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.error != null)
                ToolsForm.borrarErrores(this.error);
            if (this.activado == true)
                eliminarCliente();
            else
            {
                load_Clientes();
                this.activado = false;
                dgvCliente.ClearSelection();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.activado == true)
            {
                selBtnModificar = true;
                txtIdCliente.Text = dgvCliente.CurrentRow.Cells["cli_id"].Value.ToString();
                txtRazonSocial.Text = dgvCliente.CurrentRow.Cells["Razon Social"].Value.ToString();
                txtDireccion.Text = dgvCliente.CurrentRow.Cells["Dirección"].Value.ToString();
                txtCdPostal.Text = dgvCliente.CurrentRow.Cells["Codigo Postal"].Value.ToString();
                if (this.error != null)
                    ToolsForm.borrarErrores(this.error);
                btnCancelar.Visible = true;
                determinarEnabled(false);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.activado = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToolsForm.limpiarCampos(gpbAltaCliente);
            this.activado = false;
            btnCancelar.Visible = false;
            dgvCliente.ClearSelection();
            determinarEnabled(true);
        }

        private void txtCdPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
           
        }

        private void volver()
        {
            Principal p = new Principal();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Trim() != "" || txtDireccion.Text.Trim() != "" || txtCdPostal.Text.Trim() != "")
            {
                DialogResult Result;
                Result = MessageBox.Show("Se perderán los datos ingresados. Esta seguro que desea volver?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                    volver();
            }
            else
                volver();
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            rznModificada = true;
        }
    }
}
