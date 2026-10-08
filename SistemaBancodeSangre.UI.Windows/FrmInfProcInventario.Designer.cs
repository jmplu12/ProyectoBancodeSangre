namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmInfProcInventario
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
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            dgvDonProc = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonProc).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(dgvDonProc);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 631);
            panel1.TabIndex = 0;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(205, 127);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(279, 35);
            txtbuscar.TabIndex = 46;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(21, 124);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(176, 38);
            btnbuscar.TabIndex = 45;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // dgvDonProc
            // 
            dgvDonProc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonProc.Location = new Point(6, 192);
            dgvDonProc.Name = "dgvDonProc";
            dgvDonProc.RowHeadersWidth = 62;
            dgvDonProc.RowTemplate.Height = 33;
            dgvDonProc.Size = new Size(1110, 427);
            dgvDonProc.TabIndex = 1;
            dgvDonProc.CellDoubleClick += dgvDonProc_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1127, 102);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(301, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(551, 60);
            label2.TabIndex = 2;
            label2.Text = "Donaciones Procesadas ";
            // 
            // FrmInfProcInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 649);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmInfProcInventario";
            Text = "FrmInfProcInventario";
            Load += FrmInfProcInventario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonProc).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDonProc;
        private Label label2;
        private TextBox txtbuscar;
        private Button btnbuscar;
    }
}