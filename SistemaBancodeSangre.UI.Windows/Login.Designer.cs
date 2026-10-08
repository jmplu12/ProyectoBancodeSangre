namespace SistemaBancodeSangre.UI.Windows
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            btniniciarseccion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__1_;
            pictureBox1.Location = new Point(13, 70);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(280, 70);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 27);
            label8.TabIndex = 26;
            label8.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 26;
            label1.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(280, 189);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(278, 31);
            txtContrasena.TabIndex = 27;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(278, 102);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(278, 31);
            txtUsuario.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 239);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 26;
            label2.Text = "Ocultar Contraseña";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(302, 238);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 28;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btniniciarseccion
            // 
            btniniciarseccion.Image = Properties.Resources.login_enter_icon_249942__6_;
            btniniciarseccion.ImageAlign = ContentAlignment.MiddleLeft;
            btniniciarseccion.Location = new Point(311, 264);
            btniniciarseccion.Margin = new Padding(4, 5, 4, 5);
            btniniciarseccion.Name = "btniniciarseccion";
            btniniciarseccion.Size = new Size(135, 57);
            btniniciarseccion.TabIndex = 29;
            btniniciarseccion.Text = "          Ingresar";
            btniniciarseccion.UseVisualStyleBackColor = true;
            btniniciarseccion.Click += btniniciarseccion_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 352);
            Controls.Add(btniniciarseccion);
            Controls.Add(checkBox1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label8;
        private Label label1;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label2;
        private CheckBox checkBox1;
        private Button btniniciarseccion;
    }
}