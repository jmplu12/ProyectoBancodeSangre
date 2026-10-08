using SistemaBancodeSangre.DAL;
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
    public partial class FrmInfProcInventario : Form
    {
        public FrmInfProcInventario()
        {
            InitializeComponent();
        }


        #region Inicializar

        public void InicializarControles()
        {
            dgvDonProc.AutoGenerateColumns = true;

            dgvDonProc.ReadOnly = true;

            dgvDonProc.AllowUserToAddRows = false;

            dgvDonProc.AllowUserToDeleteRows = false;

            dgvDonProc.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDonProc.MultiSelect = false;

            dgvDonProc.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvDonProc.DataSource =
                ProcesamientoDeSangreDAL
                .ObtenerDisponiblesParaInventario();
        }

        #endregion


        #region Load

        private void FrmInfProcInventario_Load(
            object sender,
            EventArgs e)
        {
            InicializarControles();
        }

        #endregion


        #region Seleccionar Procesamiento

        private void dgvDonProc_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            try
            {
                FrmInventario frm =
                    this.Owner as FrmInventario;


                if (frm == null)
                {
                    MessageBox.Show(
                        "No se pudo encontrar el formulario de Inventario.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                DataGridViewRow fila =
                    dgvDonProc.Rows[e.RowIndex];


                // ==========================================
                // PROCESAMIENTO ID
                // ==========================================

                frm.txtProcesoId.Text =
                    fila.Cells["ProcesamientoID"]
                    .Value?
                    .ToString();


                // ==========================================
                // CÓDIGO DE BOLSA
                // ==========================================

                frm.txtCodigoBolsa.Text =
                    fila.Cells["CodigoBolsa"]
                    .Value?
                    .ToString();


                // ==========================================
                // TIPO DE SANGRE
                // ==========================================

                frm.txtTipoSangre.Text =
                    fila.Cells["TipoSangre"]
                    .Value?
                    .ToString();


                // ==========================================
                // CANTIDAD INICIAL
                // ==========================================

                string cantidad =
                    fila.Cells["CantidadInicial"]
                    .Value?
                    .ToString();


                frm.txtCantidadInicial.Text =
                    cantidad;


                // ==========================================
                // CANTIDAD DISPONIBLE
                // ==========================================

                frm.txtCantidadDisponible.Text =
                    cantidad;


                // ==========================================
                // FECHA DE DONACIÓN
                // ==========================================

                object valorFecha =
                    fila.Cells["FechaDonacion"]
                    .Value;


                // ==========================================
                // CERRAR
                // ==========================================

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al seleccionar procesamiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}