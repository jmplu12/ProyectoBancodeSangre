namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantProcesamientoSangre
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
            grbUsuarios = new GroupBox();
            txtResponsable = new TextBox();
            txtAlmacenado = new TextBox();
            dtpFechaVenc = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            txtVolumenDno = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label7 = new Label();
            txtProcesoId = new TextBox();
            txtTipoSangre = new TextBox();
            txtNoSangre = new TextBox();
            txtIdDonacion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            dgvMantProcesos = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            erpProcesamientoSangre = new ErrorProvider(components);
            txtEstado = new TextBox();
            pnlBase.SuspendLayout();
            grbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantProcesos).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpProcesamientoSangre).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbUsuarios);
            pnlBase.Controls.Add(dgvMantProcesos);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(7, 10);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1400, 717);
            pnlBase.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1157, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(181, 55);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1157, 162);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(181, 53);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1157, 112);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 53);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbUsuarios
            // 
            grbUsuarios.Controls.Add(txtEstado);
            grbUsuarios.Controls.Add(txtResponsable);
            grbUsuarios.Controls.Add(txtAlmacenado);
            grbUsuarios.Controls.Add(dtpFechaVenc);
            grbUsuarios.Controls.Add(label12);
            grbUsuarios.Controls.Add(label11);
            grbUsuarios.Controls.Add(txtVolumenDno);
            grbUsuarios.Controls.Add(label6);
            grbUsuarios.Controls.Add(label10);
            grbUsuarios.Controls.Add(label7);
            grbUsuarios.Controls.Add(txtProcesoId);
            grbUsuarios.Controls.Add(txtTipoSangre);
            grbUsuarios.Controls.Add(txtNoSangre);
            grbUsuarios.Controls.Add(txtIdDonacion);
            grbUsuarios.Controls.Add(label4);
            grbUsuarios.Controls.Add(label3);
            grbUsuarios.Controls.Add(label5);
            grbUsuarios.Controls.Add(label2);
            grbUsuarios.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbUsuarios.Location = new Point(23, 90);
            grbUsuarios.Name = "grbUsuarios";
            grbUsuarios.Size = new Size(1128, 339);
            grbUsuarios.TabIndex = 2;
            grbUsuarios.TabStop = false;
            grbUsuarios.Text = "Datos Procesamiento de Sangre";
            // 
            // txtResponsable
            // 
            txtResponsable.Anchor = AnchorStyles.None;
            txtResponsable.Location = new Point(628, 241);
            txtResponsable.Margin = new Padding(4, 5, 4, 5);
            txtResponsable.MaxLength = 150;
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(260, 33);
            txtResponsable.TabIndex = 66;
            // 
            // txtAlmacenado
            // 
            txtAlmacenado.Anchor = AnchorStyles.None;
            txtAlmacenado.Location = new Point(622, 198);
            txtAlmacenado.Margin = new Padding(4, 5, 4, 5);
            txtAlmacenado.MaxLength = 150;
            txtAlmacenado.Name = "txtAlmacenado";
            txtAlmacenado.Size = new Size(266, 33);
            txtAlmacenado.TabIndex = 67;
            // 
            // dtpFechaVenc
            // 
            dtpFechaVenc.Anchor = AnchorStyles.None;
            dtpFechaVenc.Format = DateTimePickerFormat.Short;
            dtpFechaVenc.Location = new Point(622, 46);
            dtpFechaVenc.Margin = new Padding(4, 5, 4, 5);
            dtpFechaVenc.Name = "dtpFechaVenc";
            dtpFechaVenc.Size = new Size(266, 33);
            dtpFechaVenc.TabIndex = 63;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(481, 248);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(146, 27);
            label12.TabIndex = 64;
            label12.Text = "Resposable:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(475, 201);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(152, 27);
            label11.TabIndex = 65;
            label11.Text = "Almacenado:";
            // 
            // txtVolumenDno
            // 
            txtVolumenDno.Anchor = AnchorStyles.None;
            txtVolumenDno.Location = new Point(622, 96);
            txtVolumenDno.Margin = new Padding(4, 5, 4, 5);
            txtVolumenDno.MaxLength = 35;
            txtVolumenDno.Name = "txtVolumenDno";
            txtVolumenDno.Size = new Size(266, 33);
            txtVolumenDno.TabIndex = 61;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(455, 48);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 27);
            label6.TabIndex = 58;
            label6.Text = "fecha de Venc";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(460, 96);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(167, 27);
            label10.TabIndex = 59;
            label10.Text = "Cantidad Dno:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(484, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 27);
            label7.TabIndex = 60;
            label7.Text = "Estado:";
            // 
            // txtProcesoId
            // 
            txtProcesoId.Anchor = AnchorStyles.None;
            txtProcesoId.Location = new Point(232, 59);
            txtProcesoId.Margin = new Padding(4, 5, 4, 5);
            txtProcesoId.Name = "txtProcesoId";
            txtProcesoId.ReadOnly = true;
            txtProcesoId.Size = new Size(195, 33);
            txtProcesoId.TabIndex = 57;
            txtProcesoId.Visible = false;
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Location = new Point(232, 211);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(195, 33);
            txtTipoSangre.TabIndex = 56;
            // 
            // txtNoSangre
            // 
            txtNoSangre.Anchor = AnchorStyles.None;
            txtNoSangre.Location = new Point(232, 159);
            txtNoSangre.Margin = new Padding(4, 5, 4, 5);
            txtNoSangre.Name = "txtNoSangre";
            txtNoSangre.Size = new Size(195, 33);
            txtNoSangre.TabIndex = 54;
            // 
            // txtIdDonacion
            // 
            txtIdDonacion.Anchor = AnchorStyles.None;
            txtIdDonacion.Location = new Point(232, 109);
            txtIdDonacion.Margin = new Padding(4, 5, 4, 5);
            txtIdDonacion.Name = "txtIdDonacion";
            txtIdDonacion.ReadOnly = true;
            txtIdDonacion.Size = new Size(195, 33);
            txtIdDonacion.TabIndex = 55;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 51;
            label4.Text = "Tipo de Sangre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(92, 159);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 52;
            label3.Text = "No_Sangre:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 113);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 27);
            label5.TabIndex = 53;
            label5.Text = "ID Donacion:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 27);
            label2.TabIndex = 50;
            label2.Text = "ID Procesos:";
            // 
            // dgvMantProcesos
            // 
            dgvMantProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantProcesos.Location = new Point(11, 448);
            dgvMantProcesos.Name = "dgvMantProcesos";
            dgvMantProcesos.RowHeadersWidth = 62;
            dgvMantProcesos.RowTemplate.Height = 33;
            dgvMantProcesos.Size = new Size(1209, 225);
            dgvMantProcesos.TabIndex = 1;
            dgvMantProcesos.CellDoubleClick += dgvMantProcesos_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1399, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(373, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Procesos de Sangre";
            // 
            // erpProcesamientoSangre
            // 
            erpProcesamientoSangre.ContainerControl = this;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.None;
            txtEstado.Location = new Point(622, 152);
            txtEstado.Margin = new Padding(4, 5, 4, 5);
            txtEstado.MaxLength = 150;
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(266, 33);
            txtEstado.TabIndex = 68;
            // 
            // FrmMantProcesamientoSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 741);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantProcesamientoSangre";
            Text = "FrmMantProcesamientoSangre";
            Load += FrmMantProcesamientoSangre_Load;
            pnlBase.ResumeLayout(false);
            grbUsuarios.ResumeLayout(false);
            grbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantProcesos).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpProcesamientoSangre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbUsuarios;
        private DataGridView dgvMantProcesos;
        private Panel pnlEncabezado;
        private Label label1;
        private Label label2;
        public TextBox txtTipoSangre;
        private TextBox txtNoSangre;
        public TextBox txtIdDonacion;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtProcesoId;
        private TextBox txtResponsable;
        private TextBox txtAlmacenado;
        private DateTimePicker dtpFechaVenc;
        private Label label12;
        private Label label11;
        public TextBox txtVolumenDno;
        private Label label6;
        private Label label10;
        private Label label7;
        private ErrorProvider erpProcesamientoSangre;
        private TextBox txtEstado;
    }
}