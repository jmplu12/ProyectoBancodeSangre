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

namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    public partial class FrmMantAnalisis : Form
    {
        public FrmMantAnalisis()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            // Inicializa los controles del formulario
            txtidanalisis.Text = "0";
            txtMuestra.Text = "0";
            checHepatitisBC.Checked = false;
            checHepatitisBC.Checked = false;
            checkArritmias.Checked = false;
            checkCancer.Checked = false;
            checkChagas.Checked = false;
            checkDiabetes.Checked = false;
            checkHemofilia.Checked = false;
            checkHipertensionArterial.Checked = false;
            checkInsuficienciaCardiaca.Checked = false;
            checkVIH.Checked = false;
            dgvanalisis.DataSource = AnalisisBLL.ObtenerTodas();

        }

        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear();

            // Validar ID de donante
            if (string.IsNullOrEmpty(txtMuestra.Text) || txtMuestra.Text == "0")
            {
                errorProvider.SetError(txtMuestra, "El ID de donante es obligatorio.");
                validado = false;
            }

            // Validar nombre
            if (string.IsNullOrEmpty(txtidanalisis.Text))
            {
                errorProvider.SetError(txtidanalisis, "El nombre es obligatorio.");
                validado = false;
            }
            return validado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                AnalisisEntity analisis = new AnalisisEntity
                {
                    ID = Convert.ToInt32(txtidanalisis.Text),
                    MuestraID = Convert.ToInt32(txtMuestra.Text),
                    analista = txtAnalista.Text.Trim(),
                    Cancer = checkCancer.Checked,
                    Vhsida = checkVIH.Checked,
                    Arritmias = checkArritmias.Checked,
                    chagas = checkChagas.Checked,
                    insuficienciaCardiaca = checkInsuficienciaCardiaca.Checked,
                    Diabetes = checkDiabetes.Checked,
                    Hemofilia = checkHemofilia.Checked,
                    hepatitisBoC = checHepatitisBC.Checked,
                    HipertensionAlterial = checkHipertensionArterial.Checked,
                    Tipodesangre = cbotipodesangre.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un tipo de sangre."),
                    fechaAnalisis = dtFechaAnalitica.Value

                };

                AnalisisBLL.Guardar(analisis);

                MessageBox.Show("EL ANÁLISIS SE REGISTRÓ CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvanalisis.Rows.Count > 0)
            {
                int IdAnalisis = Convert.ToInt32(dgvanalisis.SelectedRows[0].Cells["ID"].Value);

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este análisis?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AnalisisBLL.Eliminar(IdAnalisis);
                        MessageBox.Show("Análisis eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarControles();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void dgvanalisis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvanalisis.Rows[e.RowIndex];

                txtidanalisis.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                txtMuestra.Text = filaSeleccionada.Cells["MuestraID"].Value.ToString();
                txtAnalista.Text = filaSeleccionada.Cells["analista"].Value.ToString();
                checkCancer.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Cancer"].Value);
                checkVIH.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Vhsida"].Value);
                checkArritmias.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Arritmias"].Value);
                checkChagas.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Chagas"].Value);
                checkInsuficienciaCardiaca.Checked = Convert.ToBoolean(filaSeleccionada.Cells["InsuficienciaCardiaca"].Value);
                checkDiabetes.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Diabetes"].Value);
                checkHemofilia.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Hemofilia"].Value);
                checHepatitisBC.Checked = Convert.ToBoolean(filaSeleccionada.Cells["HepatitisBoC"].Value);
                checkHipertensionArterial.Checked = Convert.ToBoolean(filaSeleccionada.Cells["HipertensionAlterial"].Value);
                cbotipodesangre.SelectedItem = filaSeleccionada.Cells["Tipodesangre"].Value?.ToString();
                dtFechaAnalitica.Value = Convert.ToDateTime(filaSeleccionada.Cells["FechaAnalisis"].Value);
            }
        }

        private void FrmMantAnalisis_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
