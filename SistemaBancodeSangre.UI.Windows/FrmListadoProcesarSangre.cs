using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;


namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmListadoProcesarSangre : Form
    {
        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
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

        private void btnInforme_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar orientación horizontal para abarcar todas las columnas
                printDoc.DefaultPageSettings.Landscape = true;
                printDoc.PrintPage -= PrintDoc_PrintPage;
                printDoc.PrintPage += PrintDoc_PrintPage;

                // Configurar el diálogo de vista previa
                printPreview.Document = printDoc;
                printPreview.Width = 1150;
                printPreview.Height = 750;
                printPreview.StartPosition = FormStartPosition.CenterScreen;
                printPreview.WindowState = FormWindowState.Maximized;

                // Mostrar la vista previa del reporte
                printPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte de procesamiento de sangre:\n\n" + ex.Message,
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Lógica de Dibujo del Reporte

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes de texto
            Font fontTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Font fontCabecera = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fontContenido = new Font("Segoe UI", 8F, FontStyle.Regular);

            // Colores y pinceles
            Brush brushHeaderBg = new SolidBrush(Color.FromArgb(0, 122, 204)); // Azul primario
            Brush brushTextoBlanco = Brushes.White;
            Brush brushTextoNegro = Brushes.Black;
            Pen penLinea = new Pen(Color.LightGray, 1);

            // Coordenadas iniciales
            int x = 25;
            int y = 30;
            int anchoPagina = e.MarginBounds.Width + 150;

            // 1. Encabezado del Informe
            g.DrawString("SISTEMA BANCO DE SANGRE", fontTitulo, Brushes.DarkRed, x, y);
            y += 28;
            g.DrawString("REPORTE OFICIAL - PROCESAMIENTO Y FRACCIONAMIENTO DE SANGRE", new Font("Segoe UI", 11, FontStyle.Bold), brushTextoNegro, x, y);
            y += 18;
            g.DrawString($"Fecha y Hora de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", fontSubtitulo, Brushes.DimGray, x, y);
            y += 22;

            // Línea divisora
            g.DrawLine(new Pen(Color.DarkRed, 2), x, y, x + anchoPagina, y);
            y += 12;

            // 2. Definición de Columnas y Anchos (Suma ~1040 px)
            int[] anchos = { 50, 95, 95, 75, 75, 80, 110, 110, 85, 70, 75 };
            string[] cabeceras = {
                "ID Pro", "Estado", "F. Proceso", "T. Sangre",
                "Vol. (ML)", "Almacén", "Responsable", "N° Sangre",
                "Glób. Rojos", "Plasma", "Plaquetas"
            };

            // Dibujar fondo de cabecera de la tabla
            g.FillRectangle(brushHeaderBg, x, y, anchoPagina, 26);

            int xTemp = x;
            for (int i = 0; i < cabeceras.Length; i++)
            {
                g.DrawString(cabeceras[i], fontCabecera, brushTextoBlanco, xTemp + 4, y + 5);
                xTemp += anchos[i];
            }

            y += 26;

            // 3. Recorrer los registros del DataGridView
            // Reemplaza 'dgvProcesarSangre' si tu DataGridView se llama de otra forma
            DataGridView grid = dgvProcesamientos;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                xTemp = x;

                // Extraer valores cell por cell
                string idPro = GetCellValue(row, 0);
                string estado = GetCellValue(row, 1);

                string fecha = "";
                var rawFecha = GetCellObject(row, 2);
                if (rawFecha != null && DateTime.TryParse(rawFecha.ToString(), out DateTime dt))
                    fecha = dt.ToString("dd/MM/yyyy");
                else
                    fecha = rawFecha?.ToString() ?? "";

                string tipoSangre = GetCellValue(row, 3);
                string volumen = GetCellValue(row, 4);
                if (!string.IsNullOrEmpty(volumen) && !volumen.EndsWith("ml")) volumen += " ml";

                string almacen = GetCellValue(row, 5);
                string responsable = GetCellValue(row, 6);
                string numSangre = GetCellValue(row, 7);

                // Convertir checkboxes a texto legible (Sí / No)
                string globulosRojos = FormatBoolValue(GetCellObject(row, 8));
                string plasma = FormatBoolValue(GetCellObject(row, 9));
                string plaquetas = FormatBoolValue(GetCellObject(row, 10));

                string[] valores = {
                    idPro, estado, fecha, tipoSangre,
                    volumen, almacen, responsable, numSangre,
                    globulosRojos, plasma, plaquetas
                };

                for (int i = 0; i < valores.Length; i++)
                {
                    RectangleF rectCell = new RectangleF(xTemp + 4, y + 3, anchos[i] - 5, 18);
                    g.DrawString(valores[i], fontContenido, brushTextoNegro, rectCell);
                    xTemp += anchos[i];
                }

                y += 20;
                g.DrawLine(penLinea, x, y, x + anchoPagina, y);

                // Control de salto de página
                if (y > e.MarginBounds.Bottom + 50)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Pie de página
            y += 20;
            g.DrawString($"Total de Registros Procesados: {grid.Rows.Count}", new Font("Segoe UI", 9F, FontStyle.Bold), Brushes.Black, x, y);
        }

        #endregion

        #region Métodos Auxiliares de Lectura

        private string GetCellValue(DataGridViewRow row, int index)
        {
            if (index < row.Cells.Count)
                return row.Cells[index].Value?.ToString() ?? "";
            return "";
        }

        private object GetCellObject(DataGridViewRow row, int index)
        {
            if (index < row.Cells.Count)
                return row.Cells[index].Value;
            return null;
        }

        private string FormatBoolValue(object cellValue)
        {
            if (cellValue == null || cellValue == DBNull.Value) return "No";
            if (bool.TryParse(cellValue.ToString(), out bool result))
            {
                return result ? "Sí" : "No";
            }
            return cellValue.ToString() == "1" || cellValue.ToString().ToLower() == "true" ? "Sí" : "No";
        }

        #endregion
    }
}
