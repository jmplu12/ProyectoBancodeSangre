namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantInventario
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
            grbInventario = new GroupBox();
            dtpFechaVenc = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtCantidadDisponible = new TextBox();
            txtProcesoId = new TextBox();
            label2 = new Label();
            label8 = new Label();
            txtTipoSangre = new TextBox();
            label7 = new Label();
            txtInventarioId = new TextBox();
            txtDonacionID = new TextBox();
            label6 = new Label();
            dgvInventario = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            erpInventario = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpInventario).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbInventario);
            pnlBase.Controls.Add(dgvInventario);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(7, 6);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1434, 734);
            pnlBase.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1214, 209);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 54);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1214, 159);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(169, 52);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1214, 109);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 52);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbInventario
            // 
            grbInventario.Controls.Add(dtpFechaVenc);
            grbInventario.Controls.Add(label4);
            grbInventario.Controls.Add(label5);
            grbInventario.Controls.Add(txtCantidadDisponible);
            grbInventario.Controls.Add(txtProcesoId);
            grbInventario.Controls.Add(label2);
            grbInventario.Controls.Add(label8);
            grbInventario.Controls.Add(txtTipoSangre);
            grbInventario.Controls.Add(label7);
            grbInventario.Controls.Add(txtInventarioId);
            grbInventario.Controls.Add(txtDonacionID);
            grbInventario.Controls.Add(label6);
            grbInventario.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbInventario.Location = new Point(23, 90);
            grbInventario.Name = "grbInventario";
            grbInventario.Size = new Size(1185, 339);
            grbInventario.TabIndex = 2;
            grbInventario.TabStop = false;
            grbInventario.Text = "Datos Inventario";
            // 
            // dtpFechaVenc
            // 
            dtpFechaVenc.Anchor = AnchorStyles.None;
            dtpFechaVenc.Location = new Point(794, 119);
            dtpFechaVenc.Margin = new Padding(4, 5, 4, 5);
            dtpFechaVenc.Name = "dtpFechaVenc";
            dtpFechaVenc.Size = new Size(291, 33);
            dtpFechaVenc.TabIndex = 76;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 251);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 90;
            label4.Text = "Proceso ID";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(544, 119);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(237, 26);
            label5.TabIndex = 73;
            label5.Text = "Fecha de Vencimiento";
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Anchor = AnchorStyles.None;
            txtCantidadDisponible.Location = new Point(794, 42);
            txtCantidadDisponible.Margin = new Padding(4, 5, 4, 5);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.ReadOnly = true;
            txtCantidadDisponible.Size = new Size(162, 33);
            txtCantidadDisponible.TabIndex = 75;
            // 
            // txtProcesoId
            // 
            txtProcesoId.Anchor = AnchorStyles.None;
            txtProcesoId.Location = new Point(230, 244);
            txtProcesoId.Margin = new Padding(4, 5, 4, 5);
            txtProcesoId.Name = "txtProcesoId";
            txtProcesoId.ReadOnly = true;
            txtProcesoId.Size = new Size(172, 33);
            txtProcesoId.TabIndex = 89;
            txtProcesoId.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 82;
            label2.Text = "Inventario ID";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(662, 46);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 26);
            label8.TabIndex = 74;
            label8.Text = "Cantidad";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Location = new Point(272, 201);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(130, 33);
            txtTipoSangre.TabIndex = 88;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(81, 201);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 26);
            label7.TabIndex = 87;
            label7.Text = "Tipo de sangre";
            // 
            // txtInventarioId
            // 
            txtInventarioId.Anchor = AnchorStyles.None;
            txtInventarioId.Location = new Point(240, 39);
            txtInventarioId.Margin = new Padding(4, 5, 4, 5);
            txtInventarioId.Name = "txtInventarioId";
            txtInventarioId.ReadOnly = true;
            txtInventarioId.Size = new Size(227, 33);
            txtInventarioId.TabIndex = 83;
            // 
            // txtDonacionID
            // 
            txtDonacionID.Anchor = AnchorStyles.None;
            txtDonacionID.Location = new Point(230, 155);
            txtDonacionID.Margin = new Padding(4, 5, 4, 5);
            txtDonacionID.Name = "txtDonacionID";
            txtDonacionID.ReadOnly = true;
            txtDonacionID.Size = new Size(172, 33);
            txtDonacionID.TabIndex = 86;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(81, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 26);
            label6.TabIndex = 84;
            label6.Text = "Donacion ID";
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(11, 448);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.RowTemplate.Height = 33;
            dgvInventario.Size = new Size(1209, 225);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellDoubleClick += dgvInventario_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1430, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(262, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Inventario";
            // 
            // erpInventario
            // 
            erpInventario.ContainerControl = this;
            // 
            // FrmMantInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 739);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantInventario";
            Text = "FrmMantInventario";
            Load += FrmMantInventario_Load;
            pnlBase.ResumeLayout(false);
            grbInventario.ResumeLayout(false);
            grbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbInventario;
        private DataGridView dgvInventario;
        private Panel pnlEncabezado;
        private Label label1;
        public TextBox txtProcesoId;
        private Label label2;
        public TextBox txtTipoSangre;
        private Label label7;
        private TextBox txtInventarioId;
        public TextBox txtDonacionID;
        private Label label6;
        private Label label4;
        private DateTimePicker dtpFechaVenc;
        private Label label5;
        public TextBox txtCantidadDisponible;
        private Label label8;
        private ErrorProvider erpInventario;
    }
}