using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmListaSolicitudes : Form
    {
        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        public FrmListaSolicitudes()
        {

            InitializeComponent();
        }





        #region Lógica de Dibujo del Reporte

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes de texto
            Font fontTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Font fontCabecera = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Font fontContenido = new Font("Segoe UI", 8F, FontStyle.Regular);

            // Colores y pinceles
            Brush brushHeaderBg = new SolidBrush(Color.FromArgb(0, 122, 204)); // Azul primario
            Brush brushTextoBlanco = Brushes.White;
            Brush brushTextoNegro = Brushes.Black;
            Pen penLinea = new Pen(Color.LightGray, 1);

            // Coordenadas iniciales
            int x = 30;
            int y = 30;
            int anchoPagina = e.MarginBounds.Width + 140;

            // 1. Encabezado del Informe
            g.DrawString("SISTEMA BANCO DE SANGRE", fontTitulo, Brushes.DarkRed, x, y);
            y += 28;
            g.DrawString("REPORTE OFICIAL - LISTADO DE SOLICITUDES DE SANGRE", new Font("Segoe UI", 11, FontStyle.Bold), brushTextoNegro, x, y);
            y += 18;
            g.DrawString($"Fecha y Hora de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", fontSubtitulo, Brushes.DimGray, x, y);
            y += 22;

            // Línea divisora
            g.DrawLine(new Pen(Color.DarkRed, 2), x, y, x + anchoPagina, y);
            y += 12;

            // 2. Definición de Columnas y Anchos (Suma total ~1030 px)
            int[] anchos = { 180, 90, 95, 120, 110, 85, 350 };
            string[] cabeceras = {
                "Solicitante", "Prioridad", "Fecha", "T. Sangre Sol.",
                "Carta Médica", "Cantidad", "Motivo"
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
            // Reemplaza 'dgvSolicitudes' si tu DataGridView se llama diferente
            DataGridView grid = dgvSolicitudess;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                xTemp = x;

                // Extraer valores celda por celda según el orden visual
                string solicitante = GetCellValue(row, 0);
                string prioridad = GetCellValue(row, 1);

                string fecha = "";
                var rawFecha = GetCellObject(row, 2);
                if (rawFecha != null && DateTime.TryParse(rawFecha.ToString(), out DateTime dt))
                    fecha = dt.ToString("dd/MM/yyyy");
                else
                    fecha = rawFecha?.ToString() ?? "";

                string tipoSangre = GetCellValue(row, 3);
                string cartaMedica = GetCellValue(row, 4);
                string cantidad = GetCellValue(row, 5);
                string motivo = GetCellValue(row, 6);

                string[] valores = {
                    solicitante, prioridad, fecha, tipoSangre,
                    cartaMedica, cantidad, motivo
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
            g.DrawString($"Total de Solicitudes Registradas: {grid.Rows.Count}", new Font("Segoe UI", 9F, FontStyle.Bold), Brushes.Black, x, y);
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

        #endregion

        private void btninforme_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar orientación horizontal para abarcar todas las columnas holgadamente
                printDoc.DefaultPageSettings.Landscape = true;
                printDoc.PrintPage -= PrintDoc_PrintPage;
                printDoc.PrintPage += PrintDoc_PrintPage;

                // Configurar el diálogo de vista previa
                printPreview.Document = printDoc;
                printPreview.Width = 1100;
                printPreview.Height = 700;
                printPreview.StartPosition = FormStartPosition.CenterScreen;
                printPreview.WindowState = FormWindowState.Maximized;

                // Mostrar la vista previa
                printPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte de solicitudes:\n\n" + ex.Message,
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

        
    


