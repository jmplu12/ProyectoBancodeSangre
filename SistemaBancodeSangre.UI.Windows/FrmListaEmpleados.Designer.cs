namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListaEmpleados
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
            groupBox1 = new GroupBox();
            btnExportarPDF = new Button();
            btnExportarWord = new Button();
            btnExportarExcel = new Button();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            lblTotalEmpleados = new Label();
            cboEstado = new ComboBox();
            cboBuscarPor = new ComboBox();
            txtBuscarEmpleado = new TextBox();
            dgvRegistroEmpleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
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
            btnBuscar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTotalEmpleados);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(cboBuscarPor);
            panel1.Controls.Add(txtBuscarEmpleado);
            panel1.Controls.Add(dgvRegistroEmpleados);
            panel1.Controls.Add(btnBuscar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1709, 625);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportarPDF);
            groupBox1.Controls.Add(btnExportarWord);
            groupBox1.Controls.Add(btnExportarExcel);
            groupBox1.Location = new Point(29, 532);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 81);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reportes";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(505, 20);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(165, 34);
            btnExportarPDF.TabIndex = 2;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // btnExportarWord
            // 
            btnExportarWord.Location = new Point(298, 20);
            btnExportarWord.Name = "btnExportarWord";
            btnExportarWord.Size = new Size(160, 46);
            btnExportarWord.TabIndex = 1;
            btnExportarWord.Text = "Exportar Word";
            btnExportarWord.UseVisualStyleBackColor = true;
            btnExportarWord.Click += btnExportarWord_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(126, 20);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(137, 55);
            btnExportarExcel.TabIndex = 0;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(931, 124);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 49;
            label3.Text = "Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 124);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 48;
            label1.Text = "Buscar Por:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1709, 103);
            panel2.TabIndex = 47;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(640, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(512, 60);
            label2.TabIndex = 0;
            label2.Text = "Listado de Empleados";
            // 
            // lblTotalEmpleados
            // 
            lblTotalEmpleados.AutoSize = true;
            lblTotalEmpleados.Location = new Point(507, 142);
            lblTotalEmpleados.Name = "lblTotalEmpleados";
            lblTotalEmpleados.Size = new Size(0, 25);
            lblTotalEmpleados.TabIndex = 46;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(1061, 124);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(195, 33);
            cboEstado.TabIndex = 45;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // cboBuscarPor
            // 
            cboBuscarPor.FormattingEnabled = true;
            cboBuscarPor.Location = new Point(703, 124);
            cboBuscarPor.Name = "cboBuscarPor";
            cboBuscarPor.Size = new Size(199, 33);
            cboBuscarPor.TabIndex = 44;
            cboBuscarPor.SelectedIndexChanged += cboBuscarPor_SelectedIndexChanged;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Location = new Point(144, 120);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(384, 31);
            txtBuscarEmpleado.TabIndex = 43;
            txtBuscarEmpleado.TextChanged += txtBuscarEmpleado_TextChanged;
            // 
            // dgvRegistroEmpleados
            // 
            dgvRegistroEmpleados.AllowUserToAddRows = false;
            dgvRegistroEmpleados.AllowUserToDeleteRows = false;
            dgvRegistroEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistroEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, ColNombre, ColApellidos, ColCedula, ColEdad, ColSexo, ColTelefono, ColCorreo, ColDireccion, Cargo, ColEstado });
            dgvRegistroEmpleados.Location = new Point(0, 172);
            dgvRegistroEmpleados.Margin = new Padding(4, 5, 4, 5);
            dgvRegistroEmpleados.Name = "dgvRegistroEmpleados";
            dgvRegistroEmpleados.ReadOnly = true;
            dgvRegistroEmpleados.RowHeadersWidth = 62;
            dgvRegistroEmpleados.RowTemplate.Height = 25;
            dgvRegistroEmpleados.Size = new Size(1709, 352);
            dgvRegistroEmpleados.TabIndex = 41;
            dgvRegistroEmpleados.CellClick += dgvRegistroEmpleados_CellClick;
            dgvRegistroEmpleados.CellContentClick += dgvRegistroEmpleados_CellContentClick;
            dgvRegistroEmpleados.CellDoubleClick += dgvRegistroEmpleados_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 150;
            // 
            // ColApellidos
            // 
            ColApellidos.DataPropertyName = "Apellido";
            ColApellidos.HeaderText = "Apellidos";
            ColApellidos.MinimumWidth = 8;
            ColApellidos.Name = "ColApellidos";
            ColApellidos.ReadOnly = true;
            ColApellidos.Width = 150;
            // 
            // ColCedula
            // 
            ColCedula.DataPropertyName = "Cedula";
            ColCedula.HeaderText = "Cedula";
            ColCedula.MinimumWidth = 8;
            ColCedula.Name = "ColCedula";
            ColCedula.ReadOnly = true;
            ColCedula.Width = 150;
            // 
            // ColEdad
            // 
            ColEdad.DataPropertyName = "Edad";
            ColEdad.HeaderText = "Edad";
            ColEdad.MinimumWidth = 8;
            ColEdad.Name = "ColEdad";
            ColEdad.ReadOnly = true;
            ColEdad.Width = 150;
            // 
            // ColSexo
            // 
            ColSexo.DataPropertyName = "sexo";
            ColSexo.HeaderText = "Sexo";
            ColSexo.MinimumWidth = 8;
            ColSexo.Name = "ColSexo";
            ColSexo.ReadOnly = true;
            ColSexo.Width = 150;
            // 
            // ColTelefono
            // 
            ColTelefono.DataPropertyName = "telefono";
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.MinimumWidth = 8;
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            ColTelefono.Width = 150;
            // 
            // ColCorreo
            // 
            ColCorreo.DataPropertyName = "Email";
            ColCorreo.HeaderText = "Correo";
            ColCorreo.MinimumWidth = 8;
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            ColCorreo.Width = 150;
            // 
            // ColDireccion
            // 
            ColDireccion.DataPropertyName = "dirreccion";
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.MinimumWidth = 8;
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            ColDireccion.Width = 150;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Cargo.Width = 150;
            // 
            // ColEstado
            // 
            ColEstado.DataPropertyName = "Estado";
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 8;
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
            ColEstado.Width = 150;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(4, 113);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(133, 44);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.TextChanged += btnBuscar_TextChanged;
            btnBuscar.Click += btnbuscar_Click;
            // 
            // FrmListaEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 625);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmListaEmpleados";
            Load += FrmListaEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBuscar;
        private DataGridView dgvRegistroEmpleados;
        private TextBox txtBuscarEmpleado;
        private DataGridViewTextBoxColumn ID;
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
        private ComboBox cboBuscarPor;
        private ComboBox cboEstado;
        private Label lblTotalEmpleados;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnExportarPDF;
        private Button btnExportarWord;
        private Button btnExportarExcel;
    }
}