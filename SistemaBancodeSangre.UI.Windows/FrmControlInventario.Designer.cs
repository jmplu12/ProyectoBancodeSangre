namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmControlInventario
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
            panel2 = new Panel();
            btnReporte = new Button();
            dgvControlInventario = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvControlInventario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReporte);
            panel2.Controls.Add(dgvControlInventario);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(54, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(1213, 759);
            panel2.TabIndex = 0;
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.Right;
            btnReporte.BackColor = Color.FromArgb(192, 0, 0);
            btnReporte.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(1050, 118);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(143, 45);
            btnReporte.TabIndex = 33;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // dgvControlInventario
            // 
            dgvControlInventario.AllowUserToAddRows = false;
            dgvControlInventario.AllowUserToDeleteRows = false;
            dgvControlInventario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvControlInventario.BackgroundColor = Color.Teal;
            dgvControlInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvControlInventario.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Column2, Column3 });
            dgvControlInventario.Location = new Point(22, 169);
            dgvControlInventario.Name = "dgvControlInventario";
            dgvControlInventario.ReadOnly = true;
            dgvControlInventario.RowHeadersWidth = 62;
            dgvControlInventario.RowTemplate.Height = 33;
            dgvControlInventario.Size = new Size(1171, 561);
            dgvControlInventario.TabIndex = 32;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 200;
            // 
            // Column1
            // 
            Column1.HeaderText = "TIPO DE COMPONENTE";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 350;
            // 
            // Column2
            // 
            Column2.HeaderText = "CANTIDAD DISPONIBLE";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 350;
            // 
            // Column3
            // 
            Column3.HeaderText = "FECHA DE VENCIMIENTO";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 350;
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
            panel1.Size = new Size(1211, 110);
            panel1.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(390, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(505, 60);
            label2.TabIndex = 0;
            label2.Text = "Control de Inventario";
            // 
            // FrmControlInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 815);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmControlInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmControlInventario";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvControlInventario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvControlInventario;
        private Button btnReporte;
        private Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColTipoComponente;
        private DataGridViewTextBoxColumn ColCantidadDisponible;
        private DataGridViewTextBoxColumn ColFechaVencimiento;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}