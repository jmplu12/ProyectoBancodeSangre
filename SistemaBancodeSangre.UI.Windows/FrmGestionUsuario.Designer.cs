namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmGestionUsuario
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
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgrgar = new Button();
            txttelefono = new TextBox();
            txtCorreo = new TextBox();
            txtID = new TextBox();
            txtApellidos = new TextBox();
            txtnombre = new TextBox();
            label13 = new Label();
            label6 = new Label();
            label12 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtUsuario = new TextBox();
            label14 = new Label();
            txtclave = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            dgvusuario = new DataGridView();
            BtnBuscarEmpleados = new Button();
            txtdireccion = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            txtidEmpleado = new TextBox();
            errorProvider = new ErrorProvider(components);
            cboCargo = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(352, 528);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 46);
            btnActualizar.TabIndex = 66;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(668, 528);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 46);
            btnEliminar.TabIndex = 65;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgrgar
            // 
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrgar.ForeColor = Color.White;
            btnAgrgar.Location = new Point(54, 528);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 46);
            btnAgrgar.TabIndex = 64;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(134, 459);
            txttelefono.Margin = new Padding(4, 5, 4, 5);
            txttelefono.Name = "txttelefono";
            txttelefono.ReadOnly = true;
            txttelefono.Size = new Size(255, 31);
            txttelefono.TabIndex = 59;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(134, 379);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(255, 31);
            txtCorreo.TabIndex = 58;
            // 
            // txtID
            // 
            txtID.Location = new Point(599, 166);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 31);
            txtID.TabIndex = 57;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(134, 298);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(255, 31);
            txtApellidos.TabIndex = 60;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(134, 228);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.Name = "txtnombre";
            txtnombre.ReadOnly = true;
            txtnombre.Size = new Size(255, 31);
            txtnombre.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(457, 463);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(118, 27);
            label13.TabIndex = 50;
            label13.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(466, 381);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 48;
            label6.Text = "Cargo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(13, 463);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 27);
            label12.TabIndex = 49;
            label12.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 383);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 27);
            label7.TabIndex = 47;
            label7.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 302);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 44;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 232);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 42;
            label3.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(457, 170);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 27);
            label1.TabIndex = 52;
            label1.Text = "ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(448, 228);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 27);
            label11.TabIndex = 50;
            label11.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(599, 224);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(255, 31);
            txtUsuario.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(448, 300);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(143, 27);
            label14.TabIndex = 50;
            label14.Text = "Contraseña:";
            // 
            // txtclave
            // 
            txtclave.Location = new Point(599, 298);
            txtclave.Margin = new Padding(4, 5, 4, 5);
            txtclave.MaxLength = 30;
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(255, 31);
            txtclave.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(289, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(378, 51);
            label2.TabIndex = 0;
            label2.Text = "Regitro de Usuario";
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
            panel1.Size = new Size(882, 93);
            panel1.TabIndex = 41;
            // 
            // dgvusuario
            // 
            dgvusuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuario.Dock = DockStyle.Bottom;
            dgvusuario.Location = new Point(0, 605);
            dgvusuario.Name = "dgvusuario";
            dgvusuario.RowHeadersWidth = 62;
            dgvusuario.RowTemplate.Height = 33;
            dgvusuario.Size = new Size(882, 97);
            dgvusuario.TabIndex = 67;
            // 
            // BtnBuscarEmpleados
            // 
            BtnBuscarEmpleados.BackColor = Color.Teal;
            BtnBuscarEmpleados.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarEmpleados.ForeColor = Color.White;
            BtnBuscarEmpleados.Location = new Point(24, 101);
            BtnBuscarEmpleados.Name = "BtnBuscarEmpleados";
            BtnBuscarEmpleados.Size = new Size(186, 40);
            BtnBuscarEmpleados.TabIndex = 68;
            BtnBuscarEmpleados.Text = "Buscar Empleado";
            BtnBuscarEmpleados.UseVisualStyleBackColor = false;
            BtnBuscarEmpleados.Click += BtnBuscarEmpleados_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(604, 463);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.ReadOnly = true;
            txtdireccion.Size = new Size(250, 31);
            txtdireccion.TabIndex = 70;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 169);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 72;
            label5.Text = "ID Empleado:";
            // 
            // txtidEmpleado
            // 
            txtidEmpleado.Location = new Point(138, 170);
            txtidEmpleado.Name = "txtidEmpleado";
            txtidEmpleado.Size = new Size(150, 31);
            txtidEmpleado.TabIndex = 73;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Adminidtrador", "Responsable de Donaciones", "Técnico de Laboratorio", "Enc. Solicitudes" });
            cboCargo.Location = new Point(577, 377);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(277, 33);
            cboCargo.TabIndex = 74;
            // 
            // FrmGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 702);
            Controls.Add(cboCargo);
            Controls.Add(txtidEmpleado);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(txtdireccion);
            Controls.Add(BtnBuscarEmpleados);
            Controls.Add(dgvusuario);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgrgar);
            Controls.Add(txttelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtID);
            Controls.Add(txtclave);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellidos);
            Controls.Add(txtnombre);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmGestionUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmGestionUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgrgar;
        private TextBox txttelefono;
        private TextBox txtCorreo;
        private TextBox txtID;
        private TextBox txtApellidos;
        private TextBox txtnombre;
        private Label label13;
        private Label label6;
        private Label label12;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label11;
        private TextBox txtUsuario;
        private Label label14;
        private TextBox txtclave;
        private Label label2;
        private Panel panel1;
        private DataGridView dgvusuario;
        private Button BtnBuscarEmpleados;
        private TextBox txtdireccion;
        private TextBox textBox2;
        private Label label5;
        private TextBox txtidEmpleado;
        private ErrorProvider errorProvider;
        private ComboBox cboCargo;
    }
}