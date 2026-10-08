namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmEvaluacionDonante
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
            txtIDDonante = new TextBox();
            label14 = new Label();
            cboEstado = new ComboBox();
            btnGuardar = new Button();
            label13 = new Label();
            cboResultado = new ComboBox();
            txtObservaciones = new TextBox();
            label12 = new Label();
            chkHaDonadoAnteriormente = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            chkHaTenidoCirugia = new CheckBox();
            chkTieneSintomas = new CheckBox();
            chkTomaMedicamentos = new CheckBox();
            chkTieneEnfermedad = new CheckBox();
            label6 = new Label();
            nudTemperatura = new NumericUpDown();
            label4 = new Label();
            txtPresionArterial = new TextBox();
            nudPeso = new NumericUpDown();
            dtpFechaEvaluacion = new DateTimePicker();
            txtEmpleado = new TextBox();
            label5 = new Label();
            label = new Label();
            label3 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            btnSeleccionarDonante = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtIDDonante);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(cboResultado);
            panel1.Controls.Add(txtObservaciones);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(chkHaDonadoAnteriormente);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(chkHaTenidoCirugia);
            panel1.Controls.Add(chkTieneSintomas);
            panel1.Controls.Add(chkTomaMedicamentos);
            panel1.Controls.Add(chkTieneEnfermedad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(nudTemperatura);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPresionArterial);
            panel1.Controls.Add(nudPeso);
            panel1.Controls.Add(dtpFechaEvaluacion);
            panel1.Controls.Add(txtEmpleado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnSeleccionarDonante);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 641);
            panel1.TabIndex = 0;
            // 
            // txtIDDonante
            // 
            txtIDDonante.Location = new Point(207, 140);
            txtIDDonante.Name = "txtIDDonante";
            txtIDDonante.Size = new Size(84, 31);
            txtIDDonante.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(784, 362);
            label14.Name = "label14";
            label14.Size = new Size(70, 25);
            label14.TabIndex = 40;
            label14.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(902, 366);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(182, 33);
            cboEstado.TabIndex = 39;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(884, 548);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(764, 290);
            label13.Name = "label13";
            label13.Size = new Size(90, 25);
            label13.TabIndex = 37;
            label13.Text = "Resultado";
            // 
            // cboResultado
            // 
            cboResultado.FormattingEnabled = true;
            cboResultado.Location = new Point(902, 287);
            cboResultado.Name = "cboResultado";
            cboResultado.Size = new Size(182, 33);
            cboResultado.TabIndex = 36;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(934, 201);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(150, 31);
            txtObservaciones.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(784, 201);
            label12.Name = "label12";
            label12.Size = new Size(128, 25);
            label12.TabIndex = 34;
            label12.Text = "Observaciones";
            // 
            // chkHaDonadoAnteriormente
            // 
            chkHaDonadoAnteriormente.AutoSize = true;
            chkHaDonadoAnteriormente.Location = new Point(754, 528);
            chkHaDonadoAnteriormente.Name = "chkHaDonadoAnteriormente";
            chkHaDonadoAnteriormente.Size = new Size(22, 21);
            chkHaDonadoAnteriormente.TabIndex = 33;
            chkHaDonadoAnteriormente.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(507, 528);
            label11.Name = "label11";
            label11.Size = new Size(218, 25);
            label11.TabIndex = 32;
            label11.Text = "HaDonado Anteriormente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(507, 455);
            label10.Name = "label10";
            label10.Size = new Size(146, 25);
            label10.TabIndex = 31;
            label10.Text = "HaTenido Cirugia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 366);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 30;
            label9.Text = "Tiene Sintomas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(489, 296);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 29;
            label8.Text = "Toma Medicamentos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 223);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 28;
            label7.Text = "Tiene Enfermedad";
            // 
            // chkHaTenidoCirugia
            // 
            chkHaTenidoCirugia.AutoSize = true;
            chkHaTenidoCirugia.Location = new Point(671, 455);
            chkHaTenidoCirugia.Name = "chkHaTenidoCirugia";
            chkHaTenidoCirugia.Size = new Size(22, 21);
            chkHaTenidoCirugia.TabIndex = 27;
            chkHaTenidoCirugia.UseVisualStyleBackColor = true;
            // 
            // chkTieneSintomas
            // 
            chkTieneSintomas.AutoSize = true;
            chkTieneSintomas.Location = new Point(671, 366);
            chkTieneSintomas.Name = "chkTieneSintomas";
            chkTieneSintomas.Size = new Size(22, 21);
            chkTieneSintomas.TabIndex = 26;
            chkTieneSintomas.UseVisualStyleBackColor = true;
            // 
            // chkTomaMedicamentos
            // 
            chkTomaMedicamentos.AutoSize = true;
            chkTomaMedicamentos.Location = new Point(671, 296);
            chkTomaMedicamentos.Name = "chkTomaMedicamentos";
            chkTomaMedicamentos.Size = new Size(22, 21);
            chkTomaMedicamentos.TabIndex = 25;
            chkTomaMedicamentos.UseVisualStyleBackColor = true;
            // 
            // chkTieneEnfermedad
            // 
            chkTieneEnfermedad.AutoSize = true;
            chkTieneEnfermedad.Location = new Point(671, 227);
            chkTieneEnfermedad.Name = "chkTieneEnfermedad";
            chkTieneEnfermedad.Size = new Size(22, 21);
            chkTieneEnfermedad.TabIndex = 24;
            chkTieneEnfermedad.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 488);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 23;
            // 
            // nudTemperatura
            // 
            nudTemperatura.Location = new Point(207, 488);
            nudTemperatura.Name = "nudTemperatura";
            nudTemperatura.Size = new Size(180, 31);
            nudTemperatura.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 408);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 21;
            label4.Text = "Presion Arterial";
            // 
            // txtPresionArterial
            // 
            txtPresionArterial.Location = new Point(207, 408);
            txtPresionArterial.Name = "txtPresionArterial";
            txtPresionArterial.Size = new Size(150, 31);
            txtPresionArterial.TabIndex = 20;
            // 
            // nudPeso
            // 
            nudPeso.Location = new Point(151, 329);
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(180, 31);
            nudPeso.TabIndex = 19;
            // 
            // dtpFechaEvaluacion
            // 
            dtpFechaEvaluacion.Location = new Point(784, 146);
            dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            dtpFechaEvaluacion.Size = new Size(300, 31);
            dtpFechaEvaluacion.TabIndex = 18;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(176, 262);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(115, 31);
            txtEmpleado.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 252);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 16;
            label5.Text = "Responsable:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(41, 331);
            label.Name = "label";
            label.Size = new Size(49, 25);
            label.TabIndex = 15;
            label.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 152);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 14;
            label3.Text = "Fecha Evaluacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 201);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 13;
            label1.Text = "Nombres Donante;";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 201);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 31);
            txtNombre.TabIndex = 12;
            // 
            // btnSeleccionarDonante
            // 
            btnSeleccionarDonante.Location = new Point(9, 140);
            btnSeleccionarDonante.Name = "btnSeleccionarDonante";
            btnSeleccionarDonante.Size = new Size(154, 34);
            btnSeleccionarDonante.TabIndex = 11;
            btnSeleccionarDonante.Text = "Buscar Donante";
            btnSeleccionarDonante.UseVisualStyleBackColor = true;
            btnSeleccionarDonante.Click += btnSeleccionarDonante_Click_1;
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
            panel2.Size = new Size(1200, 128);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(373, 60);
            label2.TabIndex = 0;
            label2.Text = "Evalar Donante";
            // 
            // FrmEvaluacionDonante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 641);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmEvaluacionDonante";
            Text = "FrmEvaluacionDonante";
            Load += FrmEvaluacionDonante_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtpFechaEvaluacion;
        private TextBox txtEmpleado;
        private Label label5;
        private Label label;
        private Label label3;
        private Label label1;
        private TextBox txtNombre;
        private Button btnSeleccionarDonante;
        private NumericUpDown nudPeso;
        private Label label4;
        private TextBox txtPresionArterial;
        private NumericUpDown nudTemperatura;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private CheckBox chkHaTenidoCirugia;
        private CheckBox chkTieneSintomas;
        private CheckBox chkTomaMedicamentos;
        private CheckBox chkTieneEnfermedad;
        private Button btnGuardar;
        private Label label13;
        private ComboBox cboResultado;
        private TextBox txtObservaciones;
        private Label label12;
        private CheckBox chkHaDonadoAnteriormente;
        private Label label14;
        private ComboBox cboEstado;
        private TextBox txtIDDonante;
    }
}