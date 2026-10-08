using SistemaBancodeSangre.BLL;
using SistemaBancodeSangre.DAL;
using SistemaBancodeSangre.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    public partial class MantUsuario : Form
    {
        public MantUsuario()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            txtclave.Clear();
            txtID.Text = "0";
            txtidEmpleado.Text = "0";
            cboCargo.SelectedIndex = -1;
            txtUsuario.Clear();
            dgvManUsuarios.DataSource = UsuariosBLL.ObtenerTodas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtclave.Text = "";
            txtID.Text = "0";
            txtidEmpleado.Text = "0";
            cboCargo.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }

        private bool validardatos()
        {
            bool validado = true;
            erpmanUsuario.Clear();


            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpmanUsuario.SetError(txtUsuario, "El usuario es obligatorio");
                validado = false;

            }
            if (string.IsNullOrEmpty(txtclave.Text))
            {
                erpmanUsuario.SetError(txtclave, "La clave es obligatoria");
                validado = false;

            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpmanUsuario.SetError(txtNombre, "La clave es obligatoria");
                validado = false;

            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                erpmanUsuario.SetError(txtApellido, "La clave es obligatoria");
                validado = false;

            }


            if (string.IsNullOrEmpty(txtidEmpleado.Text))
            {
                erpmanUsuario.SetError(txtidEmpleado, "El Id Empleado es obligatorio");
                validado = false;
            }

            if (cboCargo.SelectedIndex == -1)
            {
                erpmanUsuario.SetError(cboCargo, "Debe seleccionar un valor");
                validado = false;

            }

            return validado;

        }

        private void MantUsuario_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvManUsuarios.Rows.Count > 0)
            {
                int IdUsuario = Convert.ToInt32(dgvManUsuarios.SelectedRows[0].Cells["ID"].Value);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);


                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        UsuariosBLL.Borrar(IdUsuario);

                        InicializarControles();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los datos obligatorios estén completos
            if (!validardatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UsuariosEntity usuarios = new UsuariosEntity();

                usuarios.ID = Convert.ToInt32(txtID.Text);
                usuarios.EmpleadoID = Convert.ToInt32(txtidEmpleado.Text);
                usuarios.Nombre = txtNombre.Text.Trim();
                usuarios.clave = txtclave.Text.Trim();
                usuarios.Apellido = txtApellido.Text.Trim();
                usuarios.correo = txtCorreo.Text.Trim();
                usuarios.nombreUsuario = txtUsuario.Text.Trim();
                usuarios.Cargo = cboCargo.SelectedItem?.ToString() ?? throw new InvalidOperationException("Seleccione un Cargo.");
               
                UsuariosBLL.Guardar(usuarios);
                MessageBox.Show("DATOS REGISTRADO CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvManUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvManUsuarios.Rows.Count)
            {
          
                DataGridViewRow selectedRow = dgvManUsuarios.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells["ID"].Value?.ToString() ?? string.Empty;
                txtidEmpleado.Text = selectedRow.Cells["EmpleadoID"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = selectedRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtclave.Text = selectedRow.Cells["sontrasena"].Value?.ToString() ?? string.Empty;
                txtApellido.Text = selectedRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                txtCorreo.Text = selectedRow.Cells["Correo"].Value?.ToString() ?? string.Empty;
                cboCargo.SelectedItem = selectedRow.Cells["Cargo"].Value?.ToString();
                txtUsuario.Text = selectedRow.Cells["nombreUsuario"].Value?.ToString() ?? string.Empty;
            }
        
        }
    }
}
