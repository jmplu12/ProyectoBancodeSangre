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
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            txtID.Text = "0";
            txtnombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtdireccion.Clear();
            txtTelefono.Clear();
            dtFechanac.Text = "";
            dtFechaingreso.Text = "";
            txtEdad.Clear();
            txtCorreo.Clear();
            cboCargo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            cboProvincia.SelectedIndex = -1;
            cbosexo.SelectedIndex = -1;
            dgvRegistroEmpleados.ClearSelection();

        }

        private bool validarDatos()
        {
            bool validado = true;
            errorProvider.Clear();

            // Validar nombre
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                errorProvider.SetError(txtnombre, "El nombre es obligatorio.");
                validado = false;
            }

            // Validar apellidos
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            // Validar cédula
            if (string.IsNullOrEmpty(txtCedula.Text) || txtCedula.Text.Length != 11)
            {
                errorProvider.SetError(txtCedula, "La cedula debe tener exactamente 11 dígitos.");
                validado = false;
            }

            // Validar dirección
            if (string.IsNullOrEmpty(txtdireccion.Text))
            {
                errorProvider.SetError(txtdireccion, "La dirección es obligatoria.");
                validado = false;
            }

            // Validar teléfono
            if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length != 10)
            {
                errorProvider.SetError(txtTelefono, "El teléfono debe tener exactamente 10 dígitos.");
                validado = false;
            }

            // Validar fecha de nacimiento
            if (string.IsNullOrEmpty(dtFechanac.Text))
            {
                errorProvider.SetError(dtFechanac, "La fecha de nacimiento es obligatoria.");
                validado = false;
            }

            // Validar edad
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                errorProvider.SetError(txtEdad, "La edad es obligatoria.");
                validado = false;
            }

            // Validar correo electrónico
            if (string.IsNullOrEmpty(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                errorProvider.SetError(txtCorreo, "El correo electrónico es obligatorio y debe ser válido.");
                validado = false;
            }

            // Validar cargo
            if (cboCargo.SelectedIndex == -1)
            {
                errorProvider.SetError(cboCargo, "Debe seleccionar un cargo.");
                validado = false;
            }

            // Validar estado
            if (cboEstado.SelectedIndex == -1)
            {
                errorProvider.SetError(cboEstado, "Debe seleccionar un estado.");
                validado = false;
            }

            // Validar provincia
            if (cboProvincia.SelectedIndex == -1)
            {
                errorProvider.SetError(cboProvincia, "Debe seleccionar una provincia.");
                validado = false;
            }

            // Validar sexo
            if (cbosexo.SelectedIndex == -1)
            {
                errorProvider.SetError(cbosexo, "Debe seleccionar un sexo.");
                validado = false;
            }

            return validado;
        }

        private void ptcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                EmpleadosEntity empleado = new EmpleadosEntity();
                empleado.ID = Convert.ToInt32(txtID.Text);
                empleado.nombre = txtnombre.Text;
                empleado.Apellido = txtApellidos.Text;
                empleado.cedula = txtCedula.Text;
                empleado.email = txtCorreo.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.FechaNac = Convert.ToDateTime(dtFechanac.Text);
                empleado.Edad = txtEdad.Text;
                empleado.cargo = cboCargo.SelectedItem.ToString();
                empleado.estado = cboEstado.SelectedItem.ToString() == "Activo";
                empleado.sexo = cbosexo.SelectedItem.ToString();
                //empleado.fecha_ingreso= Convert.ToDateTime(dtFechaingreso.Text);
                empleado.Municipio = cboMunicipio.SelectedItem.ToString();
                empleado.provincia = cboProvincia.SelectedItem.ToString();
                empleado.dirreccion = txtdireccion.Text;

                if (EmpleadoBLL.CedulaExiste(empleado.cedula, empleado.ID))
                {
                    MessageBox.Show(
                    "Ya existe un empleado registrado con esta cédula.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    txtCedula.Focus();
                    return;
                }

                EmpleadoBLL.Guardar(empleado);


                if (empleado.ID == 0)
                {
                    MessageBox.Show(
                    "EMPLEADO REGISTRADO CORRECTAMENTE.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                    "EMPLEADO ACTUALIZADO CORRECTAMENTE.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                InicializarControles();
            }


        }

        // Método para calcular la edad
        private string CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad.ToString();
        }

        private void dtFechanac_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
            DateTime fechaNacimiento = dtFechanac.Value;

            // Calcular la edad
            string edad = CalcularEdad(fechaNacimiento);

            // Asignar la edad al TextBox
            txtEdad.Text = edad;
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            InicializarControles();
            CargarEmpleados();
        }

        private void dgvRegistroEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvRegistroEmpleados.Rows[e.RowIndex];


                txtID.Text = fila.Cells["ID"].Value?.ToString() ?? string.Empty;


                txtnombre.Text = fila.Cells["nombre"].Value?.ToString() ?? string.Empty;


                txtApellidos.Text = fila.Cells["Apellido"].Value?.ToString() ?? string.Empty;


                txtCedula.Text = fila.Cells["cedula"].Value?.ToString() ?? string.Empty;


                txtTelefono.Text = fila.Cells["telefono"].Value?.ToString() ?? string.Empty;


                txtCorreo.Text = fila.Cells["email"].Value?.ToString() ?? string.Empty;


                txtEdad.Text = fila.Cells["Edad"].Value?.ToString() ?? string.Empty;


                txtdireccion.Text = fila.Cells["dirreccion"].Value?.ToString() ?? string.Empty;



                // ComboBox
                if (fila.Cells["cargo"].Value != null)
                {
                    cboCargo.SelectedItem = fila.Cells["cargo"].Value.ToString();
                }


                if (fila.Cells["provincia"].Value != null)
                {
                    cboProvincia.SelectedItem = fila.Cells["provincia"].Value.ToString();
                }


                if (fila.Cells["estado"].Value != null)
                {
                    cboEstado.SelectedItem = fila.Cells["estado"].Value.ToString();
                }


                if (fila.Cells["sexo"].Value != null)
                {
                    cbosexo.SelectedItem = fila.Cells["sexo"].Value.ToString();
                }



                // Fecha de nacimiento
                if (fila.Cells["FechaNac"].Value != null)
                {
                    dtFechanac.Value = Convert.ToDateTime(
                        fila.Cells["FechaNac"].Value
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar el empleado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Permitir Letras o Numeros en TXT 
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#')
            {
                e.Handled = true;

            }
        }

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }


            int id = Convert.ToInt32(txtID.Text);


            DialogResult respuesta =
            MessageBox.Show(
            "¿Desea eliminar este empleado?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {

                EmpleadoBLL.Borrar(id);


                MessageBox.Show(
                "Empleado eliminado correctamente.");


                InicializarControles();
                CargarEmpleados();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }


            btnAgrgar.PerformClick();
        }


        private void CargarEmpleados()
        {
            dgvRegistroEmpleados.AutoGenerateColumns = false;

            dgvRegistroEmpleados.DataSource =
                EmpleadoBLL.ObtenerTodas().ToList();
        }

        private void dgvRegistroEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvRegistroEmpleados.Rows[e.RowIndex];


                // Datos generales
                txtID.Text = fila.Cells["ID"].Value?.ToString() ?? string.Empty;

                txtnombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;

                txtApellidos.Text = fila.Cells["Apellido"].Value?.ToString() ?? string.Empty;

                txtCedula.Text = fila.Cells["Cedula"].Value?.ToString() ?? string.Empty;

                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? string.Empty;

                txtCorreo.Text = fila.Cells["Email"].Value?.ToString() ?? string.Empty;

                txtEdad.Text = fila.Cells["Edad"].Value?.ToString() ?? string.Empty;

                txtdireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? string.Empty;



                // ComboBox
                if (fila.Cells["Cargo"].Value != null)
                {
                    cboCargo.SelectedItem = fila.Cells["Cargo"].Value.ToString();
                }


                if (fila.Cells["Provincia"].Value != null)
                {
                    cboProvincia.SelectedItem = fila.Cells["Provincia"].Value.ToString();
                }


                if (fila.Cells["Estado"].Value != null)
                {
                    cboEstado.SelectedItem = fila.Cells["Estado"].Value.ToString();
                }


                if (fila.Cells["Sexo"].Value != null)
                {
                    cbosexo.SelectedItem = fila.Cells["Sexo"].Value.ToString();
                }



                // Fecha nacimiento
                if (fila.Cells["FechaNacimiento"].Value != null)
                {
                    dtFechanac.Value = Convert.ToDateTime(
                        fila.Cells["FechaNacimiento"].Value
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al seleccionar el empleado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
 }

