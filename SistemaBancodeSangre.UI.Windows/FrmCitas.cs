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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FrmListadoDeDonantes frm = new FrmListadoDeDonantes();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DonantesEntity donante = DonantesDAL.GetById(frm.IdDonante);


                TxtDonanteID.Text = donante.ID.ToString();
                txtNombreCompleto.Text = donante.Nombre + " " + donante.Apellido;
                txtCorreo.Text = donante.Correo;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#')
            {
                e.Handled = true;

            }
        }
    }
}
