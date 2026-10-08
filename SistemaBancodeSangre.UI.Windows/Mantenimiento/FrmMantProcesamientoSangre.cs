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
    public partial class FrmMantProcesamientoSangre : Form
    {
        public FrmMantProcesamientoSangre()
        {
            InitializeComponent();
        }

        private void inicializarControles()
        {
            txtProcesoId.Text = "0";
            txtIdDonacion.Text = "0";
            txtNoSangre.Clear();
            txtTipoSangre.Clear();
            txtVolumenDno.Clear();
            txtEstado.Clear();
            txtAlmacenado.Clear();
            txtResponsable.Clear();
            dgvMantProcesos.DataSource = ProcesamientoDeSangreBLL.ObtenerTodas();

        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNoSangre.Text))
            {
                erpProcesamientoSangre.SetError(txtNoSangre, "El campo No Sangre es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txtVolumenDno.Text))
            {
                erpProcesamientoSangre.SetError(txtVolumenDno, "El campo Vol Donacion es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txtAlmacenado.Text))
            {
                erpProcesamientoSangre.SetError(txtAlmacenado, "El campo Almacenado es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                erpProcesamientoSangre.SetError(txtResponsable, "El campo Responsable es obligatorio");
                return false;
            }

            return true;
        }

        private void FrmMantProcesamientoSangre_Load(object sender, EventArgs e)
        {
            inicializarControles();
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
                ProcesamientoDeSangreEntity procesoSangre = new ProcesamientoDeSangreEntity
                {
                    ID = Convert.ToInt32(txtProcesoId.Text),
                    TipoDeSangre = txtTipoSangre.Text.Trim(),
                    VolumenDN = Convert.ToDouble(txtVolumenDno.Text),
                    Almacenado = txtAlmacenado.Text.Trim(),
                    DonacionesID = Convert.ToInt32(txtIdDonacion.Text),
                    EstadoProceso = txtEstado.Text.Trim(),
                    Responsable = txtResponsable.Text.Trim()
                };
                ProcesamientoDeSangreBLL.Guardar(procesoSangre);

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region
            //    var procesoExistente = ProcesamientoDeSangreBLL.obtenerID(procesoSangre.ID);

            //    if (procesoExistente == null)
            //    {
            //        ProcesamientoDeSangreBLL.Guardar(procesoSangre);
            //        MessageBox.Show("PROCESO DE SANGRE REGISTRADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        inicializarControles();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ya existe un proceso de sangre con este ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMantProcesos.Rows.Count > 0)
            {
                int IdProceso = Convert.ToInt32(dgvMantProcesos.SelectedRows[0].Cells["ID"].Value);

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este proceso?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ProcesamientoDeSangreBLL.Borrar(IdProceso);
                        inicializarControles();
                        MessageBox.Show("Proceso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvMantProcesos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvMantProcesos.Rows[e.RowIndex];

                txtProcesoId.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                txtTipoSangre.Text = filaSeleccionada.Cells["TipoDeSangre"].Value.ToString();
                txtVolumenDno.Text = filaSeleccionada.Cells["VolumenDN"].Value.ToString();
                txtAlmacenado.Text = filaSeleccionada.Cells["Almacenado"].Value.ToString();
                txtIdDonacion.Text = filaSeleccionada.Cells["DonacionesID"].Value.ToString();
                txtEstado.Text = filaSeleccionada.Cells["estadoProceso"].Value.ToString();
                txtResponsable.Text = filaSeleccionada.Cells["Responsable"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            inicializarControles();
        }
    }
}
