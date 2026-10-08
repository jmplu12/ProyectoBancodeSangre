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
    public partial class FrmListaAnaliticaSangre : Form
    {
        public int IdAnalisisSeleccionado { get; private set; }
        public FrmListaAnaliticaSangre()
        {
            InitializeComponent();
        }

        private void FrmListaAnaliticaSangre_Load(object sender, EventArgs e)
        {
            CargarOpcionesFiltro();
            CargarAnaliticas();
        }

        #region Configuración Inicial y Formato

        private void CargarOpcionesFiltro()
        {
            cboFiltro.Items.Clear();
            cboFiltro.Items.Add("Todos");
            cboFiltro.Items.Add("Analista");
            cboFiltro.Items.Add("Tipo de Sangre");
            cboFiltro.Items.Add("Estado");
            cboFiltro.SelectedIndex = 0; // Por defecto selecciona "Todos"
        }

        private void CargarAnaliticas()
        {
            try
            {
                dgvListaAnalitica.DataSource = null;
                dgvListaAnalitica.DataSource = AnalisisBLL.ObtenerTodas();

                FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las analíticas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (dgvListaAnalitica.Columns.Count == 0) return;

            // Ocultar relaciones internas
            if (dgvListaAnalitica.Columns["MuestraID"] != null) dgvListaAnalitica.Columns["MuestraID"].Visible = false;
            if (dgvListaAnalitica.Columns["Muestra"] != null) dgvListaAnalitica.Columns["Muestra"].Visible = false;

            // Ajustes estéticos generales
            dgvListaAnalitica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaAnalitica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaAnalitica.MultiSelect = false;
            dgvListaAnalitica.ReadOnly = true;
            dgvListaAnalitica.AllowUserToAddRows = false;
            dgvListaAnalitica.RowHeadersVisible = false;

            // Estilos visuales
            dgvListaAnalitica.EnableHeadersVisualStyles = false;
            dgvListaAnalitica.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvListaAnalitica.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListaAnalitica.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvListaAnalitica.ColumnHeadersHeight = 35;

            dgvListaAnalitica.RowsDefaultCellStyle.BackColor = Color.White;
            dgvListaAnalitica.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246);
            dgvListaAnalitica.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgvListaAnalitica.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            EjecutarBusquedaInmediata();
        }


        #endregion



        /// <summary>
        /// Se dispara automáticamente mientras el usuario escribe en el TextBox de búsqueda.
        /// </summary>
        /// 
        private void EjecutarBusquedaInmediata()
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
                string filtroSeleccionado = cboFiltro.SelectedItem?.ToString() ?? "Todos";

                dgvListaAnalitica.DataSource = null;
                dgvListaAnalitica.DataSource = AnalisisBLL.BuscarPorFiltro(criterio, filtroSeleccionado);

                FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListaAnalitica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvListaAnalitica.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                IdAnalisisSeleccionado = Convert.ToInt32(dgvListaAnalitica.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        private void dgvListaAnalitica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && IdAnalisisSeleccionado > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            EjecutarBusquedaInmediata();
        }
    }
}

