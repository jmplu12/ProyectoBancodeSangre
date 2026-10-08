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
    public partial class FrmNuevaDonacion : Form
    {
        private readonly int empleadoId;
        private int evaluacionDonanteID = 0;

        public FrmNuevaDonacion(int empleadoId)
        {
            this.empleadoId = empleadoId;

            InitializeComponent();
        }

        private void InicializarControles()
        {
            txtID.Text = "0";

            txtIdDonante.Text = "0";

            evaluacionDonanteID = 0;

            txtNombre.Clear();

            txtApellidos.Clear();

            txtCantSangre.Clear();

            txtEvase.Clear();

            txtPoposito.Clear();

            txtTiposangre.Clear();

            txtAnalista.Clear();

            dtFecha.Value = DateTime.Now;

            errorProvider.Clear();

            try
            {
                txtNoSangre.Text = GenerarNumeroSangre();
            }
            catch
            {
                txtNoSangre.Text = "SNG-00001";
            }

            CargarAnalista();

            if (dtgDonaciones.DataSource != null)
            {
                dtgDonaciones.ClearSelection();
            }

            txtNombre.Focus();
        }

        private void CargarAnalista()
        {
            try
            {
                EmpleadosEntity empleado =
                    EmpleadoBLL.obtenerID(empleadoId);

                if (empleado != null)
                {
                    txtAnalista.Text =
                        $"{empleado.nombre} {empleado.Apellido}".Trim();
                }
                else
                {
                    txtAnalista.Text =
                        empleadoId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la información del analista.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            try
            {
                dtgDonaciones.AutoGenerateColumns = false;

                dtgDonaciones.DataSource = null;

                dtgDonaciones.DataSource =
                    DonacionesBLL.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error cargando el historial de donaciones.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarSoloDonacion(
            DonacionesEntity donacion)
        {
            try
            {
                if (donacion == null)
                {
                    return;
                }

                dtgDonaciones.AutoGenerateColumns = false;

                dtgDonaciones.DataSource = null;

                dtgDonaciones.DataSource =
                    new List<DonacionesEntity>
                    {
                        donacion
                    };
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al visualizar la donación registrada.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos(bool esActualizacion = false)
        {
            bool validado = true;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(
                    txtNombre,
                    "El nombre del donante es obligatorio.");

                validado = false;
            }
            else if (txtNombre.Text.Trim().Length > 50)
            {
                errorProvider.SetError(
                    txtNombre,
                    "El nombre no puede superar los 50 caracteres.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(
                    txtApellidos,
                    "El apellido del donante es obligatorio.");

                validado = false;
            }
            else if (txtApellidos.Text.Trim().Length > 50)
            {
                errorProvider.SetError(
                    txtApellidos,
                    "El apellido no puede superar los 50 caracteres.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtTiposangre.Text))
            {
                errorProvider.SetError(
                    txtTiposangre,
                    "Debe seleccionar el tipo de sangre.");

                validado = false;
            }

            if (!double.TryParse(
                txtCantSangre.Text,
                out double cantidad))
            {
                errorProvider.SetError(
                    txtCantSangre,
                    "Ingrese una cantidad válida.");

                validado = false;
            }
            else if (cantidad <= 0)
            {
                errorProvider.SetError(
                    txtCantSangre,
                    "La cantidad debe ser mayor que cero.");

                validado = false;
            }
            else if (cantidad > 1000)
            {
                errorProvider.SetError(
                    txtCantSangre,
                    "La cantidad no puede superar los 1000 ml.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtEvase.Text))
            {
                errorProvider.SetError(
                    txtEvase,
                    "El envase es obligatorio.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtPoposito.Text))
            {
                errorProvider.SetError(
                    txtPoposito,
                    "El propósito es obligatorio.");

                validado = false;
            }

            if (!int.TryParse(
                txtIdDonante.Text,
                out int idDonante) ||
                idDonante <= 0)
            {
                errorProvider.SetError(
                    txtIdDonante,
                    "Debe seleccionar un donante válido.");

                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtAnalista.Text))
            {
                errorProvider.SetError(
                    txtAnalista,
                    "El analista es obligatorio.");

                validado = false;
            }

            if (dtFecha.Value.Date > DateTime.Today)
            {
                errorProvider.SetError(
                    dtFecha,
                    "La fecha no puede ser futura.");

                validado = false;
            }

            return validado;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (FrmListadoDeDonantes frm =
                new FrmListadoDeDonantes(true))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DonantesEntity donante =
                            DonanteBLL.ObtenerDonantePorId(
                                frm.IdDonante);

                        if (donante == null)
                        {
                            MessageBox.Show(
                                "El donante seleccionado no existe.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        // ==========================================
                        // CARGAR DATOS DEL DONANTE
                        // ==========================================

                        txtIdDonante.Text =
                            donante.ID.ToString();

                        txtNombre.Text =
                            donante.Nombre;

                        txtApellidos.Text =
                            donante.Apellido;

                        txtTiposangre.Text =
                            donante.TipoDeSangre;


                        // ==========================================
                        // BUSCAR ÚLTIMA EVALUACIÓN
                        // ==========================================

                        EvaluacionDonanteEntity evaluacion =
                            EvaluacionDonanteBLL.ObtenerUltimaEvaluacion(
                                donante.ID);

                        if (evaluacion == null)
                        {
                            evaluacionDonanteID = 0;

                            MessageBox.Show(
                                "El donante no tiene una evaluación registrada.\n\n" +
                                "Debe realizar la evaluación antes de registrar la donación.",
                                "Evaluación requerida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }


                        // ==========================================
                        // VERIFICAR RESULTADO
                        // ==========================================

                        if (evaluacion.Resultado == "NO APTO")
                        {
                            evaluacionDonanteID = 0;

                            MessageBox.Show(
                                "El donante ha sido evaluado como NO APTO.\n\n" +
                                "No se puede registrar la donación.",
                                "Donante no apto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }


                        if (evaluacion.Resultado == "PENDIENTE")
                        {
                            evaluacionDonanteID = 0;

                            MessageBox.Show(
                                "La evaluación del donante está PENDIENTE.\n\n" +
                                "No se puede registrar la donación hasta completar la evaluación.",
                                "Evaluación pendiente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }


                        // ==========================================
                        // DONANTE APTO
                        // ==========================================

                        if (evaluacion.Resultado == "APTO")
                        {
                            evaluacionDonanteID =
                                evaluacion.ID;

                            MessageBox.Show(
                                "Donante seleccionado correctamente.\n\n" +
                                "Resultado de evaluación: APTO",
                                "Evaluación aprobada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Ocurrió un error al verificar la evaluación del donante.\n\n" +
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {

            // Validar los datos del formulario
            if (!ValidarDatos())
            {
                MessageBox.Show(
                    "Corrija los campos marcados antes de continuar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (evaluacionDonanteID <= 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un donante que tenga una evaluación APTO antes de registrar la donación.",
                    "Evaluación requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            try
            {
                // Crear la entidad de donación
                DonacionesEntity donacion = new DonacionesEntity
                {
                    ID = Convert.ToInt32(txtID.Text),

                    DonanteID = Convert.ToInt32(txtIdDonante.Text),

                    EvaluacionDonanteID = evaluacionDonanteID,

                    Nombre = txtNombre.Text.Trim(),

                    Apellido = txtApellidos.Text.Trim(),

                    TipoDeSangre = txtTiposangre.Text.Trim(),

                    CantidadSangre = Convert.ToInt32(txtCantSangre.Text),

                    Envase = txtEvase.Text.Trim(),

                    FechaDonacion = dtFecha.Value,

                    Proposito = txtPoposito.Text.Trim(),

                    Analista = txtAnalista.Text.Trim(),

                    NumeroSangre = txtNoSangre.Text.Trim()
                };
                // Guardar la donación mediante la BLL
                DonacionesBLL.Guardar(donacion);

                // Mensaje de confirmación
                MessageBox.Show(
                    "DONACIÓN REGISTRADA CORRECTAMENTE.\n\n" +
                    "Número de sangre: " + donacion.NumeroSangre,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Recargar el DataGridView
                CargarDatos();

                // Limpiar el formulario y preparar una nueva donación
                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Error en el formato de los datos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado al registrar la donación.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmNuevaDonacion_Load(object sender, EventArgs e)
        {
            InicializarControles();

            CargarAnalista();

            CargarDatos();

        }

        private string GenerarNumeroSangre()
        {
            try
            {
                var donaciones = DonacionesBLL.GetAll();

                int ultimoNumero = 0;

                foreach (var donacion in donaciones)
                {
                    if (string.IsNullOrWhiteSpace(donacion.NumeroSangre))
                        continue;

                    if (!donacion.NumeroSangre.StartsWith("SNG-"))
                        continue;

                    string numeroTexto = donacion.NumeroSangre.Substring(4);

                    if (int.TryParse(numeroTexto, out int numero))
                    {
                        if (numero > ultimoNumero)
                        {
                            ultimoNumero = numero;
                        }
                    }
                }

                int nuevoNumero = ultimoNumero + 1;

                return $"SNG-{nuevoNumero:D5}";
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo generar el número de sangre.\n\n" +
                    ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show(
                    "Corrija los campos marcados antes de continuar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                DonacionesEntity donacion =
                    new DonacionesEntity();

                donacion.ID =
                    Convert.ToInt32(txtID.Text);

                donacion.DonanteID =
                    Convert.ToInt32(txtIdDonante.Text);

                donacion.Nombre =
                    txtNombre.Text.Trim();

                donacion.Apellido =
                    txtApellidos.Text.Trim();

                donacion.TipoDeSangre =
                    txtTiposangre.Text.Trim();

                donacion.CantidadSangre =
                    Convert.ToInt32(txtCantSangre.Text);

                donacion.Envase =
                    txtEvase.Text.Trim();

                donacion.FechaDonacion =
                    dtFecha.Value;

                donacion.Proposito =
                    txtPoposito.Text.Trim();

                donacion.Analista =
                    txtAnalista.Text.Trim();

                DonacionesBLL.Guardar(donacion);

                MessageBox.Show(
                    "DONACIÓN REGISTRADA CORRECTAMENTE.\n\n" +
                    "Número de sangre:\n" +
                    donacion.NumeroSangre,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarDatos();

                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Error en el formato de los datos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado al registrar " +
                    "la donación.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDonaciones.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una donación para eliminar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dtgDonaciones.CurrentRow.Cells["ID"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar esta donación?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                DonacionesBLL.Eliminar(id);

                MessageBox.Show(
                    "DONACIÓN ELIMINADA CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarDatos();
                InicializarControles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la donación.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDonaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dtgDonaciones.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value?.ToString() ?? "0";
                txtIdDonante.Text = row.Cells["DonanteID"].Value?.ToString() ?? "0";
                txtNombre.Text = row.Cells["nombre"].Value?.ToString() ?? string.Empty;
                txtApellidos.Text = row.Cells["apellido"].Value?.ToString() ?? string.Empty;
                txtTiposangre.Text = row.Cells["tipoDeSangre"].Value?.ToString() ?? string.Empty;
                txtCantSangre.Text = row.Cells["cantidadSangre"].Value?.ToString() ?? string.Empty;
                txtEvase.Text = row.Cells["envase"].Value?.ToString() ?? string.Empty;

                if (row.Cells["fechaDonacion"].Value != null)
                {
                    dtFecha.Value = Convert.ToDateTime(row.Cells["fechaDonacion"].Value);
                }

                txtPoposito.Text = row.Cells["proposito"].Value?.ToString() ?? string.Empty;
                txtAnalista.Text = row.Cells["analista"].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar la donación.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Control de Teclas (KeyPress)

        private void txtCantSangre_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            // Permite números, tecla de borrado (Backspace) y punto/coma decimal
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
                return;
            }

            // Evita ingresar más de un separador decimal
            if (e.KeyChar == decimalSeparator && (sender as TextBox).Text.Contains(decimalSeparator.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtPoposito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }

}
