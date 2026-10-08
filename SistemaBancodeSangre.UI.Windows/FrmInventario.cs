using SistemaBancodeSangre.DAL;
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
    public partial class FrmInventario : Form
    {
      
        public FrmInventario()
        {
            InitializeComponent();
        }


        #region Inicialización

        private void Inicializacion()
        {
            txtInventarioId.Text = "0";

            txtProcesoId.Text = "0";

            txtCodigoBolsa.Clear();

            txtTipoSangre.Clear();

            txtCantidadInicial.Clear();

            txtCantidadDisponible.Clear();

            dtpFechaDonacion.Value = DateTime.Today;

            dtpFechaVenc.Value =
                DateTime.Today.AddDays(35);

            // El estado ya no será seleccionado manualmente.
            // El BLL lo determina automáticamente.

            cboEstado.Items.Clear();

            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Agotándose");
            cboEstado.Items.Add("Agotada");
            cboEstado.Items.Add("Reservada");
            cboEstado.Items.Add("Utilizada");
            cboEstado.Items.Add("Vencida");
            cboEstado.Items.Add("Descartada");

            cboEstado.SelectedIndex = 0;

            // El ComboBox solamente muestra el estado.
            cboEstado.Enabled = false;

            erpInventario.Clear();

            ConfigurarDataGridView();

            CargarInventario();
        }

        #endregion

        #region Configurar DataGridView

        private void ConfigurarDataGridView()
        {
            dgvInventario.AutoGenerateColumns = false;

            dgvInventario.ReadOnly = true;

            dgvInventario.AllowUserToAddRows = false;

            dgvInventario.AllowUserToDeleteRows = false;

            dgvInventario.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvInventario.MultiSelect = false;

            dgvInventario.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Cargar Inventario

        private void CargarInventario()
        {
            try
            {
                // Actualizamos automáticamente los estados
                // antes de cargar el inventario.

                InventarioDAL.ActualizarEstados();

                dgvInventario.DataSource = null;

                dgvInventario.DataSource =
                    InventarioBLL.ObtenerTodas().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Validaciones

        private bool ValidarDatos()
        {
            bool validacion = true;

            erpInventario.Clear();


            // ==========================================
            // CÓDIGO DE BOLSA
            // ==========================================

            if (string.IsNullOrWhiteSpace(
                txtCodigoBolsa.Text))
            {
                erpInventario.SetError(
                    txtCodigoBolsa,
                    "El código de bolsa es obligatorio.");

                validacion = false;
            }


            // ==========================================
            // PROCESAMIENTO
            // ==========================================

            if (!int.TryParse(
                txtProcesoId.Text,
                out int procesoID)
                || procesoID <= 0)
            {
                erpInventario.SetError(
                    txtProcesoId,
                    "Debe seleccionar un procesamiento válido.");

                validacion = false;
            }


            // ==========================================
            // TIPO DE SANGRE
            // ==========================================

            if (string.IsNullOrWhiteSpace(
                txtTipoSangre.Text))
            {
                erpInventario.SetError(
                    txtTipoSangre,
                    "El tipo de sangre es obligatorio.");

                validacion = false;
            }


            // ==========================================
            // CANTIDAD INICIAL
            // ==========================================

            if (!int.TryParse(
                txtCantidadInicial.Text,
                out int cantidadInicial)
                || cantidadInicial <= 0)
            {
                erpInventario.SetError(
                    txtCantidadInicial,
                    "La cantidad inicial debe ser mayor que cero.");

                validacion = false;
            }


            // ==========================================
            // CANTIDAD DISPONIBLE
            // ==========================================

            if (!int.TryParse(
                txtCantidadDisponible.Text,
                out int cantidadDisponible)
                || cantidadDisponible < 0)
            {
                erpInventario.SetError(
                    txtCantidadDisponible,
                    "La cantidad disponible no es válida.");

                validacion = false;
            }


            // ==========================================
            // DISPONIBLE NO MAYOR QUE INICIAL
            // ==========================================

            if (int.TryParse(
                txtCantidadInicial.Text,
                out int inicial)
                &&
                int.TryParse(
                    txtCantidadDisponible.Text,
                    out int disponible))
            {
                if (disponible > inicial)
                {
                    erpInventario.SetError(
                        txtCantidadDisponible,
                        "La cantidad disponible no puede ser mayor que la cantidad inicial.");

                    validacion = false;
                }
            }


            // ==========================================
            // FECHA DONACIÓN
            // ==========================================

            if (dtpFechaDonacion.Value.Date >
                DateTime.Today)
            {
                erpInventario.SetError(
                    dtpFechaDonacion,
                    "La fecha de donación no puede ser futura.");

                validacion = false;
            }


            // ==========================================
            // FECHA VENCIMIENTO
            // ==========================================

            if (dtpFechaVenc.Value.Date <=
                dtpFechaDonacion.Value.Date)
            {
                erpInventario.SetError(
                    dtpFechaVenc,
                    "La fecha de vencimiento debe ser posterior a la fecha de donación.");

                validacion = false;
            }


            return validacion;
        }

        #endregion

        #region Guardar

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show(
                    "Complete correctamente los campos obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {
                InventarioEntity inventario =
                    new InventarioEntity();


                // ==========================================
                // ID
                // ==========================================

                inventario.ID =
                    Convert.ToInt32(
                        txtInventarioId.Text);


                // ==========================================
                // CÓDIGO
                // ==========================================

                inventario.CodigoBolsa =
                    txtCodigoBolsa.Text.Trim();


                // ==========================================
                // TIPO DE SANGRE
                // ==========================================

                inventario.TipoSangre =
                    txtTipoSangre.Text.Trim();


                // ==========================================
                // CANTIDADES
                // ==========================================

                inventario.CantidadInicial =
                    Convert.ToInt32(
                        txtCantidadInicial.Text);

                inventario.CantidadDisponible =
                    Convert.ToInt32(
                        txtCantidadDisponible.Text);


                // ==========================================
                // FECHAS
                // ==========================================

                inventario.FechaDonacion =
                    dtpFechaDonacion.Value.Date;

                inventario.FechaVencimiento =
                    dtpFechaVenc.Value.Date;


                // ==========================================
                // ESTADO
                // ==========================================

                /*
                 * IMPORTANTE:
                 *
                 * No tomamos el estado desde el ComboBox.
                 *
                 * InventarioBLL.Guardar() se encargará
                 * de determinar automáticamente:
                 *
                 * Disponible
                 * Agotándose
                 * Agotada
                 * Vencida
                 */

                inventario.Estado =
                    "Disponible";


                // ==========================================
                // FECHA REGISTRO
                // ==========================================

                inventario.FechaRegistro =
                    DateTime.Now;


                // ==========================================
                // PROCESAMIENTO
                // ==========================================

                inventario.ProcesamientoID =
                    Convert.ToInt32(
                        txtProcesoId.Text);


                // ==========================================
                // EMPLEADO
                // ==========================================

                if (!int.TryParse(
                    txtEmpleadoID.Text,
                    out int empleadoID)
                    || empleadoID <= 0)
                {
                    MessageBox.Show(
                        "No se pudo determinar el empleado responsable.",
                        "Empleado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                inventario.EmpleadoID =
                    empleadoID;


                // ==========================================
                // GUARDAR
                // ==========================================

                InventarioBLL.Guardar(
                    inventario);


                // ==========================================
                // ACTUALIZAR ESTADOS
                // ==========================================

                InventarioDAL.ActualizarEstados();


                // ==========================================
                // ACTUALIZAR PROCESAMIENTO
                // ==========================================

                ProcesamientoDeSangreBLL
                    .ActualizarEstadoProceso(
                        inventario.ProcesamientoID,
                        "Almacenada en el inventario");


                MessageBox.Show(
                    "El inventario se registró correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                CargarInventario();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo guardar el inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Seleccionar registro

        private void dgvInventario_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            try
            {
                InventarioEntity inventario =
                    dgvInventario.Rows[e.RowIndex]
                    .DataBoundItem as InventarioEntity;


                if (inventario == null)
                    return;


                txtInventarioId.Text =
                    inventario.ID.ToString();


                txtProcesoId.Text =
                    inventario.ProcesamientoID.ToString();


                txtCodigoBolsa.Text =
                    inventario.CodigoBolsa;


                txtTipoSangre.Text =
                    inventario.TipoSangre;


                txtCantidadInicial.Text =
                    inventario.CantidadInicial.ToString();


                txtCantidadDisponible.Text =
                    inventario.CantidadDisponible.ToString();


                dtpFechaDonacion.Value =
                    inventario.FechaDonacion;


                dtpFechaVenc.Value =
                    inventario.FechaVencimiento;


                // Mostrar el estado actual.
                cboEstado.SelectedItem =
                    inventario.Estado;


                if (inventario.EmpleadoID.HasValue)
                {
                    txtEmpleadoID.Text =
                        inventario.EmpleadoID.Value.ToString();
                }
                else
                {
                    txtEmpleadoID.Clear();
                }
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

        #endregion


        #region Eliminar

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (!int.TryParse(
                txtInventarioId.Text,
                out int id)
                || id <= 0)
            {
                MessageBox.Show(
                    "Seleccione un registro de inventario.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro de eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (respuesta != DialogResult.Yes)
                return;


            try
            {
                InventarioBLL.Borrar(id);


                MessageBox.Show(
                    "El registro fue eliminado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                CargarInventario();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Limpiar

        private void LimpiarFormulario()
        {
            txtInventarioId.Text = "0";

            txtProcesoId.Text = "0";

            txtCodigoBolsa.Clear();

            txtTipoSangre.Clear();

            txtCantidadInicial.Clear();

            txtCantidadDisponible.Clear();

            dtpFechaDonacion.Value =
                DateTime.Today;

            dtpFechaVenc.Value =
                DateTime.Today.AddDays(35);

            cboEstado.SelectedIndex = 0;

            erpInventario.Clear();
        }

        #endregion

  
     #region Buscar Procesamiento

        private void btnbuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                FrmInfProcInventario frm =
                    new FrmInfProcInventario();

                this.AddOwnedForm(frm);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al buscar procesamiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
    

    #region Form Load

    private void FrmInventario_Load(
            object sender,
            EventArgs e)
        {
            Inicializacion();
        }

        #endregion


    }
}
