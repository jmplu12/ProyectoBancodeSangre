using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmEntrega : Form
    {

        private int empleadoId;
        public FrmEntrega(int empleadoId)
        {
            InitializeComponent();
            this.empleadoId = empleadoId;
        }

        private void inicializarControles()
        {
            txtSolicitudID.Text = "";
            txtEntregaID.Text = "0";
            txtTipoSangre.Text = "";
            txtCantidadEntrega.Clear();

        }



        private bool validarDatos()
        {

            if (string.IsNullOrEmpty(txtCantidadEntrega.Text))
            {
                erpEntrega.SetError(txtCantidadEntrega, "El campo Cantidad es obligatorio");
                return false;
            }
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            inicializarControles();
        }

        private void DgvEntregas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filas = DgvEntregas.Rows[e.RowIndex];

                txtSolicitudID.Text = filas.Cells["ID"].Value?.ToString();
                txtCantidadEntrega.Text = filas.Cells["cantidad"].Value?.ToString();
                txtTipoSangre.Text = filas.Cells["tipoDeSangresolicitada"].Value?.ToString();

            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                EntregaEntity entrega = new EntregaEntity();

                entrega.ID = Convert.ToInt32(txtEntregaID.Text);
                entrega.EmpleadoID = this.empleadoId;
                entrega.CantidadEntregada =Convert. ToInt32(txtCantidadEntrega.Text);
                entrega.TipoDeSangre = txtTipoSangre.Text;
                entrega.SolicitudID = Convert.ToInt32(txtSolicitudID.Text);
              

                EntregaBLL.Guardar(entrega);
                inicializarControles();

            }
            catch (Exception ex)

            {
                string errorMessage = ex.Message;

                if (ex.InnerException != null)
                {
                    errorMessage += $"\nDetalles internos: {ex.InnerException.Message}";
                }

                MessageBox.Show($"Ocurrió un error:\n{errorMessage}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if(string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Por favor, ingresa un término para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            DgvEntregas.DataSource = SolicitudBLL.ObtenerSolicitudesDisponibles(filtro);
        }
    }
}
