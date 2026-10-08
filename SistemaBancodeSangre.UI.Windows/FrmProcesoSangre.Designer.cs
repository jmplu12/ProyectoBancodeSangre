namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmProcesoSangre
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
            panel5 = new Panel();
            panel4 = new Panel();
            txtProcesoId = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            checkPlaquetas = new CheckBox();
            btnAgrgar = new Button();
            checkPlasma = new CheckBox();
            checkConcentradoGlobulosRojos = new CheckBox();
            label14 = new Label();
            label13 = new Label();
            label9 = new Label();
            label6 = new Label();
            dtFechaProceso = new DateTimePicker();
            txtAlmacenado = new TextBox();
            label3 = new Label();
            label11 = new Label();
            txtResponsable = new TextBox();
            label5 = new Label();
            label12 = new Label();
            cbbEstado = new ComboBox();
            groupBox1 = new GroupBox();
            btnbuscar = new Button();
            txtApellido = new TextBox();
            label8 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            txtIdDonacion = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtTipoSangre = new TextBox();
            label10 = new Label();
            txtVolumenDno = new TextBox();
            erpProcesamientoSangre = new ErrorProvider(components);
            txtNoSangre = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpProcesamientoSangre).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1389, 787);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(35, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(1306, 734);
            panel5.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtProcesoId);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1304, 95);
            panel4.TabIndex = 29;
            panel4.Paint += panel4_Paint;
            // 
            // txtProcesoId
            // 
            txtProcesoId.Anchor = AnchorStyles.None;
            txtProcesoId.Location = new Point(298, 43);
            txtProcesoId.Margin = new Padding(4, 5, 4, 5);
            txtProcesoId.Name = "txtProcesoId";
            txtProcesoId.Size = new Size(41, 31);
            txtProcesoId.TabIndex = 30;
            txtProcesoId.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(383, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(578, 60);
            label2.TabIndex = 0;
            label2.Text = "Procesamiento de Sangre";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(20, 533);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 167);
            panel3.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 44);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1223, 116);
            dataGridView1.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(20, 105);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 396);
            panel2.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNoSangre);
            groupBox2.Controls.Add(checkPlaquetas);
            groupBox2.Controls.Add(btnAgrgar);
            groupBox2.Controls.Add(checkPlasma);
            groupBox2.Controls.Add(checkConcentradoGlobulosRojos);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtFechaProceso);
            groupBox2.Controls.Add(txtAlmacenado);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtResponsable);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cbbEstado);
            groupBox2.Location = new Point(603, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 357);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // checkPlaquetas
            // 
            checkPlaquetas.AutoSize = true;
            checkPlaquetas.Location = new Point(579, 184);
            checkPlaquetas.Name = "checkPlaquetas";
            checkPlaquetas.Size = new Size(22, 21);
            checkPlaquetas.TabIndex = 48;
            checkPlaquetas.UseVisualStyleBackColor = true;
            // 
            // btnAgrgar
            // 
            btnAgrgar.Anchor = AnchorStyles.None;
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrgar.ForeColor = SystemColors.ControlLightLight;
            btnAgrgar.Location = new Point(427, 253);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 56);
            btnAgrgar.TabIndex = 43;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // checkPlasma
            // 
            checkPlasma.AutoSize = true;
            checkPlasma.Location = new Point(579, 116);
            checkPlasma.Name = "checkPlasma";
            checkPlasma.Size = new Size(22, 21);
            checkPlasma.TabIndex = 47;
            checkPlasma.UseVisualStyleBackColor = true;
            // 
            // checkConcentradoGlobulosRojos
            // 
            checkConcentradoGlobulosRojos.AutoSize = true;
            checkConcentradoGlobulosRojos.Location = new Point(579, 41);
            checkConcentradoGlobulosRojos.Name = "checkConcentradoGlobulosRojos";
            checkConcentradoGlobulosRojos.Size = new Size(22, 21);
            checkConcentradoGlobulosRojos.TabIndex = 46;
            checkConcentradoGlobulosRojos.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(383, 186);
            label14.Name = "label14";
            label14.Size = new Size(127, 27);
            label14.TabIndex = 45;
            label14.Text = "Plaquetas:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(383, 111);
            label13.Name = "label13";
            label13.Size = new Size(99, 27);
            label13.TabIndex = 44;
            label13.Text = "Plasma:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(375, 41);
            label9.Name = "label9";
            label9.Size = new Size(184, 27);
            label9.TabIndex = 43;
            label9.Text = "Glóbulos Rojos:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 27);
            label6.TabIndex = 26;
            label6.Text = "Fecha Vct:";
            // 
            // dtFechaProceso
            // 
            dtFechaProceso.Anchor = AnchorStyles.None;
            dtFechaProceso.Format = DateTimePickerFormat.Short;
            dtFechaProceso.Location = new Point(158, 46);
            dtFechaProceso.Margin = new Padding(4, 5, 4, 5);
            dtFechaProceso.Name = "dtFechaProceso";
            dtFechaProceso.Size = new Size(178, 31);
            dtFechaProceso.TabIndex = 31;
            // 
            // txtAlmacenado
            // 
            txtAlmacenado.Anchor = AnchorStyles.None;
            txtAlmacenado.Location = new Point(189, 258);
            txtAlmacenado.Margin = new Padding(4, 5, 4, 5);
            txtAlmacenado.MaxLength = 150;
            txtAlmacenado.Name = "txtAlmacenado";
            txtAlmacenado.Size = new Size(171, 31);
            txtAlmacenado.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 26;
            label3.Text = "No_Sangre:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(18, 260);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(152, 27);
            label11.TabIndex = 40;
            label11.Text = "Almacenado:";
            // 
            // txtResponsable
            // 
            txtResponsable.Anchor = AnchorStyles.None;
            txtResponsable.Location = new Point(189, 321);
            txtResponsable.Margin = new Padding(4, 5, 4, 5);
            txtResponsable.MaxLength = 150;
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(315, 31);
            txtResponsable.TabIndex = 41;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 27);
            label5.TabIndex = 26;
            label5.Text = "Estado:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(18, 321);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(146, 27);
            label12.TabIndex = 39;
            label12.Text = "Resposable:";
            // 
            // cbbEstado
            // 
            cbbEstado.Anchor = AnchorStyles.None;
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstado.FormattingEnabled = true;
            cbbEstado.Items.AddRange(new object[] { "Pendiente", "", "En procesamiento", "", "Procesada", "", "No apta", "", "Almacenada" });
            cbbEstado.Location = new Point(158, 184);
            cbbEstado.Margin = new Padding(4, 5, 4, 5);
            cbbEstado.Name = "cbbEstado";
            cbbEstado.Size = new Size(122, 33);
            cbbEstado.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtIdDonacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTipoSangre);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtVolumenDno);
            groupBox1.Location = new Point(16, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 348);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Donacion";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(339, 34);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(191, 49);
            btnbuscar.TabIndex = 47;
            btnbuscar.Text = "Buscar Donacion";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(183, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(314, 31);
            txtApellido.TabIndex = 50;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 151);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 49;
            label8.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(303, 31);
            txtNombre.TabIndex = 48;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 27);
            label7.TabIndex = 47;
            label7.Text = "Nombres:";
            // 
            // txtIdDonacion
            // 
            txtIdDonacion.Anchor = AnchorStyles.None;
            txtIdDonacion.Location = new Point(183, 37);
            txtIdDonacion.Margin = new Padding(4, 5, 4, 5);
            txtIdDonacion.Name = "txtIdDonacion";
            txtIdDonacion.ReadOnly = true;
            txtIdDonacion.Size = new Size(80, 31);
            txtIdDonacion.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 26;
            label1.Text = "ID Donacion:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 26;
            label4.Text = "Tipo de Sangre:";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Location = new Point(220, 217);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(106, 31);
            txtTipoSangre.TabIndex = 46;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(25, 278);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(167, 27);
            label10.TabIndex = 26;
            label10.Text = "Cantidad Dno:";
            // 
            // txtVolumenDno
            // 
            txtVolumenDno.Anchor = AnchorStyles.None;
            txtVolumenDno.Location = new Point(220, 278);
            txtVolumenDno.Margin = new Padding(4, 5, 4, 5);
            txtVolumenDno.MaxLength = 35;
            txtVolumenDno.Name = "txtVolumenDno";
            txtVolumenDno.ReadOnly = true;
            txtVolumenDno.Size = new Size(126, 31);
            txtVolumenDno.TabIndex = 27;
            txtVolumenDno.KeyPress += txtVolumenDno_KeyPress;
            // 
            // erpProcesamientoSangre
            // 
            erpProcesamientoSangre.ContainerControl = this;
            // 
            // txtNoSangre
            // 
            txtNoSangre.Location = new Point(154, 106);
            txtNoSangre.Name = "txtNoSangre";
            txtNoSangre.Size = new Size(150, 31);
            txtNoSangre.TabIndex = 49;
            // 
            // FrmProcesoSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmProcesoSangre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProcesoSangre";
            Load += FrmProcesoSangre_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpProcesamientoSangre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DateTimePicker dtFechaProceso;
        private ComboBox cbbEstado;
        private Label label6;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtProcesoId;
        private Panel panel4;
        private Label label2;
        private Button btnAgrgar;
        private TextBox txtResponsable;
        private TextBox txtAlmacenado;
        private Label label12;
        private Label label11;
        private ErrorProvider erpProcesamientoSangre;
        private Button btnbuscar;
        public TextBox txtIdDonacion;
        public TextBox txtTipoSangre;
        public TextBox txtVolumenDno;
        private Panel panel5;
        private GroupBox groupBox1;
        private TextBox txtApellido;
        private Label label8;
        private TextBox txtNombre;
        private Label label7;
        private GroupBox groupBox2;
        private CheckBox checkPlaquetas;
        private CheckBox checkPlasma;
        private CheckBox checkConcentradoGlobulosRojos;
        private Label label14;
        private Label label13;
        private Label label9;
        private TextBox txtNoSangre;
    }
}