namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmListaMuestra
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
            label2 = new Label();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Responsable = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            Fechatoma = new DataGridViewTextBoxColumn();
            temperatura = new DataGridViewTextBoxColumn();
            pulso = new DataGridViewTextBoxColumn();
            precionalterial = new DataGridViewTextBoxColumn();
            examenanemia = new DataGridViewTextBoxColumn();
            ColCantidadml = new DataGridViewTextBoxColumn();
            ColTipoSangre = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            ApellidoDoante = new DataGridViewTextBoxColumn();
            NombreDonante = new DataGridViewTextBoxColumn();
            DonanteID = new DataGridViewTextBoxColumn();
            ColID = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(510, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(391, 60);
            label2.TabIndex = 0;
            label2.Text = "Listado Muestra";
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Left;
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.Location = new Point(19, 138);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(126, 41);
            btnbuscar.TabIndex = 10;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Anchor = AnchorStyles.Left;
            txtbuscar.Location = new Point(177, 138);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Multiline = true;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(238, 41);
            txtbuscar.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1172, 141);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 12;
            button1.Text = "Informe";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, DonanteID, NombreDonante, ApellidoDoante, sexo, edad, ColTipoSangre, ColCantidadml, examenanemia, precionalterial, pulso, temperatura, Fechatoma, estado, Responsable });
            dataGridView1.Location = new Point(19, 202);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1299, 395);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Responsable
            // 
            Responsable.DataPropertyName = "Responsable";
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 8;
            Responsable.Name = "Responsable";
            Responsable.Width = 150;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // Fechatoma
            // 
            Fechatoma.DataPropertyName = "fechaToma";
            Fechatoma.HeaderText = "Fecha Toma";
            Fechatoma.MinimumWidth = 8;
            Fechatoma.Name = "Fechatoma";
            Fechatoma.Width = 150;
            // 
            // temperatura
            // 
            temperatura.DataPropertyName = "temperatura";
            temperatura.HeaderText = "Temperatura";
            temperatura.MinimumWidth = 8;
            temperatura.Name = "temperatura";
            temperatura.Width = 150;
            // 
            // pulso
            // 
            pulso.DataPropertyName = "pulso";
            pulso.HeaderText = "Pulso";
            pulso.MinimumWidth = 8;
            pulso.Name = "pulso";
            pulso.Width = 150;
            // 
            // precionalterial
            // 
            precionalterial.DataPropertyName = "presionAlterial";
            precionalterial.HeaderText = "Precion Anterial";
            precionalterial.MinimumWidth = 8;
            precionalterial.Name = "precionalterial";
            precionalterial.Width = 150;
            // 
            // examenanemia
            // 
            examenanemia.DataPropertyName = "exmenAnemia";
            examenanemia.HeaderText = "Anemia";
            examenanemia.MinimumWidth = 8;
            examenanemia.Name = "examenanemia";
            examenanemia.Width = 150;
            // 
            // ColCantidadml
            // 
            ColCantidadml.DataPropertyName = "CantidadM";
            ColCantidadml.HeaderText = "Cantidad ML";
            ColCantidadml.MinimumWidth = 8;
            ColCantidadml.Name = "ColCantidadml";
            ColCantidadml.Width = 150;
            // 
            // ColTipoSangre
            // 
            ColTipoSangre.DataPropertyName = "TipoSangre";
            ColTipoSangre.HeaderText = "Tipo de Sangre";
            ColTipoSangre.MinimumWidth = 8;
            ColTipoSangre.Name = "ColTipoSangre";
            ColTipoSangre.Width = 150;
            // 
            // edad
            // 
            edad.DataPropertyName = "edad";
            edad.HeaderText = "Edad";
            edad.MinimumWidth = 8;
            edad.Name = "edad";
            edad.Width = 150;
            // 
            // sexo
            // 
            sexo.DataPropertyName = "sexo";
            sexo.HeaderText = "Sexo";
            sexo.MinimumWidth = 8;
            sexo.Name = "sexo";
            sexo.Width = 150;
            // 
            // ApellidoDoante
            // 
            ApellidoDoante.DataPropertyName = "ApellidoDoante";
            ApellidoDoante.HeaderText = "Apellido Donante";
            ApellidoDoante.MinimumWidth = 8;
            ApellidoDoante.Name = "ApellidoDoante";
            ApellidoDoante.Width = 150;
            // 
            // NombreDonante
            // 
            NombreDonante.DataPropertyName = "NombreDonante";
            NombreDonante.HeaderText = "Nombre Donante";
            NombreDonante.MinimumWidth = 8;
            NombreDonante.Name = "NombreDonante";
            NombreDonante.Width = 150;
            // 
            // DonanteID
            // 
            DonanteID.DataPropertyName = "DonanteID";
            DonanteID.HeaderText = "ID Donante";
            DonanteID.MinimumWidth = 8;
            DonanteID.Name = "DonanteID";
            DonanteID.Width = 150;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "ID";
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 8;
            ColID.Name = "ColID";
            ColID.Width = 150;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 607);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(220, 58);
            button2.TabIndex = 14;
            button2.Text = "Editar Muestras";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Maroon;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1154, 610);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(164, 52);
            button3.TabIndex = 15;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtbuscar);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(49, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 681);
            panel1.TabIndex = 12;
            // 
            // FrmListaMuestra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 737);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmListaMuestra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaMuestra";
            Load += FrmListaMuestra_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn DonanteID;
        private DataGridViewTextBoxColumn NombreDonante;
        private DataGridViewTextBoxColumn ApellidoDoante;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn ColTipoSangre;
        private DataGridViewTextBoxColumn ColCantidadml;
        private DataGridViewTextBoxColumn examenanemia;
        private DataGridViewTextBoxColumn precionalterial;
        private DataGridViewTextBoxColumn pulso;
        private DataGridViewTextBoxColumn temperatura;
        private DataGridViewTextBoxColumn Fechatoma;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn Responsable;
        private Button button2;
        private Button button3;
        private Panel panel1;
    }
}