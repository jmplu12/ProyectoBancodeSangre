using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaBancodeSangre.Entities.seguridad;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

            txtContrasena.UseSystemPasswordChar = true;

            this.AcceptButton = btniniciarseccion;

            CrearPermisosPorDefecto();
            CrearAdministradorPorDefecto();
            AsignarPermisosAdministrador();
        }

        private void CrearAdministradorPorDefecto()
        {
            using (var context = new AppDbContext())
            {
                if (!context.Usuarios.Any())
                {
                    EmpleadosEntity empleado = new EmpleadosEntity
                    {
                        nombre = "Administrador",
                        Apellido = "Sistema",
                        FechaNac = DateTime.Now,
                        Edad = "0",
                        sexo = "N/A",
                        cedula = "00000000000",
                        telefono = "0000000000",
                        email = "admin@admin.com",
                        estado = true,
                        cargo = "Administrador",
                        provincia = "N/A",
                        Municipio = "N/A",
                        dirreccion = "Sistema"
                    };

                    context.Empleados.Add(empleado);
                    context.SaveChanges();

                    UsuariosEntity usuario = new UsuariosEntity
                    {
                        Nombre = "Administrador",
                        Apellido = "Sistema",
                        correo = "admin@admin.com",
                        telefono = "0000000000",
                        nombreUsuario = "admin",
                        clave = Seguridad.Encriptar("admin123"),
                        Cargo = "Administrador",
                        EmpleadoID = empleado.ID,
                        IntentosFallidos = 0,
                        Bloqueado = false
                    };

                    context.Usuarios.Add(usuario);
                    context.SaveChanges();

                    MessageBox.Show(
                        "Se creó el usuario administrador por defecto.\n\n" +
                        "Usuario: admin\n" +
                        "Contraseña: admin123",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        private void btniniciarseccion_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtUsuario.Text.Trim();

                string clave = txtContrasena.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                    string.IsNullOrWhiteSpace(clave))
                {
                    MessageBox.Show("Debe completar todos los campos.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (var context = new AppDbContext())
                {
                    var usuario = context.Usuarios.FirstOrDefault(u =>
                        u.nombreUsuario.ToLower() ==
                        nombreUsuario.ToLower());

                    if (usuario == null)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    if (usuario.Bloqueado)
                    {
                        MessageBox.Show(
                            "Este usuario está bloqueado.\nContacte al administrador.",
                            "Usuario Bloqueado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);

                        return;
                    }

                    if (Seguridad.Verificar(clave, usuario.clave))
                    {
                        usuario.IntentosFallidos = 0;

                        context.SaveChanges();

                        string saludo =
                            $"Bienvenido {usuario.Cargo} {usuario.Nombre}";

                        MessageBox.Show(saludo,
                            "Inicio de sesión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        SesionUsuario.Iniciar(
                         usuario.ID,
                         usuario.EmpleadoID,
                         usuario.Nombre,
                         usuario.Apellido,
                         usuario.Cargo);

                        BitacoraBLL.RegistrarAccion(
                        "Inicio de sesión",
                         "Ingresó al sistema");

                        FrmPantallaPrincipal frm =
                             new FrmPantallaPrincipal(usuario.ID, usuario.EmpleadoID);

                        this.Hide();

                        frm.Show();
                    }
                    else
                    {
                        usuario.IntentosFallidos++;

                        if (usuario.IntentosFallidos >= 3)
                        {
                            usuario.Bloqueado = true;

                            MessageBox.Show(
                                "Usuario bloqueado por exceder el número de intentos permitidos.",
                                "Seguridad",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Usuario o contraseña incorrectos.\nIntento {usuario.IntentosFallidos} de 3.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ha ocurrido un error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        
    }

        private void CrearPermisosPorDefecto()
        {
            using (var context = new AppDbContext())
            {
                if (!context.Permisos.Any())
                {
                    context.Permisos.AddRange(

                        new PermisosEntity { NombrePermiso = "Donantes" },
                        new PermisosEntity { NombrePermiso = "Donaciones" },
                        new PermisosEntity { NombrePermiso = "Muestras" },
                        new PermisosEntity { NombrePermiso = "Analisis" },
                        new PermisosEntity { NombrePermiso = "Procesamiento" },
                        new PermisosEntity { NombrePermiso = "Inventario" },
                        new PermisosEntity { NombrePermiso = "Solicitudes" },
                        new PermisosEntity { NombrePermiso = "Entrega" },
                        new PermisosEntity { NombrePermiso = "Usuarios" },
                        new PermisosEntity { NombrePermiso = "Empleados" },
                        new PermisosEntity { NombrePermiso = "Configuracion" },
                        new PermisosEntity { NombrePermiso = "Reportes" },
                        new PermisosEntity { NombrePermiso = "Citas" },
                        new PermisosEntity { NombrePermiso = "ControlInventario" }

                    );

                    context.SaveChanges();
                }
            }
        }

        private void AsignarPermisosAdministrador()
        {
            using (var context = new AppDbContext())
            {
                var admin = context.Usuarios.FirstOrDefault(x => x.nombreUsuario == "admin");

                if (admin == null)
                    return;

                var permisos = context.Permisos.ToList();

                foreach (var permiso in permisos)
                {
                    bool existe = context.UsuarioPermisos.Any(x =>
                        x.UsuarioID == admin.ID &&
                        x.PermisoID == permiso.ID);

                    if (!existe)
                    {
                        context.UsuarioPermisos.Add(new UsuarioPermisosEntity
                        {
                            UsuarioID = admin.ID,
                            PermisoID = permiso.ID,
                            Activo = true
                        });
                    }
                }

                context.SaveChanges();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}