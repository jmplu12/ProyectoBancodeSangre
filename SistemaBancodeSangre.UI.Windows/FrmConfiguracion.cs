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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado formulario = new FrmAgregarEmpleado();
            formulario.ShowDialog();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FrmGestionUsuario formulario = new FrmGestionUsuario();
            formulario.ShowDialog();
        }

        private void btnSonreNosotros_Click(object sender, EventArgs e)
        {
            FrmSobreNosotros formulario = new FrmSobreNosotros();
            formulario.ShowDialog();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos formulario = new FrmPermisos();
            formulario.ShowDialog();
        }
    }
}
