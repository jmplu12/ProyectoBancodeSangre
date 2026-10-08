using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
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

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmSolicitudesDeSangre : Form
    {
        public FrmSolicitudesDeSangre()
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

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIO.", "EXITO.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SolicitudEntity solicitud = new SolicitudEntity();
                solicitud.ID = Convert.ToInt32(txtidSolicitante.Text);
                solicitud.solicitante = txtSolicitante.Text;
                solicitud.cantidad = Convert.ToInt32(txtCantidad.Text);
                solicitud.tipoDeSangresolicitada = cboTipoSangre.SelectedItem.ToString();
                solicitud.prioridad = cboPrioridad.SelectedItem.ToString();
                solicitud.medico = txtMedico.Text;
                solicitud.motivo = txtMotivo.Text;
                solicitud.proposito = txtProposito.Text;
                solicitud.fechaDeSolicitud = dtFechaSolicitud.Value;
                solicitud.estadoSolicitud = "Pendiente";

                SolicitudBLL.Guardar(solicitud);
                MessageBox.Show("DATOS REGISTRADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvSolicitud.DataSource = new List<SolicitudEntity> { solicitud }; 

                InicializarControles();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Solicitud Agregada", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSolicitudesDeSangre_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

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
    }
}
