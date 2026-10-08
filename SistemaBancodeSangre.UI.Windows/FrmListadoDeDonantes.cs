using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
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
    public partial class FrmListadoDeDonantes : Form
    {
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
    }
}
