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
    public partial class FrmPerfilUsuario : Form
    {
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {

            cargar();
        }

        private void cargar()
        {
            // Asumiendo que tienes un TextBox para el ID del usuario
            int idUsuario;

            // Verificar si el ID ingresado es un número válido
            if (int.TryParse(txtID.Text, out idUsuario))
            {
                using (var dbContext = new AppDbContext())
                {
                    // Obtener el usuario desde la base de datos
                    var usuario = dbContext.Usuarios.FirstOrDefault(u => u.ID == idUsuario);

                    if (usuario != null)
                    {
                        // Cargar los datos en los TextBox
                        txtUsurio.Text = usuario.nombreUsuario; 
                        txtNombreCompleto.Text = usuario.Nombre;
                        txtcorreo.Text = usuario.correo; 
                        txttelefono.Text = usuario.telefono; 
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
