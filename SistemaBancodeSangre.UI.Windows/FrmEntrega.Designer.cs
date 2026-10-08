namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmEntrega
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
            label8 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            panel4 = new Panel();
            DgvEntregas = new DataGridView();
            panel3 = new Panel();
            txtTipoSangre = new TextBox();
            btnAgregar = new Button();
            txtCantidadEntrega = new TextBox();
            txtSolicitudID = new TextBox();
            txtEntregaID = new TextBox();
            dtpFechaEntrega = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            erpEntrega = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEntregas).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpEntrega).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 789);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(btnBuscar);
            panel5.Location = new Point(16, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(1351, 83);
            panel5.TabIndex = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(39, 10);
            label8.Name = "label8";
            label8.Size = new Size(369, 24);
            label8.TabIndex = 92;
            label8.Text = "Busqueda por Nombre del Solicitante:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.None;
            txtBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(28, 40);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(483, 34);
            txtBuscar.TabIndex = 91;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = SystemColors.ControlDark;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(519, 40);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(193, 38);
            btnBuscar.TabIndex = 89;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(DgvEntregas);
            panel4.Location = new Point(16, 455);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1351, 287);
            panel4.TabIndex = 79;
            // 
            // DgvEntregas
            // 
            DgvEntregas.Anchor = AnchorStyles.None;
            DgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEntregas.Location = new Point(80, 18);
            DgvEntregas.Margin = new Padding(4, 5, 4, 5);
            DgvEntregas.Name = "DgvEntregas";
            DgvEntregas.RowHeadersWidth = 62;
            DgvEntregas.RowTemplate.Height = 25;
            DgvEntregas.Size = new Size(1221, 250);
            DgvEntregas.TabIndex = 78;
            DgvEntregas.CellDoubleClick += DgvEntregas_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTipoSangre);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(txtCantidadEntrega);
            panel3.Controls.Add(txtSolicitudID);
            panel3.Controls.Add(txtEntregaID);
            panel3.Controls.Add(dtpFechaEntrega);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(16, 138);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1351, 218);
            panel3.TabIndex = 78;
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Anchor = AnchorStyles.None;
            txtTipoSangre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoSangre.Location = new Point(563, 24);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.Size = new Size(273, 35);
            txtTipoSangre.TabIndex = 91;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(1017, 90);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 38);
            btnAgregar.TabIndex = 90;
            btnAgregar.Text = "Entregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtCantidadEntrega
            // 
            txtCantidadEntrega.Anchor = AnchorStyles.None;
            txtCantidadEntrega.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadEntrega.Location = new Point(593, 90);
            txtCantidadEntrega.Margin = new Padding(4, 5, 4, 5);
            txtCantidadEntrega.Name = "txtCantidadEntrega";
            txtCantidadEntrega.Size = new Size(273, 35);
            txtCantidadEntrega.TabIndex = 86;
            // 
            // txtSolicitudID
            // 
            txtSolicitudID.Anchor = AnchorStyles.None;
            txtSolicitudID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSolicitudID.Location = new Point(210, 90);
            txtSolicitudID.Margin = new Padding(4, 5, 4, 5);
            txtSolicitudID.Name = "txtSolicitudID";
            txtSolicitudID.Size = new Size(138, 35);
            txtSolicitudID.TabIndex = 85;
            // 
            // txtEntregaID
            // 
            txtEntregaID.Anchor = AnchorStyles.None;
            txtEntregaID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEntregaID.Location = new Point(210, 28);
            txtEntregaID.Margin = new Padding(4, 5, 4, 5);
            txtEntregaID.Name = "txtEntregaID";
            txtEntregaID.Size = new Size(138, 35);
            txtEntregaID.TabIndex = 88;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Anchor = AnchorStyles.None;
            dtpFechaEntrega.Location = new Point(1049, 28);
            dtpFechaEntrega.Margin = new Padding(4, 5, 4, 5);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(273, 31);
            dtpFechaEntrega.TabIndex = 84;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(869, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 80;
            label6.Text = "Fecha Entrega";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(360, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(228, 27);
            label5.TabIndex = 79;
            label5.Text = "Cantidad Entregada";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(360, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 78;
            label4.Text = "Tipo de Sangre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 77;
            label3.Text = "Solicitud ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 82;
            label1.Text = "Entrega ID";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 128);
            panel2.TabIndex = 61;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(600, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 43);
            label2.TabIndex = 0;
            label2.Text = "Entrega";
            // 
            // erpEntrega
            // 
            erpEntrega.ContainerControl = this;
            // 
            // FrmEntrega
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEntrega";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvEntregas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpEntrega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private DataGridView DgvEntregas;
        private Panel panel3;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtCantidadEntrega;
        private TextBox txtSolicitudID;
        private TextBox txtEntregaID;
        private DateTimePicker dtpFechaEntrega;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ErrorProvider erpEntrega;
        private Panel panel5;
        private TextBox txtBuscar;
        private Label label8;
        private TextBox txtTipoSangre;
    }
}