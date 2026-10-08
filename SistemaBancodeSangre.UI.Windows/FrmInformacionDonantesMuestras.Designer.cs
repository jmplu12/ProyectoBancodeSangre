namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmInformacionDonantesMuestras
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
            btnEliminarDonantes = new Button();
            dgvInfDonMuestras = new DataGridView();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfDonMuestras).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEliminarDonantes);
            panel1.Controls.Add(dgvInfDonMuestras);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(66, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1610, 735);
            panel1.TabIndex = 1;
            // 
            // btnEliminarDonantes
            // 
            btnEliminarDonantes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarDonantes.BackColor = Color.Teal;
            btnEliminarDonantes.FlatStyle = FlatStyle.Flat;
            btnEliminarDonantes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarDonantes.Location = new Point(1210, 1326);
            btnEliminarDonantes.Margin = new Padding(4, 5, 4, 5);
            btnEliminarDonantes.Name = "btnEliminarDonantes";
            btnEliminarDonantes.Size = new Size(197, 67);
            btnEliminarDonantes.TabIndex = 43;
            btnEliminarDonantes.Text = "Eliminar Donantes";
            btnEliminarDonantes.UseVisualStyleBackColor = false;
            // 
            // dgvInfDonMuestras
            // 
            dgvInfDonMuestras.AllowUserToAddRows = false;
            dgvInfDonMuestras.AllowUserToDeleteRows = false;
            dgvInfDonMuestras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInfDonMuestras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfDonMuestras.Location = new Point(27, 178);
            dgvInfDonMuestras.Margin = new Padding(4, 5, 4, 5);
            dgvInfDonMuestras.Name = "dgvInfDonMuestras";
            dgvInfDonMuestras.ReadOnly = true;
            dgvInfDonMuestras.RowHeadersWidth = 62;
            dgvInfDonMuestras.RowTemplate.Height = 25;
            dgvInfDonMuestras.Size = new Size(1518, 476);
            dgvInfDonMuestras.TabIndex = 41;
            dgvInfDonMuestras.CellContentDoubleClick += dgvInfDonMuestras_CellContentDoubleClick;
            dgvInfDonMuestras.CellDoubleClick += dgvInfDonMuestras_CellDoubleClick;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(183, 133);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(238, 35);
            txtbuscar.TabIndex = 39;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(27, 130);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(135, 38);
            btnbuscar.TabIndex = 38;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1608, 106);
            panel2.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(383, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(611, 60);
            label2.TabIndex = 0;
            label2.Text = "Datos Donantes y Muestra";
            // 
            // FrmInformacionDonantesMuestras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 771);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmInformacionDonantesMuestras";
            Text = "FrmInformacionDonantesMuestras";
            Load += FrmInformacionDonantesMuestras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfDonMuestras).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminarDonantes;
        private DataGridView dgvInfDonMuestras;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
    }
}