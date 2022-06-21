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
    public partial class RegistrarAlquiler : Form
    {
       
        Label[] error;
        Control[] campos;
        public RegistrarAlquiler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que controla si las fechas de Alquiler están registradas correctamente
        /// </summary>
        /// <param name="fechaValida">devuelve false si no estan correctas las fechas</param>
        private void controlFechas(ref bool fechaValida)
        {
            this.error = new Label[] { lblErrorCli, lblErrorMaq, lblErrorPrecio, lblErrorCont };
            this.campos = new Control[] { txtCli, txtMaq, txtPrecio, cmbContactos };
            ToolsForm.mostrarErrores(error, campos, lblErrorFechaDev, dtpFechaAlq.Value, dtpFechaDev.Value);
            if (dtpFechaDev.Value <= dtpFechaAlq.Value)
            {
                ToolsForm.mostrarErrores(error, campos, lblErrorFechaDev, dtpFechaAlq.Value, dtpFechaDev.Value);
                MessageBox.Show("No puede tener Fecha Final menor o igual a Fecha Inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fechaValida = false;
            }
        }

        /// <summary>
        /// Validacion de Campos para evitar campos vacios
        /// </summary>
        /// <param name="vacios"></param>
        private void controlCamposVacios(ref bool vacios)
        {
            this.error = new Label[] { lblErrorCli, lblErrorMaq, lblErrorPrecio,lblErrorCont };
            this.campos = new Control[] { txtCli, txtMaq,txtPrecio, cmbContactos};
            ToolsForm.mostrarErrores(this.error, this.campos);
            if (txtCli.Text.Trim() == "" || txtMaq.Text.Trim() == "" || txtPrecio.Text.Trim() == ""
                || cmbContactos.Text.Trim() == "Seleccionar" || cmbContactos.Text.Trim() == "")
            {
                MessageBox.Show("No puede tener campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vacios = true;
            }
        }

        /// <summary>
        /// Carga el DGV Maquinaria
        /// </summary>
        private void load_Maquinarias()
        {
            dgvMaquinarias.DataSource = ControladorMaquinaria.list_maquinariasDisponibles();
            dgvMaquinarias.Columns["maq_id"].Visible = false;
            dgvMaquinarias.Columns["Estado"].Visible = false;
            dgvMaquinarias.ClearSelection();
        }

        /// <summary>
        /// Carga el DGV Clientes
        /// </summary>
        private void load_Clientes()
        {
            dgvClientes.DataSource = ControladorCliente.list_clientes();
            dgvClientes.Columns["cli_id"].Visible = false;
            dgvClientes.ClearSelection();
        }

        private void RegistrarAlquiler_Load(object sender, EventArgs e)
        {
            this.load_Clientes();
            this.load_Maquinarias();
            validarFechas();
        }

        private string generarCodigo() {
            string dia = Convert.ToString(DateTime.Now.Day);
            string mes = Convert.ToString(DateTime.Now.Month);
            string año = Convert.ToString(DateTime.Now.Year);
            string hora = Convert.ToString(DateTime.Now.Hour);
            string min = Convert.ToString(DateTime.Now.Minute);
            string seg = Convert.ToString(DateTime.Now.Second);
            string fechaActual = año + mes + dia + hora + min + seg;
            string codigo = "ALQ-" + dgvMaquinarias.CurrentRow.Cells["Codigo"].Value.ToString()+fechaActual;
            return codigo;
        }
        private Alquiler crearAlquiler()
        {
            //DateTime fechaActual = DateTime.Now;
            Alquiler oAlquiler = new Alquiler();
            oAlquiler.Alq_Codigo = generarCodigo(); ;
            oAlquiler.Alq_FechaAlq = dtpFechaAlq.Value;
            oAlquiler.Alq_FechaDev = dtpFechaDev.Value;
            oAlquiler.Alq_Precio = Convert.ToDecimal( txtPrecio.Text.ToString());
            oAlquiler.Maq_Id = Convert.ToInt32( dgvMaquinarias.CurrentRow.Cells["maq_id"].Value.ToString());
            oAlquiler.Cli_Id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["cli_id"].Value.ToString());
            return oAlquiler;
        }

        private void cambiarEstadoMaquinaria() {
            Maquinaria maquinaria = obtenerMaquinaria();
            maquinaria.Maq_Estado = "0";
            ControladorMaquinaria.ABM_maquinaria(maquinaria,2);
        }
        private void registrarAlquiler() {
            Alquiler alquier = crearAlquiler();
            ControladorAlquiler.registrar_alquiler(alquier);
            cambiarEstadoMaquinaria();
            MessageBox.Show("ALQUILER REGISTRADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool camposVacios = false, fechaValida = true;
            controlCamposVacios(ref camposVacios);
            controlFechas(ref fechaValida);
            if (txtPrecio.Text.ToString().Length <= 28)
            {
                if (camposVacios == false && (fechaValida == true))
                {
                    DialogResult Result = MessageBox.Show("Guardar registro de Alquiler?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Result == DialogResult.OK)
                    {
                        registrarAlquiler();
                        Maquinaria maquinaria = obtenerMaquinaria();
                        Cliente cliente = obtenerCliente();
                        Alquiler alquiler = crearAlquiler();
                        Contacto contacto = obtenerContacto();
                        ToolsForm.exportar_dgv_como_pdf(alquiler, maquinaria, cliente, contacto);
                    }

                }
            }
            else {
                MessageBox.Show("Campo Precio se permite maximo 28 digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime fechaActual = DateTime.Now;
            //MessageBox.Show("Entro");
            //Alquiler oAlquiler = new Alquiler();
            //oAlquiler.Alq_FechaAlq = dtpFechaAlq.Value;
            //oAlquiler.Alq_FechaDev = dtpFechaDev.Value;
            //oAlquiler.Maq_Id = Convert.ToInt32(dgvMaquinarias.CurrentRow.Cells["maq_id"].Value.ToString());
            //DataTable dt = ControladorAlquiler.buscar_alquiler(oAlquiler);
            //if (dt.Rows.Count != 0) {
            //    MessageBox.Show("No se puede alquilar en la fecha deseada");
            //}
        }

        private void txtBusquedaCli_TextChanged(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_RazonSocial = txtBusquedaCli.Text.ToUpper().Trim();
            oCliente.Cli_Direccion = txtBusquedaCli.Text.ToUpper().Trim();
            if (txtBusquedaCli.Text != "")
                dgvClientes.DataSource = ControladorCliente.buscar_cliente(oCliente, 0);
            else
                load_Clientes();
            dgvClientes.ClearSelection();

        }
        
        private void txtBusquedaMaq_TextChanged(object sender, EventArgs e)
        {
            Maquinaria oMaquinaria = new Maquinaria();
            oMaquinaria.Maq_CodigoMaq = txtBusquedaMaq.Text.ToUpper().Trim();
            oMaquinaria.Maq_Marca = txtBusquedaMaq.Text.ToUpper().Trim();
            oMaquinaria.Maq_Modelo = txtBusquedaMaq.Text.ToUpper().Trim();
            oMaquinaria.Maq_Tipo = txtBusquedaMaq.Text.ToUpper().Trim();
            if (txtBusquedaMaq.Text != "")
                dgvMaquinarias.DataSource = ControladorMaquinaria.buscar_maquinaria(oMaquinaria, 3);
            else
                load_Maquinarias();
            dgvMaquinarias.ClearSelection();
        }

        private Maquinaria obtenerMaquinaria()
        {
            Maquinaria oMaquinaria = new Maquinaria();
            oMaquinaria.Maq_Id = Convert.ToInt32( dgvMaquinarias.CurrentRow.Cells["maq_id"].Value.ToString());
            oMaquinaria.Maq_CodigoMaq = dgvMaquinarias.CurrentRow.Cells["Codigo"].Value.ToString();
            oMaquinaria.Maq_Marca = dgvMaquinarias.CurrentRow.Cells["Marca"].Value.ToString();
            oMaquinaria.Maq_Modelo = dgvMaquinarias.CurrentRow.Cells["Modelo"].Value.ToString();
            oMaquinaria.Maq_Tipo = dgvMaquinarias.CurrentRow.Cells["Tipo"].Value.ToString();
            oMaquinaria.Maq_FechaAdquisicion = Convert.ToDateTime(dgvMaquinarias.CurrentRow.Cells["Fecha de Adquisición"].Value.ToString());
            oMaquinaria.Maq_PrecioVigente = Convert.ToDecimal(dgvMaquinarias.CurrentRow.Cells["Precio"].Value.ToString());
            return oMaquinaria;
        }

        private Cliente obtenerCliente() 
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_RazonSocial = dgvClientes.CurrentRow.Cells["Razon Social"].Value.ToString();
            oCliente.Cli_Direccion = dgvClientes.CurrentRow.Cells["Dirección"].Value.ToString();
            oCliente.Cli_CodigoPostal =Convert.ToInt32( dgvClientes.CurrentRow.Cells["Codigo Postal"].Value.ToString());
            return oCliente;
        }

        private Contacto obtenerContacto() {
            int idContacto =Convert.ToInt32( cmbContactos.SelectedValue.ToString());
            DataTable dtContacto = ControladorContacto.buscar_contacto(idContacto,1);
            Contacto oContacto = new Contacto();
            oContacto.Cont_Id =Convert.ToInt32( dtContacto.Rows[0]["cont_id"].ToString());
            oContacto.Cont_NroDocumento = dtContacto.Rows[0]["Nro Documento"].ToString();
            oContacto.Cont_Apellido = dtContacto.Rows[0]["Apellidos"].ToString();
            oContacto.Cont_Nombre = dtContacto.Rows[0]["Nombres"].ToString();
            return oContacto;
        }

        private void validarFechas() {
            dtpFechaAlq.ResetText();
            dtpFechaAlq.MinDate = DateTime.Now;
            dtpFechaDev.ResetText();
            dtpFechaDev.MinDate = DateTime.Now;
        }
        private void dgvMaquinarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaq.Text = "COD: " + dgvMaquinarias.CurrentRow.Cells["Codigo"].Value.ToString() + " - MARCA: " + dgvMaquinarias.CurrentRow.Cells["Marca"].Value.ToString();
            //txtPrecio.Text = dgvMaquinarias.CurrentRow.Cells["Precio"].Value.ToString();
       
            //if (dgvMaquinarias.CurrentRow.Cells["Estado"].Value.ToString() == "0" ||
            //    dgvMaquinarias.CurrentRow.Cells["Estado"].Value.ToString() == "1")
            //{

            //    int idMaq = (int)dgvMaquinarias.CurrentRow.Cells["maq_id"].Value;
            //    DataTable alquilerEncontrado = ControladorAlquiler.buscar_alquiler(idMaq);
            //    DateTime fechafinal = new DateTime();
            //    fechafinal = DateTime.Now;
            //    for (int i = 0; i < alquilerEncontrado.Rows.Count; i++)
            //    {
            //        if (Convert.ToDateTime(alquilerEncontrado.Rows[i]["alq_fechaDev"]) > fechafinal)
            //            fechafinal = Convert.ToDateTime(alquilerEncontrado.Rows[i]["alq_fechaDev"]);
            //    }
            //        dtpFechaAlq.MinDate = fechafinal.AddDays(1);
            //        dtpFechaAlq.Value = fechafinal.AddDays(1);
            //        dtpFechaDev.MinDate = fechafinal.AddDays(1);
            //        dtpFechaDev.Value = fechafinal.AddDays(1);
            //}
            //else
            //{
                validarFechas();
            //}
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["cli_id"].Value.ToString());

            txtCli.Text = dgvClientes.CurrentRow.Cells["Razon Social"].Value.ToString();
            cmbContactos.DisplayMember = "datos";
            cmbContactos.ValueMember = "cont_id";
            cmbContactos.DataSource = ControladorContacto.buscar_contacto(idCliente, 0);
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
            if(txtCli.Text.Trim() != "" || txtMaq.Text.Trim() != "" || txtPrecio.Text.Trim() != ""
                || cmbContactos.Text.Trim() != "" ){
                DialogResult Result;
                Result = MessageBox.Show("Se perderán los datos ingresados. Esta seguro que desea volver?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                    volver();
            }
            else
                volver();
        }

        private void cmbContactos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
