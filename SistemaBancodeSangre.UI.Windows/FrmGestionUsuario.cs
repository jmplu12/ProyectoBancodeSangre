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
using static SistemaBancodeSangre.Entities.seguridad;

namespace SistemaBancodeSangre.UI.Windows
{
    public partial class FrmGestionUsuario : Form
    {
        public FrmGestionUsuario()
        {
            InitializeComponent();
          
        }

     
        private void InicializarControles()
        {
            txtID.Text = "0"; 
            txtUsuario.Clear();
            txtclave.Clear();
            cboCargo.SelectedIndex = -1;
            txtidEmpleado.Text = "0"; 
            errorProvider.Clear();
        }
        private void BtnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            
            FrmListaEmpleados frm = new FrmListaEmpleados();
           
            if (frm.ShowDialog() == DialogResult.OK)
            {
               
                EmpleadosEntity empleado = EmpleadosDAL.GetById(frm.IdEmpleado);

                txtidEmpleado.Text = empleado.ID.ToString();
                txtnombre.Text = empleado.nombre;
                txtApellidos.Text = empleado.Apellido; 
                txtCorreo.Text = empleado.email;
                txttelefono.Text = empleado.telefono;
                txtdireccion.Text = empleado.dirreccion;
                cboCargo.Text = empleado.cargo;


            }
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();

        }

        private void GuardarUsuario()
        {
            if (!validarDatos())
                return;

            if (string.IsNullOrWhiteSpace(cboCargo.Text))
            {
                MessageBox.Show("Debe seleccionar un cargo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int empleadoID = Convert.ToInt32(txtidEmpleado.Text);

            using (var context = new AppDbContext())
            {
                var empleadoExistente = context.Empleados
                    .FirstOrDefault(e => e.ID == empleadoID);

                if (empleadoExistente == null)
                {
                    MessageBox.Show("El EmpleadoID no existe.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            UsuariosEntity usuario = new UsuariosEntity
            {
                ID = Convert.ToInt32(txtID.Text),

                nombreUsuario = txtUsuario.Text.Trim(),

                // ENCRIPTAR LA CONTRASEÑA
                clave = Seguridad.Encriptar(txtclave.Text.Trim()),

                Nombre = txtnombre.Text,

                Apellido = txtApellidos.Text,

                correo = txtCorreo.Text,

                telefono = txttelefono.Text,

                Cargo = cboCargo.Text.Trim(),

                EmpleadoID = empleadoID,

                IntentosFallidos = 0,

                Bloqueado = false
            };
            MessageBox.Show(usuario.clave);
            // GUARDAR UTILIZANDO LA BLL
            UsuariosBLL.Guardar(usuario);

            MessageBox.Show("Usuario guardado correctamente.",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            InicializarControles();
        }

        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear();

            // Validar nombre de usuario
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtUsuario, "El nombre de usuario es obligatorio.");
                validado = false;
            }

            // Validar clave
            if (string.IsNullOrEmpty(txtclave.Text))
            {
                errorProvider.SetError(txtclave, "La clave es obligatoria.");
                validado = false;
            }

            //// Validar rol
            //if (cboRol.SelectedIndex == -1)
            //{
            //    errorProvider.SetError(cboRol, "Debe seleccionar un rol.");
            //    validado = false;
            //}

            return validado; // Retorna true si todos los campos son válidos
        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
