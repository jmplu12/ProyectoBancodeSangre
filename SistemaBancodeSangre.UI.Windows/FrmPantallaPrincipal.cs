using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using SistemaBancodeSangre.UI.Windows.Mantenimiento;
using System.Diagnostics.Contracts;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmPantallaPrincipal : Form
    {
        private int empleadoId;
        private int usuarioId;

        public FrmPantallaPrincipal(int usuarioId, int empleadoId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.empleadoId = empleadoId;

            // ===== NUEVO: mostrar el usuario logueado arriba a la derecha =====
            var usuario = UsuariosDAL.GetById(usuarioId);
            if (usuario != null)
            {
                lblUsuario.Text =
                    $"{usuario.Nombre} {usuario.Apellido}   |   {usuario.Cargo}";


            }
            // =================================================================

        }


        #region ABRIR FRMS EN EL PANEL PRINCIPAL

        private void Abrirfromhija(object Frmhija)
        {
            if (this.panelcontenedor1.Controls.Count > 0)
                this.panelcontenedor1.Controls.RemoveAt(0);
            Form fh = Frmhija as Form;
            fh.Dock = DockStyle.Fill;
            fh.TopLevel = false;
            this.panelcontenedor1.Controls.Add(fh);
            this.panelcontenedor1.Tag = fh;
            fh.Show();
        }


        private void procesarSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
            AjustarTextoLabel(lblUsuario);
        }

        private void AplicarPermisos()
        {
            // DONANTES
            registrarDonantesToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Donantes");

            btnRegistrarDonates.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Donantes");

            // DONACIONES
            BtnNuevaDonacion.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Donaciones");

            nuevaDonaciónToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Donaciones");

            listadoDeDonacionesToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Donaciones");

            // MUESTRAS
            tomaDeMuestraToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Muestras");

            consultaMuestraToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Muestras");

            // ANALISIS
            analisisDeSangreToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Analisis");

            // PROCESAMIENTO
            procesarSangreToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Procesamiento");

            // INVENTARIO
            inventarioToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Inventario");

            controlDeInventarioToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "ControlInventario");

            // SOLICITUDES
            solicitudesDeSangreToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Solicitudes");

            procesarSolicitudesToolStripMenuItem1.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Solicitudes");

            // ENTREGA
            entregaDeSangreToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Entrega");

            // REPORTES
            informesToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Reportes");

            // CITAS
            btnAgendarCitas.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Citas");

            // CONFIGURACION
            btnConfiGu.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Configuracion");

            // MANTENIMIENTOS
            empleadosToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Empleados");

            usuariosToolStripMenuItem.Visible =
                UsuarioPermisosBLL.TienePermiso(usuarioId, "Usuarios");
        }
        private void registrarDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmAgregarDonante(empleadoId));
        }

        private void tomaDeMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMuestraSangre(empleadoId));
        }

        private void btnRegistrarDonates_Click(object sender, EventArgs e)
        {
            //Le paso el ID del Empleado => cambio
            Abrirfromhija(new FrmAgregarDonante(empleadoId));
        }

        private void BtnNuevaDonacion_Click(object sender, EventArgs e)
        {
            // Enviar ID del empleado al formulario de donaciones
            Abrirfromhija(new FrmNuevaDonacion(empleadoId));
        }

        private void btnConfiGu_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmConfiguracion());
        }

        private void ptPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendarCitas_Click(object sender, EventArgs e)
        {
            FrmCitas formulario = new FrmCitas();
            formulario.ShowDialog();
        }

        private void analisisDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmAnaliticaSangre(empleadoId));
        }

        private void consultaMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaMuestra());
        }

        private void listaDeDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListadoDeDonantes());
        }

        private void procesarSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmProcesoSangre());
        }

        private void nuevaDonaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enviar ID del empleado al formulario de donaciones
            Abrirfromhija(new FrmNuevaDonacion(empleadoId));
        }

        private void listadoDeDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaDonacion());
        }

        private void controlDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmControlInventario());
        }

        private void reservasDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmNuevaReserva());
        }

        private void entregaDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmEntrega(empleadoId));
        }

        private void procesarSolicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmDistribucion());
        }

        private void solicitudesDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmSolicitudesDeSangre());
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmInventario());
        }

        private void informesDeDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListadoDeDonantes());
        }

        private void informeDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListadoProcesarSangre());
        }

        private void informeDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaSolicitudes());
        }

        private void informeDeProcesarSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaProcesarSangre());
        }

        private void informeAnaliticaDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListadoAnalisisSangre());
        }

        private void informeDeMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaMuestra());
        }
        #endregion

        #region Mantenimientos
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantEmpleados());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new MantUsuario());
        }

        private void donantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantDonantes(empleadoId));
        }

        private void donacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantDonaciones());
        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantAnalisis());
        }

        private void procesamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantProcesamientoSangre());
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantInventario());
        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantMuestras());
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantSolicitudesSangre());
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmMantEntregasSangre());
        }
        #endregion


        private void btnCerarrseccion_Click(object sender, EventArgs e)
        {
            AplicarPermisos();
            AjustarTextoLabel(lblUsuario);

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
        private void AjustarTextoLabel(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                float tamano = lbl.Font.Size;
                Font fuente = lbl.Font;

                // Reducir la letra hasta que el texto quepa en el ancho del label
                while (tamano > 6f)
                {
                    SizeF medida = g.MeasureString(lbl.Text, fuente);
                    if (medida.Width <= lbl.Width - 12)
                        break;

                    tamano -= 0.5f;
                    fuente.Dispose();
                    fuente = new Font(lbl.Font.FontFamily, tamano, lbl.Font.Style);
                }

                lbl.Font = fuente;
            }
        }

        private void btnCerarrseccion_Click_1(object sender, EventArgs e)
        {
            BitacoraBLL.RegistrarAccion(
           "Cerrar sesión",
           "Salió del sistema");

            SesionUsuario.CerrarSesion();

            this.Close();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaEmpleados());
        }

        private void listaAnaliticaDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListaAnaliticaSangre());
        }

        private void listadoDeSangreProcesadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmListadoProcesarSangre());
        }

        private void evaluarDonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfromhija(new FrmEvaluacionDonante(empleadoId));
        }
    }
}