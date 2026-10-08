using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    public partial class FrmMantSolicitudesSangre : Form
    {
        public FrmMantSolicitudesSangre()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {

            txtidSolicitante.Text = "0";
            txtSolicitante.Clear();
            dtFechaSolicitud.Text = "";
            cboTipoSangre.SelectedIndex = -1;
            txtCantidad.Clear();
            txtProposito.Clear();
            cboPrioridad.SelectedIndex = -1;
            txtMedico.Clear();
            txtMotivo.Clear();
            txtExequatur.Clear();
            dgvMantSolicitudes.DataSource = SolicitudBLL.ObtenerTodas();
        }



        private bool validarDatos()
        {
            bool validacion = true;


            //validar solicitante
            if (string.IsNullOrEmpty(txtSolicitante.Text))
            {
                erpSolicitudes.SetError(txtSolicitante, "El campo Solicitante es obligatorio");
                validacion = false;
            }

            //validar Tipo de sangre
            if (cboTipoSangre.SelectedIndex == -1)
            {
                erpSolicitudes.SetError(cboTipoSangre, "Debes eligir un Tipo de sangre");
                validacion = false;
            }

            //validar cantidad
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                erpSolicitudes.SetError(txtCantidad, "El campo Cantidad es obliigatorio ");
                validacion = false;
            }

            //validar proposito
            if (string.IsNullOrEmpty(txtProposito.Text))
            {
                erpSolicitudes.SetError(txtProposito, "El campo Proposito es obligatorio");
                validacion = false;
            }

            //validar prioridad
            if (cboPrioridad.SelectedIndex == -1)
            {
                erpSolicitudes.SetError(cboPrioridad, "Debe seleccionar la Prioridad");
                validacion = false;
            }

            //validar medico
            if (string.IsNullOrEmpty(txtMedico.Text))
            {
                erpSolicitudes.SetError(txtMedico, "El campo Medico es obligatorio");
                validacion = false;
            }

            //validar motivo
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                erpSolicitudes.SetError(txtMotivo, "El campo Motivo es obligatorio");
                validacion = false;
            }

            return validacion;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SolicitudEntity solicitud = new SolicitudEntity();
                solicitud.ID = Convert.ToInt32(txtidSolicitante.Text);
                solicitud.solicitante = txtSolicitante.Text.Trim();
                solicitud.cantidad = Convert.ToInt32(txtCantidad.Text);
                solicitud.tipoDeSangresolicitada = cboTipoSangre.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un tipo de sangre.");
                solicitud.prioridad = cboPrioridad.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione una prioridad.");
                solicitud.medico = txtMedico.Text.Trim();
                solicitud.motivo = txtMotivo.Text.Trim();
                solicitud.proposito = txtProposito.Text.Trim();
                solicitud.fechaDeSolicitud = dtFechaSolicitud.Value;
                solicitud.estadoSolicitud = txtEstado.Text;
                solicitud.exequatur = txtExequatur.Text.Trim();

                // Validar si ya existe la solicitud antes de crearla
                var solicitudExistente = SolicitudBLL.obtenerID(solicitud.ID);

                if (solicitudExistente == null)
                {
                    SolicitudBLL.Guardar(solicitud);
                    MessageBox.Show("SOLICITUD REGISTRADA CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarControles();
                }
                else
                {
                    MessageBox.Show("Ya existe una solicitud con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        #region Validacion Ingreso Txt Letras y Numeros 
        private void txtSolicitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números o un punto decimal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txtCantidad.Text.Contains("."))
            {
                MessageBox.Show("Solo se permite un punto decimal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtProposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        private void txtMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMantSolicitudes.Rows.Count > 0)
            {
                int IdSolicitud = Convert.ToInt32(dgvMantSolicitudes.SelectedRows[0].Cells["ID"].Value);

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta solicitud?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SolicitudBLL.Borrar(IdSolicitud);

                        InicializarControles();

                        MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvMantSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvMantSolicitudes.Rows[e.RowIndex];

                txtidSolicitante.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                txtSolicitante.Text = filaSeleccionada.Cells["Solicitante"].Value.ToString();
                txtCantidad.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();
                cboTipoSangre.SelectedItem = filaSeleccionada.Cells["TipoDeSangreSolicitada"].Value?.ToString();
                cboPrioridad.SelectedItem = filaSeleccionada.Cells["Prioridad"].Value?.ToString();
                txtMedico.Text = filaSeleccionada.Cells["Medico"].Value.ToString();
                txtMotivo.Text = filaSeleccionada.Cells["Motivo"].Value.ToString();
                txtProposito.Text = filaSeleccionada.Cells["Proposito"].Value.ToString();
                dtFechaSolicitud.Value = Convert.ToDateTime(filaSeleccionada.Cells["FechaDeSolicitud"].Value);
                txtExequatur.Text = filaSeleccionada.Cells["exequatur"].Value.ToString();
            }

        }

        #region Permitir Letras y numero
        private void txtSolicitante_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtProposito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMedico_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExequatur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMotivo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
