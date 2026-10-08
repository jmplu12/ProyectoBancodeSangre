namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCitasID = new TextBox();
            TxtDonanteID = new TextBox();
            txtFechaCita = new DateTimePicker();
            btnenviar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            label7 = new Label();
            txtNombreCompleto = new TextBox();
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            txtCorreo = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 0;
            label1.Text = "CitasID:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 92);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(243, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 55);
            label2.TabIndex = 0;
            label2.Text = "Citas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 0;
            label3.Text = "DonanteID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 356);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 27);
            label4.TabIndex = 0;
            label4.Text = "Fecha:";
            // 
            // txtCitasID
            // 
            txtCitasID.Location = new Point(207, 120);
            txtCitasID.Margin = new Padding(4, 5, 4, 5);
            txtCitasID.Name = "txtCitasID";
            txtCitasID.ReadOnly = true;
            txtCitasID.Size = new Size(113, 31);
            txtCitasID.TabIndex = 2;
            // 
            // TxtDonanteID
            // 
            TxtDonanteID.Location = new Point(207, 198);
            TxtDonanteID.Margin = new Padding(4, 5, 4, 5);
            TxtDonanteID.Name = "TxtDonanteID";
            TxtDonanteID.ReadOnly = true;
            TxtDonanteID.Size = new Size(113, 31);
            TxtDonanteID.TabIndex = 2;
            // 
            // txtFechaCita
            // 
            txtFechaCita.Location = new Point(207, 352);
            txtFechaCita.Margin = new Padding(4, 5, 4, 5);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.Size = new Size(391, 31);
            txtFechaCita.TabIndex = 3;
            // 
            // btnenviar
            // 
            btnenviar.BackColor = SystemColors.HotTrack;
            btnenviar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnenviar.ForeColor = Color.White;
            btnenviar.Location = new Point(48, 636);
            btnenviar.Margin = new Padding(4, 5, 4, 5);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(153, 54);
            btnenviar.TabIndex = 4;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(416, 636);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 54);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 517);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 5;
            label6.Text = "Descripción:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 274);
            label7.Name = "label7";
            label7.Size = new Size(188, 27);
            label7.TabIndex = 6;
            label7.Text = "Nombre Donate:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(207, 274);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(378, 31);
            txtNombreCompleto.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(325, 198);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 57);
            btnBuscar.TabIndex = 8;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(207, 513);
            txtDescripcion.MaxLength = 300;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(378, 31);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(207, 428);
            txtCorreo.MaxLength = 150;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(378, 31);
            txtCorreo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 430);
            label8.Name = "label8";
            label8.Size = new Size(91, 27);
            label8.TabIndex = 11;
            label8.Text = "Correo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 728);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(txtDescripcion);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnenviar);
            Controls.Add(txtFechaCita);
            Controls.Add(TxtDonanteID);
            Controls.Add(txtCitasID);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCitas";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCitasID;
        private TextBox TxtDonanteID;
        private DateTimePicker txtFechaCita;
        private Button btnenviar;
        private Button btnCancelar;
        private Label label6;
        private Label label7;
        private TextBox txtNombreCompleto;
        private Button btnBuscar;
        private TextBox txtDescripcion;
        private TextBox txtCorreo;
        private Label label8;
        private PictureBox pictureBox1;
    }
}