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
    public partial class FrmAnaliticaSangre : Form
    {
        private readonly int empleadoId;
        public FrmAnaliticaSangre(int empleadoId)
        {
            this.empleadoId = empleadoId;
            InitializeComponent();
        }

        #region Limpieza de Controles

        private void InicializarControles()
        {
            txtidanalisis.Text = "0";
            txtidDonante.Text = "0";
            txtMuestra.Text = "0";
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDonante.Clear();
            txtsexo.Clear();
            txtAnalista.Clear();

            cbotipodesangre.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            dtFechaAnalitica.Value = DateTime.Today;

            checHepatitisBC.Checked = false;
            checkArritmias.Checked = false;
            checkCancer.Checked = false;
            checkChagas.Checked = false;
            checkDiabetes.Checked = false;
            checkHemofilia.Checked = false;
            checkHipertensionArterial.Checked = false;
            checkInsuficienciaCardiaca.Checked = false;
            checkVIH.Checked = false;

            errorProvider.Clear();
        }

        #endregion

        private void CargarDatos()
        {
            try
            {
                dgvmuestra.AutoGenerateColumns = false;
                dgvmuestra.ReadOnly = true;
                dgvmuestra.AllowUserToAddRows = false;
                dgvmuestra.AllowUserToDeleteRows = false;
                dgvmuestra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvmuestra.MultiSelect = false;

                dgvmuestra.DataSource = null;
                dgvmuestra.DataSource = AnalisisBLL.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            bool validado = true;

            errorProvider.Clear();

            if (txtidDonante.Text == "0")
            {
                errorProvider.SetError(txtidDonante,
                    "Seleccione un donante.");

                validado = false;
            }

            if (txtMuestra.Text == "0")
            {
                errorProvider.SetError(txtMuestra,
                    "Seleccione una muestra.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido,
                    "Campo obligatorio.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtTipoDonante.Text))
            {
                errorProvider.SetError(txtTipoDonante,
                    "Campo obligatorio.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtsexo.Text))
            {
                errorProvider.SetError(txtsexo,
                    "Campo obligatorio.");

                validado = false;
            }

            if (cbotipodesangre.SelectedIndex == -1)
            {
                errorProvider.SetError(
                    cbotipodesangre,
                    "Seleccione un tipo de sangre.");

                validado = false;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                errorProvider.SetError(
                    cboEstado,
                    "Seleccione un estado.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtAnalista.Text))
            {
                errorProvider.SetError(
                    txtAnalista,
                    "Digite el analista.");

                validado = false;
            }

            if (dtFechaAnalitica.Value.Date > DateTime.Now.Date)
            {
                errorProvider.SetError(
                    dtFechaAnalitica,
                    "La fecha no puede ser mayor que hoy.");

                validado = false;
            }

            return validado;
        }

        private void LimpiarChecks()
        {
            checkVIH.Checked = false;
            checkDiabetes.Checked = false;
            checHepatitisBC.Checked = false;
            checkHipertensionArterial.Checked = false;
            checkInsuficienciaCardiaca.Checked = false;
            checkCancer.Checked = false;
            checkArritmias.Checked = false;
            checkHemofilia.Checked = false;
            checkChagas.Checked = false;
        }

        private void ConfigurarGrid()
        {
            dgvmuestra.AutoGenerateColumns = false;

            dgvmuestra.ReadOnly = true;

            dgvmuestra.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvmuestra.MultiSelect = false;

            dgvmuestra.AllowUserToAddRows = false;

            dgvmuestra.AllowUserToDeleteRows = false;

            dgvmuestra.AllowUserToResizeRows = false;
        }

        private void CargarAnalista()
        {
            try
            {
                EmpleadosEntity empleado = EmpleadoBLL.obtenerID(empleadoId);

                if (empleado != null)
                {
                    txtAnalista.Text = $"{empleado.nombre} {empleado.Apellido}".Trim();
                }
                else
                {
                    txtAnalista.Text = empleadoId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la información del analista.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

            private void RefrescarGrid()
        {
            dgvmuestra.DataSource = null;
            dgvmuestra.DataSource = AnalisisBLL.ObtenerTodas();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        #region Selección de Muestras / Donantes
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmInformacionDonantesMuestras frm = new FrmInformacionDonantesMuestras();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Asignación segura a través de las propiedades expuestas
                txtidDonante.Text = frm.DonanteID.ToString();
                txtNombre.Text = frm.NombreDonante;
                txtApellido.Text = frm.ApellidoDonante;
                txtsexo.Text = frm.Sexo;
                txtTipoDonante.Text = frm.TipoDonante;
                txtMuestra.Text = frm.MuestraID.ToString();
                txtCodigoMuestra.Text = frm.CodigoMuestra;
            }
        }
        #endregion

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show(
                    "Complete los campos obligatorios.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                AnalisisEntity analisis = new AnalisisEntity();

                analisis.ID = Convert.ToInt32(txtidanalisis.Text);

                analisis.MuestraID = Convert.ToInt32(txtMuestra.Text);

                analisis.analista = txtAnalista.Text.Trim();

                analisis.estado = cboEstado.Text;

                analisis.Tipodesangre = cbotipodesangre.Text;

                analisis.fechaAnalisis = dtFechaAnalitica.Value;

                analisis.Vhsida = checkVIH.Checked;

                analisis.Diabetes = checkDiabetes.Checked;

                analisis.hepatitisBoC = checHepatitisBC.Checked;

                analisis.HipertensionAlterial =
                    checkHipertensionArterial.Checked;

                analisis.insuficienciaCardiaca =
                    checkInsuficienciaCardiaca.Checked;

                analisis.Cancer =
                    checkCancer.Checked;

                analisis.Arritmias =
                    checkArritmias.Checked;

                analisis.Hemofilia =
                    checkHemofilia.Checked;

                analisis.chagas =
                    checkChagas.Checked;


                AnalisisBLL.Guardar(analisis);

                MessageBox.Show(
                    analisis.ID == 0 ?
                    "Análisis registrado correctamente." :
                    "Análisis actualizado correctamente.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                InicializarControles();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void FrmAnaliticaSangre_Load(object sender, EventArgs e)
        {
            InicializarControles();
            CargarDatos();
            ConfigurarGrid();

            CargarAnalista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtidanalisis.Text == "0")
            {
                MessageBox.Show(
                    "Seleccione un análisis.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea eliminar este análisis?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            try
            {
                AnalisisBLL.Eliminar(
                    Convert.ToInt32(txtidanalisis.Text));

                MessageBox.Show(
                    "Registro eliminado.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                InicializarControles();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvmuestra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvmuestra.Rows[e.RowIndex];

                txtidanalisis.Text = fila.Cells["ID"].Value?.ToString() ?? "0";
                txtMuestra.Text = fila.Cells["MuestraID"].Value?.ToString() ?? "0";

                txtAnalista.Text = fila.Cells["analista"].Value?.ToString() ?? string.Empty;

                cboEstado.SelectedItem = fila.Cells["estado"].Value?.ToString();

                cbotipodesangre.SelectedItem = fila.Cells["Tipodesangre"].Value?.ToString();

                if (fila.Cells["fechaAnalisis"].Value != null)
                {
                    dtFechaAnalitica.Value =
                        Convert.ToDateTime(fila.Cells["fechaAnalisis"].Value);
                }

                checkVIH.Checked =
                    Convert.ToBoolean(fila.Cells["Vhsida"].Value);

                checkDiabetes.Checked =
                    Convert.ToBoolean(fila.Cells["Diabetes"].Value);

                checHepatitisBC.Checked =
                    Convert.ToBoolean(fila.Cells["hepatitisBoC"].Value);

                checkHipertensionArterial.Checked =
                    Convert.ToBoolean(fila.Cells["HipertensionAlterial"].Value);

                checkInsuficienciaCardiaca.Checked =
                    Convert.ToBoolean(fila.Cells["insuficienciaCardiaca"].Value);

                checkCancer.Checked =
                    Convert.ToBoolean(fila.Cells["Cancer"].Value);

                checkArritmias.Checked =
                    Convert.ToBoolean(fila.Cells["Arritmias"].Value);

                checkHemofilia.Checked =
                    Convert.ToBoolean(fila.Cells["Hemofilia"].Value);

                checkChagas.Checked =
                    Convert.ToBoolean(fila.Cells["chagas"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvmuestra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvmuestra_CellClick(sender, e);
        }
    }
}