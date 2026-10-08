namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantEntregasSangre
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
            txtTipoSangre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCantidadEntrega = new TextBox();
            label4 = new Label();
            txtSolicitudID = new TextBox();
            label5 = new Label();
            txtEntregaID = new TextBox();
            label6 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            dgvMantEntregas = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            epmanEntrega = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantEntregas).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epmanEntrega).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbSolicitudes);
            pnlBase.Controls.Add(dgvMantEntregas);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(12, 5);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1404, 729);
            pnlBase.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1191, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(202, 61);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1191, 140);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(202, 59);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1191, 90);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 59);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbSolicitudes
            // 
            grbSolicitudes.Controls.Add(txtTipoSangre);
            grbSolicitudes.Controls.Add(label2);
            grbSolicitudes.Controls.Add(label3);
            grbSolicitudes.Controls.Add(txtCantidadEntrega);
            grbSolicitudes.Controls.Add(label4);
            grbSolicitudes.Controls.Add(txtSolicitudID);
            grbSolicitudes.Controls.Add(label5);
            grbSolicitudes.Controls.Add(txtEntregaID);
            grbSolicitudes.Controls.Add(label6);
            grbSolicitudes.Controls.Add(dtpFechaEntrega);
            grbSolicitudes.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbSolicitudes.Location = new Point(23, 90);
            grbSolicitudes.Name = "grbSolicitudes";
            grbSolicitudes.Size = new Size(1162, 303);
            grbSolicitudes.TabIndex = 2;
            grbSolicitudes.TabStop = false;
            grbSolicitudes.Text = "Datos Solicitudes";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoSangre.Location = new Point(661, 55);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.Size = new Size(303, 35);
            txtTipoSangre.TabIndex = 102;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 27);
            label2.TabIndex = 96;
            label2.Text = "Entrega ID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 92;
            label3.Text = "Solicitud ID";
            // 
            // txtCantidadEntrega
            // 
            txtCantidadEntrega.Anchor = AnchorStyles.None;
            txtCantidadEntrega.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadEntrega.Location = new Point(691, 121);
            txtCantidadEntrega.Margin = new Padding(4, 5, 4, 5);
            txtCantidadEntrega.Name = "txtCantidadEntrega";
            txtCantidadEntrega.Size = new Size(273, 35);
            txtCantidadEntrega.TabIndex = 99;
            txtCantidadEntrega.KeyPress += txtCantidadEntrega_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(458, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 93;
            label4.Text = "Tipo de Sangre:";
            // 
            // txtSolicitudID
            // 
            txtSolicitudID.Anchor = AnchorStyles.None;
            txtSolicitudID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSolicitudID.Location = new Point(200, 121);
            txtSolicitudID.Margin = new Padding(4, 5, 4, 5);
            txtSolicitudID.Name = "txtSolicitudID";
            txtSolicitudID.ReadOnly = true;
            txtSolicitudID.Size = new Size(138, 35);
            txtSolicitudID.TabIndex = 98;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(458, 121);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(228, 27);
            label5.TabIndex = 94;
            label5.Text = "Cantidad Entregada";
            // 
            // txtEntregaID
            // 
            txtEntregaID.Anchor = AnchorStyles.None;
            txtEntregaID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEntregaID.Location = new Point(200, 59);
            txtEntregaID.Margin = new Padding(4, 5, 4, 5);
            txtEntregaID.Name = "txtEntregaID";
            txtEntregaID.ReadOnly = true;
            txtEntregaID.Size = new Size(138, 35);
            txtEntregaID.TabIndex = 100;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(80, 181);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 95;
            label6.Text = "Fecha Entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Anchor = AnchorStyles.None;
            dtpFechaEntrega.Location = new Point(260, 181);
            dtpFechaEntrega.Margin = new Padding(4, 5, 4, 5);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(273, 33);
            dtpFechaEntrega.TabIndex = 97;
            // 
            // dgvMantEntregas
            // 
            dgvMantEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantEntregas.Location = new Point(11, 448);
            dgvMantEntregas.Name = "dgvMantEntregas";
            dgvMantEntregas.RowHeadersWidth = 62;
            dgvMantEntregas.RowTemplate.Height = 33;
            dgvMantEntregas.Size = new Size(1174, 225);
            dgvMantEntregas.TabIndex = 1;
            dgvMantEntregas.CellDoubleClick += dgvMantSolicitudes_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1438, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(251, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Entregas";
            // 
            // epmanEntrega
            // 
            epmanEntrega.ContainerControl = this;
            // 
            // FrmMantEntregasSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 745);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantEntregasSangre";
            Text = "FrmMantEntregasSangre";
            Load += FrmMantEntregasSangre_Load;
            pnlBase.ResumeLayout(false);
            grbSolicitudes.ResumeLayout(false);
            grbSolicitudes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantEntregas).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epmanEntrega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbSolicitudes;
        private DataGridView dgvMantEntregas;
        private Panel pnlEncabezado;
        private Label label1;
        private TextBox txtTipoSangre;
        private Label label2;
        private Label label3;
        private TextBox txtCantidadEntrega;
        private Label label4;
        private TextBox txtSolicitudID;
        private Label label5;
        private TextBox txtEntregaID;
        private Label label6;
        private DateTimePicker dtpFechaEntrega;
        private ErrorProvider epmanEntrega;
    }
}