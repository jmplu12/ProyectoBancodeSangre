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
    public partial class FrmMantEntregasSangre : Form
    {
        public FrmMantEntregasSangre()
        {
            InitializeComponent();
        }

        private void inicializarControles()
        {
            txtCantidadEntrega.Clear();
            txtEntregaID.Clear();
            txtSolicitudID.Clear();
            txtTipoSangre.Clear();
            dgvMantEntregas.DataSource = EntregaBLL.ObtenerTodas();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidadEntrega.Text = "";
            txtEntregaID.Text = "";
            txtSolicitudID.Text = "";
            txtTipoSangre.Text = "";
        }

        private bool validarDatosEntrega()
        {
            bool validado = true;
            epmanEntrega.Clear();


            if (string.IsNullOrEmpty(txtCantidadEntrega.Text) || !double.TryParse(txtCantidadEntrega.Text, out _))
            {
                epmanEntrega.SetError(txtCantidadEntrega, "La cantidad entregada es obligatoria y debe ser un número válido.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtSolicitudID.Text) || !int.TryParse(txtSolicitudID.Text, out _))
            {
                epmanEntrega.SetError(txtSolicitudID, "El ID de la solicitud es obligatorio y debe ser un número.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtTipoSangre.Text))
            {
                epmanEntrega.SetError(txtTipoSangre, "El tipo de sangre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtEntregaID.Text) || !int.TryParse(txtEntregaID.Text, out _))
            {
                epmanEntrega.SetError(txtEntregaID, "El ID de entrega es obligatorio y debe ser un número.");
                validado = false;
            }

            return validado;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarDatosEntrega())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                EntregaEntity entrega = new EntregaEntity
                {
                    ID = Convert.ToInt32(txtEntregaID.Text),
                    SolicitudID = Convert.ToInt32(txtSolicitudID.Text),
                    CantidadEntregada = Convert.ToInt32(txtCantidadEntrega.Text),
                    TipoDeSangre = txtTipoSangre.Text.Trim(),
                    FechaEntrega = dtpFechaEntrega.Value,
                };

                var entregaExistente = EntregaBLL.ObtenerPorID(entrega.ID);

                if (entregaExistente == null)
                {
                    EntregaBLL.Guardar(entrega);
                    MessageBox.Show("ENTREGA REGISTRADA CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicializarControles();
                }
                else
                {
                    MessageBox.Show("Ya existe una entrega con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMantEntregas.SelectedRows.Count > 0)
            {
                int idEntregas = Convert.ToInt32(dgvMantEntregas.SelectedRows[0].Cells["ID"].Value);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        EntregaBLL.Borrar(idEntregas);

                        inicializarControles();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMantEntregasSangre_Load(object sender, EventArgs e)
        {
            inicializarControles();
        }

        private void dgvMantSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewRow row = dgvMantEntregas.Rows[e.RowIndex];

                txtEntregaID.Text = row.Cells["ID"].Value?.ToString() ?? "0";
                txtSolicitudID.Text = row.Cells["SolicitudID"].Value?.ToString() ?? "0";
                txtCantidadEntrega.Text = row.Cells["CantidadEntregada"].Value?.ToString() ?? "0";
                txtTipoSangre.Text = row.Cells["TipoDeSangre"].Value?.ToString() ?? "Tipo de sangre no especificado";

            }
        }
        #region Permitir Letras o numero


        private void txtCantidadEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 && e.KeyChar != '.') ||
               (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && txtCantidadEntrega.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
