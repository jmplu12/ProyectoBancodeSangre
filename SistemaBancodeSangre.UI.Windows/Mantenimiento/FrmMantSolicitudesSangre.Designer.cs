namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantSolicitudesSangre
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
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            grbSolicitudes = new GroupBox();
            txtEstado = new TextBox();
            label13 = new Label();
            txtExequatur = new TextBox();
            label12 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtSolicitante = new TextBox();
            label6 = new Label();
            dtFechaSolicitud = new DateTimePicker();
            label4 = new Label();
            cboPrioridad = new ComboBox();
            label7 = new Label();
            cboTipoSangre = new ComboBox();
            label9 = new Label();
            txtMotivo = new TextBox();
            label3 = new Label();
            txtMedico = new TextBox();
            label11 = new Label();
            txtProposito = new TextBox();
            label10 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtidSolicitante = new TextBox();
            dgvMantSolicitudes = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            erpSolicitudes = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantSolicitudes).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbSolicitudes);
            pnlBase.Controls.Add(dgvMantSolicitudes);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(14, 2);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1504, 719);
            pnlBase.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1258, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(233, 50);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1258, 157);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(233, 48);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1258, 107);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(233, 48);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbSolicitudes
            // 
            grbSolicitudes.Controls.Add(txtEstado);
            grbSolicitudes.Controls.Add(label13);
            grbSolicitudes.Controls.Add(txtExequatur);
            grbSolicitudes.Controls.Add(label12);
            grbSolicitudes.Controls.Add(label2);
            grbSolicitudes.Controls.Add(label8);
            grbSolicitudes.Controls.Add(txtSolicitante);
            grbSolicitudes.Controls.Add(label6);
            grbSolicitudes.Controls.Add(dtFechaSolicitud);
            grbSolicitudes.Controls.Add(label4);
            grbSolicitudes.Controls.Add(cboPrioridad);
            grbSolicitudes.Controls.Add(label7);
            grbSolicitudes.Controls.Add(cboTipoSangre);
            grbSolicitudes.Controls.Add(label9);
            grbSolicitudes.Controls.Add(txtMotivo);
            grbSolicitudes.Controls.Add(label3);
            grbSolicitudes.Controls.Add(txtMedico);
            grbSolicitudes.Controls.Add(label11);
            grbSolicitudes.Controls.Add(txtProposito);
            grbSolicitudes.Controls.Add(label10);
            grbSolicitudes.Controls.Add(txtCantidad);
            grbSolicitudes.Controls.Add(label5);
            grbSolicitudes.Controls.Add(txtidSolicitante);
            grbSolicitudes.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbSolicitudes.Location = new Point(23, 90);
            grbSolicitudes.Name = "grbSolicitudes";
            grbSolicitudes.Size = new Size(1215, 339);
            grbSolicitudes.TabIndex = 2;
            grbSolicitudes.TabStop = false;
            grbSolicitudes.Text = "Datos Solicitudes";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.None;
            txtEstado.Location = new Point(1002, 86);
            txtEstado.Margin = new Padding(4, 5, 4, 5);
            txtEstado.MaxLength = 300;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(191, 33);
            txtEstado.TabIndex = 81;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(902, 86);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(94, 27);
            label13.TabIndex = 80;
            label13.Text = "Estado:";
            // 
            // txtExequatur
            // 
            txtExequatur.Anchor = AnchorStyles.None;
            txtExequatur.Location = new Point(683, 225);
            txtExequatur.Margin = new Padding(4, 5, 4, 5);
            txtExequatur.MaxLength = 50;
            txtExequatur.Name = "txtExequatur";
            txtExequatur.Size = new Size(190, 33);
            txtExequatur.TabIndex = 64;
            txtExequatur.KeyPress += txtExequatur_KeyPress;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(553, 225);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 27);
            label12.TabIndex = 63;
            label12.Text = "Exequatur";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(111, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 79;
            label2.Text = "Solicitante:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(111, 39);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 27);
            label8.TabIndex = 69;
            label8.Text = "ID Solicitud:";
            // 
            // txtSolicitante
            // 
            txtSolicitante.Anchor = AnchorStyles.None;
            txtSolicitante.Location = new Point(258, 79);
            txtSolicitante.Name = "txtSolicitante";
            txtSolicitante.Size = new Size(191, 33);
            txtSolicitante.TabIndex = 78;
            txtSolicitante.KeyPress += txtSolicitante_KeyPress_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(545, 39);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 27);
            label6.TabIndex = 61;
            label6.Text = "Cantidad:";
            // 
            // dtFechaSolicitud
            // 
            dtFechaSolicitud.Anchor = AnchorStyles.None;
            dtFechaSolicitud.Location = new Point(297, 133);
            dtFechaSolicitud.Margin = new Padding(4, 5, 4, 5);
            dtFechaSolicitud.Name = "dtFechaSolicitud";
            dtFechaSolicitud.Size = new Size(152, 33);
            dtFechaSolicitud.TabIndex = 77;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(111, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 27);
            label4.TabIndex = 62;
            label4.Text = "T.S Solicitada:";
            // 
            // cboPrioridad
            // 
            cboPrioridad.Anchor = AnchorStyles.None;
            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPrioridad.FormattingEnabled = true;
            cboPrioridad.Items.AddRange(new object[] { "Inmediata", "Varios dias de espera" });
            cboPrioridad.Location = new Point(663, 129);
            cboPrioridad.Margin = new Padding(4, 5, 4, 5);
            cboPrioridad.Name = "cboPrioridad";
            cboPrioridad.Size = new Size(210, 34);
            cboPrioridad.TabIndex = 76;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(539, 86);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 27);
            label7.TabIndex = 63;
            label7.Text = "Proposito:";
            // 
            // cboTipoSangre
            // 
            cboTipoSangre.Anchor = AnchorStyles.None;
            cboTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSangre.FormattingEnabled = true;
            cboTipoSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cboTipoSangre.Location = new Point(276, 241);
            cboTipoSangre.Margin = new Padding(4, 5, 4, 5);
            cboTipoSangre.Name = "cboTipoSangre";
            cboTipoSangre.Size = new Size(191, 34);
            cboTipoSangre.TabIndex = 75;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(564, 182);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 27);
            label9.TabIndex = 64;
            label9.Text = "Medico:";
            // 
            // txtMotivo
            // 
            txtMotivo.Anchor = AnchorStyles.None;
            txtMotivo.Location = new Point(1002, 43);
            txtMotivo.Margin = new Padding(4, 5, 4, 5);
            txtMotivo.MaxLength = 300;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(191, 33);
            txtMotivo.TabIndex = 73;
            txtMotivo.KeyPress += txtMotivo_KeyPress_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(111, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 27);
            label3.TabIndex = 65;
            label3.Text = "Fecha Solicitud";
            // 
            // txtMedico
            // 
            txtMedico.Anchor = AnchorStyles.None;
            txtMedico.Location = new Point(663, 182);
            txtMedico.Margin = new Padding(4, 5, 4, 5);
            txtMedico.MaxLength = 50;
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(210, 33);
            txtMedico.TabIndex = 72;
            txtMedico.KeyPress += txtMedico_KeyPress_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(912, 43);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 27);
            label11.TabIndex = 66;
            label11.Text = "Motivo:";
            // 
            // txtProposito
            // 
            txtProposito.Anchor = AnchorStyles.None;
            txtProposito.Location = new Point(663, 83);
            txtProposito.Margin = new Padding(4, 5, 4, 5);
            txtProposito.MaxLength = 200;
            txtProposito.Name = "txtProposito";
            txtProposito.Size = new Size(210, 33);
            txtProposito.TabIndex = 74;
            txtProposito.KeyPress += txtProposito_KeyPress_1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(546, 129);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(115, 27);
            label10.TabIndex = 67;
            label10.Text = "Prioridad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.Location = new Point(662, 40);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 33);
            txtCantidad.TabIndex = 71;
            txtCantidad.KeyPress += txtCantidad_KeyPress_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(111, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 27);
            label5.TabIndex = 68;
            label5.Text = "Carta Medica:";
            // 
            // txtidSolicitante
            // 
            txtidSolicitante.Anchor = AnchorStyles.None;
            txtidSolicitante.Location = new Point(258, 38);
            txtidSolicitante.Margin = new Padding(4, 5, 4, 5);
            txtidSolicitante.Name = "txtidSolicitante";
            txtidSolicitante.ReadOnly = true;
            txtidSolicitante.Size = new Size(191, 33);
            txtidSolicitante.TabIndex = 70;
            // 
            // dgvMantSolicitudes
            // 
            dgvMantSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantSolicitudes.Location = new Point(11, 448);
            dgvMantSolicitudes.Name = "dgvMantSolicitudes";
            dgvMantSolicitudes.RowHeadersWidth = 62;
            dgvMantSolicitudes.RowTemplate.Height = 33;
            dgvMantSolicitudes.Size = new Size(1227, 225);
            dgvMantSolicitudes.TabIndex = 1;
            dgvMantSolicitudes.CellDoubleClick += dgvMantSolicitudes_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, 3);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1500, 72);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 18);
            label1.Name = "label1";
            label1.Size = new Size(274, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Solicitudes";
            // 
            // erpSolicitudes
            // 
            erpSolicitudes.ContainerControl = this;
            // 
            // FrmMantSolicitudesSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 727);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantSolicitudesSangre";
            Text = "FrmMantSolicitudesSangre";
            pnlBase.ResumeLayout(false);
            grbSolicitudes.ResumeLayout(false);
            grbSolicitudes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantSolicitudes).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbSolicitudes;
        private DataGridView dgvMantSolicitudes;
        private Panel pnlEncabezado;
        private Label label1;
        private Label label2;
        private Label label8;
        private TextBox txtSolicitante;
        private Label label6;
        private DateTimePicker dtFechaSolicitud;
        private Label label4;
        private ComboBox cboPrioridad;
        private Label label7;
        private ComboBox cboTipoSangre;
        private Label label9;
        private TextBox txtMotivo;
        private Label label3;
        private TextBox txtMedico;
        private Label label11;
        private TextBox txtProposito;
        private Label label10;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtidSolicitante;
        private TextBox txtExequatur;
        private Label label12;
        private ErrorProvider erpSolicitudes;
        private TextBox txtEstado;
        private Label label13;
    }
}