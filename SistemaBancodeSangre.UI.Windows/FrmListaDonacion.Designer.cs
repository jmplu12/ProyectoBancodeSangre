namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListaDonacion
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
            dtgDonaciones = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ColApellidos = new DataGridViewTextBoxColumn();
            ColAnalista = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColTipoSangre = new DataGridViewTextBoxColumn();
            cantidadSangre = new DataGridViewTextBoxColumn();
            NumeroSangre = new DataGridViewTextBoxColumn();
            ColProposito = new DataGridViewTextBoxColumn();
            ColEnvase = new DataGridViewTextBoxColumn();
            DonanteID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtgDonaciones);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(51, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 759);
            panel1.TabIndex = 12;
            panel1.Tag = "";
            // 
            // dtgDonaciones
            // 
            dtgDonaciones.AllowUserToAddRows = false;
            dtgDonaciones.AllowUserToDeleteRows = false;
            dtgDonaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDonaciones.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, ColApellidos, ColAnalista, ColFecha, ColTipoSangre, cantidadSangre, NumeroSangre, ColProposito, ColEnvase, DonanteID });
            dtgDonaciones.Location = new Point(4, 186);
            dtgDonaciones.Margin = new Padding(4, 5, 4, 5);
            dtgDonaciones.Name = "dtgDonaciones";
            dtgDonaciones.ReadOnly = true;
            dtgDonaciones.RowHeadersWidth = 62;
            dtgDonaciones.RowTemplate.Height = 25;
            dtgDonaciones.Size = new Size(1324, 508);
            dtgDonaciones.TabIndex = 37;
            dtgDonaciones.CellContentClick += dtgDonaciones_CellContentClick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1082, 704);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(229, 48);
            button3.TabIndex = 36;
            button3.Text = "Eliminar Registros";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(4, 704);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(229, 48);
            button2.TabIndex = 35;
            button2.Text = "Edictar Registros ";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1165, 195);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 33;
            button1.Text = "Informe";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscar.Location = new Point(159, 141);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(297, 35);
            txtbuscar.TabIndex = 32;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(14, 138);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(126, 38);
            btnbuscar.TabIndex = 31;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            panel2.Size = new Size(1332, 128);
            panel2.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(392, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(524, 60);
            label2.TabIndex = 0;
            label2.Text = "Listado de Donaciones";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID Donacion";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // ColApellidos
            // 
            ColApellidos.DataPropertyName = "Apellido";
            ColApellidos.HeaderText = "Apellidos";
            ColApellidos.MinimumWidth = 8;
            ColApellidos.Name = "ColApellidos";
            ColApellidos.ReadOnly = true;
            ColApellidos.Width = 150;
            // 
            // ColAnalista
            // 
            ColAnalista.DataPropertyName = "analista";
            ColAnalista.HeaderText = "Analista";
            ColAnalista.MinimumWidth = 8;
            ColAnalista.Name = "ColAnalista";
            ColAnalista.ReadOnly = true;
            ColAnalista.Width = 150;
            // 
            // ColFecha
            // 
            ColFecha.DataPropertyName = "FechaDonacion";
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 8;
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            ColFecha.Width = 150;
            // 
            // ColTipoSangre
            // 
            ColTipoSangre.DataPropertyName = "tipoDeSangre";
            ColTipoSangre.HeaderText = "Tipo de Sangre";
            ColTipoSangre.MinimumWidth = 8;
            ColTipoSangre.Name = "ColTipoSangre";
            ColTipoSangre.ReadOnly = true;
            ColTipoSangre.Width = 150;
            // 
            // cantidadSangre
            // 
            cantidadSangre.DataPropertyName = "cantidadSangre";
            cantidadSangre.HeaderText = "Cantidad Sangre";
            cantidadSangre.MinimumWidth = 8;
            cantidadSangre.Name = "cantidadSangre";
            cantidadSangre.ReadOnly = true;
            cantidadSangre.Width = 150;
            // 
            // NumeroSangre
            // 
            NumeroSangre.DataPropertyName = "NumeroSangre";
            NumeroSangre.HeaderText = "Numero Sangre";
            NumeroSangre.MinimumWidth = 8;
            NumeroSangre.Name = "NumeroSangre";
            NumeroSangre.ReadOnly = true;
            NumeroSangre.Width = 150;
            // 
            // ColProposito
            // 
            ColProposito.DataPropertyName = "proposito";
            ColProposito.HeaderText = "Proposito";
            ColProposito.MinimumWidth = 8;
            ColProposito.Name = "ColProposito";
            ColProposito.ReadOnly = true;
            ColProposito.Width = 150;
            // 
            // ColEnvase
            // 
            ColEnvase.DataPropertyName = "envase";
            ColEnvase.HeaderText = "Envase";
            ColEnvase.MinimumWidth = 8;
            ColEnvase.Name = "ColEnvase";
            ColEnvase.ReadOnly = true;
            ColEnvase.Width = 150;
            // 
            // DonanteID
            // 
            DonanteID.DataPropertyName = "DonanteID";
            DonanteID.HeaderText = "Donante ID";
            DonanteID.MinimumWidth = 8;
            DonanteID.Name = "DonanteID";
            DonanteID.ReadOnly = true;
            DonanteID.Width = 150;
            // 
            // FrmListaDonacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 815);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmListaDonacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaDonacion";
            Load += FrmListaDonacion_Load;
            KeyDown += FrmListaDonacion_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtbuscar;
        private Button btnbuscar;
        private Panel panel2;
        private Label label2;
        private DataGridView dtgDonaciones;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ColApellidos;
        private DataGridViewTextBoxColumn ColAnalista;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColTipoSangre;
        private DataGridViewTextBoxColumn cantidadSangre;
        private DataGridViewTextBoxColumn NumeroSangre;
        private DataGridViewTextBoxColumn ColProposito;
        private DataGridViewTextBoxColumn ColEnvase;
        private DataGridViewTextBoxColumn DonanteID;
    }
}