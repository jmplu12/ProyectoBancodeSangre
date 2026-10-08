using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.Entities;


namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmListadoProcesarSangre : Form
    {
        private List<ProcesamientoDeSangreEntity> ListaProcesamientos =
            new List<ProcesamientoDeSangreEntity>();


        public FrmListadoProcesarSangre()
        {
            InitializeComponent();
        }


        #region Cargar Datos

        private void InicializarDatos()
        {
            try
            {
                ListaProcesamientos =
                    ProcesamientoDeSangreBLL
                    .ObtenerTodas()
                    .ToList();

                dgvProcesamientos.AutoGenerateColumns = true;

                dgvProcesamientos.DataSource =
                    ListaProcesamientos;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los procesamientos de sangre.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Configurar DataGridView

        private void ConfigurarDataGridView()
        {
            dgvProcesamientos.ReadOnly = true;

            dgvProcesamientos.AllowUserToAddRows = false;

            dgvProcesamientos.AllowUserToDeleteRows = false;

            dgvProcesamientos.AllowUserToResizeRows = false;

            dgvProcesamientos.MultiSelect = false;

            dgvProcesamientos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProcesamientos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProcesamientos.RowHeadersVisible = false;

            dgvProcesamientos.AllowUserToResizeColumns = false;

            dgvProcesamientos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;


            // =====================================================
            // OCULTAR COLUMNAS QUE NO NECESITAMOS MOSTRAR
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("DonacionesID"))
            {
                dgvProcesamientos.Columns["DonacionesID"].Visible = false;
            }

            if (dgvProcesamientos.Columns.Contains("AnalisisID"))
            {
                dgvProcesamientos.Columns["AnalisisID"].Visible = false;
            }

            if (dgvProcesamientos.Columns.Contains("MuestraID"))
            {
                dgvProcesamientos.Columns["MuestraID"].Visible = false;
            }


            // =====================================================
            // ID PROCESAMIENTO
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("ID"))
            {
                dgvProcesamientos.Columns["ID"].HeaderText =
                    "ID PROCESO";

                dgvProcesamientos.Columns["ID"].FillWeight = 20;
            }


            // =====================================================
            // NUMERO DE SANGRE
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("NumeroSangre"))
            {
                dgvProcesamientos.Columns["NumeroSangre"].HeaderText =
                    "NÚMERO DE SANGRE";

                dgvProcesamientos.Columns["NumeroSangre"].FillWeight = 45;
            }


            // =====================================================
            // TIPO DE SANGRE
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("TipoDeSangre"))
            {
                dgvProcesamientos.Columns["TipoDeSangre"].HeaderText =
                    "TIPO DE SANGRE";

                dgvProcesamientos.Columns["TipoDeSangre"].FillWeight = 30;
            }


            // =====================================================
            // VOLUMEN
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("VolumenDN"))
            {
                dgvProcesamientos.Columns["VolumenDN"].HeaderText =
                    "VOLUMEN (ML)";

                dgvProcesamientos.Columns["VolumenDN"].FillWeight = 30;
            }


            // =====================================================
            // ESTADO
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("EstadoProceso"))
            {
                dgvProcesamientos.Columns["EstadoProceso"].HeaderText =
                    "ESTADO";

                dgvProcesamientos.Columns["EstadoProceso"].FillWeight = 40;
            }


            // =====================================================
            // ALMACENADO
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("Almacenado"))
            {
                dgvProcesamientos.Columns["Almacenado"].HeaderText =
                    "ALMACENAMIENTO";

                dgvProcesamientos.Columns["Almacenado"].FillWeight = 40;
            }


            // =====================================================
            // RESPONSABLE
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("Responsable"))
            {
                dgvProcesamientos.Columns["Responsable"].HeaderText =
                    "RESPONSABLE";

                dgvProcesamientos.Columns["Responsable"].FillWeight = 40;
            }


            // =====================================================
            // FECHA
            // =====================================================

            if (dgvProcesamientos.Columns.Contains("FechaProceso"))
            {
                dgvProcesamientos.Columns["FechaProceso"].HeaderText =
                    "FECHA PROCESO";

                dgvProcesamientos.Columns["FechaProceso"].DefaultCellStyle
                    .Format = "dd/MM/yyyy";

                dgvProcesamientos.Columns["FechaProceso"].FillWeight = 35;
            }


            // =====================================================
            // COMPONENTES
            // =====================================================

            if (dgvProcesamientos.Columns.Contains(
                "ConcentradoGlobulosRojos"))
            {
                dgvProcesamientos.Columns[
                    "ConcentradoGlobulosRojos"].HeaderText =
                    "GLÓBULOS ROJOS";

                dgvProcesamientos.Columns[
                    "ConcentradoGlobulosRojos"].FillWeight = 35;
            }


            if (dgvProcesamientos.Columns.Contains("Plasma"))
            {
                dgvProcesamientos.Columns["Plasma"].HeaderText =
                    "PLASMA";

                dgvProcesamientos.Columns["Plasma"].FillWeight = 25;
            }


            if (dgvProcesamientos.Columns.Contains("Plaquetas"))
            {
                dgvProcesamientos.Columns["Plaquetas"].HeaderText =
                    "PLAQUETAS";

                dgvProcesamientos.Columns["Plaquetas"].FillWeight = 30;
            }
        }

        #endregion


        #region Buscar Automáticamente

        private void BuscarProcesamientoAutomaticamente()
        {
            try
            {
                string textoBuscar =
                    txtbuscar.Text.Trim();

                // =================================================
                // SI ESTÁ VACÍO, MOSTRAR TODO
                // =================================================

                if (string.IsNullOrWhiteSpace(textoBuscar))
                {
                    dgvProcesamientos.DataSource =
                        ListaProcesamientos;

                    ConfigurarDataGridView();

                    return;
                }


                // =================================================
                // BUSCAR
                // =================================================

                var resultados =
                    ListaProcesamientos
                    .Where(x =>
                    {
                        string id =
                            x.ID.ToString();

                        string numeroSangre =
                            x.NumeroSangre ?? "";

                        string tipoSangre =
                            x.TipoDeSangre ?? "";

                        string estado =
                            x.EstadoProceso ?? "";

                        string almacenado =
                            x.Almacenado ?? "";

                        string responsable =
                            x.Responsable ?? "";


                        return
                            id.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0

                            ||

                            numeroSangre.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0

                            ||

                            tipoSangre.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0

                            ||

                            estado.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0

                            ||

                            almacenado.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0

                            ||

                            responsable.IndexOf(
                                textoBuscar,
                                StringComparison.OrdinalIgnoreCase) >= 0;
                    })
                    .ToList();


                // =================================================
                // MOSTRAR RESULTADOS
                // =================================================

                dgvProcesamientos.DataSource =
                    resultados;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error durante la búsqueda.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Eventos

        private void FrmListadoProcesarSangre_Load(
            object sender,
            EventArgs e)
        {
            InicializarDatos();

            txtbuscar.Clear();

            txtbuscar.Focus();
        }


        private void txtbuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            BuscarProcesamientoAutomaticamente();
        }


        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        #endregion

        private void txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            BuscarProcesamientoAutomaticamente();
        }
    }
}