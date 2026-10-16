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
            dgvSolicitudess = new DataGridView();
            ColSolicitante = new DataGridViewTextBoxColumn();
            ColPrioridad = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColTipoSangreSolicitada = new DataGridViewTextBoxColumn();
            ColCartaMedica = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColMotivo = new DataGridViewTextBoxColumn();
            btninforme = new Button();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudess).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dgvSolicitudess);
            panel1.Controls.Add(btninforme);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(36, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 708);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(1104, 662);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(187, 38);
            button3.TabIndex = 29;
            button3.Text = "Eliminar Registros";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(69, 662);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(187, 38);
            button2.TabIndex = 28;
            button2.Text = "Edictar Registros ";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // dgvSolicitudess
            // 
            dgvSolicitudess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudess.Columns.AddRange(new DataGridViewColumn[] { ColSolicitante, ColPrioridad, ColFecha, ColTipoSangreSolicitada, ColCartaMedica, ColCantidad, ColMotivo });
            dgvSolicitudess.Location = new Point(20, 257);
            dgvSolicitudess.Margin = new Padding(4, 5, 4, 5);
            dgvSolicitudess.Name = "dgvSolicitudess";
            dgvSolicitudess.RowHeadersWidth = 62;
            dgvSolicitudess.RowTemplate.Height = 25;
            dgvSolicitudess.Size = new Size(1326, 395);
            dgvSolicitudess.TabIndex = 27;
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
            // btninforme
            // 
            btninforme.BackColor = Color.FromArgb(192, 0, 0);
            btninforme.ForeColor = SystemColors.ButtonFace;
            btninforme.Location = new Point(1200, 182);
            btninforme.Margin = new Padding(4, 5, 4, 5);
            btninforme.Name = "btninforme";
            btninforme.Size = new Size(146, 38);
            btninforme.TabIndex = 26;
            btninforme.Text = "Informe";
            btninforme.UseVisualStyleBackColor = false;
            btninforme.Click += btninforme_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(171, 180);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(238, 31);
            txtbuscar.TabIndex = 25;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Location = new Point(20, 180);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(126, 38);
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
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1334, 128);
            panel2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(496, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(349, 41);
            label2.TabIndex = 0;
            label2.Text = "Listado de Solicitudes";
            // 
            // FrmListaSolicitudes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmListaSolicitudes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaSolicitudes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudess).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private DataGridView dgvSolicitudess;
        private DataGridViewTextBoxColumn ColSolicitante;
        private DataGridViewTextBoxColumn ColPrioridad;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColTipoSangreSolicitada;
        private DataGridViewTextBoxColumn ColCartaMedica;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColMotivo;
        private Button btninforme;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
    }
}