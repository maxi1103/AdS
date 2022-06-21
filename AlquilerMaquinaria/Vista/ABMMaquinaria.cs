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
    public partial class ABMMaquinaria : Form
    {
        bool selBtnModificar = false;
        bool codModificada = false;
        bool activado = false;
        Label[] error;
        Control[] campos;
        public ABMMaquinaria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validacion de Campos para evitar campos vacios
        /// </summary>
        /// <param name="vacios"></param>
        private void controlCamposVacios(ref bool vacios)
        {
            this.error = new Label[] { lblErrorMarca, lblErrorModelo, lblErrorTipo,lblErrorPrecio,lblErrorEstado,lblErrorCod };
            this.campos = new Control[] { txtMarca, txtModelo, txtTipo, txtPrecio, cmbEstado,txtCodigo };
            ToolsForm.mostrarErrores(this.error, this.campos);
            if (txtMarca.Text.Trim() == "" || txtModelo.Text.Trim() == "" || txtTipo.Text.Trim() == "" || 
                txtPrecio.Text.Trim() == "" || txtCodigo.Text.Trim()=="" || cmbEstado.Text.Trim()=="Seleccionar" )
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
        /// Carga el DGV Maquinaria
        /// </summary>
        private void load_Maquinarias()
        {
            dgvMaquinaria.DataSource = ControladorMaquinaria.list_maquinarias();
            dgvMaquinaria.Columns["maq_id"].Visible = false;
            dgvMaquinaria.Columns["Estado"].Visible = false;
            dgvMaquinaria.ClearSelection();
        }

        private void modificarMaquinaria(Maquinaria oMaquinaria)
        {
            oMaquinaria.Maq_Id = Convert.ToInt32(txtIdMaq .Text);
            ControladorMaquinaria.ABM_maquinaria(oMaquinaria, 2);
            MessageBox.Show("MAQUINARIA MODIFICADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar.Visible = false;
            ToolsForm.limpiarCampos(gpbAltaMaq);
            determinarEnabled(true);
        }

        private bool verificarMaquinaria(Maquinaria oMaquinaria)
        {
            bool verificar = true;
            DataTable maquinariaEncontrada = ControladorMaquinaria.buscar_maquinaria(oMaquinaria, 3);
            if (maquinariaEncontrada.Rows.Count != 0 && maquinariaEncontrada.Rows[0]["maq_id"].ToString() != txtIdMaq.Text)
            {
                MessageBox.Show("La Maquinaria con codigo: " + txtCodigo.Text + ", se encuentra registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificar = false;
            }
            return verificar;
        }

        private void agregarMaquinaria(Maquinaria maquinaria)
        {
            if (verificarMaquinaria(maquinaria) == true)
            {
                ControladorMaquinaria.ABM_maquinaria(maquinaria, 1);
                MessageBox.Show("MAQUINARIA AGREGADA CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToolsForm.limpiarCampos(gpbAltaMaq);
                determinarEnabled(true);
            }
        }

        private Maquinaria crearMaquinaria()
        {
            Maquinaria oMaquinaria = new Maquinaria();
            oMaquinaria.Maq_CodigoMaq = txtCodigo.Text;
            oMaquinaria.Maq_Marca = txtMarca.Text;
            oMaquinaria.Maq_Modelo = txtModelo.Text;
            oMaquinaria.Maq_Tipo = txtTipo.Text;
            oMaquinaria.Maq_PrecioVigente = Convert.ToDecimal( txtPrecio.Text.ToString());
            oMaquinaria.Maq_FechaAdquisicion = dtpFecha.Value;
            
            oMaquinaria.Maq_Estado = cmbEstado.SelectedIndex.ToString();
            return oMaquinaria;
        }
        /// <summary>
        /// Agregar Maquinaria en caso de no estar registrado aun, de otra forma Modificarlo
        /// </summary>
        private void insertarMaquinaria()
        {
            Maquinaria oMaquinaria = crearMaquinaria();
            if (txtIdMaq.Text == "")
                agregarMaquinaria(oMaquinaria);

            else
            {
                if (verificarMaquinaria(oMaquinaria) == true)
                    modificarMaquinaria(oMaquinaria);
            }
        }
        private void codigoRepetido(ref bool codigoRep) {
         
            Maquinaria oMaquinaria = new Maquinaria();
            oMaquinaria.Maq_CodigoMaq = txtCodigo.Text;
            oMaquinaria.Maq_Marca = txtMarca.Text;
            oMaquinaria.Maq_Modelo = txtModelo.Text;
            oMaquinaria.Maq_Tipo = txtTipo.Text;
            
            DataTable dt = ControladorMaquinaria.buscar_maquinaria(oMaquinaria, 3);
            if (dt.Rows.Count != 0)
                codigoRep = true;
        }

        private void controlModificarCodigo(ref bool respuesta)
        {
            if (selBtnModificar == true && codModificada == true)
            {
                DialogResult Result = MessageBox.Show("Realmente desea modificar el Código ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                    respuesta = true;
                else
                    respuesta = false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool camposVacios = false, codigoRep=false, respuesta=false;
            controlCamposVacios(ref camposVacios);
            controlModificarCodigo(ref respuesta);
            if (respuesta == true)
                codigoRepetido(ref codigoRep);
           
            if (codigoRep == false)
            {
                if (camposVacios == false)
                {
                    DialogResult Result = MessageBox.Show("Guardar los campos?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Result == DialogResult.OK)
                        insertarMaquinaria();
                    load_Maquinarias();
                    this.activado = false;
                    dgvMaquinaria.ClearSelection();
                }
            }
            else {
                MessageBox.Show("El codigo ya se encuentra registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text != "Seleccionar")
            {
                int opcion = cmbBusqueda.SelectedIndex;
                Maquinaria oMaquinaria = new Maquinaria();
                oMaquinaria.Maq_CodigoMaq = txtBusqueda.Text.ToUpper().Trim();
                oMaquinaria.Maq_Marca = txtBusqueda.Text.ToUpper().Trim();
                oMaquinaria.Maq_Modelo = txtBusqueda.Text.ToUpper().Trim();
                oMaquinaria.Maq_Tipo = txtBusqueda.Text.ToUpper().Trim();
                if (txtBusqueda.Text != "")
                    dgvMaquinaria.DataSource = ControladorMaquinaria.buscar_maquinaria(oMaquinaria, opcion);
                else
                    load_Maquinarias();
                dgvMaquinaria.ClearSelection();
            }
        }

        private void ABMMaquinaria_Load(object sender, EventArgs e)
        {
            load_Maquinarias();
            ToolsForm.limpiarCampos(gpbAltaMaq);
            dgvMaquinaria.ClearSelection();
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
        /// Eliminar Maquinaria con previa confirmacion
        /// </summary>
        private void eliminarMaquinaria()
        {
            DialogResult Result = MessageBox.Show("Esta seguro que desea eliminar la maquinaria: " + dgvMaquinaria.CurrentRow.Cells["Codigo"].Value.ToString() 
                + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                int eliminar = Convert.ToInt32(dgvMaquinaria.CurrentRow.Cells["maq_id"].Value.ToString());
                Maquinaria oMaq = new Maquinaria();
                oMaq.Maq_Id = eliminar;
                oMaq.Maq_CodigoMaq = dgvMaquinaria.CurrentRow.Cells["Codigo"].Value.ToString();
                oMaq.Maq_Marca = dgvMaquinaria.CurrentRow.Cells["Marca"].Value.ToString();
                oMaq.Maq_Modelo = dgvMaquinaria.CurrentRow.Cells["Modelo"].Value.ToString();
                oMaq.Maq_Tipo = dgvMaquinaria.CurrentRow.Cells["Tipo"].Value.ToString();
                oMaq.Maq_FechaAdquisicion = Convert.ToDateTime(dgvMaquinaria.CurrentRow.Cells["Fecha de Adquisición"].Value.ToString());
                oMaq.Maq_PrecioVigente = Convert.ToDecimal( dgvMaquinaria.CurrentRow.Cells["Precio"].Value.ToString());
                oMaq.Maq_Estado = dgvMaquinaria.CurrentRow.Cells["Estado"].Value.ToString();
                
                ControladorMaquinaria.ABM_maquinaria(oMaq, 3);
                load_Maquinarias();
                MessageBox.Show("MAQUINARIA ELIMINADO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.error != null)
                ToolsForm.borrarErrores(this.error);
            if (this.activado == true)
                eliminarMaquinaria();
            else
            {
                load_Maquinarias();
                this.activado = false;
                dgvMaquinaria.ClearSelection();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.activado == true)
            {
                selBtnModificar = true;
                txtIdMaq.Text = dgvMaquinaria.CurrentRow.Cells["maq_id"].Value.ToString();
                txtCodigo.Text = dgvMaquinaria.CurrentRow.Cells["Codigo"].Value.ToString();
                txtMarca.Text = dgvMaquinaria.CurrentRow.Cells["Marca"].Value.ToString();
                txtModelo.Text = dgvMaquinaria.CurrentRow.Cells["Modelo"].Value.ToString();
                txtTipo.Text = dgvMaquinaria.CurrentRow.Cells["Tipo"].Value.ToString();
                dtpFecha.Text = dgvMaquinaria.CurrentRow.Cells["Fecha de Adquisición"].Value.ToString();
                txtPrecio.Text = dgvMaquinaria.CurrentRow.Cells["Precio"].Value.ToString();
                cmbEstado.SelectedIndex = Convert.ToInt32( dgvMaquinaria.CurrentRow.Cells["Estado"].Value.ToString());
                if (this.error != null)
                    ToolsForm.borrarErrores(this.error);
                btnCancelar.Visible = true;
                determinarEnabled(false);
            }
        }

        private void dgvMaquinaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.activado = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ToolsForm.limpiarCampos(gpbAltaMaq);
            this.activado = false;
            btnCancelar.Visible = false;
            dgvMaquinaria.ClearSelection();
            determinarEnabled(true);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
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
            if (txtMarca.Text.Trim() != "" || txtModelo.Text.Trim() != "" || txtTipo.Text.Trim() != "" ||
                txtPrecio.Text.Trim() != "" || txtCodigo.Text.Trim() != "" || cmbEstado.Text.Trim() != "Seleccionar")
            {
                DialogResult Result;
                Result = MessageBox.Show("Se perderán los datos ingresados. Esta seguro que desea volver?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                    volver();
            }
            else
                volver();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            codModificada = true;
        }

    }
}
