using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
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
    public partial class FrmListadoDeDonantes : Form
    {
        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        public FrmListadoDeDonantes(bool modoSeleccion = false)
        {
            InitializeComponent();

            _modoSeleccion = modoSeleccion;
        }

        private int _idDonante;
        private bool _modoSeleccion;
        public int IdDonante
        {
            get
            {
                return _idDonante;
            }
        }

        private void InicializarControles()
        {
            dgvListaDonantes.AutoGenerateColumns = false;

            dgvListaDonantes.ReadOnly = true;
            dgvListaDonantes.MultiSelect = false;
            dgvListaDonantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvListaDonantes.AllowUserToAddRows = false;
            dgvListaDonantes.AllowUserToDeleteRows = false;
            dgvListaDonantes.AllowUserToResizeRows = false;

            dgvListaDonantes.RowHeadersVisible = false;

            dgvListaDonantes.DataSource = DonanteBLL.GetAll();

            dgvListaDonantes.ClearSelection();

            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void dgvListaDonantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmListadoDeDonantes_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void dgvListaDonantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _idDonante = Convert.ToInt32(
                dgvListaDonantes.CurrentRow.Cells["Id"].Value
            );

            if (_modoSeleccion)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void BuscarDonantes()
        {
            try
            {
                string busqueda = txtbuscar.Text.Trim();

                // Si está vacío, mostrar todos
                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    dgvListaDonantes.DataSource = DonanteBLL.GetAll();
                    return;
                }

                // Buscar por ID
                if (int.TryParse(busqueda, out int id))
                {
                    DonantesEntity donante = DonanteBLL.ObtenerDonantePorId(id);

                    if (donante != null)
                        dgvListaDonantes.DataSource = new List<DonantesEntity> { donante };
                    else
                        dgvListaDonantes.DataSource = new List<DonantesEntity>();

                    return;
                }

                // Buscar por cédula
                if (busqueda.Length == 11 && busqueda.All(char.IsDigit))
                {
                    DonantesEntity donante = DonanteBLL.ObtenerDonanteCedula(busqueda);

                    if (donante != null)
                        dgvListaDonantes.DataSource = new List<DonantesEntity> { donante };
                    else
                        dgvListaDonantes.DataSource = new List<DonantesEntity>();

                    return;
                }
                dgvListaDonantes.ClearSelection();
                // Buscar por nombre o apellido
                dgvListaDonantes.DataSource = DonanteBLL.ObtenerDonantesPorNombre(busqueda);
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarDonantes();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDonantes();
        }

        private void FrmListadoDeDonantes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvListaDonantes.CurrentRow != null)
                {
                    _idDonante = Convert.ToInt32(
                        dgvListaDonantes.CurrentRow.Cells["Id"].Value
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar orientación horizontal para abarcar todas las columnas de donantes
                printDoc.DefaultPageSettings.Landscape = true;
                printDoc.PrintPage -= PrintDoc_PrintPage;
                printDoc.PrintPage += PrintDoc_PrintPage;

                // Configurar el diálogo de vista previa
                printPreview.Document = printDoc;
                printPreview.Width = 1100;
                printPreview.Height = 750;
                printPreview.StartPosition = FormStartPosition.CenterScreen;
                printPreview.WindowState = FormWindowState.Maximized;

                // Mostrar la vista previa
                printPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte de donantes:\n\n" + ex.Message,
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Lógica de Dibujo del Reporte de Donantes

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fuentes de texto
            Font fontTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            Font fontCabecera = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fontContenido = new Font("Segoe UI", 7.5F, FontStyle.Regular);

            // Colores y pinceles
            Brush brushHeaderBg = new SolidBrush(Color.FromArgb(0, 122, 204)); // Azul institucional
            Brush brushTextoBlanco = Brushes.White;
            Brush brushTextoNegro = Brushes.Black;
            Pen penLinea = new Pen(Color.LightGray, 1);

            // Margen inicial y ancho usable en horizontal
            int x = 20;
            int y = 30;
            int anchoPagina = e.MarginBounds.Width + 160;

            // 1. Encabezado del Documento
            g.DrawString("SISTEMA BANCO DE SANGRE", fontTitulo, Brushes.DarkRed, x, y);
            y += 28;
            g.DrawString("INFORME COMPLETO DE REGISTRO DE DONANTES", new Font("Segoe UI", 11, FontStyle.Bold), brushTextoNegro, x, y);
            y += 18;
            g.DrawString($"Fecha y Hora de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", fontSubtitulo, Brushes.DimGray, x, y);
            y += 22;

            // Línea divisora
            g.DrawLine(new Pen(Color.DarkRed, 2), x, y, x + anchoPagina, y);
            y += 12;

            // 2. Definición de Columnas y Anchos (Suma total alineada con la página)
            // ID, Nombre, Apellido, Cédula, Teléfono, Sexo, Edad, Peso, T.Sangre, T.Donante, F.Nac, Correo, Prov/Mun, Dirección
            int[] anchos = { 35, 80, 80, 75, 70, 50, 35, 45, 55, 65, 65, 110, 100, 120 };
            string[] cabeceras = {
                "ID", "Nombre", "Apellido", "Cédula", "Teléfono",
                "Sexo", "Edad", "Peso", "T.Sang", "T.Donante", "F.Nac",
                "Correo", "Ubicación", "Dirección"
            };

            // Dibujar fondo de cabecera
            g.FillRectangle(brushHeaderBg, x, y, anchoPagina, 26);

            int xTemp = x;
            for (int i = 0; i < cabeceras.Length; i++)
            {
                g.DrawString(cabeceras[i], fontCabecera, brushTextoBlanco, xTemp + 3, y + 5);
                xTemp += anchos[i];
            }

            y += 26;

            // 3. Recorrer los registros desde el DataGridView
            DataGridView grid = dgvListaDonantes; // Reemplazar con el nombre exacto de tu DataGridView

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                xTemp = x;

                // Mapeo seguro comprobando celdas por nombre de propiedad o índice
                string id = GetCellValue(row, "ID", 0);
                string nombre = GetCellValue(row, "Nombre", 1);
                string apellido = GetCellValue(row, "Apellido", 2);
                string cedula = GetCellValue(row, "Cedula", 3);
                string telefono = GetCellValue(row, "Telefono", 4);
                string sexo = GetCellValue(row, "Sexo", 5);
                string edad = GetCellValue(row, "Edad", 6);
                string peso = GetCellValue(row, "PesoKlg", 7);
                string tipoSangre = GetCellValue(row, "TipoDeSangre", 8);
                string tipoDonante = GetCellValue(row, "TipodeDonante", 9);

                string fNac = "";
                var rawFNac = GetCellObject(row, "FechaNacimiento", 10);
                if (rawFNac != null && DateTime.TryParse(rawFNac.ToString(), out DateTime dt))
                    fNac = dt.ToString("dd/MM/yyyy");

                string correo = GetCellValue(row, "Correo", 11);

                string provincia = GetCellValue(row, "Provincia", 12);
                string municipio = GetCellValue(row, "Municipio", 13);
                string ubicacion = $"{provincia} / {municipio}".Trim('/', ' ');

                string direccion = GetCellValue(row, "Direccion", 14);

                string[] valores = {
                    id, nombre, apellido, cedula, telefono,
                    sexo, edad, peso, tipoSangre, tipoDonante, fNac,
                    correo, ubicacion, direccion
                };

                for (int i = 0; i < valores.Length; i++)
                {
                    RectangleF rectCell = new RectangleF(xTemp + 3, y + 3, anchos[i] - 5, 18);
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
            g.DrawString($"Total de Donantes Registrados: {grid.Rows.Count}", new Font("Segoe UI", 9F, FontStyle.Bold), Brushes.Black, x, y);
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
    

