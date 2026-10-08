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
    public partial class FrmMantMuestras : Form
    {
        public FrmMantMuestras()
        {
            InitializeComponent();
        }
        private void InicializarControles()
        {
            txtMuestraID.Text = "0";
            txtDonanteID.Text = "0";
            txtPresionArterial.Text = "0";
            txtPulso.Text = "0";
            txtTemperatura.Text = "0";
            cboEstado.SelectedIndex = -1;
            dtFechaToma.Text = "";
            txtCantidadM.Text = "0";
            txtResponsable.Clear();
            dgManMuestras.DataSource = MuestraBLL.ObtenerTodas();
        }

        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear();

            // Validar ID de donante
            if (string.IsNullOrEmpty(txtDonanteID.Text) || txtDonanteID.Text == "0")
            {
                errorProvider.SetError(txtDonanteID, "El ID de donante es obligatorio.");
                validado = false;
            }

            // Validar presión arterial
            if (string.IsNullOrEmpty(txtPresionArterial.Text) || txtPresionArterial.Text == "0")
            {
                errorProvider.SetError(txtPresionArterial, "La presión arterial es obligatoria y no puede ser cero.");
                validado = false;
            }

            // Validar pulso
            if (string.IsNullOrEmpty(txtPulso.Text) || txtPulso.Text == "0")
            {
                errorProvider.SetError(txtPulso, "El pulso es obligatorio y no puede ser cero.");
                validado = false;
            }

            // Validar temperatura
            if (string.IsNullOrEmpty(txtTemperatura.Text) || txtTemperatura.Text == "0")
            {
                errorProvider.SetError(txtTemperatura, "La temperatura es obligatoria y no puede ser cero.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadM.Text) ||
              txtCantidadM.Text == "0")
            {
                errorProvider.SetError(
                    txtCantidadM,
                    "La cantidad de muestra es obligatoria y debe ser mayor a cero.");

                validado = false;
            }
            else if (!double.TryParse(txtCantidadM.Text, out double cantidad) ||
                     cantidad <= 0)
            {
                errorProvider.SetError(
                    txtCantidadM,
                    "Ingrese una cantidad de muestra válida.");

                validado = false;
            }
            else if (cantidad > 100)
            {
                errorProvider.SetError(
                    txtCantidadM,
                    "La cantidad de muestra no puede ser mayor de 100 ml.");

                validado = false;
            }
            return validado;


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
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
                MuestraEntity muestra = new MuestraEntity();
                muestra.ID = Convert.ToInt32(txtMuestraID.Text);
                muestra.DonacionesID = Convert.ToInt32(txtDonanteID.Text);
                muestra.CodigoMuestra = txtCodMuestra.Text;
                muestra.FechaToma = dtFechaToma.Value;
                muestra.CantidadM = Convert.ToDouble(txtCantidadM.Text);
                muestra.Responsable = txtResponsable.Text;
                
                
                MuestraBLL.Guardar(muestra);
                MessageBox.Show("LA MUESTRA SE REGISTRÓ CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Permitir Letras o numeros
        private void txtPresionArterial_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPulso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadM_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }

        }
        #endregion

        private void FrmMantMuestras_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void dgManMuestras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgManMuestras.Rows[e.RowIndex];

                txtMuestraID.Text = filaSeleccionada.Cells["ID"].Value?.ToString();
                txtDonanteID.Text = filaSeleccionada.Cells["DonanteID"].Value?.ToString();
                txtCodMuestra.Text = filaSeleccionada.Cells["CodigoMuestra"].Value?.ToString();
                dtFechaToma.Value = Convert.ToDateTime(filaSeleccionada.Cells["FechaToma"].Value ?? DateTime.Now);
                txtCantidadM.Text = filaSeleccionada.Cells["CantidadM"].Value?.ToString();
                txtResponsable.Text = filaSeleccionada.Cells["Responsable"].Value?.ToString();
                txtPresionArterial.Text = filaSeleccionada.Cells["presionAlterial"].Value?.ToString();
                txtPulso.Text = filaSeleccionada.Cells["Pulso"].Value?.ToString();
                txtTemperatura.Text = filaSeleccionada.Cells["Temperatura"].Value?.ToString();
                txtCantidadM.Text = filaSeleccionada.Cells["CantidadM"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
