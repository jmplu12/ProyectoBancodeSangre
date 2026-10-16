using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.Entities;
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

    public partial class FrmListaDonacion : Form
    {
        private int _idDonacion;

        private bool _modoSeleccion;

        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public int IdDonacion
        {
            get
            {
                return _idDonacion;
            }
        }



        public FrmListaDonacion(bool modoSeleccion = false)
        {
            InitializeComponent();

            _modoSeleccion = modoSeleccion;
        }




        private void InicializarControles()
        {

            dtgDonaciones.AutoGenerateColumns = false;


            dtgDonaciones.ReadOnly = true;


            dtgDonaciones.MultiSelect = false;


            dtgDonaciones.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;


            dtgDonaciones.AllowUserToAddRows = false;


            dtgDonaciones.AllowUserToDeleteRows = false;


            dtgDonaciones.AllowUserToResizeRows = false;


            dtgDonaciones.RowHeadersVisible = false;



            dtgDonaciones.DataSource =
                DonacionesBLL.GetAll();



            dtgDonaciones.ClearSelection();


            txtbuscar.Clear();

            txtbuscar.Focus();

        }





        private void dtgDonaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;



            _idDonacion = Convert.ToInt32(
                dtgDonaciones.CurrentRow.Cells["ID"].Value
            );



            if (_modoSeleccion)
            {

                DialogResult = DialogResult.OK;

                Close();

            }


        }

        private void BuscarDonaciones()
        {

            try
            {

                string busqueda = txtbuscar.Text.Trim();



                // Mostrar todas
                if (string.IsNullOrWhiteSpace(busqueda))
                {

                    dtgDonaciones.DataSource =
                        DonacionesBLL.GetAll();

                    return;

                }





                // Buscar por ID
                if (int.TryParse(busqueda, out int id))
                {

                    DonacionesEntity donacion =
                        DonacionesBLL.ObtenerPorId(id);



                    if (donacion != null)
                    {

                        dtgDonaciones.DataSource =
                            new List<DonacionesEntity> { donacion };

                    }
                    else
                    {

                        dtgDonaciones.DataSource =
                            new List<DonacionesEntity>();

                    }


                    return;

                }





                // Buscar por nombre
                dtgDonaciones.DataSource =
                    DonacionesBLL.ObtenerPorNombre(busqueda);



            }


            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }



        private void FrmListaDonacion_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarDonaciones();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDonaciones();
        }

        private void FrmListaDonacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (dtgDonaciones.CurrentRow != null)
                {

                    _idDonacion =
                        Convert.ToInt32(
                            dtgDonaciones.CurrentRow.Cells["ID"].Value
                        );



                    DialogResult = DialogResult.OK;


                    Close();

                }

            }

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar orientación horizontal (Landscape)
                printDoc.DefaultPageSettings.Landscape = true;
                printDoc.PrintPage -= PrintDoc_PrintPage;
                printDoc.PrintPage += PrintDoc_PrintPage;

                // Configurar cuadro de diálogo de vista previa
                printPreview.Document = printDoc;
                printPreview.Width = 1150;
                printPreview.Height = 750;
                printPreview.StartPosition = FormStartPosition.CenterScreen;
                printPreview.WindowState = FormWindowState.Maximized;

                // Mostrar vista previa
                printPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte de donaciones:\n\n" + ex.Message,
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

            #region Lógica de Dibujo del Reporte Completo de Donaciones

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes de texto
            Font fontTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Font fontCabecera = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Font fontContenido = new Font("Segoe UI", 8F, FontStyle.Regular);

            // Colores y pinceles
            Brush brushHeaderBg = new SolidBrush(Color.FromArgb(0, 122, 204)); // Azul institucional
            Brush brushTextoBlanco = Brushes.White;
            Brush brushTextoNegro = Brushes.Black;
            Pen penLinea = new Pen(Color.LightGray, 1);

            // Margen inicial y ancho usable en horizontal
            int x = 30;
            int y = 30;
            int anchoPagina = e.MarginBounds.Width + 140;

            // 1. Encabezado del Documento
            g.DrawString("SISTEMA BANCO DE SANGRE", fontTitulo, Brushes.DarkRed, x, y);
            y += 28;
            g.DrawString("INFORME COMPLETO DE REGISTRO DE DONACIONES", new Font("Segoe UI", 11, FontStyle.Bold), brushTextoNegro, x, y);
            y += 18;
            g.DrawString($"Fecha y Hora de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", fontSubtitulo, Brushes.DimGray, x, y);
            y += 22;

            // Línea divisora superior
            g.DrawLine(new Pen(Color.DarkRed, 2), x, y, x + anchoPagina, y);
            y += 12;

            // 2. Definición de Columnas y Anchos (Suma ~1030 px)
            int[] anchos = { 40, 90, 90, 110, 85, 80, 80, 95, 170, 85, 45 };

            // 2. Modificar arreglo de cabeceras (mismo orden que la lista visual):
            string[] cabeceras = {
                     "ID Donacion", "Nombre", "Apellidos", "Analista",
                      "Fecha", "T. Sangre", "Cantidad", "N° Sangre",
                     "Proposito", "Envase", "Donante ID"
             };

            // Dibujar fondo de cabecera
            g.FillRectangle(brushHeaderBg, x, y, anchoPagina, 26);

            int xTemp = x;
            for (int i = 0; i < cabeceras.Length; i++)
            {
                g.DrawString(cabeceras[i], fontCabecera, brushTextoBlanco, xTemp + 4, y + 5);
                xTemp += anchos[i];
            }

            y += 26;

            // 3. Recorrer los registros desde el DataGridView
            // Cambia 'dgvDonaciones' si tu DataGridView se llama de otra manera en el formulario
            DataGridView grid = dtgDonaciones;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                xTemp = x;

                // Mapeo seguro comprobando celdas por nombre de propiedad o índice
                string idDonacion = GetCellValue(row, "ID Donacion", 0);
                string nombre = GetCellValue(row, "Nombre", 1);
                string apellidos = GetCellValue(row, "Apellidos", 2);
                string analista = GetCellValue(row, "Analista", 3);

                string fecha = "";
                var rawFecha = GetCellObject(row, "Fecha", 4);
                if (rawFecha != null && DateTime.TryParse(rawFecha.ToString(), out DateTime dt))
                    fecha = dt.ToString("dd/MM/yyyy");

                string tipoSangre = GetCellValue(row, "Tipo de Sangre", 5);
                string cantidadSangre = GetCellValue(row, "Cantidad Sangre", 6) + " ml";
                string numeroSangre = GetCellValue(row, "Numero Sangre", 7);
                string proposito = GetCellValue(row, "Proposito", 8);
                string envase = GetCellValue(row, "Envase", 9);
                string donanteId = GetCellValue(row, "Donante ID", 10);

                // 4. Modificar arreglo de valores final:
                string[] valores = {
                  idDonacion, nombre, apellidos, analista,
                   fecha, tipoSangre, cantidadSangre, numeroSangre,
                    proposito, envase, donanteId
                 };

                for (int i = 0; i < valores.Length; i++)
                {
                    RectangleF rectCell = new RectangleF(xTemp + 4, y + 3, anchos[i] - 6, 18);
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

            // Pie de página con el total acumulado
            y += 20;
            g.DrawString($"Total de Donaciones Registradas: {grid.Rows.Count}", new Font("Segoe UI", 9F, FontStyle.Bold), Brushes.Black, x, y);
        }

        #endregion

        #region Métodos Auxiliares para Lectura Segura

        private string GetCellValue(DataGridViewRow row, string columnName, int defaultIndex)
        {
            if (row.DataGridView.Columns.Contains(columnName))
                return row.Cells[columnName].Value?.ToString() ?? "";

            if (defaultIndex < row.Cells.Count)
                return row.Cells[defaultIndex].Value?.ToString() ?? "";

            return "";
        }

        private object GetCellObject(DataGridViewRow row, string columnName, int defaultIndex)
        {
            if (row.DataGridView.Columns.Contains(columnName))
                return row.Cells[columnName].Value;

            if (defaultIndex < row.Cells.Count)
                return row.Cells[defaultIndex].Value;

            return null;
        }

        #endregion
    }
}
        
    

    

