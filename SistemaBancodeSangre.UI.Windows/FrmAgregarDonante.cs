using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmAgregarDonante : Form
    {

        //Agregue esto aca, guardar el Id empleado => cambio
        private int empleadoId;

        public FrmAgregarDonante(int empleadoId)
        {
            InitializeComponent();
            //=> cambio
            this.empleadoId = empleadoId;
        }

        private void Abrirfromhija(object Frmhija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Frmhija as Form;
            fh.TopLevel = false;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void InicializarControles()
        {
            txtIdDonante.Text = "0";

            txtNombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txttelefono.Clear();
            txtDireccion.Clear();

            txtEdad.Clear();
            txtPesokg.Text = "0";

            cboProvincia.SelectedIndex = -1;
            cboMunicipio.SelectedIndex = -1;
            cbosexo.SelectedIndex = -1;
            cboTipoDonante.SelectedIndex = -1;
            cboTiposangre.SelectedIndex = -1;

            dtFechaNac.Value = DateTime.Today;

            errorProvider.Clear();

            if (dgvRegistroDonante.DataSource != null)
            {
                dgvRegistroDonante.ClearSelection();
            }

            txtNombre.Focus();
        }

        private void FrmAgregarDonante_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show(
                    "Corrija los campos marcados antes de continuar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                DonantesEntity donante = new DonantesEntity
                {
                    ID = Convert.ToInt32(txtIdDonante.Text),
                    EmpleadosID = this.empleadoId,

                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellidos.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = txttelefono.Text.Trim(),

                    FechaNacimiento = dtFechaNac.Value,
                    Edad = txtEdad.Text,
                    PesoKlg = Convert.ToDouble(txtPesokg.Text),

                    Sexo = cbosexo.SelectedItem.ToString(),
                    TipoDeSangre = cboTiposangre.SelectedItem.ToString(),
                    TipodeDonante = cboTipoDonante.SelectedItem.ToString(),

                    Provincia = cboProvincia.SelectedItem.ToString(),
                    Municipio = cboMunicipio.SelectedItem.ToString(),

                    Direccion = txtDireccion.Text.Trim()
                };

                // La BLL decide si crea o actualiza
                DonanteBLL.CrearDonante(donante);

                MessageBox.Show(
                    "DONANTE REGISTRADO CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Mostrar solamente el donante registrado
                dgvRegistroDonante.DataSource = null;
                dgvRegistroDonante.DataSource = new List<DonantesEntity> { donante };

                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Error en el formato de los datos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Método para calcular la edad
        private string CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad.ToString();
        }

        private bool validarDatos(bool esActualizacion = false)
        {
            bool validado = true;

            errorProvider.Clear();

            // ==========================
            // Nombre
            // ==========================
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            // ==========================
            // Apellidos
            // ==========================
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            // ==========================
            // Cédula
            // ==========================
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                errorProvider.SetError(txtCedula, "La cédula es obligatoria.");
                validado = false;
            }
            else if (txtCedula.Text.Length != 11)
            {
                errorProvider.SetError(txtCedula, "La cédula debe tener exactamente 11 dígitos.");
                validado = false;
            }
            else if (!esActualizacion && DonanteBLL.ExisteCedula(txtCedula.Text.Trim()))
            {
                errorProvider.SetError(txtCedula, "Esta cédula ya está registrada.");
                validado = false;
            }

            // ==========================
            // Teléfono
            // ==========================
            if (string.IsNullOrWhiteSpace(txttelefono.Text))
            {
                errorProvider.SetError(txttelefono, "El teléfono es obligatorio.");
                validado = false;
            }
            else if (txttelefono.Text.Length != 10)
            {
                errorProvider.SetError(txttelefono, "El teléfono debe tener exactamente 10 dígitos.");
                validado = false;
            }
            else if (!esActualizacion && DonanteBLL.ExisteTelefono(txttelefono.Text.Trim()))
            {
                errorProvider.SetError(txttelefono, "Este teléfono ya está registrado.");
                validado = false;
            }

            // ==========================
            // Correo
            // ==========================
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider.SetError(txtCorreo, "El correo electrónico es obligatorio.");
                validado = false;
            }
            else
            {
                try
                {
                    var correo = new System.Net.Mail.MailAddress(txtCorreo.Text);

                    if (!esActualizacion && DonanteBLL.ExisteCorreo(txtCorreo.Text.Trim()))
                    {
                        errorProvider.SetError(txtCorreo, "Este correo ya está registrado.");
                        validado = false;
                    }
                }
                catch
                {
                    errorProvider.SetError(txtCorreo, "Correo electrónico inválido.");
                    validado = false;
                }
            }

            // ==========================
            // Sexo
            // ==========================
            if (cbosexo.SelectedIndex == -1)
            {
                errorProvider.SetError(cbosexo, "Seleccione el sexo.");
                validado = false;
            }

            // ==========================
            // Tipo de sangre
            // ==========================
            if (cboTiposangre.SelectedIndex == -1)
            {
                errorProvider.SetError(cboTiposangre, "Seleccione el tipo de sangre.");
                validado = false;
            }

            // ==========================
            // Tipo de donante
            // ==========================
            if (cboTipoDonante.SelectedIndex == -1)
            {
                errorProvider.SetError(cboTipoDonante, "Seleccione el tipo de donante.");
                validado = false;
            }

            // ==========================
            // Provincia
            // ==========================
            if (cboProvincia.SelectedIndex == -1)
            {
                errorProvider.SetError(cboProvincia, "Seleccione la provincia.");
                validado = false;
            }

            // ==========================
            // Municipio
            // ==========================
            if (cboMunicipio.SelectedIndex == -1)
            {
                errorProvider.SetError(cboMunicipio, "Seleccione el municipio.");
                validado = false;
            }

            // ==========================
            // Dirección
            // ==========================
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "La dirección es obligatoria.");
                validado = false;
            }

            // ==========================
            // Peso
            // ==========================
            if (!double.TryParse(txtPesokg.Text, out double peso))
            {
                errorProvider.SetError(txtPesokg, "Peso inválido.");
                validado = false;
            }
            else if (peso < 50)
            {
                errorProvider.SetError(txtPesokg, "El peso mínimo para donar es de 50 Kg.");
                validado = false;
            }

            // ==========================
            // Edad
            // ==========================
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                errorProvider.SetError(txtEdad, "Edad inválida.");
                validado = false;
            }
            else if (edad < 18)
            {
                errorProvider.SetError(txtEdad, "El donante debe ser mayor de edad.");
                validado = false;
            }

            // ==========================
            // Fecha de nacimiento
            // ==========================
            if (dtFechaNac.Value.Date > DateTime.Today)
            {
                errorProvider.SetError(dtFechaNac, "La fecha de nacimiento no es válida.");
                validado = false;
            }

            return validado;
        }

        private void dgvRegistroDonante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return; // Si se hace clic en la cabecera, no hacer nada
            }

            DataGridViewRow row = this.dgvRegistroDonante.CurrentRow; // Obtener la fila actual

            // Asignar los valores de la fila a los controles del formulario
            this.txtIdDonante.Text = row.Cells["ID"].Value.ToString();
            this.txtNombre.Text = row.Cells["nombre"].Value.ToString();
            this.txtApellidos.Text = row.Cells["apellido"].Value.ToString();
            this.txtCedula.Text = row.Cells["cedula"].Value.ToString();
            this.txtCorreo.Text = row.Cells["correo"].Value.ToString();
            this.txttelefono.Text = row.Cells["telefono"].Value.ToString();
            this.dtFechaNac.Value = Convert.ToDateTime(row.Cells["fechaNacimiento"].Value);
            this.txtEdad.Text = row.Cells["edad"].Value.ToString();
            this.txtPesokg.Text = row.Cells["pesoKlg"].Value.ToString();
            this.txttelefono.Text = row.Cells["Dirreccion"].Value.ToString();
            this.cbosexo.SelectedItem = row.Cells["sexo"].Value.ToString();
            this.cboTiposangre.SelectedItem = row.Cells["tipoDeSangre"].Value.ToString();
            this.cboProvincia.SelectedItem = row.Cells["provincia"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRegistroDonante.CurrentRow;

            if (dgvRegistroDonante.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un donante para eliminar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = Convert.ToInt32(dgvRegistroDonante.CurrentRow.Cells["ID"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar este donante?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                // Todo pasa por la BLL
                DonanteBLL.EliminarDonante(id);

                MessageBox.Show(
                    "DONANTE ELIMINADO CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvRegistroDonante.DataSource = null;

                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al eliminar el donante.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
          }

        private void dgvRegistroDonante_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ignorar clics en la cabecera del DataGridView
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvRegistroDonante.Rows[e.RowIndex];

                // Asignación segura de campos de texto
                txtIdDonante.Text = row.Cells["ID"].Value?.ToString() ?? "0";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtApellidos.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                txtCedula.Text = row.Cells["Cedula"].Value?.ToString() ?? string.Empty;
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString() ?? string.Empty;
                txttelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                txtEdad.Text = row.Cells["Edad"].Value?.ToString() ?? string.Empty;
                txtPesokg.Text = row.Cells["PesoKlg"].Value?.ToString() ?? "0";
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString() ?? string.Empty;

                // Asignación segura de la Fecha de Nacimiento
                if (row.Cells["FechaNacimiento"].Value != null && row.Cells["FechaNacimiento"].Value != DBNull.Value)
                {
                    dtFechaNac.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                }

                // Asignación de ComboBoxes usando .Text para mayor compatibilidad
                cboTipoDonante.Text = row.Cells["TipodeDonante"].Value?.ToString() ?? string.Empty;
                cbosexo.Text = row.Cells["Sexo"].Value?.ToString() ?? string.Empty;
                cboTiposangre.Text = row.Cells["TipoDeSangre"].Value?.ToString() ?? string.Empty;
                cboProvincia.Text = row.Cells["Provincia"].Value?.ToString() ?? string.Empty;
                cboMunicipio.Text = row.Cells["Municipio"].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar el donante: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void dtFechaNac_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
            DateTime fechaNacimiento = dtFechaNac.Value;

            // Calcular la edad
            string edad = CalcularEdad(fechaNacimiento);

            // Asignar la edad al TextBox
            txtEdad.Text = edad;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            FrmListadoDeDonantes frm = new FrmListadoDeDonantes(true);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DonantesEntity donante = DonanteBLL.ObtenerDonantePorId(frm.IdDonante);


                txtIdDonante.Text = donante.ID.ToString();

                txtNombre.Text = donante.Nombre;

                txtApellidos.Text = donante.Apellido;

                txtCedula.Text = donante.Cedula;

                txtCorreo.Text = donante.Correo;

                txttelefono.Text = donante.Telefono;

                txtDireccion.Text = donante.Direccion;

                dtFechaNac.Value = Convert.ToDateTime(donante.FechaNacimiento);

                txtEdad.Text = donante.Edad.ToString();

                txtPesokg.Text = donante.PesoKlg.ToString();

                cbosexo.Text = donante.Sexo;

                cboTiposangre.Text = donante.TipoDeSangre;

                cboProvincia.Text = donante.Provincia;

                cboMunicipio.Text = donante.Municipio;

                cboTipoDonante.Text = donante.TipodeDonante;
            }
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            if (!validarDatos(true))
            {
                MessageBox.Show(
                    "Corrija los campos marcados antes de continuar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                DonantesEntity donante = new DonantesEntity
                {
                    ID = Convert.ToInt32(txtIdDonante.Text),
                    EmpleadosID = this.empleadoId,

                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellidos.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = txttelefono.Text.Trim(),

                    FechaNacimiento = dtFechaNac.Value,
                    Edad = txtEdad.Text,
                    PesoKlg = Convert.ToDouble(txtPesokg.Text),

                    Sexo = cbosexo.SelectedItem.ToString(),
                    TipoDeSangre = cboTiposangre.SelectedItem.ToString(),
                    TipodeDonante = cboTipoDonante.SelectedItem.ToString(),

                    Provincia = cboProvincia.SelectedItem.ToString(),
                    Municipio = cboMunicipio.SelectedItem.ToString(),

                    Direccion = txtDireccion.Text.Trim()
                };

                // Buscar únicamente por la BLL
                DonantesEntity donanteExistente = DonanteBLL.ObtenerDonantePorId(donante.ID);

                if (donanteExistente == null)
                {
                    MessageBox.Show(
                        "El donante no existe.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                // La BLL actualizará el registro
                DonanteBLL.CrearDonante(donante);

                MessageBox.Show(
                    "DONANTE ACTUALIZADO CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvRegistroDonante.DataSource = null;
                dgvRegistroDonante.DataSource = new List<DonantesEntity> { donante };

                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Error en el formato de los datos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        #region Tipós de datos permitidos en TXT

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtNombre.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtApellidos.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtCedula.Text.Length >= 11 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txttelefono.Text.Length >= 10 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPesokg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' &&
                txtPesokg.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '#' &&
                e.KeyChar != '.' &&
                e.KeyChar != ',' &&
                e.KeyChar != '-' &&
                e.KeyChar != '/')
            {
                e.Handled = true;
            }

            if (txtDireccion.Text.Length >= 200 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '@' &&
                e.KeyChar != '.' &&
                e.KeyChar != '_' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (txtCorreo.Text.Length >= 100 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        #endregion


    }
}