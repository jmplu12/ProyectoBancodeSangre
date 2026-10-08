using SistemaBancodeSangre.BLL;
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
    public partial class FrmListaMuestra : Form
    {
        public FrmListaMuestra()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = MuestraBLL.ObtenerTodas();
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InicializarControles();
        }

        private void FrmListaMuestra_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
