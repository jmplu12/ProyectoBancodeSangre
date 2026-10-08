namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmInventario
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
            panel3 = new Panel();
            dtpFechaDonacion = new DateTimePicker();
            label11 = new Label();
            txtEmpleadoID = new TextBox();
            txtCantidadInicial = new TextBox();
            cboEstado = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCodigoBolsa = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtProcesoId = new TextBox();
            label6 = new Label();
            txtTipoSangre = new TextBox();
            label7 = new Label();
            txtDonacionID = new TextBox();
            txtInventarioId = new TextBox();
            dtpFechaVenc = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtCantidadDisponible = new TextBox();
            dgvInventario = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            btnbuscar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            erpInventario = new ErrorProvider(components);
            colInventarioID = new DataGridViewTextBoxColumn();
            colCodigoBolsa = new DataGridViewTextBoxColumn();
            colTipoSangre = new DataGridViewTextBoxColumn();
            colCantidadInicial = new DataGridViewTextBoxColumn();
            colCantidadDisponible = new DataGridViewTextBoxColumn();
            colFechaDonacion = new DataGridViewTextBoxColumn();
            colFechaVencimiento = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpInventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvInventario);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(27, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 644);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtpFechaDonacion);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtEmpleadoID);
            panel3.Controls.Add(txtCantidadInicial);
            panel3.Controls.Add(cboEstado);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtCodigoBolsa);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtProcesoId);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtTipoSangre);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtDonacionID);
            panel3.Controls.Add(txtInventarioId);
            panel3.Controls.Add(dtpFechaVenc);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtCantidadDisponible);
            panel3.Location = new Point(19, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(1363, 319);
            panel3.TabIndex = 81;
            // 
            // dtpFechaDonacion
            // 
            dtpFechaDonacion.Location = new Point(535, 139);
            dtpFechaDonacion.Name = "dtpFechaDonacion";
            dtpFechaDonacion.Size = new Size(112, 31);
            dtpFechaDonacion.TabIndex = 91;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(928, 225);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 90;
            label11.Text = "Estado:";
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Anchor = AnchorStyles.None;
            txtEmpleadoID.Location = new Point(515, 200);
            txtEmpleadoID.Margin = new Padding(4, 5, 4, 5);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(112, 31);
            txtEmpleadoID.TabIndex = 89;
            // 
            // txtCantidadInicial
            // 
            txtCantidadInicial.Anchor = AnchorStyles.None;
            txtCantidadInicial.Location = new Point(217, 197);
            txtCantidadInicial.Margin = new Padding(4, 5, 4, 5);
            txtCantidadInicial.Name = "txtCantidadInicial";
            txtCantidadInicial.Size = new Size(112, 31);
            txtCantidadInicial.TabIndex = 87;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(1075, 222);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(182, 33);
            cboEstado.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 203);
            label10.Name = "label10";
            label10.Size = new Size(115, 25);
            label10.TabIndex = 85;
            label10.Text = "Empleado ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 145);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 84;
            label9.Text = "Fecha Donacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 203);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 83;
            label8.Text = "Cantidad Inicial";
            // 
            // txtCodigoBolsa
            // 
            txtCodigoBolsa.Anchor = AnchorStyles.None;
            txtCodigoBolsa.Location = new Point(217, 144);
            txtCodigoBolsa.Margin = new Padding(4, 5, 4, 5);
            txtCodigoBolsa.Name = "txtCodigoBolsa";
            txtCodigoBolsa.Size = new Size(112, 31);
            txtCodigoBolsa.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 154);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 81;
            label3.Text = "Codigo Bolsa";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 26);
            label1.TabIndex = 68;
            label1.Text = "Inventario ID:";
            // 
            // txtProcesoId
            // 
            txtProcesoId.Anchor = AnchorStyles.None;
            txtProcesoId.Location = new Point(654, 42);
            txtProcesoId.Margin = new Padding(4, 5, 4, 5);
            txtProcesoId.Name = "txtProcesoId";
            txtProcesoId.ReadOnly = true;
            txtProcesoId.Size = new Size(73, 31);
            txtProcesoId.TabIndex = 80;
            txtProcesoId.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 76);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 26);
            label6.TabIndex = 71;
            label6.Text = "Donacion ID:";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Location = new Point(246, 269);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(291, 31);
            txtTipoSangre.TabIndex = 79;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 271);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(171, 26);
            label7.TabIndex = 78;
            label7.Text = "Tipo de sangre:";
            // 
            // txtDonacionID
            // 
            txtDonacionID.Anchor = AnchorStyles.None;
            txtDonacionID.Location = new Point(217, 85);
            txtDonacionID.Margin = new Padding(4, 5, 4, 5);
            txtDonacionID.Name = "txtDonacionID";
            txtDonacionID.ReadOnly = true;
            txtDonacionID.Size = new Size(291, 31);
            txtDonacionID.TabIndex = 72;
            // 
            // txtInventarioId
            // 
            txtInventarioId.Anchor = AnchorStyles.None;
            txtInventarioId.Location = new Point(217, 31);
            txtInventarioId.Margin = new Padding(4, 5, 4, 5);
            txtInventarioId.Name = "txtInventarioId";
            txtInventarioId.ReadOnly = true;
            txtInventarioId.Size = new Size(291, 31);
            txtInventarioId.TabIndex = 70;
            // 
            // dtpFechaVenc
            // 
            dtpFechaVenc.Anchor = AnchorStyles.None;
            dtpFechaVenc.Location = new Point(958, 137);
            dtpFechaVenc.Margin = new Padding(4, 5, 4, 5);
            dtpFechaVenc.Name = "dtpFechaVenc";
            dtpFechaVenc.Size = new Size(291, 31);
            dtpFechaVenc.TabIndex = 72;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(817, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 26);
            label4.TabIndex = 67;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(687, 144);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(245, 26);
            label5.TabIndex = 65;
            label5.Text = "Fecha de Vencimiento:";
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Anchor = AnchorStyles.None;
            txtCantidadDisponible.Location = new Point(958, 53);
            txtCantidadDisponible.Margin = new Padding(4, 5, 4, 5);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.Size = new Size(112, 31);
            txtCantidadDisponible.TabIndex = 69;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colInventarioID, colCodigoBolsa, colTipoSangre, colCantidadInicial, colCantidadDisponible, colFechaDonacion, colFechaVencimiento, colEstado });
            dgvInventario.Location = new Point(37, 490);
            dgvInventario.Margin = new Padding(4, 5, 4, 5);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(972, 130);
            dgvInventario.TabIndex = 76;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnbuscar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1401, 102);
            panel2.TabIndex = 64;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(579, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(257, 60);
            label2.TabIndex = 0;
            label2.Text = "Inventario";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(18, 29);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(242, 49);
            btnbuscar.TabIndex = 77;
            btnbuscar.Text = "Procesamientos de Sangre";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1017, 557);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 63);
            btnEliminar.TabIndex = 75;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = SystemColors.HotTrack;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1218, 544);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 76);
            btnAgregar.TabIndex = 73;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // erpInventario
            // 
            erpInventario.ContainerControl = this;
            // 
            // colInventarioID
            // 
            colInventarioID.HeaderText = "Inventario ID";
            colInventarioID.MinimumWidth = 8;
            colInventarioID.Name = "colInventarioID";
            colInventarioID.ReadOnly = true;
            colInventarioID.Width = 150;
            // 
            // colCodigoBolsa
            // 
            colCodigoBolsa.HeaderText = "Código Bolsa";
            colCodigoBolsa.MinimumWidth = 8;
            colCodigoBolsa.Name = "colCodigoBolsa";
            colCodigoBolsa.ReadOnly = true;
            colCodigoBolsa.Width = 150;
            // 
            // colTipoSangre
            // 
            colTipoSangre.HeaderText = "Tipo de Sangre";
            colTipoSangre.MinimumWidth = 8;
            colTipoSangre.Name = "colTipoSangre";
            colTipoSangre.ReadOnly = true;
            colTipoSangre.Width = 150;
            // 
            // colCantidadInicial
            // 
            colCantidadInicial.HeaderText = "Cantidad Inicial";
            colCantidadInicial.MinimumWidth = 8;
            colCantidadInicial.Name = "colCantidadInicial";
            colCantidadInicial.ReadOnly = true;
            colCantidadInicial.Width = 150;
            // 
            // colCantidadDisponible
            // 
            colCantidadDisponible.HeaderText = "Cantidad Disponible";
            colCantidadDisponible.MinimumWidth = 8;
            colCantidadDisponible.Name = "colCantidadDisponible";
            colCantidadDisponible.ReadOnly = true;
            colCantidadDisponible.Width = 150;
            // 
            // colFechaDonacion
            // 
            colFechaDonacion.HeaderText = "Fecha Donación";
            colFechaDonacion.MinimumWidth = 8;
            colFechaDonacion.Name = "colFechaDonacion";
            colFechaDonacion.ReadOnly = true;
            colFechaDonacion.Width = 150;
            // 
            // colFechaVencimiento
            // 
            colFechaVencimiento.HeaderText = "Fecha Vencimiento";
            colFechaVencimiento.MinimumWidth = 8;
            colFechaVencimiento.Name = "colFechaVencimiento";
            colFechaVencimiento.ReadOnly = true;
            colFechaVencimiento.Width = 150;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 150;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInventario";
            Load += FrmInventario_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvInventario;
        private Button btnEliminar;
        private Button btnAgregar;
        private DateTimePicker dtpFechaVenc;
        private TextBox txtInventarioId;
        private Label label5;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ErrorProvider erpInventario;
        private Button btnbuscar;
        private Label label6;
        private Label label7;
        public TextBox txtTipoSangre;
        public TextBox txtDonacionID;
        public TextBox txtCantidadDisponible;
        public TextBox txtProcesoId;
        private Panel panel3;
        private Label label10;
        private Label label9;
        private Label label8;
        public TextBox txtCodigoBolsa;
        private Label label3;
        private DateTimePicker dtpFechaDonacion;
        private Label label11;
        public TextBox txtEmpleadoID;
        public TextBox txtCantidadInicial;
        private ComboBox cboEstado;
        private DataGridViewTextBoxColumn colInventarioID;
        private DataGridViewTextBoxColumn colCodigoBolsa;
        private DataGridViewTextBoxColumn colTipoSangre;
        private DataGridViewTextBoxColumn colCantidadInicial;
        private DataGridViewTextBoxColumn colCantidadDisponible;
        private DataGridViewTextBoxColumn colFechaDonacion;
        private DataGridViewTextBoxColumn colFechaVencimiento;
        private DataGridViewTextBoxColumn colEstado;
    }
}