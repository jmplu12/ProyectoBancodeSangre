using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmMuestraSangre : Form
    {
        private readonly int empleadoId;
        
        public FrmMuestraSangre(int empleadoId)
        {
            // 1. OBLIGATORIO: Debe ir en la primera línea para inicializar todos los TextBox y controles
            InitializeComponent();

            // 2. Asignar variables de clase
            this.empleadoId = empleadoId;

           
            InicializarControles();
        }

        #region Métodos Auxiliares e Inicialización

        private void InicializarControles()
        {
            txtMuestraID.Text = "0";
             txtIdDonacion.Text = "0";
            txtIDDonant.Text = "0";

            txtNombre.Clear();
            txtApellidos.Clear();
            txtTiposangre.Clear();
            txtCodMuestra.Clear();
            txtResponsable.Clear();
            txtObservacion.Clear();

            txtCantidadM.Text = "0";
            cboEstado.SelectedIndex = -1;

            dtFechaToma.Value = DateTime.Now;
            dtFechaDonacion.Value = DateTime.Now;
            // 1. GENERACIÓN AUTOMÁTICA AL INICIALIZAR
            txtCodMuestra.Text = GenerarCodigoMuestra();
            errorProvider.Clear();
            CargarEstados();
     

            if (dgvmuestra.DataSource != null)
            {
                dgvmuestra.ClearSelection();
            }
        }

        private void Analista()
        {
            try
            {
                EmpleadosEntity empleado = EmpleadoBLL.obtenerID(empleadoId);

                if (empleado != null)
                {
                    txtResponsable.Text = $"{empleado.nombre} {empleado.Apellido}".Trim();
                }
                else
                {
                    txtResponsable.Text = empleadoId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la información del analista.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("En análisis");
            cboEstado.Items.Add("Analizada");
            cboEstado.Items.Add("Rechazada");
            cboEstado.SelectedIndex = -1;
        }

        private void CargarTodasLasMuestras()
        {
            try
            {
                dgvmuestra.DataSource = MuestraBLL.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las muestras.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListaDonacion frm = new FrmListaDonacion(true);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DonacionesEntity donacion = DonacionesBLL.ObtenerPorId(frm.IdDonacion);

                    if (donacion != null)
                    {
                        txtIdDonacion.Text = donacion.ID.ToString();
                        txtIDDonant.Text = donacion.DonanteID.ToString();
                        txtNombre.Text = donacion.Nombre;
                        txtApellidos.Text = donacion.Apellido;
                        txtTiposangre.Text = donacion.TipoDeSangre;
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró el donante seleccionado.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el donante.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarDatos())
                {
                    MessageBox.Show(
                        "COMPLETE LOS CAMPOS OBLIGATORIOS.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                MuestraEntity muestra = new MuestraEntity
                {
                    ID = Convert.ToInt32(txtMuestraID.Text),
                    DonacionesID = Convert.ToInt32(txtIdDonacion.Text),
                    DonanteID = Convert.ToInt32(txtIDDonant.Text),
                    NombreDonante = txtNombre.Text.Trim(),
                    ApellidoDonante = txtApellidos.Text.Trim(),
                    TipoSangre = txtTiposangre.Text.Trim(),
                    CodigoMuestra = txtCodMuestra.Text.Trim(),
                    FechaToma = dtFechaToma.Value,
                    FechaDonacion = dtFechaDonacion.Value,
                    CantidadM = Convert.ToDouble(txtCantidadM.Text),
                    Estado = cboEstado.SelectedItem.ToString(),
                    Observacion = txtObservacion.Text.Trim(),
                    Responsable = txtResponsable.Text.Trim()
                };

                MuestraBLL.Guardar(muestra);

                MessageBox.Show(
                    "MUESTRA REGISTRADA CORRECTAMENTE.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvmuestra.DataSource = null;
                dgvmuestra.DataSource = new List<MuestraEntity> { muestra };

                InicializarControles();
                Analista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la muestra:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region Validaciones

        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtTiposangre.Text))
            {
                errorProvider.SetError(txtTiposangre, "El tipo de sangre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtCodMuestra.Text))
            {
                errorProvider.SetError(txtCodMuestra, "El código de muestra es obligatorio.");
                validado = false;
            }

            if (!double.TryParse(txtCantidadM.Text, out double cantidad) || cantidad <= 0 || cantidad > 100)
            {
                errorProvider.SetError(txtCantidadM, "Ingrese una cantidad válida de muestra (1 a 100 ml).");
                validado = false;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                errorProvider.SetError(cboEstado, "Debe seleccionar un estado.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                errorProvider.SetError(txtResponsable, "El responsable es obligatorio.");
                validado = false;
            }

            return validado;
        }

        #endregion
        private void FrmMuestraSangre_Load(object sender, EventArgs e)
        {
            InicializarControles();
            Analista();
            CargarTodasLasMuestras();
           
        }


        #region Generación e Impresión de Código

        private string GenerarCodigoMuestra()
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string aleatorio = Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
            return $"MS-{fecha}-{aleatorio}";
        }

        #endregion
        private void btnMuestra_Click(object sender, EventArgs e)
        {
            // Permite regenerar un nuevo código manualmente si se presiona el botón
            txtCodMuestra.Text = GenerarCodigoMuestra();


        }

        #region Imprimir Codigos de Muestras 
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodMuestra.Text))
                {
                    MessageBox.Show(
                        "No hay ningún código de muestra generado para imprimir.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // 2. USAR EL COMPONENTE ARRASTRADO DESDE EL DISEÑADOR (SIN RECREARLO NI ACCEDER A VARIABLES NO DECLARADAS)
                printCodMuestra.PrinterSettings = new PrinterSettings();

                // Evitar que el evento se registre múltiples veces
                printCodMuestra.PrintPage -= imprimir;
                printCodMuestra.PrintPage += imprimir;

                printCodMuestra.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al imprimir el código:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        private void imprimir(object sender, PrintPageEventArgs e)
        {
            // 3. MENTENER RECURSOS SEGUROS CON 'USING' Y AMPLIAR EL ÁREA DE DIBUJO
            using (Font font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point))
            {
                string codMuestra = txtCodMuestra.Text;

                // Se amplió el ancho a 300 y alto a 40 para que quepa todo el código "MS-YYYYMMDD-XXXXX"
                e.Graphics.DrawString(codMuestra, font, Brushes.Black, new RectangleF(10, 10, 300, 40));
            }
        }
        #endregion

        #region Permitir Letras y Numeros TXT
        private void txtCantidadM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        #endregion



        private void dgvmuestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvmuestra.Rows[e.RowIndex];

                txtMuestraID.Text = row.Cells["ID"].Value?.ToString() ?? "0";
                txtDonanteID.Text = row.Cells["DonanteID"].Value?.ToString() ?? "0";
                txtNombre.Text = row.Cells["NombreDonante"].Value?.ToString() ?? string.Empty;
                txtApellidos.Text = row.Cells["ApellidoDonante"].Value?.ToString() ?? string.Empty;
                txtTiposangre.Text = row.Cells["TipoSangre"].Value?.ToString() ?? string.Empty;
                txtCodMuestra.Text = row.Cells["CodigoMuestra"].Value?.ToString() ?? string.Empty;
                txtCantidadM.Text = row.Cells["CantidadM"].Value?.ToString() ?? "0";
                txtObservacion.Text = row.Cells["Observacion"].Value?.ToString() ?? string.Empty;
                txtResponsable.Text = row.Cells["Responsable"].Value?.ToString() ?? string.Empty;

                if (row.Cells["FechaToma"].Value != null)
                    dtFechaToma.Value = Convert.ToDateTime(row.Cells["FechaToma"].Value);

                if (row.Cells["FechaDonacion"].Value != null)
                    dtFechaDonacion.Value = Convert.ToDateTime(row.Cells["FechaDonacion"].Value);

                if (row.Cells["Estado"].Value != null)
                    cboEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el registro:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvmuestra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }


}