using SistemaBancodeSangre.BLL;
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
    public partial class FrmListaDonacion : Form
    {
        private int _idDonacion;

        private bool _modoSeleccion;


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

    }
}
    

