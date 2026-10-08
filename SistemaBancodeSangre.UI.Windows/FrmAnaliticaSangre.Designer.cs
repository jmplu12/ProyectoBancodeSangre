namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmAnaliticaSangre
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
            dgvmuestra = new DataGridView();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnguardar = new Button();
            panel2 = new Panel();
            txtAnalista = new TextBox();
            dtFechaAnalitica = new DateTimePicker();
            groupBox2 = new GroupBox();
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
            cboEstado = new ComboBox();
            cbotipodesangre = new ComboBox();
            label7 = new Label();
            txtidanalisis = new TextBox();
            label21 = new Label();
            label19 = new Label();
            label20 = new Label();
            label18 = new Label();
            groupBox1 = new GroupBox();
            txtCodigoMuestra = new TextBox();
            lbl = new Label();
            txtNombre = new TextBox();
            label8 = new Label();
            txtsexo = new TextBox();
            txtTipoDonante = new TextBox();
            txtMuestra = new TextBox();
            txtApellido = new TextBox();
            txtidDonante = new TextBox();
            btnbuscar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmuestra).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvmuestra);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnguardar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 779);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // dgvmuestra
            // 
            dgvmuestra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvmuestra.BackgroundColor = SystemColors.ActiveCaption;
            dgvmuestra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmuestra.Location = new Point(44, 612);
            dgvmuestra.Margin = new Padding(4, 5, 4, 5);
            dgvmuestra.Name = "dgvmuestra";
            dgvmuestra.RowHeadersWidth = 62;
            dgvmuestra.RowTemplate.Height = 25;
            dgvmuestra.Size = new Size(1462, 148);
            dgvmuestra.TabIndex = 78;
            dgvmuestra.CellClick += dgvmuestra_CellClick;
            dgvmuestra.CellDoubleClick += dgvmuestra_CellDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1219, 549);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 51);
            btnEliminar.TabIndex = 77;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.HotTrack;
            btnNuevo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(875, 549);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(186, 51);
            btnNuevo.TabIndex = 76;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Green;
            btnguardar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnguardar.ForeColor = Color.White;
            btnguardar.Location = new Point(586, 549);
            btnguardar.Margin = new Padding(4, 5, 4, 5);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(186, 51);
            btnguardar.TabIndex = 75;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtAnalista);
            panel2.Controls.Add(dtFechaAnalitica);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(cboEstado);
            panel2.Controls.Add(cbotipodesangre);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtidanalisis);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label18);
            panel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(512, 114);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 416);
            panel2.TabIndex = 74;
            // 
            // txtAnalista
            // 
            txtAnalista.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnalista.Location = new Point(595, 345);
            txtAnalista.Margin = new Padding(4, 5, 4, 5);
            txtAnalista.MaxLength = 50;
            txtAnalista.Name = "txtAnalista";
            txtAnalista.ReadOnly = true;
            txtAnalista.Size = new Size(393, 35);
            txtAnalista.TabIndex = 7;
            // 
            // dtFechaAnalitica
            // 
            dtFechaAnalitica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaAnalitica.Format = DateTimePickerFormat.Short;
            dtFechaAnalitica.Location = new Point(668, 269);
            dtFechaAnalitica.Margin = new Padding(4, 5, 4, 5);
            dtFechaAnalitica.Name = "dtFechaAnalitica";
            dtFechaAnalitica.Size = new Size(244, 35);
            dtFechaAnalitica.TabIndex = 6;
            // 
            // groupBox2
            // 
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
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 64);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(964, 186);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado de Pruebas";
            // 
            // checkHipertensionArterial
            // 
            checkHipertensionArterial.AutoSize = true;
            checkHipertensionArterial.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkHipertensionArterial.Location = new Point(880, 56);
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
            checkDiabetes.Location = new Point(576, 52);
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
            checkChagas.Location = new Point(880, 143);
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
            checkHemofilia.Location = new Point(738, 143);
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
            checkArritmias.Location = new Point(571, 143);
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
            checkCancer.Location = new Point(421, 139);
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
            checHepatitisBC.Location = new Point(361, 52);
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
            checkVIH.Location = new Point(127, 56);
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
            checkInsuficienciaCardiaca.Location = new Point(268, 143);
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
            label17.Location = new Point(780, 137);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(102, 27);
            label17.TabIndex = 0;
            label17.Text = "Chagas:";
            label17.Click += label17_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(612, 139);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(118, 27);
            label16.TabIndex = 0;
            label16.Text = "Hemofilia:";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(451, 139);
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
            label12.Location = new Point(644, 48);
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
            label14.Location = new Point(316, 135);
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
            label11.Location = new Point(421, 48);
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
            label13.Location = new Point(4, 139);
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
            label10.Location = new Point(176, 50);
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
            label9.Location = new Point(8, 52);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 27);
            label9.TabIndex = 0;
            label9.Text = "VIH/SIDA";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo ", "No activo" });
            cboEstado.Location = new Point(222, 350);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(171, 35);
            cboEstado.TabIndex = 5;
            // 
            // cbotipodesangre
            // 
            cbotipodesangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodesangre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbotipodesangre.FormattingEnabled = true;
            cbotipodesangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cbotipodesangre.Location = new Point(222, 277);
            cbotipodesangre.Margin = new Padding(4, 5, 4, 5);
            cbotipodesangre.Name = "cbotipodesangre";
            cbotipodesangre.Size = new Size(171, 35);
            cbotipodesangre.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 19);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 27);
            label7.TabIndex = 0;
            label7.Text = "ID Analisis:";
            // 
            // txtidanalisis
            // 
            txtidanalisis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtidanalisis.Location = new Point(159, 11);
            txtidanalisis.Margin = new Padding(4, 5, 4, 5);
            txtidanalisis.Name = "txtidanalisis";
            txtidanalisis.ReadOnly = true;
            txtidanalisis.Size = new Size(108, 35);
            txtidanalisis.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(469, 350);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(104, 27);
            label21.TabIndex = 0;
            label21.Text = "Analista:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(469, 279);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(182, 27);
            label19.TabIndex = 0;
            label19.Text = "Fecha Analitica:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(18, 353);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(94, 27);
            label20.TabIndex = 0;
            label20.Text = "Estado:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(18, 277);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(183, 27);
            label18.TabIndex = 0;
            label18.Text = "Tipo de Sangre:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(txtCodigoMuestra);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtsexo);
            groupBox1.Controls.Add(txtTipoDonante);
            groupBox1.Controls.Add(txtMuestra);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtidDonante);
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 114);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(452, 465);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Donante";
            // 
            // txtCodigoMuestra
            // 
            txtCodigoMuestra.Location = new Point(195, 298);
            txtCodigoMuestra.Margin = new Padding(4, 5, 4, 5);
            txtCodigoMuestra.Name = "txtCodigoMuestra";
            txtCodigoMuestra.ReadOnly = true;
            txtCodigoMuestra.Size = new Size(177, 35);
            txtCodigoMuestra.TabIndex = 10;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(24, 301);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(163, 27);
            lbl.TabIndex = 9;
            lbl.Text = "Cod. Muestra:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 120);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(295, 35);
            txtNombre.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 120);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 27);
            label8.TabIndex = 7;
            label8.Text = "Nombre:";
            // 
            // txtsexo
            // 
            txtsexo.Location = new Point(172, 411);
            txtsexo.Name = "txtsexo";
            txtsexo.ReadOnly = true;
            txtsexo.Size = new Size(200, 35);
            txtsexo.TabIndex = 6;
            // 
            // txtTipoDonante
            // 
            txtTipoDonante.Location = new Point(180, 356);
            txtTipoDonante.Name = "txtTipoDonante";
            txtTipoDonante.ReadOnly = true;
            txtTipoDonante.Size = new Size(192, 35);
            txtTipoDonante.TabIndex = 5;
            // 
            // txtMuestra
            // 
            txtMuestra.Location = new Point(180, 241);
            txtMuestra.Margin = new Padding(4, 5, 4, 5);
            txtMuestra.Name = "txtMuestra";
            txtMuestra.ReadOnly = true;
            txtMuestra.Size = new Size(287, 35);
            txtMuestra.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(172, 176);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(295, 35);
            txtApellido.TabIndex = 3;
            // 
            // txtidDonante
            // 
            txtidDonante.Location = new Point(172, 59);
            txtidDonante.Margin = new Padding(4, 5, 4, 5);
            txtidDonante.Name = "txtidDonante";
            txtidDonante.ReadOnly = true;
            txtidDonante.Size = new Size(86, 35);
            txtidDonante.TabIndex = 2;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(305, 28);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(139, 51);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 419);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 27);
            label6.TabIndex = 0;
            label6.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 359);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 27);
            label5.TabIndex = 0;
            label5.Text = "Tipo Donante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 244);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 27);
            label4.TabIndex = 0;
            label4.Text = "Muestra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 27);
            label3.TabIndex = 0;
            label3.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 27);
            label1.TabIndex = 0;
            label1.Text = "IdDonante:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1535, 104);
            panel3.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(538, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(423, 55);
            label2.TabIndex = 0;
            label2.Text = "Analitica de Sangre";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmAnaliticaSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 815);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAnaliticaSangre";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmAnaliticaSangre";
            Load += FrmAnaliticaSangre_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvmuestra).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvmuestra;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnguardar;
        private GroupBox groupBox1;
        private Button btnbuscar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private TextBox txtAnalista;
        private DateTimePicker dtFechaAnalitica;
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
        private ComboBox cboEstado;
        private ComboBox cbotipodesangre;
        private Label label7;
        private TextBox txtidanalisis;
        private Label label21;
        private Label label19;
        private Label label20;
        private Label label18;
        private ErrorProvider errorProvider;
        public TextBox txtMuestra;
        public TextBox txtApellido;
        public TextBox txtidDonante;
        public TextBox txtsexo;
        public TextBox txtTipoDonante;
        public TextBox txtNombre;
        private Label label8;
        public TextBox txtCodigoMuestra;
        private Label lbl;
    }
}