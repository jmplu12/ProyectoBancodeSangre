namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmMuestraSangre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuestraSangre));
            btnbuscar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dtFechaDonacion = new DateTimePicker();
            txtTiposangre = new TextBox();
            txtIdDonacion = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnActualizar = new Button();
            btnAgrgar = new Button();
            dgvmuestra = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreDonante = new DataGridViewTextBoxColumn();
            ApellidoDonate = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            TipoSangre = new DataGridViewTextBoxColumn();
            cantidadM = new DataGridViewTextBoxColumn();
            CodigoMuestra = new DataGridViewTextBoxColumn();
            PresionArterial = new DataGridViewTextBoxColumn();
            pulso = new DataGridViewTextBoxColumn();
            Temperatura = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            FechaToma = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            txtObservacion = new TextBox();
            label11 = new Label();
            label10 = new Label();
            btnPrint = new Button();
            label9 = new Label();
            txtCodMuestra = new TextBox();
            cboEstado = new ComboBox();
            dtFechaToma = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            label8 = new Label();
            txtResponsable = new TextBox();
            txtCantidadM = new TextBox();
            txtMuestraID = new TextBox();
            errorProvider = new ErrorProvider(components);
            printCodMuestra = new System.Drawing.Printing.PrintDocument();
            txtIDDonant = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmuestra).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(4, 120);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(199, 38);
            btnbuscar.TabIndex = 20;
            btnbuscar.Text = "Buscar Donacion";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            panel1.Size = new Size(1357, 119);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(501, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(443, 60);
            label2.TabIndex = 0;
            label2.Text = "Muestra de Sangre";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtIDDonant);
            groupBox1.Controls.Add(dtFechaDonacion);
            groupBox1.Controls.Add(txtTiposangre);
            groupBox1.Controls.Add(txtIdDonacion);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(4, 168);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1349, 151);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Donacion:";
            // 
            // dtFechaDonacion
            // 
            dtFechaDonacion.Location = new Point(994, 103);
            dtFechaDonacion.Name = "dtFechaDonacion";
            dtFechaDonacion.Size = new Size(300, 35);
            dtFechaDonacion.TabIndex = 31;
            // 
            // txtTiposangre
            // 
            txtTiposangre.Location = new Point(994, 38);
            txtTiposangre.Name = "txtTiposangre";
            txtTiposangre.ReadOnly = true;
            txtTiposangre.Size = new Size(185, 35);
            txtTiposangre.TabIndex = 30;
            // 
            // txtIdDonacion
            // 
            txtIdDonacion.Location = new Point(166, 98);
            txtIdDonacion.Name = "txtIdDonacion";
            txtIdDonacion.ReadOnly = true;
            txtIdDonacion.Size = new Size(134, 35);
            txtIdDonacion.TabIndex = 29;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(448, 103);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(316, 35);
            txtApellidos.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(448, 43);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(316, 35);
            txtNombre.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 106);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 27);
            label5.TabIndex = 25;
            label5.Text = "Donacion ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(804, 43);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 27);
            label7.TabIndex = 25;
            label7.Text = "Tipo de Sangre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 25;
            label4.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(804, 111);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 27);
            label6.TabIndex = 25;
            label6.Text = "Fecha Donacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(312, 46);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 25;
            label3.Text = "Nombres:";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(808, 565);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 35);
            btnActualizar.TabIndex = 26;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgrgar
            // 
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.FlatStyle = FlatStyle.Flat;
            btnAgrgar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrgar.ForeColor = Color.White;
            btnAgrgar.Location = new Point(345, 565);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 35);
            btnAgrgar.TabIndex = 24;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // dgvmuestra
            // 
            dgvmuestra.AllowUserToAddRows = false;
            dgvmuestra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmuestra.Columns.AddRange(new DataGridViewColumn[] { ID, NombreDonante, ApellidoDonate, Edad, Sexo, Estado, TipoSangre, cantidadM, CodigoMuestra, PresionArterial, pulso, Temperatura, Responsable, FechaToma });
            dgvmuestra.Location = new Point(12, 610);
            dgvmuestra.Margin = new Padding(4, 5, 4, 5);
            dgvmuestra.Name = "dgvmuestra";
            dgvmuestra.ReadOnly = true;
            dgvmuestra.RowHeadersWidth = 62;
            dgvmuestra.RowTemplate.Height = 25;
            dgvmuestra.Size = new Size(1281, 154);
            dgvmuestra.TabIndex = 27;
            dgvmuestra.CellClick += dgvmuestra_CellClick;
            dgvmuestra.CellContentClick += dgvmuestra_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID MUESTRA";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // NombreDonante
            // 
            NombreDonante.HeaderText = "Nombre";
            NombreDonante.MinimumWidth = 8;
            NombreDonante.Name = "NombreDonante";
            NombreDonante.ReadOnly = true;
            NombreDonante.Width = 150;
            // 
            // ApellidoDonate
            // 
            ApellidoDonate.HeaderText = "Apellido";
            ApellidoDonate.MinimumWidth = 8;
            ApellidoDonate.Name = "ApellidoDonate";
            ApellidoDonate.ReadOnly = true;
            ApellidoDonate.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 150;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // TipoSangre
            // 
            TipoSangre.HeaderText = "Tipo de Sangre";
            TipoSangre.MinimumWidth = 8;
            TipoSangre.Name = "TipoSangre";
            TipoSangre.ReadOnly = true;
            TipoSangre.Width = 150;
            // 
            // cantidadM
            // 
            cantidadM.HeaderText = "Cantidad de la Muestra (En ML)";
            cantidadM.MinimumWidth = 8;
            cantidadM.Name = "cantidadM";
            cantidadM.ReadOnly = true;
            cantidadM.Width = 150;
            // 
            // CodigoMuestra
            // 
            CodigoMuestra.HeaderText = "Codigo de la Muestra";
            CodigoMuestra.MinimumWidth = 8;
            CodigoMuestra.Name = "CodigoMuestra";
            CodigoMuestra.ReadOnly = true;
            CodigoMuestra.Width = 150;
            // 
            // PresionArterial
            // 
            PresionArterial.HeaderText = "Presion Alterial";
            PresionArterial.MinimumWidth = 8;
            PresionArterial.Name = "PresionArterial";
            PresionArterial.ReadOnly = true;
            PresionArterial.Width = 150;
            // 
            // pulso
            // 
            pulso.HeaderText = "Pulso";
            pulso.MinimumWidth = 8;
            pulso.Name = "pulso";
            pulso.ReadOnly = true;
            pulso.Width = 150;
            // 
            // Temperatura
            // 
            Temperatura.HeaderText = "Temperatura";
            Temperatura.MinimumWidth = 8;
            Temperatura.Name = "Temperatura";
            Temperatura.ReadOnly = true;
            Temperatura.Width = 150;
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 8;
            Responsable.Name = "Responsable";
            Responsable.ReadOnly = true;
            Responsable.Width = 150;
            // 
            // FechaToma
            // 
            FechaToma.HeaderText = "Fecha";
            FechaToma.MinimumWidth = 8;
            FechaToma.Name = "FechaToma";
            FechaToma.ReadOnly = true;
            FechaToma.Width = 150;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvmuestra);
            panel2.Controls.Add(btnbuscar);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnAgrgar);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(109, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1359, 769);
            panel2.TabIndex = 28;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtObservacion);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnPrint);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCodMuestra);
            groupBox2.Controls.Add(cboEstado);
            groupBox2.Controls.Add(dtFechaToma);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtResponsable);
            groupBox2.Controls.Add(txtCantidadM);
            groupBox2.Controls.Add(txtMuestraID);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(4, 329);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1349, 226);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Muestra";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(1144, 73);
            txtObservacion.Margin = new Padding(4, 5, 4, 5);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(180, 143);
            txtObservacion.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1132, 32);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(192, 27);
            label11.TabIndex = 33;
            label11.Text = " Observaciones: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(329, 163);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(150, 27);
            label10.TabIndex = 32;
            label10.Text = "Fecha Toma:";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.MintCream;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(1067, 23);
            btnPrint.Margin = new Padding(4, 5, 4, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(69, 56);
            btnPrint.TabIndex = 31;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(612, 47);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(188, 27);
            label9.TabIndex = 30;
            label9.Text = "Codigo Muestra:";
            // 
            // txtCodMuestra
            // 
            txtCodMuestra.Location = new Point(808, 38);
            txtCodMuestra.Margin = new Padding(4, 5, 4, 5);
            txtCodMuestra.Multiline = true;
            txtCodMuestra.Name = "txtCodMuestra";
            txtCodMuestra.ReadOnly = true;
            txtCodMuestra.Size = new Size(247, 38);
            txtCodMuestra.TabIndex = 29;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(149, 155);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(172, 35);
            cboEstado.TabIndex = 27;
            // 
            // dtFechaToma
            // 
            dtFechaToma.Location = new Point(487, 157);
            dtFechaToma.Margin = new Padding(4, 5, 4, 5);
            dtFechaToma.Name = "dtFechaToma";
            dtFechaToma.Size = new Size(200, 35);
            dtFechaToma.TabIndex = 27;
            dtFechaToma.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(270, 47);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(209, 27);
            label15.TabIndex = 25;
            label15.Text = "Cantidad Muestra:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(13, 165);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(94, 27);
            label14.TabIndex = 25;
            label14.Text = "Estado:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(695, 173);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(160, 27);
            label16.TabIndex = 25;
            label16.Text = "Responsable:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 47);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 27);
            label8.TabIndex = 25;
            label8.Text = "Muestra ID:";
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(863, 170);
            txtResponsable.Margin = new Padding(4, 5, 4, 5);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(273, 35);
            txtResponsable.TabIndex = 26;
            // 
            // txtCantidadM
            // 
            txtCantidadM.Location = new Point(498, 44);
            txtCantidadM.Margin = new Padding(4, 5, 4, 5);
            txtCantidadM.Name = "txtCantidadM";
            txtCantidadM.Size = new Size(106, 35);
            txtCantidadM.TabIndex = 26;
            // 
            // txtMuestraID
            // 
            txtMuestraID.Location = new Point(149, 44);
            txtMuestraID.Margin = new Padding(4, 5, 4, 5);
            txtMuestraID.Name = "txtMuestraID";
            txtMuestraID.ReadOnly = true;
            txtMuestraID.Size = new Size(103, 35);
            txtMuestraID.TabIndex = 26;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // txtIDDonant
            // 
            txtIDDonant.Location = new Point(166, 38);
            txtIDDonant.Name = "txtIDDonant";
            txtIDDonant.ReadOnly = true;
            txtIDDonant.Size = new Size(134, 35);
            txtIDDonant.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 46);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 27);
            label12.TabIndex = 33;
            label12.Text = "Donante ID:";
            // 
            // FrmMuestraSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 793);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMuestraSangre";
            Text = "FrmMuestraSangre";
            Load += FrmMuestraSangre_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmuestra).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnbuscar;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private TextBox txtDonanteID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtApellidos;
        private Label label7;
        private Label label6;
        private Button btnActualizar;
        private Button btnAgrgar;
        private DataGridView dgvmuestra;
        private Panel panel2;
        private TextBox txtTiposangre;
        private TextBox txtIdDonacion;
        private ErrorProvider errorProvider;
        private GroupBox groupBox2;
        private ComboBox cboEstado;
        private DateTimePicker dtFechaToma;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label8;
        private TextBox txtResponsable;
        private TextBox txtCantidadM;
        private TextBox txtMuestraID;
        private Label label9;
        private TextBox txtCodMuestra;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printCodMuestra;
        private Label label10;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreDonante;
        private DataGridViewTextBoxColumn ApellidoDonate;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn TipoSangre;
        private DataGridViewTextBoxColumn cantidadM;
        private DataGridViewTextBoxColumn CodigoMuestra;
        private DataGridViewTextBoxColumn PresionArterial;
        private DataGridViewTextBoxColumn pulso;
        private DataGridViewTextBoxColumn Temperatura;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn FechaToma;
        private DateTimePicker dtFechaDonacion;
        private TextBox txtObservacion;
        private Label label11;
        private Label label12;
        private TextBox txtIDDonant;
    }
}