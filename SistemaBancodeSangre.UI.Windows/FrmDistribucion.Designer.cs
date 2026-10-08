namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmDistribucion
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
            dgvDistribucion = new DataGridView();
            btnAutorizar = new Button();
            btnDeclinar = new Button();
            panel4 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvDistribucion);
            panel1.Controls.Add(btnAutorizar);
            panel1.Controls.Add(btnDeclinar);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(34, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 718);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // dgvDistribucion
            // 
            dgvDistribucion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucion.Location = new Point(44, 159);
            dgvDistribucion.Name = "dgvDistribucion";
            dgvDistribucion.RowHeadersWidth = 62;
            dgvDistribucion.RowTemplate.Height = 33;
            dgvDistribucion.Size = new Size(1238, 535);
            dgvDistribucion.TabIndex = 76;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Anchor = AnchorStyles.Right;
            btnAutorizar.BackColor = Color.PaleGreen;
            btnAutorizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutorizar.Location = new Point(1096, 104);
            btnAutorizar.Margin = new Padding(4, 5, 4, 5);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(186, 47);
            btnAutorizar.TabIndex = 75;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // btnDeclinar
            // 
            btnDeclinar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeclinar.BackColor = Color.Red;
            btnDeclinar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeclinar.Location = new Point(902, 104);
            btnDeclinar.Margin = new Padding(4, 5, 4, 5);
            btnDeclinar.Name = "btnDeclinar";
            btnDeclinar.Size = new Size(186, 47);
            btnDeclinar.TabIndex = 73;
            btnDeclinar.Text = "Declinar";
            btnDeclinar.UseVisualStyleBackColor = false;
            btnDeclinar.Click += btnDeclinar_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, -34);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1316, 128);
            panel4.TabIndex = 70;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(524, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 43);
            label2.TabIndex = 0;
            label2.Text = "Procesar Solicitud";
            // 
            // FrmDistribucion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmDistribucion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDistribucion";
            Load += FrmDistribucion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAutorizar;
        private Button btnEliminar;
        private Button btnDeclinar;
        private Panel panel3;
        private DataGridViewTextBoxColumn ColIdSolicitud;
        private DataGridViewTextBoxColumn ColHospital;
        private DataGridViewTextBoxColumn ColEstado;
        private DateTimePicker txtFechaVenc;
        private TextBox txtTempConservacion;
        private TextBox txtproposito;
        private TextBox txttelefono;
        private TextBox txtDireccion;
        private TextBox tctNHospital;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private Button btnbuscar;
        private DateTimePicker txtFechaDonacion;
        private TextBox txtIdDistribucion;
        private TextBox txtCantidadSolicitada;
        private ComboBox txtComponenteSangre;
        private ComboBox txtTipoSangre;
        private TextBox txtIdDonante;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private DataGridView dgvDistribucion;
    }
}