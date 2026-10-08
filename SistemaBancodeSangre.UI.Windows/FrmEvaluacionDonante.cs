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

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmEvaluacionDonante : Form
    {
        private int donanteID = 0;
        private int empleadoID = 0;

        public FrmEvaluacionDonante(int empleadoId)
        {
            InitializeComponent();

            empleadoID = empleadoId;
        }

        #region Load

        private void FrmEvaluacionDonante_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        #endregion

        #region Inicializar Controles

        private void InicializarControles()
        {
            dtpFechaEvaluacion.Value = DateTime.Today;

            txtEmpleado.Text = empleadoID.ToString();
            txtEmpleado.ReadOnly = true;

            txtNombre.Clear();
            txtNombre.ReadOnly = true;

            nudPeso.Minimum = 0;
            nudPeso.Maximum = 300;
            nudPeso.DecimalPlaces = 2;
            nudPeso.Increment = 0.10M;
            nudPeso.Value = 0;

            nudTemperatura.Minimum = 30;
            nudTemperatura.Maximum = 45;
            nudTemperatura.DecimalPlaces = 1;
            nudTemperatura.Increment = 0.1M;
            nudTemperatura.Value = 37;

            txtPresionArterial.Clear();

            chkTieneEnfermedad.Checked = false;
            chkTomaMedicamentos.Checked = false;
            chkTieneSintomas.Checked = false;
            chkHaTenidoCirugia.Checked = false;
            chkHaDonadoAnteriormente.Checked = false;

            txtObservaciones.Clear();

            cboResultado.Items.Clear();

            cboResultado.Items.Add("APTO");
            cboResultado.Items.Add("NO APTO");
            cboResultado.Items.Add("PENDIENTE");

            cboResultado.SelectedIndex = 2;

            cboEstado.Items.Clear();

            cboEstado.Items.Add("ACTIVA");
            cboEstado.Items.Add("FINALIZADA");

            cboEstado.SelectedIndex = 0;

            cboResultado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion


        private void LimpiarFormulario()
        {
            donanteID = 0;

            txtIDDonante.Clear();

            txtNombre.Clear();

            dtpFechaEvaluacion.Value =
                DateTime.Today;

            nudPeso.Value = 0;

            txtPresionArterial.Clear();

            nudTemperatura.Value = 37;

            chkTieneEnfermedad.Checked = false;

            chkTomaMedicamentos.Checked = false;

            chkTieneSintomas.Checked = false;

            chkHaTenidoCirugia.Checked = false;

            chkHaDonadoAnteriormente.Checked = false;

            txtObservaciones.Clear();

            cboResultado.SelectedIndex = 2;

            cboEstado.SelectedIndex = 0;
        }
        #region Obtener Datos

        private EvaluacionDonanteEntity ObtenerDatosFormulario()
        {
            EvaluacionDonanteEntity evaluacion =
                new EvaluacionDonanteEntity();

            evaluacion.DonanteID = donanteID;

            evaluacion.EmpleadoID = empleadoID;

            evaluacion.FechaEvaluacion =
                dtpFechaEvaluacion.Value;

            evaluacion.Peso =
                nudPeso.Value;

            evaluacion.PresionArterial =
                txtPresionArterial.Text.Trim();

            evaluacion.Temperatura =
                nudTemperatura.Value;

            evaluacion.TieneEnfermedad =
                chkTieneEnfermedad.Checked;

            evaluacion.TomaMedicamentos =
                chkTomaMedicamentos.Checked;

            evaluacion.TieneSintomas =
                chkTieneSintomas.Checked;

            evaluacion.HaTenidoCirugia =
                chkHaTenidoCirugia.Checked;

            evaluacion.HaDonadoAnteriormente =
                chkHaDonadoAnteriormente.Checked;

            evaluacion.Observaciones =
                txtObservaciones.Text.Trim();

            evaluacion.Resultado =
                cboResultado.SelectedItem?.ToString();

            evaluacion.Estado =
                cboEstado.SelectedItem?.ToString();

            return evaluacion;
        }

        #endregion

        #region Validar Formulario

        private bool ValidarFormulario()
        {
            if (donanteID <= 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un donante.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                btnSeleccionarDonante.Focus();

                return false;
            }

            if (empleadoID <= 0)
            {
                MessageBox.Show(
                    "No se ha identificado el empleado que realiza la evaluación.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (nudPeso.Value <= 0)
            {
                MessageBox.Show(
                    "Debe introducir el peso del donante.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudPeso.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPresionArterial.Text))
            {
                MessageBox.Show(
                    "Debe introducir la presión arterial.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPresionArterial.Focus();

                return false;
            }

            if (nudTemperatura.Value <= 0)
            {
                MessageBox.Show(
                    "Debe introducir la temperatura del donante.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudTemperatura.Focus();

                return false;
            }

            if (cboResultado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el resultado de la evaluación.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboResultado.Focus();

                return false;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar el estado de la evaluación.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboEstado.Focus();

                return false;
            }

            return true;
        }

        #endregion




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSeleccionarDonante_Click_1(object sender, EventArgs e)
        {
            using (FrmListadoDeDonantes frm =
        new FrmListadoDeDonantes(true))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DonantesEntity donante =
                        DonanteBLL.ObtenerDonantePorId(frm.IdDonante);

                    if (donante != null)
                    {
                        // Guardar el ID en la variable
                        donanteID = donante.ID;

                        // Mostrar ID
                        txtIDDonante.Text =
                            donante.ID.ToString();

                        // Mostrar nombre y apellido
                        txtNombre.Text =
                            donante.Nombre + " " +
                            donante.Apellido;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                EvaluacionDonanteEntity evaluacion =
                    ObtenerDatosFormulario();

                EvaluacionDonanteBLL.Guardar(evaluacion);

                MessageBox.Show(
                    "La evaluación del donante se guardó correctamente.",
                    "Evaluación del Donante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar la evaluación.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmEvaluacionDonante_Load_1(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
