namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListaAnaliticaSangre
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
            cboFiltro = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            dgvListaAnalitica = new DataGridView();
            button1 = new Button();
            txtBuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAnalitica).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboFiltro);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dgvListaAnalitica);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1391, 750);
            panel1.TabIndex = 0;
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Location = new Point(578, 154);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(182, 33);
            cboFiltro.TabIndex = 23;
            cboFiltro.SelectedIndexChanged += cboFiltro_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(1113, 668);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(187, 38);
            button3.TabIndex = 22;
            button3.Text = "Eliminar Registros";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(77, 668);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(187, 38);
            button2.TabIndex = 21;
            button2.Text = "Edictar Registros ";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // dgvListaAnalitica
            // 
            dgvListaAnalitica.AllowUserToAddRows = false;
            dgvListaAnalitica.AllowUserToDeleteRows = false;
            dgvListaAnalitica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaAnalitica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAnalitica.Location = new Point(29, 236);
            dgvListaAnalitica.Margin = new Padding(4, 5, 4, 5);
            dgvListaAnalitica.Name = "dgvListaAnalitica";
            dgvListaAnalitica.ReadOnly = true;
            dgvListaAnalitica.RowHeadersWidth = 62;
            dgvListaAnalitica.RowTemplate.Height = 25;
            dgvListaAnalitica.Size = new Size(1348, 422);
            dgvListaAnalitica.TabIndex = 20;
            dgvListaAnalitica.CellClick += dgvListaAnalitica_CellClick;
            dgvListaAnalitica.CellDoubleClick += dgvListaAnalitica_CellDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1199, 156);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 19;
            button1.Text = "Informe";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(188, 156);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(238, 31);
            txtBuscar.TabIndex = 18;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Location = new Point(29, 149);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(126, 38);
            btnbuscar.TabIndex = 17;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1389, 128);
            panel2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(473, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(480, 41);
            label2.TabIndex = 0;
            label2.Text = "Listado de Analitica de Sangre";
            // 
            // FrmListaAnaliticaSangre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmListaAnaliticaSangre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaAnaliticaSangre";
            Load += FrmListaAnaliticaSangre_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAnalitica).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private DataGridView dgvListaAnalitica;
        private Button button1;
        private TextBox txtBuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
        private ComboBox cboFiltro;
    }
}