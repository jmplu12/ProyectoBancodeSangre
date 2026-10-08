namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmAgregarEmpleado
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
            dgvRegistroEmpleados = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellidos = new DataGridViewTextBoxColumn();
            ColCedula = new DataGridViewTextBoxColumn();
            ColEdad = new DataGridViewTextBoxColumn();
            ColSexo = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgrgar = new Button();
            txtCorreo = new TextBox();
            txtEdad = new TextBox();
            txtTelefono = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label7 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label9 = new Label();
            cboEstado = new ComboBox();
            txtnombre = new TextBox();
            txtApellidos = new TextBox();
            txtID = new TextBox();
            txtCedula = new TextBox();
            panel2 = new Panel();
            cboMunicipio = new ComboBox();
            label16 = new Label();
            dtFechaingreso = new DateTimePicker();
            label15 = new Label();
            txtdireccion = new TextBox();
            cboProvincia = new ComboBox();
            label14 = new Label();
            cboCargo = new ComboBox();
            cbosexo = new ComboBox();
            label11 = new Label();
            dtFechanac = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleados).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistroEmpleados
            // 
            dgvRegistroEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroEmpleados.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColApellidos, ColCedula, ColEdad, ColSexo, ColTelefono, ColCorreo, ColDireccion, Cargo, ColEstado });
            dgvRegistroEmpleados.Dock = DockStyle.Bottom;
            dgvRegistroEmpleados.Location = new Point(0, 595);
            dgvRegistroEmpleados.Margin = new Padding(4, 5, 4, 5);
            dgvRegistroEmpleados.Name = "dgvRegistroEmpleados";
            dgvRegistroEmpleados.RowHeadersWidth = 62;
            dgvRegistroEmpleados.RowTemplate.Height = 25;
            dgvRegistroEmpleados.Size = new Size(1364, 153);
            dgvRegistroEmpleados.TabIndex = 40;
            dgvRegistroEmpleados.CellClick += dgvRegistroEmpleados_CellClick;
            dgvRegistroEmpleados.CellContentClick += dgvRegistroEmpleados_CellContentClick;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "ID";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 8;
            ColId.Name = "ColId";
            ColId.Width = 150;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 150;
            // 
            // ColApellidos
            // 
            ColApellidos.DataPropertyName = "Apellido";
            ColApellidos.HeaderText = "Apellidos";
            ColApellidos.MinimumWidth = 8;
            ColApellidos.Name = "ColApellidos";
            ColApellidos.Width = 150;
            // 
            // ColCedula
            // 
            ColCedula.DataPropertyName = "Cedula";
            ColCedula.HeaderText = "Cedula";
            ColCedula.MinimumWidth = 8;
            ColCedula.Name = "ColCedula";
            ColCedula.Width = 150;
            // 
            // ColEdad
            // 
            ColEdad.DataPropertyName = "Edad";
            ColEdad.HeaderText = "Edad";
            ColEdad.MinimumWidth = 8;
            ColEdad.Name = "ColEdad";
            ColEdad.Width = 150;
            // 
            // ColSexo
            // 
            ColSexo.DataPropertyName = "sexo";
            ColSexo.HeaderText = "Sexo";
            ColSexo.MinimumWidth = 8;
            ColSexo.Name = "ColSexo";
            ColSexo.Width = 150;
            // 
            // ColTelefono
            // 
            ColTelefono.DataPropertyName = "telefono";
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.MinimumWidth = 8;
            ColTelefono.Name = "ColTelefono";
            ColTelefono.Width = 150;
            // 
            // ColCorreo
            // 
            ColCorreo.DataPropertyName = "Email";
            ColCorreo.HeaderText = "Correo";
            ColCorreo.MinimumWidth = 8;
            ColCorreo.Name = "ColCorreo";
            ColCorreo.Width = 150;
            // 
            // ColDireccion
            // 
            ColDireccion.DataPropertyName = "dirreccion";
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.MinimumWidth = 8;
            ColDireccion.Name = "ColDireccion";
            ColDireccion.Width = 150;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            Cargo.Width = 150;
            // 
            // ColEstado
            // 
            ColEstado.DataPropertyName = "Estado";
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 8;
            ColEstado.Name = "ColEstado";
            ColEstado.Width = 150;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(495, 523);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 51);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(832, 523);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 51);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgrgar
            // 
            btnAgrgar.Location = new Point(181, 523);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 51);
            btnAgrgar.TabIndex = 37;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = true;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(147, 463);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(296, 35);
            txtCorreo.TabIndex = 33;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(810, 228);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(76, 35);
            txtEdad.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(579, 382);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(309, 35);
            txtTelefono.TabIndex = 34;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(930, 382);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 23;
            label13.Text = "Direccion:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(454, 390);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 27);
            label12.TabIndex = 22;
            label12.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 471);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 27);
            label7.TabIndex = 21;
            label7.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(454, 311);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 27);
            label10.TabIndex = 18;
            label10.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 398);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 17;
            label5.Text = "Cedula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 319);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 15;
            label4.Text = "Apellidos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(726, 236);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 27);
            label8.TabIndex = 14;
            label8.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 244);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 13;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(444, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(461, 60);
            label2.TabIndex = 0;
            label2.Text = "Agregar Empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 27);
            label1.TabIndex = 24;
            label1.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 96);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(454, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 21;
            label6.Text = "Cargo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(924, 163);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 27);
            label9.TabIndex = 23;
            label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Licencia" });
            cboEstado.Location = new Point(1045, 163);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(239, 35);
            cboEstado.TabIndex = 36;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(147, 241);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.MaxLength = 50;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(255, 35);
            txtnombre.TabIndex = 26;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(147, 311);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(255, 35);
            txtApellidos.TabIndex = 34;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // txtID
            // 
            txtID.Location = new Point(147, 159);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(96, 35);
            txtID.TabIndex = 29;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(147, 390);
            txtCedula.Margin = new Padding(4, 5, 4, 5);
            txtCedula.MaxLength = 11;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(255, 35);
            txtCedula.TabIndex = 34;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboMunicipio);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(dtFechaingreso);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(cboProvincia);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(cboCargo);
            panel2.Controls.Add(cbosexo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtFechanac);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvRegistroEmpleados);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnAgrgar);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cboEstado);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(txtApellidos);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(txtEdad);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1366, 750);
            panel2.TabIndex = 41;
            panel2.Paint += panel2_Paint;
            // 
            // cboMunicipio
            // 
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Neyba" });
            cboMunicipio.Location = new Point(1054, 300);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(230, 35);
            cboMunicipio.TabIndex = 51;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(928, 303);
            label16.Name = "label16";
            label16.Size = new Size(120, 27);
            label16.TabIndex = 50;
            label16.Text = "Municipio:";
            // 
            // dtFechaingreso
            // 
            dtFechaingreso.Location = new Point(633, 452);
            dtFechaingreso.Name = "dtFechaingreso";
            dtFechaingreso.Size = new Size(246, 35);
            dtFechaingreso.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(454, 460);
            label15.Name = "label15";
            label15.Size = new Size(173, 27);
            label15.TabIndex = 48;
            label15.Text = "Fecha Ingreso:";
            // 
            // txtdireccion
            // 
            txtdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdireccion.Location = new Point(1058, 379);
            txtdireccion.MaxLength = 300;
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(271, 89);
            txtdireccion.TabIndex = 47;
            txtdireccion.KeyPress += txtdireccion_KeyPress;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Items.AddRange(new object[] { "Bahoruco", "San Juan ", "Barahona" });
            cboProvincia.Location = new Point(1046, 223);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(238, 35);
            cboProvincia.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(924, 231);
            label14.Name = "label14";
            label14.Size = new Size(116, 27);
            label14.TabIndex = 45;
            label14.Text = "Provincia:";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Administrador", "Responsable de Donaciones", "Técnico de Laboratorio", "Enc. Solicitudes" });
            cboCargo.Location = new Point(563, 155);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(316, 35);
            cboCargo.TabIndex = 44;
            // 
            // cbosexo
            // 
            cbosexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "M", "F" });
            cbosexo.Location = new Point(579, 303);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(182, 35);
            cbosexo.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(445, 236);
            label11.Name = "label11";
            label11.Size = new Size(122, 27);
            label11.TabIndex = 42;
            label11.Text = "Fecha Nc:";
            // 
            // dtFechanac
            // 
            dtFechanac.Location = new Point(573, 230);
            dtFechanac.Name = "dtFechanac";
            dtFechanac.Size = new Size(142, 35);
            dtFechanac.TabIndex = 41;
            dtFechanac.ValueChanged += dtFechanac_ValueChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 750);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmAgregarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRegistroEmpleados;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgrgar;
        private TextBox txtCorreo;
        private TextBox txtEdad;
        private TextBox txtTelefono;
        private Label label13;
        private Label label12;
        private Label label7;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label9;
        private ComboBox cboEstado;
        private TextBox txtnombre;
        private TextBox txtApellidos;
        private TextBox txtID;
        private TextBox txtCedula;
        private Panel panel2;
        private ComboBox cboCargo;
        private ComboBox cbosexo;
        private Label label11;
        private DateTimePicker dtFechanac;
        private TextBox txtdireccion;
        private ComboBox cboProvincia;
        private Label label14;
        private Label label16;
        private DateTimePicker dtFechaingreso;
        private Label label15;
        private ComboBox cboMunicipio;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellidos;
        private DataGridViewTextBoxColumn ColCedula;
        private DataGridViewTextBoxColumn ColEdad;
        private DataGridViewTextBoxColumn ColSexo;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn ColEstado;
    }
}