namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantDonaciones
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
            pnlBase = new Panel();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            grbDonaciones = new GroupBox();
            txtIdDonante = new TextBox();
            label2 = new Label();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label8 = new Label();
            txtTiposangre = new TextBox();
            dtFecha = new DateTimePicker();
            txtAnalista = new TextBox();
            txtPoposito = new TextBox();
            txtEvase = new TextBox();
            txtCantSangre = new TextBox();
            label6 = new Label();
            label11 = new Label();
            label5 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            dtgDonaciones = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbDonaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbDonaciones);
            pnlBase.Controls.Add(dtgDonaciones);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(12, 12);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1377, 734);
            pnlBase.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1167, 194);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 54);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1167, 144);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1167, 94);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 52);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbDonaciones
            // 
            grbDonaciones.Controls.Add(txtIdDonante);
            grbDonaciones.Controls.Add(label2);
            grbDonaciones.Controls.Add(txtApellidos);
            grbDonaciones.Controls.Add(txtNombre);
            grbDonaciones.Controls.Add(label4);
            grbDonaciones.Controls.Add(label3);
            grbDonaciones.Controls.Add(txtID);
            grbDonaciones.Controls.Add(label8);
            grbDonaciones.Controls.Add(txtTiposangre);
            grbDonaciones.Controls.Add(dtFecha);
            grbDonaciones.Controls.Add(txtAnalista);
            grbDonaciones.Controls.Add(txtPoposito);
            grbDonaciones.Controls.Add(txtEvase);
            grbDonaciones.Controls.Add(txtCantSangre);
            grbDonaciones.Controls.Add(label6);
            grbDonaciones.Controls.Add(label11);
            grbDonaciones.Controls.Add(label5);
            grbDonaciones.Controls.Add(label10);
            grbDonaciones.Controls.Add(label9);
            grbDonaciones.Controls.Add(label7);
            grbDonaciones.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbDonaciones.Location = new Point(23, 90);
            grbDonaciones.Name = "grbDonaciones";
            grbDonaciones.Size = new Size(1138, 339);
            grbDonaciones.TabIndex = 2;
            grbDonaciones.TabStop = false;
            grbDonaciones.Text = "Datos Donaciones";
            // 
            // txtIdDonante
            // 
            txtIdDonante.Location = new Point(211, 81);
            txtIdDonante.Margin = new Padding(4, 5, 4, 5);
            txtIdDonante.Name = "txtIdDonante";
            txtIdDonante.ReadOnly = true;
            txtIdDonante.Size = new Size(235, 33);
            txtIdDonante.TabIndex = 49;
            txtIdDonante.KeyPress += txtIdDonante_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 27);
            label2.TabIndex = 48;
            label2.Text = "ID Donante:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(129, 276);
            txtApellidos.Margin = new Padding(4, 5, 4, 5);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(317, 33);
            txtApellidos.TabIndex = 46;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 218);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(302, 33);
            txtNombre.TabIndex = 47;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 279);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 27);
            label4.TabIndex = 44;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 45;
            label3.Text = "Nombre:";
            // 
            // txtID
            // 
            txtID.Location = new Point(211, 37);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(235, 33);
            txtID.TabIndex = 43;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(54, 43);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 27);
            label8.TabIndex = 42;
            label8.Text = "ID Donacion:";
            // 
            // txtTiposangre
            // 
            txtTiposangre.Location = new Point(211, 122);
            txtTiposangre.Name = "txtTiposangre";
            txtTiposangre.ReadOnly = true;
            txtTiposangre.Size = new Size(235, 33);
            txtTiposangre.TabIndex = 41;
            txtTiposangre.KeyPress += txtTiposangre_KeyPress;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(682, 99);
            dtFecha.Margin = new Padding(4, 5, 4, 5);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(274, 33);
            dtFecha.TabIndex = 40;
            // 
            // txtAnalista
            // 
            txtAnalista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnalista.Location = new Point(699, 156);
            txtAnalista.Margin = new Padding(4, 5, 4, 5);
            txtAnalista.MaxLength = 100;
            txtAnalista.Name = "txtAnalista";
            txtAnalista.Size = new Size(257, 33);
            txtAnalista.TabIndex = 36;
            txtAnalista.KeyPress += txtAnalista_KeyPress;
            // 
            // txtPoposito
            // 
            txtPoposito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPoposito.Location = new Point(699, 215);
            txtPoposito.Margin = new Padding(4, 5, 4, 5);
            txtPoposito.MaxLength = 200;
            txtPoposito.Multiline = true;
            txtPoposito.Name = "txtPoposito";
            txtPoposito.Size = new Size(257, 74);
            txtPoposito.TabIndex = 37;
            txtPoposito.KeyPress += txtPoposito_KeyPress;
            // 
            // txtEvase
            // 
            txtEvase.Location = new Point(697, 40);
            txtEvase.Margin = new Padding(4, 5, 4, 5);
            txtEvase.Name = "txtEvase";
            txtEvase.ReadOnly = true;
            txtEvase.Size = new Size(259, 33);
            txtEvase.TabIndex = 38;
            txtEvase.KeyPress += txtEvase_KeyPress;
            // 
            // txtCantSangre
            // 
            txtCantSangre.Location = new Point(221, 169);
            txtCantSangre.Margin = new Padding(4, 5, 4, 5);
            txtCantSangre.Name = "txtCantSangre";
            txtCantSangre.Size = new Size(225, 33);
            txtCantSangre.TabIndex = 39;
            txtCantSangre.KeyPress += txtCantSangre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(570, 104);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 27);
            label6.TabIndex = 30;
            label6.Text = "Fecha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(569, 43);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 27);
            label11.TabIndex = 31;
            label11.Text = "Envase:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(569, 159);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 32;
            label5.Text = "Analista:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(569, 215);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 27);
            label10.TabIndex = 33;
            label10.Text = "Proposito:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(28, 172);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 27);
            label9.TabIndex = 34;
            label9.Text = "Cnt de Sangre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 128);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 27);
            label7.TabIndex = 35;
            label7.Text = "Tipo de Sangre:";
            // 
            // dtgDonaciones
            // 
            dtgDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDonaciones.Location = new Point(11, 448);
            dtgDonaciones.Name = "dtgDonaciones";
            dtgDonaciones.RowHeadersWidth = 62;
            dtgDonaciones.RowTemplate.Height = 33;
            dtgDonaciones.Size = new Size(1150, 225);
            dtgDonaciones.TabIndex = 1;
            dtgDonaciones.CellDoubleClick += dtgDonaciones_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1376, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(283, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Donaciones";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmMantDonaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 739);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantDonaciones";
            Text = "FrmMantDonaciones";
            Load += FrmMantDonaciones_Load;
            pnlBase.ResumeLayout(false);
            grbDonaciones.ResumeLayout(false);
            grbDonaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDonaciones).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBase;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox grbDonaciones;
        private DataGridView dtgDonaciones;
        private Panel pnlEncabezado;
        private Label label1;
        private TextBox txtTiposangre;
        private DateTimePicker dtFecha;
        private TextBox txtAnalista;
        private TextBox txtPoposito;
        private TextBox txtEvase;
        private TextBox txtCantSangre;
        private Label label6;
        private Label label11;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtID;
        private Label label8;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private TextBox txtIdDonante;
        private Label label2;
        private ErrorProvider errorProvider;
    }
}