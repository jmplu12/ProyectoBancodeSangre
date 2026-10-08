namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmAgregarDonante
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtIdDonante = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            dtFechaNac = new DateTimePicker();
            txtPesokg = new TextBox();
            txtEdad = new TextBox();
            txttelefono = new TextBox();
            txtDireccion = new TextBox();
            cboTipoDonante = new ComboBox();
            btnAgrgar = new Button();
            btnEditar = new Button();
            dgvRegistroDonante = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            pesoklg = new DataGridViewTextBoxColumn();
            TipoDeSangre = new DataGridViewTextBoxColumn();
            tipodedonante = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            Municipio = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            label14 = new Label();
            cboTiposangre = new ComboBox();
            panel2 = new Panel();
            txtActualizar = new Button();
            label16 = new Label();
            cboMunicipio = new ComboBox();
            cbosexo = new ComboBox();
            cboProvincia = new ComboBox();
            label15 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroDonante).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1332, 110);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(546, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(427, 60);
            label2.TabIndex = 0;
            label2.Text = "Agregar Donantes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 27);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 4;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 4;
            label4.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 406);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 4;
            label5.Text = "Cedula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(471, 172);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 27);
            label6.TabIndex = 4;
            label6.Text = "Fecha Nac:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(942, 260);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 27);
            label7.TabIndex = 4;
            label7.Text = "Correo:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(942, 174);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 27);
            label8.TabIndex = 4;
            label8.Text = "Edad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(474, 406);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 27);
            label9.TabIndex = 4;
            label9.Text = "Peso kg:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(471, 253);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 27);
            label10.TabIndex = 4;
            label10.Text = "Sexo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(14, 499);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(196, 27);
            label11.TabIndex = 4;
            label11.Text = "Tipo de Donante:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(471, 334);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 27);
            label12.TabIndex = 4;
            label12.Text = "Telefono:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(915, 493);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 4;
            label13.Text = "Direccion:";
            // 
            // txtIdDonante
            // 
            txtIdDonante.Location = new Point(153, 172);
            txtIdDonante.Margin = new Padding(4, 5, 4, 5);
            txtIdDonante.Name = "txtIdDonante";
            txtIdDonante.ReadOnly = true;
            txtIdDonante.Size = new Size(125, 35);
            txtIdDonante.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 250);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 35);
            txtNombre.TabIndex = 5;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(153, 328);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(255, 35);
            txtApellidos.TabIndex = 5;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(153, 401);
            txtCedula.Margin = new Padding(4, 5, 4, 5);
            txtCedula.MaxLength = 11;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(255, 35);
            txtCedula.TabIndex = 5;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top;
            txtCorreo.Location = new Point(1068, 255);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(260, 35);
            txtCorreo.TabIndex = 5;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(620, 168);
            dtFechaNac.Margin = new Padding(4, 5, 4, 5);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(255, 35);
            dtFechaNac.TabIndex = 6;
            dtFechaNac.ValueChanged += dtFechaNac_ValueChanged;
            // 
            // txtPesokg
            // 
            txtPesokg.Location = new Point(620, 406);
            txtPesokg.Margin = new Padding(4, 5, 4, 5);
            txtPesokg.Name = "txtPesokg";
            txtPesokg.Size = new Size(182, 35);
            txtPesokg.TabIndex = 5;
            txtPesokg.KeyPress += txtPesokg_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top;
            txtEdad.Location = new Point(1068, 167);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(202, 35);
            txtEdad.TabIndex = 5;
           
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(620, 331);
            txttelefono.Margin = new Padding(4, 5, 4, 5);
            txttelefono.MaxLength = 10;
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(299, 35);
            txttelefono.TabIndex = 5;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.Location = new Point(1045, 480);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.MaxLength = 300;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(267, 71);
            txtDireccion.TabIndex = 5;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // cboTipoDonante
            // 
            cboTipoDonante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDonante.FormattingEnabled = true;
            cboTipoDonante.Items.AddRange(new object[] { "Voluntario", "Recurrente", "Esporadico", "Aferesis", "Reposicion o Familiar", "Comercial", "Unico", "Autologo" });
            cboTipoDonante.Location = new Point(218, 497);
            cboTipoDonante.Margin = new Padding(4, 5, 4, 5);
            cboTipoDonante.Name = "cboTipoDonante";
            cboTipoDonante.Size = new Size(190, 35);
            cboTipoDonante.TabIndex = 7;
            // 
            // btnAgrgar
            // 
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.FlatStyle = FlatStyle.Popup;
            btnAgrgar.ForeColor = Color.White;
            btnAgrgar.Location = new Point(218, 561);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(234, 43);
            btnAgrgar.TabIndex = 8;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Maroon;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(14, 119);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(274, 43);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Seleccionar Donantes";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvRegistroDonante
            // 
            dgvRegistroDonante.AllowUserToAddRows = false;
            dgvRegistroDonante.AllowUserToDeleteRows = false;
            dgvRegistroDonante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistroDonante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroDonante.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, cedula, edad, sexo, telefono, pesoklg, TipoDeSangre, tipodedonante, fechaNacimiento, correo, provincia, Municipio, Direccion });
            dgvRegistroDonante.Location = new Point(14, 614);
            dgvRegistroDonante.Margin = new Padding(4, 5, 4, 5);
            dgvRegistroDonante.Name = "dgvRegistroDonante";
            dgvRegistroDonante.ReadOnly = true;
            dgvRegistroDonante.RowHeadersWidth = 62;
            dgvRegistroDonante.RowTemplate.Height = 25;
            dgvRegistroDonante.Size = new Size(1298, 151);
            dgvRegistroDonante.TabIndex = 11;
            dgvRegistroDonante.CellClick += dgvRegistroDonante_CellClick;
            dgvRegistroDonante.CellContentClick += dgvRegistroDonante_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID Donante";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre ";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "Apellido";
            apellido.HeaderText = "Apellidos";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 150;
            // 
            // cedula
            // 
            cedula.DataPropertyName = "Cedula";
            cedula.HeaderText = "Cedula";
            cedula.MinimumWidth = 8;
            cedula.Name = "cedula";
            cedula.ReadOnly = true;
            cedula.Width = 150;
            // 
            // edad
            // 
            edad.DataPropertyName = "Edad";
            edad.HeaderText = "Edad";
            edad.MinimumWidth = 8;
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 150;
            // 
            // sexo
            // 
            sexo.DataPropertyName = "Sexo";
            sexo.HeaderText = "Sexo";
            sexo.MinimumWidth = 8;
            sexo.Name = "sexo";
            sexo.ReadOnly = true;
            sexo.Width = 150;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "Telefono";
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 8;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 150;
            // 
            // pesoklg
            // 
            pesoklg.DataPropertyName = "Pesoklg";
            pesoklg.HeaderText = "Peso kg";
            pesoklg.MinimumWidth = 8;
            pesoklg.Name = "pesoklg";
            pesoklg.ReadOnly = true;
            pesoklg.Width = 150;
            // 
            // TipoDeSangre
            // 
            TipoDeSangre.DataPropertyName = "TipoDeSangre";
            TipoDeSangre.HeaderText = "Tipo de Sangre";
            TipoDeSangre.MinimumWidth = 8;
            TipoDeSangre.Name = "TipoDeSangre";
            TipoDeSangre.ReadOnly = true;
            TipoDeSangre.Width = 150;
            // 
            // tipodedonante
            // 
            tipodedonante.DataPropertyName = "TipodeDonante";
            tipodedonante.HeaderText = "Tipo de Donante";
            tipodedonante.MinimumWidth = 8;
            tipodedonante.Name = "tipodedonante";
            tipodedonante.ReadOnly = true;
            tipodedonante.Width = 150;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.DataPropertyName = "FechaNacimiento";
            fechaNacimiento.HeaderText = "Fecha Nac";
            fechaNacimiento.MinimumWidth = 8;
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            fechaNacimiento.Width = 150;
            // 
            // correo
            // 
            correo.DataPropertyName = "Correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 8;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 150;
            // 
            // provincia
            // 
            provincia.DataPropertyName = "Provincia";
            provincia.HeaderText = "provincia";
            provincia.MinimumWidth = 8;
            provincia.Name = "provincia";
            provincia.ReadOnly = true;
            provincia.Width = 150;
            // 
            // Municipio
            // 
            Municipio.DataPropertyName = "Municipio";
            Municipio.HeaderText = "Municipio";
            Municipio.MinimumWidth = 8;
            Municipio.Name = "Municipio";
            Municipio.ReadOnly = true;
            Municipio.Width = 150;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 150;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(471, 493);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(183, 27);
            label14.TabIndex = 4;
            label14.Text = "Tipo de Sangre:";
            // 
            // cboTiposangre
            // 
            cboTiposangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposangre.FormattingEnabled = true;
            cboTiposangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cboTiposangre.Location = new Point(667, 490);
            cboTiposangre.Margin = new Padding(4, 5, 4, 5);
            cboTiposangre.Name = "cboTiposangre";
            cboTiposangre.Size = new Size(208, 35);
            cboTiposangre.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtActualizar);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(cboMunicipio);
            panel2.Controls.Add(cbosexo);
            panel2.Controls.Add(cboProvincia);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvRegistroDonante);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnAgrgar);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cboTiposangre);
            panel2.Controls.Add(txtIdDonante);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(cboTipoDonante);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(dtFechaNac);
            panel2.Controls.Add(txtApellidos);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(txtEdad);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtPesokg);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txttelefono);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label12);
            panel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(42, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(1334, 774);
            panel2.TabIndex = 31;
            // 
            // txtActualizar
            // 
            txtActualizar.BackColor = SystemColors.HotTrack;
            txtActualizar.FlatStyle = FlatStyle.Flat;
            txtActualizar.ForeColor = Color.White;
            txtActualizar.Location = new Point(764, 563);
            txtActualizar.Name = "txtActualizar";
            txtActualizar.Size = new Size(229, 43);
            txtActualizar.TabIndex = 17;
            txtActualizar.Text = "Actulizar Donantes";
            txtActualizar.UseVisualStyleBackColor = false;
            txtActualizar.Click += txtActualizar_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Location = new Point(942, 423);
            label16.Name = "label16";
            label16.Size = new Size(120, 27);
            label16.TabIndex = 16;
            label16.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            cboMunicipio.Anchor = AnchorStyles.Top;
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Neyba" });
            cboMunicipio.Location = new Point(1068, 415);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(202, 35);
            cboMunicipio.TabIndex = 15;
            // 
            // cbosexo
            // 
            cbosexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbosexo.Location = new Point(617, 251);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(182, 35);
            cbosexo.TabIndex = 14;
            // 
            // cboProvincia
            // 
            cboProvincia.Anchor = AnchorStyles.Top;
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Items.AddRange(new object[] { "Bahoruco" });
            cboProvincia.Location = new Point(1068, 334);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(202, 35);
            cboProvincia.TabIndex = 13;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(942, 337);
            label15.Name = "label15";
            label15.Size = new Size(116, 27);
            label15.TabIndex = 12;
            label15.Text = "Provincia:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmAgregarDonante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 815);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarDonante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarDonante";
            Load += FrmAgregarDonante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroDonante).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtIdDonante;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private DateTimePicker dtFechaNac;
        private TextBox txtPesokg;
        private TextBox txtEdad;
        private TextBox txttelefono;
        private TextBox txtDireccion;
        private ComboBox cboTipoDonante;
        private Button btnAgrgar;
        private Button btnEditar;
        private DataGridView dgvRegistroDonante;
        private Label label14;
        private ComboBox cboTiposangre;
        private Panel panel2;
        private ComboBox cboProvincia;
        private Label label15;
        private ErrorProvider errorProvider;
        private ComboBox cbosexo;
        private Label label16;
        private ComboBox cboMunicipio;
        private Button txtActualizar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn pesoklg;
        private DataGridViewTextBoxColumn TipoDeSangre;
        private DataGridViewTextBoxColumn tipodedonante;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn Municipio;
        private DataGridViewTextBoxColumn Direccion;
    }
}