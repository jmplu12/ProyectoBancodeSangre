using SistemaBancodeSangre.BLL;
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
    public partial class FrmDistribucion : Form
    {
        public FrmDistribucion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void inicializarControles()
        {
            dgvDistribucion.DataSource = SolicitudBLL.ObtenerEstados();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas autorizar esta solicitud?",
                                                      "Confirmar autorización",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                CambiarEstadoSolicitud("Autorizada");
            }
        }

        private void btnDeclinar_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas autorizar esta solicitud?",
                                                      "Confirmar Declinar",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                CambiarEstadoSolicitud("Declinada");
            }
        }

       
            private void CambiarEstadoSolicitud(string nuevoEstado)
            {
                try
                {
                    if (dgvDistribucion.SelectedRows.Count > 0)
                    {
      int solicitudId = Convert.ToInt32(dgvDistribucion.SelectedRows[0].Cells["ID"].Value);
      string tipoSangre = dgvDistribucion.SelectedRows[0].Cells["tipoDeSangresolicitada"].Value.ToString();
      int cantidadSolicitada = Convert.ToInt32(dgvDistribucion.SelectedRows[0].Cells["cantidad"].Value);

                        // Cambiar el estado de la solicitud
                        SolicitudBLL.ActualizarEstado(solicitudId, nuevoEstado);

                        // Si la solicitud es autorizada, restar del inventario
                        if (nuevoEstado == "Autorizada")
                        {
                            SolicitudBLL.RestarInventario(tipoSangre, cantidadSolicitada);
                        }

                        inicializarControles();
                        MessageBox.Show($"Estado cambiado a '{nuevoEstado}' con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una solicitud.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        private void FrmDistribucion_Load(object sender, EventArgs e)
        {
            inicializarControles();
        }
    }
}
