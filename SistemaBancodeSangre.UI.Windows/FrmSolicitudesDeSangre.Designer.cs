namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmSolicitudesDeSangre
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
            pictureBox1 = new PictureBox();
            txtExequatur = new TextBox();
            label12 = new Label();
            label1 = new Label();
            txtSolicitante = new TextBox();
            dgvSolicitud = new DataGridView();
            ColIDSolicitante = new DataGridViewTextBoxColumn();
            ColSolicitante = new DataGridViewTextBoxColumn();
            ColFechaSolicitud = new DataGridViewTextBoxColumn();
            ColTipoSangreSolicitada = new DataGridViewTextBoxColumn();
            ColCartaMedica = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColProposito = new DataGridViewTextBoxColumn();
            ColPrioridad = new DataGridViewTextBoxColumn();
            ColMedico = new DataGridViewTextBoxColumn();
            ColMotivo = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnAgrgar = new Button();
            dtFechaSolicitud = new DateTimePicker();
            cboPrioridad = new ComboBox();
            cboTipoSangre = new ComboBox();
            txtMotivo = new TextBox();
            txtMedico = new TextBox();
            txtProposito = new TextBox();
            txtCantidad = new TextBox();
            txtidSolicitante = new TextBox();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label3 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            erpSolicitudes = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitud).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtExequatur);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSolicitante);
            panel1.Controls.Add(dgvSolicitud);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnAgrgar);
            panel1.Controls.Add(dtFechaSolicitud);
            panel1.Controls.Add(cboPrioridad);
            panel1.Controls.Add(cboTipoSangre);
            panel1.Controls.Add(txtMotivo);
            panel1.Controls.Add(txtMedico);
            panel1.Controls.Add(txtProposito);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(txtidSolicitante);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(51, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1333, 759);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(264, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 75);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // txtExequatur
            // 
            txtExequatur.Anchor = AnchorStyles.None;
            txtExequatur.Location = new Point(1069, 245);
            txtExequatur.Margin = new Padding(4, 5, 4, 5);
            txtExequatur.MaxLength = 50;
            txtExequatur.Name = "txtExequatur";
            txtExequatur.Size = new Size(191, 31);
            txtExequatur.TabIndex = 62;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(939, 245);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 27);
            label12.TabIndex = 61;
            label12.Text = "Exequatur";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 60;
            label1.Text = "Solicitante";
            // 
            // txtSolicitante
            // 
            txtSolicitante.Anchor = AnchorStyles.None;
            txtSolicitante.Location = new Point(271, 193);
            txtSolicitante.Name = "txtSolicitante";
            txtSolicitante.Size = new Size(191, 31);
            txtSolicitante.TabIndex = 59;
            txtSolicitante.KeyPress += txtSolicitante_KeyPress;
            // 
            // dgvSolicitud
            // 
            dgvSolicitud.Anchor = AnchorStyles.None;
            dgvSolicitud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitud.Columns.AddRange(new DataGridViewColumn[] { ColIDSolicitante, ColSolicitante, ColFechaSolicitud, ColTipoSangreSolicitada, ColCartaMedica, ColCantidad, ColProposito, ColPrioridad, ColMedico, ColMotivo });
            dgvSolicitud.Location = new Point(49, 453);
            dgvSolicitud.Margin = new Padding(4, 5, 4, 5);
            dgvSolicitud.Name = "dgvSolicitud";
            dgvSolicitud.RowHeadersWidth = 62;
            dgvSolicitud.RowTemplate.Height = 25;
            dgvSolicitud.Size = new Size(1243, 212);
            dgvSolicitud.TabIndex = 58;
            // 
            // ColIDSolicitante
            // 
            ColIDSolicitante.HeaderText = "ID Solicitante";
            ColIDSolicitante.MinimumWidth = 8;
            ColIDSolicitante.Name = "ColIDSolicitante";
            ColIDSolicitante.Width = 150;
            // 
            // ColSolicitante
            // 
            ColSolicitante.HeaderText = "Solicitante";
            ColSolicitante.MinimumWidth = 8;
            ColSolicitante.Name = "ColSolicitante";
            ColSolicitante.Width = 150;
            // 
            // ColFechaSolicitud
            // 
            ColFechaSolicitud.HeaderText = "Fecha Solicitud";
            ColFechaSolicitud.MinimumWidth = 8;
            ColFechaSolicitud.Name = "ColFechaSolicitud";
            ColFechaSolicitud.Width = 150;
            // 
            // ColTipoSangreSolicitada
            // 
            ColTipoSangreSolicitada.HeaderText = "Tipo de Sangre Solicitada";
            ColTipoSangreSolicitada.MinimumWidth = 8;
            ColTipoSangreSolicitada.Name = "ColTipoSangreSolicitada";
            ColTipoSangreSolicitada.Width = 150;
            // 
            // ColCartaMedica
            // 
            ColCartaMedica.HeaderText = "Carta Medica";
            ColCartaMedica.MinimumWidth = 8;
            ColCartaMedica.Name = "ColCartaMedica";
            ColCartaMedica.Width = 150;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.MinimumWidth = 8;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.Width = 150;
            // 
            // ColProposito
            // 
            ColProposito.HeaderText = "Proposito";
            ColProposito.MinimumWidth = 8;
            ColProposito.Name = "ColProposito";
            ColProposito.Width = 150;
            // 
            // ColPrioridad
            // 
            ColPrioridad.HeaderText = "Prioridad";
            ColPrioridad.MinimumWidth = 8;
            ColPrioridad.Name = "ColPrioridad";
            ColPrioridad.Width = 150;
            // 
            // ColMedico
            // 
            ColMedico.HeaderText = "Medico";
            ColMedico.MinimumWidth = 8;
            ColMedico.Name = "ColMedico";
            ColMedico.Width = 150;
            // 
            // ColMotivo
            // 
            ColMotivo.HeaderText = "Motivo";
            ColMotivo.MinimumWidth = 8;
            ColMotivo.Name = "ColMotivo";
            ColMotivo.Width = 150;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(863, 381);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 44);
            btnActualizar.TabIndex = 57;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgrgar
            // 
            btnAgrgar.Anchor = AnchorStyles.None;
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrgar.ForeColor = SystemColors.ButtonHighlight;
            btnAgrgar.Location = new Point(1074, 376);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 49);
            btnAgrgar.TabIndex = 55;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // dtFechaSolicitud
            // 
            dtFechaSolicitud.Anchor = AnchorStyles.None;
            dtFechaSolicitud.Location = new Point(271, 252);
            dtFechaSolicitud.Margin = new Padding(4, 5, 4, 5);
            dtFechaSolicitud.Name = "dtFechaSolicitud";
            dtFechaSolicitud.Size = new Size(191, 31);
            dtFechaSolicitud.TabIndex = 54;
            // 
            // cboPrioridad
            // 
            cboPrioridad.Anchor = AnchorStyles.None;
            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPrioridad.FormattingEnabled = true;
            cboPrioridad.Items.AddRange(new object[] { "Inmediata", "Varios dias de espera" });
            cboPrioridad.Location = new Point(731, 302);
            cboPrioridad.Margin = new Padding(4, 5, 4, 5);
            cboPrioridad.Name = "cboPrioridad";
            cboPrioridad.Size = new Size(191, 33);
            cboPrioridad.TabIndex = 53;
            // 
            // cboTipoSangre
            // 
            cboTipoSangre.Anchor = AnchorStyles.None;
            cboTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSangre.FormattingEnabled = true;
            cboTipoSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cboTipoSangre.Location = new Point(731, 150);
            cboTipoSangre.Margin = new Padding(4, 5, 4, 5);
            cboTipoSangre.Name = "cboTipoSangre";
            cboTipoSangre.Size = new Size(191, 33);
            cboTipoSangre.TabIndex = 52;
            // 
            // txtMotivo
            // 
            txtMotivo.Anchor = AnchorStyles.None;
            txtMotivo.Location = new Point(1069, 199);
            txtMotivo.Margin = new Padding(4, 5, 4, 5);
            txtMotivo.MaxLength = 300;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(191, 31);
            txtMotivo.TabIndex = 49;
            txtMotivo.KeyPress += txtMotivo_KeyPress;
            // 
            // txtMedico
            // 
            txtMedico.Anchor = AnchorStyles.None;
            txtMedico.Location = new Point(1069, 152);
            txtMedico.Margin = new Padding(4, 5, 4, 5);
            txtMedico.MaxLength = 50;
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(191, 31);
            txtMedico.TabIndex = 48;
            txtMedico.KeyPress += txtMedico_KeyPress;
            // 
            // txtProposito
            // 
            txtProposito.Anchor = AnchorStyles.None;
            txtProposito.Location = new Point(731, 246);
            txtProposito.Margin = new Padding(4, 5, 4, 5);
            txtProposito.MaxLength = 200;
            txtProposito.Name = "txtProposito";
            txtProposito.Size = new Size(191, 31);
            txtProposito.TabIndex = 51;
            txtProposito.KeyPress += txtProposito_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.Location = new Point(731, 199);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(191, 31);
            txtCantidad.TabIndex = 47;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtidSolicitante
            // 
            txtidSolicitante.Anchor = AnchorStyles.None;
            txtidSolicitante.Location = new Point(271, 152);
            txtidSolicitante.Margin = new Padding(4, 5, 4, 5);
            txtidSolicitante.Name = "txtidSolicitante";
            txtidSolicitante.ReadOnly = true;
            txtidSolicitante.Size = new Size(191, 31);
            txtidSolicitante.TabIndex = 46;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(104, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 27);
            label5.TabIndex = 44;
            label5.Text = "Carta Medica";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(623, 302);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 27);
            label10.TabIndex = 43;
            label10.Text = "Prioridad";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(966, 199);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 27);
            label11.TabIndex = 42;
            label11.Text = "Motivo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(86, 252);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 27);
            label3.TabIndex = 41;
            label3.Text = "Fecha Solicitud";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(957, 152);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 40;
            label9.Text = "Medico";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(614, 246);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 27);
            label7.TabIndex = 39;
            label7.Text = "Proposito";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(470, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(253, 27);
            label4.TabIndex = 38;
            label4.Text = "Tipo Sangre Solicitada";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(620, 199);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(109, 27);
            label6.TabIndex = 37;
            label6.Text = "Cantidad";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(104, 152);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 27);
            label8.TabIndex = 45;
            label8.Text = "ID Solicitud";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 128);
            panel2.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(539, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(390, 43);
            label2.TabIndex = 0;
            label2.Text = "Solicitudes de Sangre";
            // 
            // erpSolicitudes
            // 
            erpSolicitudes.ContainerControl = this;
            // 
            // FrmSolicitudesDeSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmSolicitudesDeSangre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSolicitudesDeSangre";
            Load += FrmSolicitudesDeSangre_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitud).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvSolicitud;
        private DataGridViewTextBoxColumn ColIDSolicitante;
        private DataGridViewTextBoxColumn ColSolicitante;
        private DataGridViewTextBoxColumn ColFechaSolicitud;
        private DataGridViewTextBoxColumn ColTipoSangreSolicitada;
        private DataGridViewTextBoxColumn ColCartaMedica;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColProposito;
        private DataGridViewTextBoxColumn ColPrioridad;
        private DataGridViewTextBoxColumn ColMedico;
        private DataGridViewTextBoxColumn ColMotivo;
        private Button btnActualizar;
        private Button btnAgrgar;
        private DateTimePicker dtFechaSolicitud;
        private ComboBox cboPrioridad;
        private ComboBox cboTipoSangre;
        private TextBox txtMotivo;
        private TextBox txtMedico;
        private TextBox txtProposito;
        private TextBox txtCantidad;
        private TextBox txtidSolicitante;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label3;
        private Label label9;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label8;
        private Panel panel2;
        private Label label2;
        private ErrorProvider erpSolicitudes;
        private TextBox txtSolicitante;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtExequatur;
        private Label label12;
    }
}