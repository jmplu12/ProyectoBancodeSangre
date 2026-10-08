namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmNuevaDonacion
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
            btnbuscar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            txtTiposangre = new TextBox();
            dtFecha = new DateTimePicker();
            txtAnalista = new TextBox();
            txtPoposito = new TextBox();
            txtApellidos = new TextBox();
            txtEvase = new TextBox();
            txtNombre = new TextBox();
            txtCantSangre = new TextBox();
            txtIdDonante = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label11 = new Label();
            label5 = new Label();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            label8 = new Label();
            btnActualizar = new Button();
            btnAgrgar = new Button();
            dtgDonaciones = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DonanteID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ColApellidos = new DataGridViewTextBoxColumn();
            ColAnalista = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColTipoSangre = new DataGridViewTextBoxColumn();
            cantidadSangre = new DataGridViewTextBoxColumn();
            ColProposito = new DataGridViewTextBoxColumn();
            ColEnvase = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnEliminar = new Button();
            errorProvider = new ErrorProvider(components);
            label12 = new Label();
            txtNoSangre = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Teal;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(25, 129);
            btnbuscar.Margin = new Padding(4, 5, 4, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(242, 49);
            btnbuscar.TabIndex = 23;
            btnbuscar.Text = "Busqueda Donante";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            panel1.Size = new Size(1332, 119);
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(500, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(391, 60);
            label2.TabIndex = 0;
            label2.Text = "Nueva Donacion";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtNoSangre);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtTiposangre);
            panel2.Controls.Add(dtFecha);
            panel2.Controls.Add(txtAnalista);
            panel2.Controls.Add(txtPoposito);
            panel2.Controls.Add(txtApellidos);
            panel2.Controls.Add(txtEvase);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(txtCantSangre);
            panel2.Controls.Add(txtIdDonante);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label8);
            panel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(25, 188);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1294, 312);
            panel2.TabIndex = 25;
            // 
            // txtTiposangre
            // 
            txtTiposangre.Location = new Point(733, 91);
            txtTiposangre.Name = "txtTiposangre";
            txtTiposangre.ReadOnly = true;
            txtTiposangre.Size = new Size(150, 35);
            txtTiposangre.TabIndex = 29;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(740, 253);
            dtFecha.Margin = new Padding(4, 5, 4, 5);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(231, 35);
            dtFecha.TabIndex = 28;
            // 
            // txtAnalista
            // 
            txtAnalista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnalista.Location = new Point(1115, 251);
            txtAnalista.Margin = new Padding(4, 5, 4, 5);
            txtAnalista.MaxLength = 100;
            txtAnalista.Name = "txtAnalista";
            txtAnalista.Size = new Size(162, 35);
            txtAnalista.TabIndex = 27;
            // 
            // txtPoposito
            // 
            txtPoposito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPoposito.Location = new Point(1003, 73);
            txtPoposito.Margin = new Padding(4, 5, 4, 5);
            txtPoposito.MaxLength = 200;
            txtPoposito.Multiline = true;
            txtPoposito.Name = "txtPoposito";
            txtPoposito.Size = new Size(274, 122);
            txtPoposito.TabIndex = 27;
            txtPoposito.KeyPress += txtPoposito_KeyPress_1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(184, 256);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(339, 35);
            txtApellidos.TabIndex = 27;
            // 
            // txtEvase
            // 
            txtEvase.Location = new Point(740, 196);
            txtEvase.Margin = new Padding(4, 5, 4, 5);
            txtEvase.Name = "txtEvase";
            txtEvase.Size = new Size(231, 35);
            txtEvase.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 177);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(324, 35);
            txtNombre.TabIndex = 27;
            // 
            // txtCantSangre
            // 
            txtCantSangre.Location = new Point(740, 146);
            txtCantSangre.Margin = new Padding(4, 5, 4, 5);
            txtCantSangre.Name = "txtCantSangre";
            txtCantSangre.Size = new Size(231, 35);
            txtCantSangre.TabIndex = 27;
            txtCantSangre.KeyPress += txtCantSangre_KeyPress_1;
            // 
            // txtIdDonante
            // 
            txtIdDonante.Location = new Point(184, 103);
            txtIdDonante.Margin = new Padding(4, 5, 4, 5);
            txtIdDonante.Name = "txtIdDonante";
            txtIdDonante.ReadOnly = true;
            txtIdDonante.Size = new Size(135, 35);
            txtIdDonante.TabIndex = 27;
            // 
            // txtID
            // 
            txtID.Location = new Point(184, 27);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(135, 35);
            txtID.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(566, 264);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 27);
            label6.TabIndex = 26;
            label6.Text = "Fecha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(550, 204);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 27);
            label11.TabIndex = 26;
            label11.Text = "Envase:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1003, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 26;
            label5.Text = "Analista:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1003, 41);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 27);
            label10.TabIndex = 26;
            label10.Text = "Proposito:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 26;
            label4.Text = "Apellidos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(550, 154);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 27);
            label9.TabIndex = 26;
            label9.Text = "Cnt de Sangre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 26;
            label3.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(543, 94);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 27);
            label7.TabIndex = 26;
            label7.Text = "Tipo de Sangre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 26;
            label1.Text = "ID Donante:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 33);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 27);
            label8.TabIndex = 26;
            label8.Text = "ID Donacion:";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(592, 510);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 50);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgrgar
            // 
            btnAgrgar.Anchor = AnchorStyles.Top;
            btnAgrgar.BackColor = Color.Green;
            btnAgrgar.FlatStyle = FlatStyle.Flat;
            btnAgrgar.ForeColor = Color.White;
            btnAgrgar.Location = new Point(230, 510);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 50);
            btnAgrgar.TabIndex = 27;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = false;
            btnAgrgar.Click += btnAgrgar_Click;
            // 
            // dtgDonaciones
            // 
            dtgDonaciones.AllowUserToAddRows = false;
            dtgDonaciones.AllowUserToDeleteRows = false;
            dtgDonaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDonaciones.Columns.AddRange(new DataGridViewColumn[] { ID, DonanteID, Nombre, ColApellidos, ColAnalista, ColFecha, ColTipoSangre, cantidadSangre, ColProposito, ColEnvase });
            dtgDonaciones.Location = new Point(4, 570);
            dtgDonaciones.Margin = new Padding(4, 5, 4, 5);
            dtgDonaciones.Name = "dtgDonaciones";
            dtgDonaciones.ReadOnly = true;
            dtgDonaciones.RowHeadersWidth = 62;
            dtgDonaciones.RowTemplate.Height = 25;
            dtgDonaciones.Size = new Size(1324, 199);
            dtgDonaciones.TabIndex = 30;
            dtgDonaciones.CellClick += dtgDonaciones_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Donacion ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
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
            cantidadSangre.HeaderText = "Cantidad Sangre (ML)";
            cantidadSangre.MinimumWidth = 8;
            cantidadSangre.Name = "cantidadSangre";
            cantidadSangre.ReadOnly = true;
            cantidadSangre.Width = 150;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dtgDonaciones);
            panel3.Controls.Add(btnbuscar);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnAgrgar);
            panel3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(28, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(1334, 786);
            panel3.TabIndex = 31;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = SystemColors.HotTrack;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(894, 510);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 50);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(543, 27);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 27);
            label12.TabIndex = 30;
            label12.Text = "No_Sangre:";
            // 
            // txtNoSangre
            // 
            txtNoSangre.Location = new Point(716, 19);
            txtNoSangre.Name = "txtNoSangre";
            txtNoSangre.ReadOnly = true;
            txtNoSangre.Size = new Size(150, 35);
            txtNoSangre.TabIndex = 31;
            // 
            // FrmNuevaDonacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 820);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmNuevaDonacion";
            Text = "FrmNuevaDonacion";
            Load += FrmNuevaDonacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnbuscar;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label8;
        private DateTimePicker dtFecha;
        private TextBox txtAnalista;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtIdDonante;
        private TextBox txtID;
        private TextBox txtPoposito;
        private TextBox txtEvase;
        private TextBox txtCantSangre;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Button btnActualizar;
        private Button btnAgrgar;
        private DataGridView dtgDonaciones;
        private Panel panel3;
        private TextBox txtTiposangre;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DonanteID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ColApellidos;
        private DataGridViewTextBoxColumn ColAnalista;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColTipoSangre;
        private DataGridViewTextBoxColumn cantidadSangre;
        private DataGridViewTextBoxColumn ColProposito;
        private DataGridViewTextBoxColumn ColEnvase;
        private Button btnEliminar;
        private TextBox txtNoSangre;
        private Label label12;
    }
}