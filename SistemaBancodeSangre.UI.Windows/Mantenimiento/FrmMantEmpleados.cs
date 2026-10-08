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

namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    public partial class FrmMantEmpleados : Form
    {
        public FrmMantEmpleados()
        {
            InitializeComponent();
        }

        private void inicializarControles()
        {
            txtID.Text = "0";
            txtnombre.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            cboCargo.SelectedIndex = -1;
            cbosexo.SelectedIndex = -1;
            txtTelefono.Clear();
            txtEdad.Clear();
            cboEstado.SelectedIndex = -1;
            txtCorreo.Clear();
            cboProvincia.SelectedIndex = -1;
            cboMunicipio.SelectedIndex = -1;
            txtdireccion.Clear();
            dgvMantEmpleados.DataSource = EmpleadoBLL.ObtenerTodas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {

                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
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
                empleado.estado.ToString();
                empleado.sexo = cbosexo.SelectedItem.ToString();
                //empleado.fecha_ingreso= Convert.ToDateTime(dtFechaingreso.Text);
                empleado.Municipio = cboMunicipio.SelectedItem.ToString();
                empleado.provincia = cboProvincia.SelectedItem.ToString();
                empleado.dirreccion = txtdireccion.Text;
                EmpleadoBLL.Guardar(empleado);

                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inicializarControles(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtnombre.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            cboEstado.SelectedIndex = -1;
            cbosexo.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtEdad.Text = "";
            cboCargo.SelectedIndex = -1;
            txtCorreo.Text = "";
            cboProvincia.SelectedIndex = -1;
            cboMunicipio.SelectedIndex = -1;
            txtdireccion.Text = "";
        }

        private bool validarDatos()
        {
            bool validado = true;
            epmanEmp.Clear();

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                epmanEmp.SetError(txtnombre, "El nombre es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                epmanEmp.SetError(txtApellidos, "Los apellidos son obligatorios.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length != 10)
            {
                epmanEmp.SetError(txtTelefono, "El teléfono debe tener exactamente 10 dígitos.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtCedula.Text) || txtCedula.Text.Length != 11)
            {
                epmanEmp.SetError(txtCedula, "La cédula debe tener exactamente 11 dígitos.");
                validado = false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                epmanEmp.SetError(txtCorreo, "El correo electrónico es obligatorio y debe ser válido.");
                validado = false;
            }
            if (String.IsNullOrEmpty(txtCedula.Text))
            {
                epmanEmp.SetError(txtCedula, "La Cedula es Obligatoria.");
            }

            if (cboMunicipio.SelectedIndex == -1)
            {
                epmanEmp.SetError(cboMunicipio, "Debe eligir un valor");
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                epmanEmp.SetError(cboProvincia, "Debe eligir un valor");
            }

            if (cboEstado.SelectedIndex == -1)
            {
                epmanEmp.SetError(cboEstado, "Debe eligir un valor");
            }

            if (cbosexo.SelectedIndex == -1)
            {
                epmanEmp.SetError(cbosexo, "Debe eligir un valor");
            }

            return validado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMantEmpleados.Rows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvMantEmpleados.SelectedRows[0].Cells["ID"].Value);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                    "Confirmar eliminación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        EmpleadoBLL.Borrar(idEmpleado);

                        inicializarControles();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void FrmMantEmpleados_Load(object sender, EventArgs e)
        {
            inicializarControles();
        }


        private void pnlBase_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Permitir Letras y Numeros
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
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

        private void dgvMantEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0) // Verifica que no se haga clic en el encabezado
    {
        DataGridViewRow row = dgvMantEmpleados.Rows[e.RowIndex];

        // Asigna los valores de las celdas a los campos del formulario
        txtID.Text = row.Cells["ID"].Value.ToString();
        txtnombre.Text = row.Cells["nombre"].Value.ToString();
        txtApellidos.Text = row.Cells["Apellido"].Value.ToString();
        txtCedula.Text = row.Cells["cedula"].Value.ToString();
        txtCorreo.Text = row.Cells["email"].Value.ToString();
        txtTelefono.Text = row.Cells["telefono"].Value.ToString();
        dtFechanac.Text = row.Cells["FechaNac"].Value.ToString();
        txtEdad.Text = row.Cells["Edad"].Value.ToString();
        cboCargo.SelectedItem = row.Cells["cargo"].Value.ToString();
        cboEstado.SelectedItem = row.Cells["estado"].Value.ToString();
        cbosexo.SelectedItem = row.Cells["sexo"].Value.ToString();
        cboMunicipio.SelectedItem = row.Cells["Municipio"].Value.ToString();
        cboProvincia.SelectedItem = row.Cells["provincia"].Value.ToString();
        txtdireccion.Text = row.Cells["dirreccion"].Value.ToString();
    }
        }
    }
}