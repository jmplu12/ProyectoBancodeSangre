namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class MantUsuario
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
            grbUsuarios = new GroupBox();
            cboCargo = new ComboBox();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtidEmpleado = new TextBox();
            label5 = new Label();
            txtID = new TextBox();
            txtclave = new TextBox();
            txtUsuario = new TextBox();
            label14 = new Label();
            label11 = new Label();
            label6 = new Label();
            label2 = new Label();
            dgvManUsuarios = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            erpmanUsuario = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManUsuarios).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpmanUsuario).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbUsuarios);
            pnlBase.Controls.Add(dgvManUsuarios);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(12, 12);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1390, 725);
            pnlBase.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1155, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 52);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1155, 166);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(188, 50);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1155, 107);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbUsuarios
            // 
            grbUsuarios.Controls.Add(cboCargo);
            grbUsuarios.Controls.Add(txtCorreo);
            grbUsuarios.Controls.Add(label7);
            grbUsuarios.Controls.Add(txtApellido);
            grbUsuarios.Controls.Add(label3);
            grbUsuarios.Controls.Add(txtNombre);
            grbUsuarios.Controls.Add(label4);
            grbUsuarios.Controls.Add(txtidEmpleado);
            grbUsuarios.Controls.Add(label5);
            grbUsuarios.Controls.Add(txtID);
            grbUsuarios.Controls.Add(txtclave);
            grbUsuarios.Controls.Add(txtUsuario);
            grbUsuarios.Controls.Add(label14);
            grbUsuarios.Controls.Add(label11);
            grbUsuarios.Controls.Add(label6);
            grbUsuarios.Controls.Add(label2);
            grbUsuarios.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbUsuarios.Location = new Point(23, 90);
            grbUsuarios.Name = "grbUsuarios";
            grbUsuarios.Size = new Size(1126, 193);
            grbUsuarios.TabIndex = 2;
            grbUsuarios.TabStop = false;
            grbUsuarios.Text = "Datos Usuarios";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Administrador", "Responsable de Donaciones", "Técnico de Laboratorio", "Enc. Solicitudes" });
            cboCargo.Location = new Point(768, 113);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(277, 34);
            cboCargo.TabIndex = 101;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(473, 93);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(235, 33);
            txtCorreo.TabIndex = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(387, 96);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 99;
            label7.Text = "Correo:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(471, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(235, 33);
            txtApellido.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(378, 50);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 97;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(103, 142);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 33);
            txtNombre.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-1, 148);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 95;
            label4.Text = "Nombre:";
            // 
            // txtidEmpleado
            // 
            txtidEmpleado.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtidEmpleado.Location = new Point(142, 89);
            txtidEmpleado.Name = "txtidEmpleado";
            txtidEmpleado.ReadOnly = true;
            txtidEmpleado.Size = new Size(189, 33);
            txtidEmpleado.TabIndex = 93;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(-8, 92);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 92;
            label5.Text = "ID Empleado:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(129, 42);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(202, 33);
            txtID.TabIndex = 87;
            // 
            // txtclave
            // 
            txtclave.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(841, 34);
            txtclave.Margin = new Padding(4, 5, 4, 5);
            txtclave.MaxLength = 30;
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(204, 33);
            txtclave.TabIndex = 85;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(473, 140);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(235, 33);
            txtUsuario.TabIndex = 86;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(754, 46);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(73, 25);
            label14.TabIndex = 80;
            label14.Text = "Clave:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(378, 148);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(93, 25);
            label11.TabIndex = 81;
            label11.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(768, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 78;
            label6.Text = "Cargo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-2, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 83;
            label2.Text = "ID Usuario:";
            // 
            // dgvManUsuarios
            // 
            dgvManUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManUsuarios.Location = new Point(11, 326);
            dgvManUsuarios.Name = "dgvManUsuarios";
            dgvManUsuarios.RowHeadersWidth = 62;
            dgvManUsuarios.RowTemplate.Height = 33;
            dgvManUsuarios.Size = new Size(1138, 347);
            dgvManUsuarios.TabIndex = 1;
            dgvManUsuarios.CellDoubleClick += dgvManUsuarios_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1389, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(251, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Usuarios";
            // 
            // erpmanUsuario
            // 
            erpmanUsuario.ContainerControl = this;
            // 
            // MantUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 749);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantUsuario";
            Text = "MantUsuarion";
            Load += MantUsuario_Load;
            pnlBase.ResumeLayout(false);
            grbUsuarios.ResumeLayout(false);
            grbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManUsuarios).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpmanUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbUsuarios;
        private DataGridView dgvManUsuarios;
        private Panel pnlEncabezado;
        private Label label1;
        private TextBox txtidEmpleado;
        private Label label5;
        private TextBox txtID;
        private TextBox txtclave;
        private TextBox txtUsuario;
        private Label label14;
        private Label label11;
        private Label label6;
        private Label label2;
        private ErrorProvider erpmanUsuario;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cboCargo;
    }
}