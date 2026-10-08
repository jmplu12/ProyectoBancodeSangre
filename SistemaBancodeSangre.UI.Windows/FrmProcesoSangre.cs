using Microsoft.EntityFrameworkCore;
using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmProcesoSangre : Form
    {
        private int DonacionSeleccionadaID = 0;

        public FrmProcesoSangre()
        {
            InitializeComponent();
        }

        // =========================================================
        // INICIALIZAR CONTROLES
        // =========================================================

        private void InicializarControles()
        {
            txtProcesoId.Text = "0";
            txtIdDonacion.Text = "0";

            txtNoSangre.Clear();
            txtTipoSangre.Clear();
            txtVolumenDno.Clear();
            txtAlmacenado.Clear();
            txtResponsable.Clear();

            cbbEstado.SelectedIndex = -1;

            checkConcentradoGlobulosRojos.Checked = false;
            checkPlasma.Checked = false;
            checkPlaquetas.Checked = false;

            dtFechaProceso.Value = DateTime.Now;

            DonacionSeleccionadaID = 0;

            erpProcesamientoSangre.Clear();
        }

        // =========================================================
        // CARGAR ESTADOS
        // =========================================================

        private void CargarEstados()
        {
            cbbEstado.Items.Clear();

            cbbEstado.Items.Add("Pendiente");
            cbbEstado.Items.Add("En procesamiento");
            cbbEstado.Items.Add("Procesada");
            cbbEstado.Items.Add("No apta");
            cbbEstado.Items.Add("Almacenada");

            cbbEstado.SelectedIndex = -1;
        }

        // =========================================================
        // CARGAR DONACIÓN SELECCIONADA
        // =========================================================


        public void CargarDonacionDesdeListado(
    int DonacionID,
    string Nombre,
    string Apellido,
    string TipoDeSangre,
    double CantidadSangre)
        {
            DonacionSeleccionadaID = DonacionID;

            txtIdDonacion.Text =
                DonacionID.ToString();

            txtNoSangre.Text =
                Nombre + " " + Apellido;

            txtTipoSangre.Text =
                TipoDeSangre;

            txtVolumenDno.Text =
                CantidadSangre.ToString("0.##");
        }

        // =========================================================
        // VALIDAR DATOS
        // =========================================================

        private bool ValidarDatos()
        {
            bool validado = true;

            erpProcesamientoSangre.Clear();

            // -----------------------------------------------------
            // DONACIÓN
            // -----------------------------------------------------

            if (!int.TryParse(
                txtIdDonacion.Text,
                out int donacionID) ||
                donacionID <= 0)
            {
                erpProcesamientoSangre.SetError(
                    txtIdDonacion,
                    "Debe seleccionar una donación válida.");

                validado = false;
            }

            // -----------------------------------------------------
            // NÚMERO DE SANGRE
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtNoSangre.Text))
            {
                erpProcesamientoSangre.SetError(
                    txtNoSangre,
                    "El número de sangre es obligatorio.");

                validado = false;
            }

            // -----------------------------------------------------
            // TIPO DE SANGRE
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtTipoSangre.Text))
            {
                erpProcesamientoSangre.SetError(
                    txtTipoSangre,
                    "El tipo de sangre es obligatorio.");

                validado = false;
            }

            // -----------------------------------------------------
            // ESTADO
            // -----------------------------------------------------

            if (cbbEstado.SelectedIndex == -1)
            {
                erpProcesamientoSangre.SetError(
                    cbbEstado,
                    "Debe seleccionar el estado del procesamiento.");

                validado = false;
            }

            // -----------------------------------------------------
            // VOLUMEN
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtVolumenDno.Text))
            {
                erpProcesamientoSangre.SetError(
                    txtVolumenDno,
                    "El volumen de sangre es obligatorio.");

                validado = false;
            }
            else
            {
                if (!double.TryParse(
                    txtVolumenDno.Text,
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out double volumen))
                {
                    erpProcesamientoSangre.SetError(
                        txtVolumenDno,
                        "Ingrese un volumen válido.");

                    validado = false;
                }
                else if (volumen <= 0)
                {
                    erpProcesamientoSangre.SetError(
                        txtVolumenDno,
                        "El volumen debe ser mayor que cero.");

                    validado = false;
                }
                else if (volumen > 10000)
                {
                    erpProcesamientoSangre.SetError(
                        txtVolumenDno,
                        "El volumen no puede superar los 10,000 ml.");

                    validado = false;
                }
            }

            // -----------------------------------------------------
            // ALMACENAMIENTO
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtAlmacenado.Text))
            {
                erpProcesamientoSangre.SetError(
                    txtAlmacenado,
                    "Debe indicar dónde será almacenada la sangre.");

                validado = false;
            }

            // -----------------------------------------------------
            // RESPONSABLE
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                erpProcesamientoSangre.SetError(
                    txtResponsable,
                    "El responsable es obligatorio.");

                validado = false;
            }
            else if (txtResponsable.Text.Trim().Length > 150)
            {
                erpProcesamientoSangre.SetError(
                    txtResponsable,
                    "El responsable no puede superar los 150 caracteres.");

                validado = false;
            }

            // -----------------------------------------------------
            // FECHA
            // -----------------------------------------------------

            if (dtFechaProceso.Value.Date > DateTime.Today)
            {
                erpProcesamientoSangre.SetError(
                    dtFechaProceso,
                    "La fecha de procesamiento no puede ser futura.");

                validado = false;
            }

            // -----------------------------------------------------
            // COMPONENTES
            // -----------------------------------------------------

            if (!checkConcentradoGlobulosRojos.Checked &&
                !checkPlasma.Checked &&
                !checkPlaquetas.Checked)
            {
                erpProcesamientoSangre.SetError(
                    checkPlasma,
                    "Debe seleccionar al menos un componente sanguíneo.");

                validado = false;
            }

            return validado;
        }

      
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProcesoSangre_Load(object sender, EventArgs e)
        {
            InicializarControles();
            CargarEstados();
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
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
                // -------------------------------------------------
                // CONVERTIR VOLUMEN
                // -------------------------------------------------

                double volumen;

                if (!double.TryParse(
                    txtVolumenDno.Text,
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out volumen))
                {
                    MessageBox.Show(
                        "El volumen ingresado no es válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // -------------------------------------------------
                // CREAR ENTIDAD
                // -------------------------------------------------

                ProcesamientoDeSangreEntity proceso =
                    new ProcesamientoDeSangreEntity
                    {
                        ID = Convert.ToInt32(
                            txtProcesoId.Text),

                        DonacionesID = Convert.ToInt32(
                            txtIdDonacion.Text),

                        NumeroSangre =
                            txtNoSangre.Text.Trim(),

                        TipoDeSangre =
                            txtTipoSangre.Text.Trim(),

                        VolumenDN =
                            volumen,

                        EstadoProceso =
                            cbbEstado.SelectedItem.ToString(),

                        Almacenado =
                            txtAlmacenado.Text.Trim(),

                        Responsable =
                            txtResponsable.Text.Trim(),

                        FechaProceso =
                            dtFechaProceso.Value,

                        ConcentradoGlobulosRojos =
                            checkConcentradoGlobulosRojos.Checked,

                        Plasma =
                            checkPlasma.Checked,

                        Plaquetas =
                            checkPlaquetas.Checked
                    };

                // -------------------------------------------------
                // GUARDAR
                // -------------------------------------------------

                ProcesamientoDeSangreBLL.Guardar(
                    proceso);

                // -------------------------------------------------
                // MENSAJE
                // -------------------------------------------------

                MessageBox.Show(
                    "EL PROCESAMIENTO DE SANGRE SE REGISTRÓ CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // -------------------------------------------------
                // LIMPIAR
                // -------------------------------------------------

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
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el procesamiento.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            using (FrmInformacionProcesamiento frm =
            new FrmInformacionProcesamiento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    // Aquí se cargarán los datos de la donación seleccionada
                    // cuando FrmInformacionProcesamiento cierre con OK.

                    txtIdDonacion.Text =
                        frm.IdDonacion.ToString();

                    txtNoSangre.Text =
                        frm.NumeroSangre;

                    txtTipoSangre.Text =
                        frm.TipoDeSangre;

                    txtVolumenDno.Text =
                        frm.CantidadSangre.ToString("0.##");
                    txtNombre.Text = frm.NombreDonante;
                    txtApellido.Text = frm.ApellidoDonante;




                }
            }
        }

        #region Permitir Letras o Numeros 
        // =========================================================
        // VALIDAR VOLUMEN
        // =========================================================

        private void txtVolumenDno_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            char separadorDecimal =
                Convert.ToChar(
                    CultureInfo.CurrentCulture
                        .NumberFormat
                        .NumberDecimalSeparator);

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == separadorDecimal)
            {
                if (txtVolumenDno.Text.Contains(
                    separadorDecimal.ToString()))
                {
                    e.Handled = true;
                }

                return;
            }

            e.Handled = true;
        }

        // =========================================================
        // SOLO LETRAS - RESPONSABLE
        // =========================================================

        private void txtResponsable_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================================================
        // ALMACENAMIENTO
        // =========================================================

        private void txtAlmacenado_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        // =========================================================
        // EVENTOS DEL DISEÑADOR
        // =========================================================

        
}
        #endregion
    }
