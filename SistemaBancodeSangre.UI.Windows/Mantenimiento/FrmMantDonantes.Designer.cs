namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantDonantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlBase = new Panel();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            grbDonantes = new GroupBox();
            label16 = new Label();
            cboMunicipio = new ComboBox();
            cboProvincia = new ComboBox();
            label15 = new Label();
            txtCorreo = new TextBox();
            txtEdad = new TextBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            label13 = new Label();
            label7 = new Label();
            cboTiposangre = new ComboBox();
            cbosexo = new ComboBox();
            label14 = new Label();
            cboTipoDonante = new ComboBox();
            label9 = new Label();
            txtPesokg = new TextBox();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            txttelefono = new TextBox();
            dtFechaNac = new DateTimePicker();
            txtCedula = new TextBox();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtIdDonante = new TextBox();
            txtNombre = new TextBox();
            dgvMantDonantes = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            epmanDon = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbDonantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantDonantes).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epmanDon).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbDonantes);
            pnlBase.Controls.Add(dgvMantDonantes);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(15, 8);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1515, 734);
            pnlBase.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1316, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 53);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1316, 149);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(186, 51);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1316, 90);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 51);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbDonantes
            // 
            grbDonantes.Controls.Add(label16);
            grbDonantes.Controls.Add(cboMunicipio);
            grbDonantes.Controls.Add(cboProvincia);
            grbDonantes.Controls.Add(label15);
            grbDonantes.Controls.Add(txtCorreo);
            grbDonantes.Controls.Add(txtEdad);
            grbDonantes.Controls.Add(label8);
            grbDonantes.Controls.Add(txtDireccion);
            grbDonantes.Controls.Add(label13);
            grbDonantes.Controls.Add(label7);
            grbDonantes.Controls.Add(cboTiposangre);
            grbDonantes.Controls.Add(cbosexo);
            grbDonantes.Controls.Add(label14);
            grbDonantes.Controls.Add(cboTipoDonante);
            grbDonantes.Controls.Add(label9);
            grbDonantes.Controls.Add(txtPesokg);
            grbDonantes.Controls.Add(label5);
            grbDonantes.Controls.Add(label11);
            grbDonantes.Controls.Add(label12);
            grbDonantes.Controls.Add(txttelefono);
            grbDonantes.Controls.Add(dtFechaNac);
            grbDonantes.Controls.Add(txtCedula);
            grbDonantes.Controls.Add(label10);
            grbDonantes.Controls.Add(label4);
            grbDonantes.Controls.Add(label3);
            grbDonantes.Controls.Add(txtApellidos);
            grbDonantes.Controls.Add(label2);
            grbDonantes.Controls.Add(label6);
            grbDonantes.Controls.Add(txtIdDonante);
            grbDonantes.Controls.Add(txtNombre);
            grbDonantes.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbDonantes.Location = new Point(23, 90);
            grbDonantes.Name = "grbDonantes";
            grbDonantes.Size = new Size(1287, 397);
            grbDonantes.TabIndex = 2;
            grbDonantes.TabStop = false;
            grbDonantes.Text = "Datos Donantes";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(858, 141);
            label16.Name = "label16";
            label16.Size = new Size(110, 25);
            label16.TabIndex = 34;
            label16.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            cboMunicipio.Anchor = AnchorStyles.Top;
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Neyba" });
            cboMunicipio.Location = new Point(980, 136);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(219, 33);
            cboMunicipio.TabIndex = 33;
            // 
            // cboProvincia
            // 
            cboProvincia.Anchor = AnchorStyles.Top;
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Items.AddRange(new object[] { "Bahoruco" });
            cboProvincia.Location = new Point(980, 85);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(219, 33);
            cboProvincia.TabIndex = 32;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(858, 89);
            label15.Name = "label15";
            label15.Size = new Size(108, 25);
            label15.TabIndex = 31;
            label15.Text = "Provincia:";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top;
            txtCorreo.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(980, 40);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(219, 33);
            txtCorreo.TabIndex = 28;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top;
            txtEdad.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(557, 271);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(202, 33);
            txtEdad.TabIndex = 29;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(473, 276);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 25;
            label8.Text = "Edad:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(903, 210);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.MaxLength = 300;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(296, 109);
            txtDireccion.TabIndex = 30;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(858, 178);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(109, 25);
            label13.TabIndex = 26;
            label13.Text = "Direccion:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(881, 46);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 27;
            label7.Text = "Correo:";
            // 
            // cboTiposangre
            // 
            cboTiposangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposangre.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboTiposangre.FormattingEnabled = true;
            cboTiposangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cboTiposangre.Location = new Point(596, 221);
            cboTiposangre.Margin = new Padding(4, 5, 4, 5);
            cboTiposangre.Name = "cboTiposangre";
            cboTiposangre.Size = new Size(120, 33);
            cboTiposangre.TabIndex = 23;
            // 
            // cbosexo
            // 
            cbosexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbosexo.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbosexo.Location = new Point(534, 42);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(182, 33);
            cbosexo.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(409, 224);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(166, 25);
            label14.TabIndex = 15;
            label14.Text = "Tipo de Sangre:";
            // 
            // cboTipoDonante
            // 
            cboTipoDonante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDonante.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoDonante.FormattingEnabled = true;
            cboTipoDonante.Items.AddRange(new object[] { "Voluntario", "Recurrente", "Esporadico", "Aferesis", "Reposicion o Familiar", "Comercial", "Unico", "Autologo" });
            cboTipoDonante.Location = new Point(211, 227);
            cboTipoDonante.Margin = new Padding(4, 5, 4, 5);
            cboTipoDonante.Name = "cboTipoDonante";
            cboTipoDonante.Size = new Size(190, 33);
            cboTipoDonante.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(420, 156);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 16;
            label9.Text = "Peso kg:";
            // 
            // txtPesokg
            // 
            txtPesokg.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesokg.Location = new Point(534, 153);
            txtPesokg.Margin = new Padding(4, 5, 4, 5);
            txtPesokg.Name = "txtPesokg";
            txtPesokg.Size = new Size(182, 33);
            txtPesokg.TabIndex = 20;
            txtPesokg.KeyPress += txtPesokg_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 183);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 11;
            label5.Text = "Cedula:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 234);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 12;
            label11.Text = "Tipo de Donante:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(430, 94);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 19;
            label12.Text = "Telefono:";
            // 
            // txttelefono
            // 
            txttelefono.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefono.Location = new Point(537, 94);
            txttelefono.Margin = new Padding(4, 5, 4, 5);
            txttelefono.MaxLength = 10;
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(179, 33);
            txttelefono.TabIndex = 21;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // dtFechaNac
            // 
            dtFechaNac.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaNac.Location = new Point(150, 274);
            dtFechaNac.Margin = new Padding(4, 5, 4, 5);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(255, 33);
            dtFechaNac.TabIndex = 22;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.Location = new Point(131, 180);
            txtCedula.Margin = new Padding(4, 5, 4, 5);
            txtCedula.MaxLength = 11;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(270, 33);
            txtCedula.TabIndex = 16;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(445, 45);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 17;
            label10.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 10;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 9;
            label3.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(132, 137);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(269, 33);
            txtApellidos.TabIndex = 15;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 27);
            label2.TabIndex = 8;
            label2.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 274);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 27);
            label6.TabIndex = 18;
            label6.Text = "Fecha Nac:";
            // 
            // txtIdDonante
            // 
            txtIdDonante.Location = new Point(57, 42);
            txtIdDonante.Margin = new Padding(4, 5, 4, 5);
            txtIdDonante.Name = "txtIdDonante";
            txtIdDonante.ReadOnly = true;
            txtIdDonante.Size = new Size(125, 33);
            txtIdDonante.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(131, 91);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 33);
            txtNombre.TabIndex = 14;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // dgvMantDonantes
            // 
            dgvMantDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantDonantes.Location = new Point(11, 501);
            dgvMantDonantes.Name = "dgvMantDonantes";
            dgvMantDonantes.RowHeadersWidth = 62;
            dgvMantDonantes.RowTemplate.Height = 33;
            dgvMantDonantes.Size = new Size(1299, 225);
            dgvMantDonantes.TabIndex = 1;
            dgvMantDonantes.CellDoubleClick += dgvMantDonantes_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1514, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(258, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Donantes";
            // 
            // epmanDon
            // 
            epmanDon.ContainerControl = this;
            // 
            // FrmMantDonantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 741);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantDonantes";
            Text = "FrmMantDonantes";
            Load += FrmMantDonantes_Load;
            pnlBase.ResumeLayout(false);
            grbDonantes.ResumeLayout(false);
            grbDonantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantDonantes).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epmanDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Panel pnlEncabezado;
        private GroupBox grbDonantes;
        private DataGridView dgvMantDonantes;
        private Label label1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private ComboBox cboTipoDonante;
        private Label label5;
        private Label label11;
        private TextBox txtCedula;
        private Label label4;
        private Label label3;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtIdDonante;
        private TextBox txtNombre;
        private ComboBox cboTiposangre;
        private Label label14;
        private TextBox txtPesokg;
        private Label label9;
        private TextBox txttelefono;
        private Label label12;
        private ComboBox cbosexo;
        private DateTimePicker dtFechaNac;
        private Label label10;
        private Label label6;
        private Label label16;
        private ComboBox cboMunicipio;
        private ComboBox cboProvincia;
        private Label label15;
        private TextBox txtCorreo;
        private TextBox txtEdad;
        private Label label8;
        private TextBox txtDireccion;
        private Label label13;
        private Label label7;
        private ErrorProvider epmanDon;
    }
}