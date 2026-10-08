namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantAnalisis
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
            grbAnalisis = new GroupBox();
            txtAnalista = new TextBox();
            label21 = new Label();
            cbotipodesangre = new ComboBox();
            label18 = new Label();
            txtMuestra = new TextBox();
            label2 = new Label();
            label7 = new Label();
            txtidanalisis = new TextBox();
            groupBox2 = new GroupBox();
            dtFechaAnalitica = new DateTimePicker();
            checkHipertensionArterial = new CheckBox();
            checkDiabetes = new CheckBox();
            checkChagas = new CheckBox();
            checkHemofilia = new CheckBox();
            checkArritmias = new CheckBox();
            checkCancer = new CheckBox();
            checHepatitisBC = new CheckBox();
            checkVIH = new CheckBox();
            checkInsuficienciaCardiaca = new CheckBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label12 = new Label();
            label14 = new Label();
            label11 = new Label();
            label13 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            dgvanalisis = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbAnalisis.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvanalisis).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(grbAnalisis);
            pnlBase.Controls.Add(groupBox2);
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(dgvanalisis);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(37, 10);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1461, 734);
            pnlBase.TabIndex = 2;
            // 
            // grbAnalisis
            // 
            grbAnalisis.Controls.Add(txtAnalista);
            grbAnalisis.Controls.Add(label21);
            grbAnalisis.Controls.Add(cbotipodesangre);
            grbAnalisis.Controls.Add(label18);
            grbAnalisis.Controls.Add(txtMuestra);
            grbAnalisis.Controls.Add(label2);
            grbAnalisis.Controls.Add(label7);
            grbAnalisis.Controls.Add(txtidanalisis);
            grbAnalisis.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbAnalisis.Location = new Point(699, 132);
            grbAnalisis.Name = "grbAnalisis";
            grbAnalisis.Size = new Size(521, 249);
            grbAnalisis.TabIndex = 7;
            grbAnalisis.TabStop = false;
            grbAnalisis.Text = "Informacion Muestra y Analisis";
            // 
            // txtAnalista
            // 
            txtAnalista.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnalista.Location = new Point(144, 169);
            txtAnalista.Margin = new Padding(4, 5, 4, 5);
            txtAnalista.MaxLength = 50;
            txtAnalista.Name = "txtAnalista";
            txtAnalista.Size = new Size(305, 35);
            txtAnalista.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(32, 169);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(104, 27);
            label21.TabIndex = 9;
            label21.Text = "Analista:";
            // 
            // cbotipodesangre
            // 
            cbotipodesangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodesangre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbotipodesangre.FormattingEnabled = true;
            cbotipodesangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cbotipodesangre.Location = new Point(221, 127);
            cbotipodesangre.Margin = new Padding(4, 5, 4, 5);
            cbotipodesangre.Name = "cbotipodesangre";
            cbotipodesangre.Size = new Size(228, 35);
            cbotipodesangre.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(30, 134);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(183, 27);
            label18.TabIndex = 7;
            label18.Text = "Tipo de Sangre:";
            // 
            // txtMuestra
            // 
            txtMuestra.Location = new Point(190, 79);
            txtMuestra.Margin = new Padding(4, 5, 4, 5);
            txtMuestra.Name = "txtMuestra";
            txtMuestra.ReadOnly = true;
            txtMuestra.Size = new Size(259, 33);
            txtMuestra.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 27);
            label2.TabIndex = 5;
            label2.Text = "IdMuestra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 27);
            label7.TabIndex = 3;
            label7.Text = "ID Analisis:";
            // 
            // txtidanalisis
            // 
            txtidanalisis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtidanalisis.Location = new Point(190, 32);
            txtidanalisis.Margin = new Padding(4, 5, 4, 5);
            txtidanalisis.Name = "txtidanalisis";
            txtidanalisis.ReadOnly = true;
            txtidanalisis.Size = new Size(259, 35);
            txtidanalisis.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtFechaAnalitica);
            groupBox2.Controls.Add(checkHipertensionArterial);
            groupBox2.Controls.Add(checkDiabetes);
            groupBox2.Controls.Add(checkChagas);
            groupBox2.Controls.Add(checkHemofilia);
            groupBox2.Controls.Add(checkArritmias);
            groupBox2.Controls.Add(checkCancer);
            groupBox2.Controls.Add(checHepatitisBC);
            groupBox2.Controls.Add(checkVIH);
            groupBox2.Controls.Add(checkInsuficienciaCardiaca);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 116);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(646, 295);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado de Pruebas";
            // 
            // dtFechaAnalitica
            // 
            dtFechaAnalitica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaAnalitica.Format = DateTimePickerFormat.Short;
            dtFechaAnalitica.Location = new Point(333, 244);
            dtFechaAnalitica.Margin = new Padding(4, 5, 4, 5);
            dtFechaAnalitica.Name = "dtFechaAnalitica";
            dtFechaAnalitica.Size = new Size(204, 35);
            dtFechaAnalitica.TabIndex = 8;
            dtFechaAnalitica.Visible = false;
            // 
            // checkHipertensionArterial
            // 
            checkHipertensionArterial.AutoSize = true;
            checkHipertensionArterial.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkHipertensionArterial.Location = new Point(579, 69);
            checkHipertensionArterial.Margin = new Padding(4, 5, 4, 5);
            checkHipertensionArterial.Name = "checkHipertensionArterial";
            checkHipertensionArterial.Size = new Size(22, 21);
            checkHipertensionArterial.TabIndex = 1;
            checkHipertensionArterial.UseVisualStyleBackColor = true;
            // 
            // checkDiabetes
            // 
            checkDiabetes.AutoSize = true;
            checkDiabetes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkDiabetes.Location = new Point(110, 187);
            checkDiabetes.Margin = new Padding(4, 5, 4, 5);
            checkDiabetes.Name = "checkDiabetes";
            checkDiabetes.Size = new Size(22, 21);
            checkDiabetes.TabIndex = 1;
            checkDiabetes.UseVisualStyleBackColor = true;
            // 
            // checkChagas
            // 
            checkChagas.AutoSize = true;
            checkChagas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkChagas.Location = new Point(471, 39);
            checkChagas.Margin = new Padding(4, 5, 4, 5);
            checkChagas.Name = "checkChagas";
            checkChagas.Size = new Size(22, 21);
            checkChagas.TabIndex = 1;
            checkChagas.UseVisualStyleBackColor = true;
            // 
            // checkHemofilia
            // 
            checkHemofilia.AutoSize = true;
            checkHemofilia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkHemofilia.Location = new Point(135, 244);
            checkHemofilia.Margin = new Padding(4, 5, 4, 5);
            checkHemofilia.Name = "checkHemofilia";
            checkHemofilia.Size = new Size(22, 21);
            checkHemofilia.TabIndex = 1;
            checkHemofilia.UseVisualStyleBackColor = true;
            // 
            // checkArritmias
            // 
            checkArritmias.AutoSize = true;
            checkArritmias.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkArritmias.Location = new Point(136, 219);
            checkArritmias.Margin = new Padding(4, 5, 4, 5);
            checkArritmias.Name = "checkArritmias";
            checkArritmias.Size = new Size(22, 21);
            checkArritmias.TabIndex = 1;
            checkArritmias.UseVisualStyleBackColor = true;
            // 
            // checkCancer
            // 
            checkCancer.AutoSize = true;
            checkCancer.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkCancer.Location = new Point(110, 154);
            checkCancer.Margin = new Padding(4, 5, 4, 5);
            checkCancer.Name = "checkCancer";
            checkCancer.Size = new Size(22, 21);
            checkCancer.TabIndex = 1;
            checkCancer.UseVisualStyleBackColor = true;
            // 
            // checHepatitisBC
            // 
            checHepatitisBC.AutoSize = true;
            checHepatitisBC.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checHepatitisBC.Location = new Point(188, 89);
            checHepatitisBC.Margin = new Padding(4, 5, 4, 5);
            checHepatitisBC.Name = "checHepatitisBC";
            checHepatitisBC.Size = new Size(22, 21);
            checHepatitisBC.TabIndex = 1;
            checHepatitisBC.UseVisualStyleBackColor = true;
            // 
            // checkVIH
            // 
            checkVIH.AutoSize = true;
            checkVIH.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkVIH.Location = new Point(128, 58);
            checkVIH.Margin = new Padding(4, 5, 4, 5);
            checkVIH.Name = "checkVIH";
            checkVIH.Size = new Size(22, 21);
            checkVIH.TabIndex = 1;
            checkVIH.UseVisualStyleBackColor = true;
            // 
            // checkInsuficienciaCardiaca
            // 
            checkInsuficienciaCardiaca.AutoSize = true;
            checkInsuficienciaCardiaca.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkInsuficienciaCardiaca.Location = new Point(269, 125);
            checkInsuficienciaCardiaca.Margin = new Padding(4, 5, 4, 5);
            checkInsuficienciaCardiaca.Name = "checkInsuficienciaCardiaca";
            checkInsuficienciaCardiaca.Size = new Size(22, 21);
            checkInsuficienciaCardiaca.TabIndex = 1;
            checkInsuficienciaCardiaca.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(333, 31);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(102, 27);
            label17.TabIndex = 0;
            label17.Text = "Chagas:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(7, 240);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(118, 27);
            label16.TabIndex = 0;
            label16.Text = "Hemofilia:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(7, 213);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(112, 27);
            label15.TabIndex = 0;
            label15.Text = "Arritmias:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(333, 65);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(228, 27);
            label12.TabIndex = 0;
            label12.Text = "Hipertension Arterial";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 151);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(96, 27);
            label14.TabIndex = 0;
            label14.Text = "Cancer:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 183);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 27);
            label11.TabIndex = 0;
            label11.Text = "Diabetes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 122);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(253, 27);
            label13.TabIndex = 0;
            label13.Text = "Insuficiencia Cardiaca:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(7, 90);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(172, 27);
            label10.TabIndex = 0;
            label10.Text = "Hepatitis B o C\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(9, 54);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 27);
            label9.TabIndex = 0;
            label9.Text = "VIH/SIDA";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1254, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(204, 58);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1254, 166);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(204, 56);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1254, 116);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 56);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvanalisis
            // 
            dgvanalisis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvanalisis.Location = new Point(11, 448);
            dgvanalisis.Name = "dgvanalisis";
            dgvanalisis.RowHeadersWidth = 62;
            dgvanalisis.RowTemplate.Height = 33;
            dgvanalisis.Size = new Size(1225, 225);
            dgvanalisis.TabIndex = 1;
            dgvanalisis.CellDoubleClick += dgvanalisis_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1457, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(240, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Analisis";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmMantAnalisis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 744);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantAnalisis";
            Text = "FrmMantAnalisis";
            Load += FrmMantAnalisis_Load;
            pnlBase.ResumeLayout(false);
            grbAnalisis.ResumeLayout(false);
            grbAnalisis.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvanalisis).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private DataGridView dgvanalisis;
        private Panel pnlEncabezado;
        private Label label1;
        private GroupBox grbAnalisis;
        private GroupBox groupBox2;
        private CheckBox checkHipertensionArterial;
        private CheckBox checkDiabetes;
        private CheckBox checkChagas;
        private CheckBox checkHemofilia;
        private CheckBox checkArritmias;
        private CheckBox checkCancer;
        private CheckBox checHepatitisBC;
        private CheckBox checkVIH;
        private CheckBox checkInsuficienciaCardiaca;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label12;
        private Label label14;
        private Label label11;
        private Label label13;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtidanalisis;
        public TextBox txtMuestra;
        private Label label2;
        private ErrorProvider errorProvider;
        private ComboBox cbotipodesangre;
        private Label label18;
        private DateTimePicker dtFechaAnalitica;
        private TextBox txtAnalista;
        private Label label21;
    }
}