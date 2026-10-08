using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using Microsoft.EntityFrameworkCore;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmPermisos : Form
    {
        public FrmPermisos()
        {
            InitializeComponent();
        }



        private void CargarUsuarios()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var lista = context.Usuarios
                        .OrderBy(x => x.nombreUsuario)
                        .ToList();

                    MessageBox.Show("Usuarios encontrados: " + lista.Count);

                    cboUsuarios.DataSource = lista;
                    cboUsuarios.DisplayMember = "nombreUsuario";
                    cboUsuarios.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuarios.SelectedValue == null)
                return;

            if (!int.TryParse(cboUsuarios.SelectedValue.ToString(), out int usuarioID))
                return;

            CargarPermisos(usuarioID);
        }

        private void CargarPermisos(int usuarioID)
        {
            using (var context = new AppDbContext())
            {
                var permisos = context.UsuarioPermisos
                    .Include(x => x.Permiso)
                    .Where(x => x.UsuarioID == usuarioID)
                    .ToList();

                chkDonantes.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Donantes" && x.Activo);

                chkDonaciones.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Donaciones" && x.Activo);

                chkMuestras.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Muestras" && x.Activo);

                chkAnalisis.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Analisis" && x.Activo);

                chkProcesamiento.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Procesamiento" && x.Activo);

                chkInventario.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Inventario" && x.Activo);

                chkSolicitudes.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Solicitudes" && x.Activo);

                chkEntrega.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Entrega" && x.Activo);

                chkUsuarios.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Usuarios" && x.Activo);

                chkEmpleados.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Empleados" && x.Activo);

                chkConfiguracion.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Configuracion" && x.Activo);

                chkReportes.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Reportes" && x.Activo);

                chkCitas.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "Citas" && x.Activo);

                chkControlInventario.Checked = permisos.Any(x => x.Permiso.NombrePermiso == "ControlInventario" && x.Activo);
            }
        }
        private void GuardarPermiso(int usuarioID, string nombrePermiso, bool activo)
        {
            using (var context = new AppDbContext())
            {
                var permiso = context.Permisos
                    .FirstOrDefault(x => x.NombrePermiso == nombrePermiso);

                if (permiso == null)
                    return;

                var usuarioPermiso = context.UsuarioPermisos
                    .FirstOrDefault(x =>
                        x.UsuarioID == usuarioID &&
                        x.PermisoID == permiso.ID);

                if (usuarioPermiso == null)
                {
                    usuarioPermiso = new UsuarioPermisosEntity();

                    usuarioPermiso.UsuarioID = usuarioID;
                    usuarioPermiso.PermisoID = permiso.ID;

                    context.UsuarioPermisos.Add(usuarioPermiso);
                }

                usuarioPermiso.Activo = activo;

                context.SaveChanges();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int usuarioID = Convert.ToInt32(cboUsuarios.SelectedValue);

            GuardarPermiso(usuarioID, "Donantes", chkDonantes.Checked);
            GuardarPermiso(usuarioID, "Donaciones", chkDonaciones.Checked);
            GuardarPermiso(usuarioID, "Muestras", chkMuestras.Checked);
            GuardarPermiso(usuarioID, "Analisis", chkAnalisis.Checked);
            GuardarPermiso(usuarioID, "Procesamiento", chkProcesamiento.Checked);
            GuardarPermiso(usuarioID, "Inventario", chkInventario.Checked);
            GuardarPermiso(usuarioID, "Solicitudes", chkSolicitudes.Checked);
            GuardarPermiso(usuarioID, "Entrega", chkEntrega.Checked);
            GuardarPermiso(usuarioID, "Usuarios", chkUsuarios.Checked);
            GuardarPermiso(usuarioID, "Empleados", chkEmpleados.Checked);
            GuardarPermiso(usuarioID, "Configuracion", chkConfiguracion.Checked);
            GuardarPermiso(usuarioID, "Reportes", chkReportes.Checked);
            GuardarPermiso(usuarioID, "Citas", chkCitas.Checked);
            GuardarPermiso(usuarioID, "ControlInventario", chkControlInventario.Checked);

            MessageBox.Show("Permisos guardados correctamente.",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FrmPermisos_Load_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }


}
