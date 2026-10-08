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
    public partial class FrmMantDonaciones : Form
    {
        public FrmMantDonaciones()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            txtID.Text = "0";
            txtIdDonante.Text = "0";
            //this.txtNombre.Clear();
            txtApellidos.Clear();
            txtCantSangre.Clear();
            txtEvase.Text = "0";
            txtPoposito.Clear();
            txtTiposangre.Clear();
            dtFecha.Text = "";
            txtAnalista.Clear();
            dtgDonaciones.DataSource = DonacionesBLL.GetAll();

        }




        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear(); // Limpiar errores anteriores

            // Validar nombre
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            // Validar apellidos
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            // Validar tipo de sangre
            if (string.IsNullOrEmpty(txtTiposangre.Text))
            {
                errorProvider.SetError(txtTiposangre, "Introduzca la cantidad de sangre.");
                validado = false;
            }
            //valida analista
            if (string.IsNullOrEmpty(txtAnalista.Text))
            {
                errorProvider.SetError(txtTiposangre, "El analista es obligatorio son obligatorios.");
                validado = false;
            }
            return validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    DonacionesEntity donaciones = new DonacionesEntity
                    {
                        ID = Convert.ToInt32(txtID.Text),
                        DonanteID = Convert.ToInt32(txtIdDonante.Text),
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellidos.Text.Trim(),
                        CantidadSangre = Convert.ToInt32(txtCantSangre.Text),
                        Analista = txtAnalista.Text.Trim(),
                        TipoDeSangre = txtTiposangre.Text.Trim(),
                        Envase = txtEvase.Text.Trim(),
                        FechaDonacion = Convert.ToDateTime(dtFecha.Text),
                        Proposito = txtPoposito.Text.Trim()
                    };

                    DonacionesBLL.Guardar(donaciones);

                    MessageBox.Show("LOS DATOS SE REGISTRARON CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicializarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dtgDonaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgDonaciones.Rows[e.RowIndex];

                txtID.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                txtIdDonante.Text = filaSeleccionada.Cells["DonanteID"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                txtCantSangre.Text = filaSeleccionada.Cells["cantidadSangre"].Value.ToString();
                txtAnalista.Text = filaSeleccionada.Cells["analista"].Value.ToString();
                txtTiposangre.Text = filaSeleccionada.Cells["tipoDeSangre"].Value.ToString();
                txtEvase.Text = filaSeleccionada.Cells["envase"].Value.ToString();
                dtFecha.Text = Convert.ToDateTime(filaSeleccionada.Cells["FechaDonacion"].Value).ToString("yyyy-MM-dd");
                txtPoposito.Text = filaSeleccionada.Cells["proposito"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDonaciones.Rows.Count > 0)
            {
                int idDonacion = Convert.ToInt32(dtgDonaciones.SelectedRows[0].Cells["ID"].Value);

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta donación?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DonacionesDAL.Eliminar(idDonacion);
                        MessageBox.Show("Donación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Permitir Letras y Numeros
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtIdDonante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTiposangre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCantSangre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

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

        private void txtEvase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtAnalista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtPoposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        #endregion

        private void FrmMantDonaciones_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }

}
