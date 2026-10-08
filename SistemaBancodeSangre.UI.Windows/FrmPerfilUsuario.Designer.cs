namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilUsuario));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtdirreccion = new TextBox();
            txttelefono = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtcorreo = new TextBox();
            txtNombreCompleto = new TextBox();
            txtUsurio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtdirreccion);
            panel1.Controls.Add(txttelefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtcorreo);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Controls.Add(txtUsurio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 508);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 60);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 7);
            label1.Name = "label1";
            label1.Size = new Size(118, 51);
            label1.TabIndex = 0;
            label1.Text = "Perfil";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtdirreccion
            // 
            txtdirreccion.Location = new Point(178, 441);
            txtdirreccion.Name = "txtdirreccion";
            txtdirreccion.ReadOnly = true;
            txtdirreccion.Size = new Size(308, 31);
            txtdirreccion.TabIndex = 10;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(178, 373);
            txttelefono.Name = "txttelefono";
            txttelefono.ReadOnly = true;
            txttelefono.Size = new Size(308, 31);
            txttelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 445);
            label6.Name = "label6";
            label6.Size = new Size(114, 27);
            label6.TabIndex = 8;
            label6.Text = "Dirrecion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 373);
            label5.Name = "label5";
            label5.Size = new Size(109, 27);
            label5.TabIndex = 7;
            label5.Text = "Telefono:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(178, 284);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.ReadOnly = true;
            txtcorreo.Size = new Size(308, 31);
            txtcorreo.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(178, 199);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(308, 31);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtUsurio
            // 
            txtUsurio.Location = new Point(178, 105);
            txtUsurio.Name = "txtUsurio";
            txtUsurio.ReadOnly = true;
            txtUsurio.Size = new Size(150, 31);
            txtUsurio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 290);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 203);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 105);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 164);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 13;
            label7.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 173);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 14;
            // 
            // FrmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 508);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPerfilUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmPerfilUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private TextBox txtcorreo;
        private TextBox txtNombreCompleto;
        private TextBox txtUsurio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtdirreccion;
        private TextBox txttelefono;
        private TextBox txtID;
        private Label label7;
    }
}