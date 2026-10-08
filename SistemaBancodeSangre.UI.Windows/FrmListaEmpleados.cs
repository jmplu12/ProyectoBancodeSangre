using SistemaBancodeSangre.BLL;
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
using System.IO;
// Word
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

// PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using DocumentFormat.OpenXml;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private int _IdEmpleado;

        public int IdEmpleado
        {
            get
            {
                return _IdEmpleado;
            }
        }

        private void InicializarControles()
        {
            dgvRegistroEmpleados.AutoGenerateColumns = false;
            dgvRegistroEmpleados.DataSource = EmpleadosDAL.GetAll().ToList();
        }
        private void dgvRegistroEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InicializarControles();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            cboBuscarPor.Items.Add("Nombre");
            cboBuscarPor.Items.Add("Cédula");
            cboBuscarPor.Items.Add("Cargo");
            cboBuscarPor.Items.Add("Teléfono");

            cboBuscarPor.SelectedIndex = 0;


            cboEstado.Items.Add("Todos");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");

            cboEstado.SelectedIndex = 0;



            InicializarControles();
        }

        private void dgvRegistroEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            _IdEmpleado = (int)dgvRegistroEmpleados.CurrentRow.Cells["ID"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }



        private void BuscarEmpleados()
        {

            string campo =
            cboBuscarPor.Text;


            string texto =
            txtBuscarEmpleado.Text.Trim();


            string estado =
            cboEstado.Text;



            var lista =
            EmpleadoBLL.BuscarEmpleado(
            campo,
            texto,
            estado)
            .ToList();



            dgvRegistroEmpleados.DataSource = lista;



            //lblTotalEmpleados.Text =
            // "Total empleados: " + lista.Count;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string campo = cboBuscarPor.Text;

            string texto = txtBuscarEmpleado.Text.Trim();

            string estado = cboEstado.Text;


            var lista = EmpleadoBLL.BuscarEmpleado(
                campo,
                texto,
                estado
            ).ToList();



            dgvRegistroEmpleados.DataSource = lista;


            lblTotalEmpleados.Text =
            "Total empleados: " + lista.Count;

        }

        private void dgvRegistroEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InicializarControles();
        }

        private void btnBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }

        private void cboBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }



        

        private void ExportarPDF(string ruta)
        {
            try
            {
                iTextSharp.text.Document documento =
                    new iTextSharp.text.Document();


                PdfWriter.GetInstance(
                    documento,
                    new FileStream(ruta, FileMode.Create)
                );


                documento.Open();


                // Título
                documento.Add(
                    new iTextSharp.text.Paragraph(
                        "BANCO DE SANGRE\nLISTADO DE EMPLEADOS\n\n"
                    )
                );


                PdfPTable tabla =
                    new PdfPTable(
                        dgvRegistroEmpleados.Columns.Count
                    );


                // Encabezados
                foreach (DataGridViewColumn columna
                    in dgvRegistroEmpleados.Columns)
                {
                    tabla.AddCell(
                        new Phrase(
                            columna.HeaderText
                        )
                    );
                }


                // Datos
                foreach (DataGridViewRow fila
                    in dgvRegistroEmpleados.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        foreach (DataGridViewCell celda
                            in fila.Cells)
                        {
                            tabla.AddCell(
                                new Phrase(
                                    celda.Value?.ToString() ?? ""
                                )
                            );
                        }
                    }
                }


                documento.Add(tabla);


                documento.Close();


                MessageBox.Show(
                    "Reporte PDF guardado correctamente.",
                    "Reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar PDF: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.Title = "Guardar reporte PDF";
            guardar.FileName = "ReporteBancoSangre.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = guardar.FileName;

                // Aquí llamas tu método que genera el PDF
                ExportarPDF(ruta);

                MessageBox.Show("Reporte guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnExportarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Documento Word (*.docx)|*.docx";
            guardar.Title = "Guardar reporte Word";
            guardar.FileName = "ReporteBancoSangre.docx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = guardar.FileName;

                //ExportarWord(ruta);

                MessageBox.Show("Documento Word guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
