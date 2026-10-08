namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantEmpleados
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
            grbEmpleados = new GroupBox();
            cboCargo = new ComboBox();
            txtdireccion = new TextBox();
            label13 = new Label();
            cboMunicipio = new ComboBox();
            label16 = new Label();
            cboProvincia = new ComboBox();
            label14 = new Label();
            label9 = new Label();
            cboEstado = new ComboBox();
            dtFechaingreso = new DateTimePicker();
            label15 = new Label();
            cbosexo = new ComboBox();
            label11 = new Label();
            dtFechanac = new DateTimePicker();
            label6 = new Label();
            txtEdad = new TextBox();
            label10 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            label12 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtCedula = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtID = new TextBox();
            dgvMantEmpleados = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            epmanEmp = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantEmpleados).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epmanEmp).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.BorderStyle = BorderStyle.FixedSingle;
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbEmpleados);
            pnlBase.Controls.Add(dgvMantEmpleados);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(19, 12);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1453, 791);
            pnlBase.TabIndex = 1;
            pnlBase.Paint += pnlBase_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1270, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1270, 167);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(177, 44);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1270, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(177, 44);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbEmpleados
            // 
            grbEmpleados.Controls.Add(cboCargo);
            grbEmpleados.Controls.Add(txtdireccion);
            grbEmpleados.Controls.Add(label13);
            grbEmpleados.Controls.Add(cboMunicipio);
            grbEmpleados.Controls.Add(label16);
            grbEmpleados.Controls.Add(cboProvincia);
            grbEmpleados.Controls.Add(label14);
            grbEmpleados.Controls.Add(label9);
            grbEmpleados.Controls.Add(cboEstado);
            grbEmpleados.Controls.Add(dtFechaingreso);
            grbEmpleados.Controls.Add(label15);
            grbEmpleados.Controls.Add(cbosexo);
            grbEmpleados.Controls.Add(label11);
            grbEmpleados.Controls.Add(dtFechanac);
            grbEmpleados.Controls.Add(label6);
            grbEmpleados.Controls.Add(txtEdad);
            grbEmpleados.Controls.Add(label10);
            grbEmpleados.Controls.Add(txtTelefono);
            grbEmpleados.Controls.Add(label8);
            grbEmpleados.Controls.Add(label12);
            grbEmpleados.Controls.Add(txtCorreo);
            grbEmpleados.Controls.Add(label5);
            grbEmpleados.Controls.Add(label7);
            grbEmpleados.Controls.Add(txtCedula);
            grbEmpleados.Controls.Add(label4);
            grbEmpleados.Controls.Add(txtApellidos);
            grbEmpleados.Controls.Add(label3);
            grbEmpleados.Controls.Add(label2);
            grbEmpleados.Controls.Add(txtnombre);
            grbEmpleados.Controls.Add(txtID);
            grbEmpleados.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbEmpleados.Location = new Point(44, 90);
            grbEmpleados.Name = "grbEmpleados";
            grbEmpleados.Size = new Size(1197, 339);
            grbEmpleados.TabIndex = 2;
            grbEmpleados.TabStop = false;
            grbEmpleados.Text = "Datos Empleados";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Doctor", "Responsable de Donaciones", "Técnico de Laboratorio", "Enc. Solicitudes" });
            cboCargo.Location = new Point(97, 284);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(316, 34);
            cboCargo.TabIndex = 73;
            // 
            // txtdireccion
            // 
            txtdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdireccion.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtdireccion.Location = new Point(764, 159);
            txtdireccion.MaxLength = 300;
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(359, 118);
            txtdireccion.TabIndex = 72;
            txtdireccion.KeyPress += txtdireccion_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(754, 125);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(92, 26);
            label13.TabIndex = 71;
            label13.Text = "Direccion:";
            // 
            // cboMunicipio
            // 
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Neyba" });
            cboMunicipio.Location = new Point(859, 76);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(192, 34);
            cboMunicipio.TabIndex = 70;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(754, 77);
            label16.Name = "label16";
            label16.Size = new Size(93, 26);
            label16.TabIndex = 69;
            label16.Text = "Municipio:";
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Items.AddRange(new object[] { "Bahoruco", "San Juan ", "Barahona" });
            cboProvincia.Location = new Point(859, 35);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(192, 34);
            cboProvincia.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(754, 38);
            label14.Name = "label14";
            label14.Size = new Size(91, 26);
            label14.TabIndex = 67;
            label14.Text = "Provincia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(432, 261);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 26);
            label9.TabIndex = 65;
            label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Licencia" });
            cboEstado.Location = new Point(553, 261);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(156, 34);
            cboEstado.TabIndex = 66;
            // 
            // dtFechaingreso
            // 
            dtFechaingreso.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaingreso.Location = new Point(553, 215);
            dtFechaingreso.Name = "dtFechaingreso";
            dtFechaingreso.Size = new Size(156, 33);
            dtFechaingreso.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(407, 222);
            label15.Name = "label15";
            label15.Size = new Size(131, 26);
            label15.TabIndex = 63;
            label15.Text = "Fecha Ingreso:";
            // 
            // cbosexo
            // 
            cbosexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbosexo.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "M", "F" });
            cbosexo.Location = new Point(535, 125);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(174, 34);
            cbosexo.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(407, 38);
            label11.Name = "label11";
            label11.Size = new Size(94, 26);
            label11.TabIndex = 60;
            label11.Text = "Fecha Nc:";
            // 
            // dtFechanac
            // 
            dtFechanac.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechanac.Location = new Point(535, 38);
            dtFechanac.Name = "dtFechanac";
            dtFechanac.Size = new Size(174, 33);
            dtFechanac.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 55;
            label6.Text = "Cargo:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(536, 80);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(173, 33);
            txtEdad.TabIndex = 57;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(457, 128);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 26);
            label10.TabIndex = 54;
            label10.Text = "Sexo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(535, 170);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 33);
            txtTelefono.TabIndex = 58;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(453, 83);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 26);
            label8.TabIndex = 53;
            label8.Text = "Edad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(420, 176);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(87, 26);
            label12.TabIndex = 56;
            label12.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(101, 235);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(231, 33);
            txtCorreo.TabIndex = 50;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 194);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 45;
            label5.Text = "Cedula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 237);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 27);
            label7.TabIndex = 46;
            label7.Text = "Email:";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.Location = new Point(110, 188);
            txtCedula.Margin = new Padding(4, 5, 4, 5);
            txtCedula.MaxLength = 11;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(222, 33);
            txtCedula.TabIndex = 52;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 44;
            label4.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(122, 144);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(210, 33);
            txtApellidos.TabIndex = 51;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 43;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 27);
            label2.TabIndex = 47;
            label2.Text = "ID:";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(122, 93);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.MaxLength = 50;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(210, 33);
            txtnombre.TabIndex = 48;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtID
            // 
            txtID.Location = new Point(57, 41);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(96, 33);
            txtID.TabIndex = 49;
            // 
            // dgvMantEmpleados
            // 
            dgvMantEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantEmpleados.Location = new Point(32, 447);
            dgvMantEmpleados.Name = "dgvMantEmpleados";
            dgvMantEmpleados.RowHeadersWidth = 62;
            dgvMantEmpleados.RowTemplate.Height = 33;
            dgvMantEmpleados.Size = new Size(1209, 337);
            dgvMantEmpleados.TabIndex = 1;
            dgvMantEmpleados.CellDoubleClick += dgvMantEmpleados_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1468, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(274, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Empleados";
            // 
            // epmanEmp
            // 
            epmanEmp.ContainerControl = this;
            // 
            // FrmMantEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 815);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMantEmpleados";
            Load += FrmMantEmpleados_Load;
            pnlBase.ResumeLayout(false);
            grbEmpleados.ResumeLayout(false);
            grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantEmpleados).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epmanEmp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbEmpleados;
        private DataGridView dgvMantEmpleados;
        private Panel pnlEncabezado;
        private Label label1;
        private TextBox txtCorreo;
        private Label label5;
        private Label label7;
        private TextBox txtCedula;
        private Label label4;
        private TextBox txtApellidos;
        private Label label3;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtID;
        private DateTimePicker dtFechaingreso;
        private Label label15;
        private ComboBox cbosexo;
        private Label label11;
        private DateTimePicker dtFechanac;
        private Label label6;
        private TextBox txtEdad;
        private Label label10;
        private TextBox txtTelefono;
        private Label label8;
        private Label label12;
        private ComboBox cboMunicipio;
        private Label label16;
        private ComboBox cboProvincia;
        private Label label14;
        private Label label9;
        private ComboBox cboEstado;
        private TextBox txtdireccion;
        private Label label13;
        private ErrorProvider epmanEmp;
        private ComboBox cboCargo;
    }
}