namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListadoDeDonantes
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
            panel1 = new Panel();
            dgvListaDonantes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            pesoklg = new DataGridViewTextBoxColumn();
            tipoDeSangre = new DataGridViewTextBoxColumn();
            tipodeDonante = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            Municipio = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Dirreccion = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDonantes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvListaDonantes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 778);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dgvListaDonantes
            // 
            dgvListaDonantes.AllowUserToAddRows = false;
            dgvListaDonantes.AllowUserToDeleteRows = false;
            dgvListaDonantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDonantes.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, sexo, cedula, telefono, edad, pesoklg, tipoDeSangre, tipodeDonante, fechaNacimiento, correo, Municipio, Provincia, Dirreccion });
            dgvListaDonantes.Location = new Point(4, 199);
            dgvListaDonantes.Margin = new Padding(4, 5, 4, 5);
            dgvListaDonantes.Name = "dgvListaDonantes";
            dgvListaDonantes.ReadOnly = true;
            dgvListaDonantes.RowHeadersWidth = 62;
            dgvListaDonantes.RowTemplate.Height = 25;
            dgvListaDonantes.Size = new Size(1403, 484);
            dgvListaDonantes.TabIndex = 41;
            dgvListaDonantes.CellContentClick += dgvListaDonantes_CellContentClick;
            dgvListaDonantes.CellDoubleClick += dgvListaDonantes_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID Donantes";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombres";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "apellido";
            apellido.HeaderText = "Apellidos";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 150;
            // 
            // sexo
            // 
            sexo.DataPropertyName = "sexo";
            sexo.HeaderText = "Sexo";
            sexo.MinimumWidth = 8;
            sexo.Name = "sexo";
            sexo.ReadOnly = true;
            sexo.Width = 150;
            // 
            // cedula
            // 
            cedula.DataPropertyName = "cedula";
            cedula.HeaderText = "Cedula";
            cedula.MinimumWidth = 8;
            cedula.Name = "cedula";
            cedula.ReadOnly = true;
            cedula.Width = 150;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 8;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 150;
            // 
            // edad
            // 
            edad.DataPropertyName = "edad";
            edad.HeaderText = "Edad";
            edad.MinimumWidth = 8;
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 150;
            // 
            // pesoklg
            // 
            pesoklg.DataPropertyName = "pesoklg";
            pesoklg.HeaderText = "Peso KLG";
            pesoklg.MinimumWidth = 8;
            pesoklg.Name = "pesoklg";
            pesoklg.ReadOnly = true;
            pesoklg.Width = 150;
            // 
            // tipoDeSangre
            // 
            tipoDeSangre.DataPropertyName = "tipoDeSangre";
            tipoDeSangre.HeaderText = "Tipo Sangre";
            tipoDeSangre.MinimumWidth = 8;
            tipoDeSangre.Name = "tipoDeSangre";
            tipoDeSangre.ReadOnly = true;
            tipoDeSangre.Width = 150;
            // 
            // tipodeDonante
            // 
            tipodeDonante.DataPropertyName = "tipodeDonante";
            tipodeDonante.HeaderText = "Tipo Donante";
            tipodeDonante.MinimumWidth = 8;
            tipodeDonante.Name = "tipodeDonante";
            tipodeDonante.ReadOnly = true;
            tipodeDonante.Width = 150;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.DataPropertyName = "fechaNacimiento";
            fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            fechaNacimiento.MinimumWidth = 8;
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            fechaNacimiento.Width = 150;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 8;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 150;
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
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.MinimumWidth = 8;
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            Provincia.Width = 150;
            // 
            // Dirreccion
            // 
            Dirreccion.DataPropertyName = "Direccion";
            Dirreccion.HeaderText = "Direccion";
            Dirreccion.MinimumWidth = 8;
            Dirreccion.Name = "Dirreccion";
            Dirreccion.ReadOnly = true;
            Dirreccion.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1261, 130);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 52);
            button1.TabIndex = 40;
            button1.Text = "Informe";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(183, 133);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(238, 35);
            txtbuscar.TabIndex = 39;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(27, 130);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(135, 38);
            btnbuscar.TabIndex = 38;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1411, 106);
            panel2.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(538, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(478, 60);
            label2.TabIndex = 0;
            label2.Text = "Listado de Donantes";
            // 
            // FrmListadoDeDonantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 815);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListadoDeDonantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListadoDeDonantes";
            Load += FrmListadoDeDonantes_Load;
            KeyDown += FrmListadoDeDonantes_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDonantes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvListaDonantes;
        private Button button1;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn pesoklg;
        private DataGridViewTextBoxColumn tipoDeSangre;
        private DataGridViewTextBoxColumn tipodeDonante;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn Municipio;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Dirreccion;
    }
}