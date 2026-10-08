using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SistemaBancodeSangre.BLL;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmInformacionProcesamiento : Form
    {
        public int IdDonacion { get; private set; }
        public string NombreDonante { get; private set; }

        public string ApellidoDonante { get; private set; }
        public string NumeroSangre { get; private set; }

        public string TipoDeSangre { get; private set; }

        public double CantidadSangre { get; private set; }

        private List<DonacionSeleccionada> ListaDonaciones =
            new List<DonacionSeleccionada>();


        public FrmInformacionProcesamiento()
        {
            InitializeComponent();
        }


        private class DonacionSeleccionada
        {
            public int DonacionID { get; set; }

            public string NumeroSangre { get; set; }

            public string TipoSangre { get; set; }

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public double CantidadSangre { get; set; }
        }


        private void FrmInformacionProcesamiento_Load(
            object sender,
            EventArgs e)
        {
            InicializarDatos();

            txtbuscar.Clear();

            txtbuscar.Focus();
        }


        private void InicializarDatos()
        {
            try
            {
                var datos =
                    ProcesamientoDeSangreBLL
                    .ObtenerDonacionesDisponibles();

                ListaDonaciones.Clear();

                foreach (var item in datos)
                {
                    DonacionSeleccionada donacion =
                        new DonacionSeleccionada();

                    donacion.DonacionID =
                        ObtenerInt(
                            item,
                            "DonacionID",
                            "ID");

                    donacion.NumeroSangre =
                        ObtenerString(
                            item,
                            "NumeroSangre");

                    donacion.TipoSangre =
                        ObtenerString(
                            item,
                            "TipoSangre",
                            "TipoDeSangre");

                    donacion.Nombre =
                        ObtenerString(
                            item,
                            "Nombre");

                    donacion.Apellido =
                        ObtenerString(
                            item,
                            "Apellido");

                    donacion.CantidadSangre =
                        ObtenerDouble(
                            item,
                            "CantidadSangre");

                    ListaDonaciones.Add(donacion);
                }

                dgvDonantes.AutoGenerateColumns = true;

                dgvDonantes.DataSource =
                    ListaDonaciones;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las donaciones disponibles.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private string ObtenerString(
            object objeto,
            params string[] nombres)
        {
            if (objeto == null)
            {
                return "";
            }

            Type tipo =
                objeto.GetType();

            foreach (string nombre in nombres)
            {
                PropertyInfo propiedad =
                    tipo.GetProperty(
                        nombre,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.IgnoreCase);

                if (propiedad != null)
                {
                    object valor =
                        propiedad.GetValue(objeto);

                    if (valor != null)
                    {
                        return valor.ToString();
                    }
                }
            }

            return "";
        }


        private int ObtenerInt(
            object objeto,
            params string[] nombres)
        {
            string valor =
                ObtenerString(
                    objeto,
                    nombres);

            if (int.TryParse(
                valor,
                out int resultado))
            {
                return resultado;
            }

            return 0;
        }


        private double ObtenerDouble(
            object objeto,
            params string[] nombres)
        {
            string valor =
                ObtenerString(
                    objeto,
                    nombres);

            if (double.TryParse(
                valor,
                out double resultado))
            {
                return resultado;
            }

            return 0;
        }


        private void ConfigurarDataGridView()
        {
            dgvDonantes.ReadOnly = true;

            dgvDonantes.AllowUserToAddRows = false;

            dgvDonantes.AllowUserToDeleteRows = false;

            dgvDonantes.AllowUserToResizeRows = false;

            dgvDonantes.MultiSelect = false;

            dgvDonantes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDonantes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDonantes.RowHeadersVisible = false;


            if (dgvDonantes.Columns.Contains(
                "DonacionID"))
            {
                dgvDonantes.Columns[
                    "DonacionID"].HeaderText =
                    "ID DONACIÓN";

                dgvDonantes.Columns[
                    "DonacionID"].FillWeight = 25;
            }


            if (dgvDonantes.Columns.Contains(
                "NumeroSangre"))
            {
                dgvDonantes.Columns[
                    "NumeroSangre"].HeaderText =
                    "NÚMERO DE SANGRE";

                dgvDonantes.Columns[
                    "NumeroSangre"].FillWeight = 45;
            }


            if (dgvDonantes.Columns.Contains(
                "TipoSangre"))
            {
                dgvDonantes.Columns[
                    "TipoSangre"].HeaderText =
                    "TIPO DE SANGRE";

                dgvDonantes.Columns[
                    "TipoSangre"].FillWeight = 30;
            }


            if (dgvDonantes.Columns.Contains(
                "Nombre"))
            {
                dgvDonantes.Columns[
                    "Nombre"].HeaderText =
                    "NOMBRE";

                dgvDonantes.Columns[
                    "Nombre"].FillWeight = 40;
            }


            if (dgvDonantes.Columns.Contains(
                "Apellido"))
            {
                dgvDonantes.Columns[
                    "Apellido"].HeaderText =
                    "APELLIDO";

                dgvDonantes.Columns[
                    "Apellido"].FillWeight = 40;
            }


            if (dgvDonantes.Columns.Contains(
                "CantidadSangre"))
            {
                dgvDonantes.Columns[
                    "CantidadSangre"].HeaderText =
                    "CANTIDAD DE SANGRE";

                dgvDonantes.Columns[
                    "CantidadSangre"].FillWeight = 35;
            }
        }


        private void dgvDonantes_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                DataGridViewRow fila =
                    dgvDonantes.Rows[e.RowIndex];

                string nombre =
   fila.Cells["Nombre"].Value
   ?.ToString()
   ?? "";

                string apellido =
                    fila.Cells["Apellido"].Value
                    ?.ToString()
                    ?? "";
                int idDonacion =
                    Convert.ToInt32(
                        fila.Cells[
                            "DonacionID"].Value);


                string numeroSangre =
                    fila.Cells[
                        "NumeroSangre"].Value
                    ?.ToString()
                    ?? "";


                string tipoSangre =
                    fila.Cells[
                        "TipoSangre"].Value
                    ?.ToString()
                    ?? "";


                double cantidadSangre =
                    Convert.ToDouble(
                        fila.Cells[
                            "CantidadSangre"].Value);


                IdDonacion = idDonacion;

                NumeroSangre = numeroSangre;

                TipoDeSangre = tipoSangre;

                CantidadSangre = cantidadSangre;

                NombreDonante = nombre;

                ApellidoDonante = apellido;

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar " +
                    "la donación.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void txtbuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            BuscarDonacionAutomaticamente();
        }


        private void BuscarDonacionAutomaticamente()
        {
            try
            {
                string textoBuscar =
                    txtbuscar.Text.Trim();


                if (string.IsNullOrWhiteSpace(
                    textoBuscar))
                {
                    dgvDonantes.DataSource =
                        ListaDonaciones;

                    ConfigurarDataGridView();

                    return;
                }


                var resultados =
                    ListaDonaciones
                    .Where(x =>
                        x.DonacionID
                            .ToString()
                            .IndexOf(
                                textoBuscar,
                                StringComparison
                                    .OrdinalIgnoreCase) >= 0

                        ||

                        x.NumeroSangre
                            .IndexOf(
                                textoBuscar,
                                StringComparison
                                    .OrdinalIgnoreCase) >= 0

                        ||

                        x.TipoSangre
                            .IndexOf(
                                textoBuscar,
                                StringComparison
                                    .OrdinalIgnoreCase) >= 0

                        ||

                        x.Nombre
                            .IndexOf(
                                textoBuscar,
                                StringComparison
                                    .OrdinalIgnoreCase) >= 0

                        ||

                        x.Apellido
                            .IndexOf(
                                textoBuscar,
                                StringComparison
                                    .OrdinalIgnoreCase) >= 0
                    )
                    .ToList();


                dgvDonantes.DataSource =
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
    }
}