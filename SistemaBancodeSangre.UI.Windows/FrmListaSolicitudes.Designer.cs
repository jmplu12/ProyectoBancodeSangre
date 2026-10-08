namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListaSolicitudes
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
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ColSolicitante = new DataGridViewTextBoxColumn();
            ColPrioridad = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColTipoSangreSolicitada = new DataGridViewTextBoxColumn();
            ColCartaMedica = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColMotivo = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(25, 14);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 425);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(773, 397);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 29;
            button3.Text = "Eliminar Registros";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(48, 397);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 28;
            button2.Text = "Edictar Registros ";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColSolicitante, ColPrioridad, ColFecha, ColTipoSangreSolicitada, ColCartaMedica, ColCantidad, ColMotivo });
            dataGridView1.Location = new Point(14, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(928, 237);
            dataGridView1.TabIndex = 27;
            // 
            // ColSolicitante
            // 
            ColSolicitante.HeaderText = "Solicitante";
            ColSolicitante.MinimumWidth = 8;
            ColSolicitante.Name = "ColSolicitante";
            ColSolicitante.Width = 150;
            // 
            // ColPrioridad
            // 
            ColPrioridad.HeaderText = "Prioridad";
            ColPrioridad.MinimumWidth = 8;
            ColPrioridad.Name = "ColPrioridad";
            ColPrioridad.Width = 150;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 8;
            ColFecha.Name = "ColFecha";
            ColFecha.Width = 150;
            // 
            // ColTipoSangreSolicitada
            // 
            ColTipoSangreSolicitada.HeaderText = "Tipo de Sangre Solicitada";
            ColTipoSangreSolicitada.MinimumWidth = 8;
            ColTipoSangreSolicitada.Name = "ColTipoSangreSolicitada";
            ColTipoSangreSolicitada.Width = 150;
            // 
            // ColCartaMedica
            // 
            ColCartaMedica.HeaderText = "Carta Medica";
            ColCartaMedica.MinimumWidth = 8;
            ColCartaMedica.Name = "ColCartaMedica";
            ColCartaMedica.Width = 150;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.MinimumWidth = 8;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.Width = 150;
            // 
            // ColMotivo
            // 
            ColMotivo.HeaderText = "Motivo";
            ColMotivo.MinimumWidth = 8;
            ColMotivo.Name = "ColMotivo";
            ColMotivo.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(840, 109);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 26;
            button1.Text = "Informe";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(120, 108);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(168, 23);
            txtbuscar.TabIndex = 25;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Location = new Point(14, 108);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(88, 23);
            btnbuscar.TabIndex = 24;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 77);
            panel2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(347, 40);
            label2.Name = "label2";
            label2.Size = new Size(236, 26);
            label2.TabIndex = 0;
            label2.Text = "Listado de Solicitudes";
            // 
            // FrmListaSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaSolicitudes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaSolicitudes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColSolicitante;
        private DataGridViewTextBoxColumn ColPrioridad;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColTipoSangreSolicitada;
        private DataGridViewTextBoxColumn ColCartaMedica;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColMotivo;
        private Button button1;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
    }
}