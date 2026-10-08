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
    public partial class FrmMantInventario : Form
    {
        public FrmMantInventario()
        {
            InitializeComponent();
        }

        private void inicializacion()
        {
            txtInventarioId.Text = "0";
            txtDonacionID.Text = "0";
            txtCantidadDisponible.Text = "";
            dtpFechaVenc.Text = "";
            //  cboTipoComponentes.Text = "";
            dgvInventario.DataSource = InventarioBLL.ObtenerTodas();
        }
        private bool validarDatos()
        {
            bool validacion = true;

            if (string.IsNullOrEmpty(txtCantidadDisponible.Text))
            {
                erpInventario.SetError(txtCantidadDisponible, "El campo Cantidad es obligatorio");
                validacion = false;
            }

            return validacion;


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
                InventarioEntity inventario = new InventarioEntity
                {
                    ID = Convert.ToInt32(txtInventarioId.Text),
                    FechaVencimiento = Convert.ToDateTime(dtpFechaVenc.Text),
                    CantidadDisponible = Convert.ToInt32(txtCantidadDisponible.Text),
                    TipoSangre = txtTipoSangre.Text,
                    
                };

                InventarioBLL.Guardar(inventario);

                MessageBox.Show("El inventario se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ProcesamientoDeSangreBLL.ActualizarEstadoProceso(Convert.ToInt32(txtProcesoId.Text), "Almacenada en el inventario");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo agregar al inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            inicializacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count > 0)
            {
                int inventarioId = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["ID"].Value);

                var result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este registro del inventario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        InventarioBLL.Borrar(inventarioId);

                        MessageBox.Show("Registro eliminado correctamente del inventario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al eliminar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros seleccionados para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventario.Rows[e.RowIndex];

                txtInventarioId.Text = row.Cells["ID"].Value.ToString();
                dtpFechaVenc.Value = Convert.ToDateTime(row.Cells["fechaVencimiento"].Value);
                txtCantidadDisponible.Text = row.Cells["cantidadDisponible"].Value.ToString();
                txtTipoSangre.Text = row.Cells["TipoSangre"].Value.ToString();
                txtDonacionID.Text = row.Cells["DonacionesID"].Value.ToString();

            }
        }

        private void FrmMantInventario_Load(object sender, EventArgs e)
        {
            inicializacion();
        }
    }
}
