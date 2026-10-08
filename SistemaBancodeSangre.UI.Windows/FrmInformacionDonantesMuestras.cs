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
    public partial class FrmInformacionDonantesMuestras : Form
    {
        public FrmInformacionDonantesMuestras()
        {
            InitializeComponent();
        }

        #region Propiedades para Transferir Datos al Formulario Padre
        public int DonanteID { get; private set; }
        public string NombreDonante { get; private set; }
        public string ApellidoDonante { get; private set; }
        public string Sexo { get; private set; }
        public string TipoDonante { get; private set; }
        public int MuestraID { get; private set; }
        public string CodigoMuestra { get; private set; }
        #endregion

       

        #region Carga y Formato de Datos

        private void CargarDatos()
        {
            try
            {
                // Invocación correcta con paréntesis ()
                dgvInfDonMuestras.DataSource = null;
                dgvInfDonMuestras.DataSource = AnalisisBLL.GetDonantesMuestras();

                FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de donantes y muestras: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (dgvInfDonMuestras.Columns.Count == 0) return;

            // Nombres de encabezados limpios
            if (dgvInfDonMuestras.Columns["DonanteID"] != null) dgvInfDonMuestras.Columns["DonanteID"].HeaderText = "ID Donante";
            if (dgvInfDonMuestras.Columns["Nombre"] != null) dgvInfDonMuestras.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvInfDonMuestras.Columns["Apellido"] != null) dgvInfDonMuestras.Columns["Apellido"].HeaderText = "Apellido";
            if (dgvInfDonMuestras.Columns["Sexo"] != null) dgvInfDonMuestras.Columns["Sexo"].HeaderText = "Sexo";
            if (dgvInfDonMuestras.Columns["TipoDonante"] != null) dgvInfDonMuestras.Columns["TipoDonante"].HeaderText = "Tipo Donante";
            if (dgvInfDonMuestras.Columns["MuestraID"] != null) dgvInfDonMuestras.Columns["MuestraID"].HeaderText = "ID Muestra";
            if (dgvInfDonMuestras.Columns["CodigoMuestra"] != null) dgvInfDonMuestras.Columns["CodigoMuestra"].HeaderText = "Código Muestra";

            // Estilos estéticos
            dgvInfDonMuestras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfDonMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfDonMuestras.MultiSelect = false;
            dgvInfDonMuestras.ReadOnly = true;
            dgvInfDonMuestras.AllowUserToAddRows = false;
            dgvInfDonMuestras.RowHeadersVisible = false;

            dgvInfDonMuestras.EnableHeadersVisualStyles = false;
            dgvInfDonMuestras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvInfDonMuestras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInfDonMuestras.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            dgvInfDonMuestras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246);
        }

        #endregion

        private void FrmInformacionDonantesMuestras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvInfDonMuestras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvInfDonMuestras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow filaActual = dgvInfDonMuestras.Rows[e.RowIndex];

                // Extraemos los datos usando el nombre de la propiedad en lugar de índices rígidos
                DonanteID = Convert.ToInt32(filaActual.Cells["DonanteID"].Value);
                NombreDonante = filaActual.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                ApellidoDonante = filaActual.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                Sexo = filaActual.Cells["Sexo"].Value?.ToString() ?? string.Empty;
                TipoDonante = filaActual.Cells["TipoDonante"].Value?.ToString() ?? string.Empty;
                MuestraID = Convert.ToInt32(filaActual.Cells["MuestraID"].Value);
                CodigoMuestra = filaActual.Cells["CodigoMuestra"].Value?.ToString() ?? string.Empty;

                // Devolvemos OK y cerramos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtbuscar.Text.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    CargarDatos();
                    return;
                }

                // Filtrar el objeto anónimo devuelto por la consulta BLL
                var lista = AnalisisBLL.GetDonantesMuestras();

                // Aplicamos un filtro sencillo en memoria para la búsqueda en tiempo real
                dgvInfDonMuestras.DataSource = null;

                // Re-asignamos la lista filtrada
                dgvInfDonMuestras.DataSource = lista;
                FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
