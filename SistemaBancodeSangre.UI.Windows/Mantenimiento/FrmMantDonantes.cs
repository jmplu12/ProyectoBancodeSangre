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
    public partial class FrmMantDonantes : Form
    {

        private int empleadoId;

        public FrmMantDonantes(int emleadoId)
        {
            InitializeComponent();
            this.empleadoId = emleadoId;
        }

        public FrmMantDonantes()
        {

            InitializeComponent();

        }

        public void inicializarControles()
        {
            txtIdDonante.Text = "0";
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            cboTipoDonante.SelectedIndex = -1;
            cbosexo.SelectedIndex = -1;
            txttelefono.Clear();
            txtPesokg.Clear();
            txtEdad.Clear();
            cboTiposangre.SelectedIndex = -1;
            txtCorreo.Clear();
            cboProvincia.SelectedIndex = -1;
            cboMunicipio.SelectedIndex = -1;
            txtDireccion.Clear();

            dgvMantDonantes.DataSource = DonanteBLL.GetAll();

        }

        private bool validarDatos()
        {
            bool validado = true;
            epmanDon.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epmanDon.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                epmanDon.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txttelefono.Text) || txttelefono.Text.Length != 10)
            {
                epmanDon.SetError(txttelefono, "El teléfono debe tener exactamente 10 dígitos.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtCedula.Text) || txtCedula.Text.Length != 11)
            {
                epmanDon.SetError(txtCedula, "La cédula debe tener exactamente 11 dígitos.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                epmanDon.SetError(txtCorreo, "El correo electrónico es obligatorio y debe ser válido.");
                validado = false;
            }
            if (String.IsNullOrEmpty(txtCedula.Text))
            {
                epmanDon.SetError(txtCedula, "La Cedula es Obligatoria.");
            }

            if (cboMunicipio.SelectedIndex == -1)
            {
                epmanDon.SetError(cboMunicipio, "Debe eligir un valor");
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                epmanDon.SetError(cboProvincia, "Debe eligir un valor");
            }
            if (cboTipoDonante.SelectedIndex == -1)
            {
                epmanDon.SetError(cboTipoDonante, "Debe eligir un valor");
            }
            if (cboTiposangre.SelectedIndex == -1)
            {
                epmanDon.SetError(cboMunicipio, "Debe eligir un valor");
            }

            return validado;
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
                DonantesEntity donantes = new DonantesEntity();
                donantes.ID = Convert.ToInt32(txtIdDonante.Text);
                donantes.EmpleadosID = this.empleadoId;
                donantes.Nombre = txtNombre.Text.Trim();
                donantes.Apellido = txtApellidos.Text.Trim();
                donantes.Cedula = txtCedula.Text.Trim();
                donantes.Correo = txtCorreo.Text.Trim();
                donantes.Telefono = txttelefono.Text.Trim();
                donantes.FechaNacimiento = Convert.ToDateTime(dtFechaNac.Text);
                donantes.Edad = txtEdad.Text;
                donantes.PesoKlg = Convert.ToDouble(txtPesokg.Text);
                donantes.Sexo = cbosexo.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un sexo.");
                donantes.TipoDeSangre = cboTiposangre.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un tipo de sangre.");
                donantes.TipodeDonante = cboTipoDonante.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un tipo de donante.");
                donantes.Provincia = cboProvincia.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione una provincia.");
                donantes.Municipio = cboMunicipio.SelectedItem.ToString() ?? throw new InvalidOperationException("Seleccione una provincia.");
                donantes.Direccion = txtDireccion.Text.Trim();

               DonanteBLL.CrearDonante(donantes);
               MessageBox.Show("DATOS REGISTRADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               inicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmMantDonantes_Load(object sender, EventArgs e)
        {
            inicializarControles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            inicializarControles();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMantDonantes.Rows.Count > 0)
            {
                int idDonante = Convert.ToInt32(dgvMantDonantes.SelectedRows[0].Cells["ID"].Value);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DonanteBLL.EliminarDonante(idDonante);

                        inicializarControles();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvMantDonantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMantDonantes.Rows[e.RowIndex];

                cboTipoDonante.SelectedItem = row.Cells["TipodeDonante"].Value?.ToString();
                cbosexo.SelectedItem = row.Cells["Sexo"].Value?.ToString();
                cboTiposangre.SelectedItem = row.Cells["TipoDeSangre"].Value?.ToString();
                cboProvincia.SelectedItem = row.Cells["Provincia"].Value?.ToString();
                cboMunicipio.SelectedItem = row.Cells["Municipio"].Value?.ToString();
                txtIdDonante.Text = row.Cells["ID"].Value?.ToString() ?? "0";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtApellidos.Text = row.Cells["Apellido"].Value?.ToString();
                txtCedula.Text = row.Cells["Cedula"].Value?.ToString();
                txttelefono.Text = row.Cells["Telefono"].Value?.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
                txtPesokg.Text = row.Cells["PesoKlg"].Value?.ToString();
                txtEdad.Text = row.Cells["Edad"].Value?.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();

            }

        }

        #region Permitir Letras o Numeros
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPesokg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#')
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}