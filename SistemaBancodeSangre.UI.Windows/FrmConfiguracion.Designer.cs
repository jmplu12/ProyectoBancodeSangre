namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            label2 = new Label();
            panel2 = new Panel();
            ptCerrar = new PictureBox();
            btnSonreNosotros = new Button();
            btnAgregarEmpleados = new Button();
            btnRegistroUsuario = new Button();
            btnPermisos = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptCerrar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(408, 51);
            label2.TabIndex = 0;
            label2.Text = "CONFIGURACION";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnPermisos);
            panel2.Controls.Add(ptCerrar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSonreNosotros);
            panel2.Controls.Add(btnAgregarEmpleados);
            panel2.Controls.Add(btnRegistroUsuario);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 600);
            panel2.TabIndex = 43;
            // 
            // ptCerrar
            // 
            ptCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptCerrar.BorderStyle = BorderStyle.FixedSingle;
            ptCerrar.Image = (Image)resources.GetObject("ptCerrar.Image");
            ptCerrar.Location = new Point(497, 12);
            ptCerrar.Name = "ptCerrar";
            ptCerrar.Size = new Size(34, 34);
            ptCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            ptCerrar.TabIndex = 3;
            ptCerrar.TabStop = false;
            ptCerrar.Click += ptCerrar_Click;
            // 
            // btnSonreNosotros
            // 
            btnSonreNosotros.BackColor = Color.Green;
            btnSonreNosotros.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSonreNosotros.ForeColor = Color.White;
            btnSonreNosotros.Location = new Point(21, 343);
            btnSonreNosotros.Margin = new Padding(4, 5, 4, 5);
            btnSonreNosotros.Name = "btnSonreNosotros";
            btnSonreNosotros.Size = new Size(510, 112);
            btnSonreNosotros.TabIndex = 2;
            btnSonreNosotros.Text = "Sobre Nosotros";
            btnSonreNosotros.UseVisualStyleBackColor = false;
            btnSonreNosotros.Click += btnSonreNosotros_Click;
            // 
            // btnAgregarEmpleados
            // 
            btnAgregarEmpleados.BackColor = Color.Green;
            btnAgregarEmpleados.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEmpleados.ForeColor = Color.White;
            btnAgregarEmpleados.Location = new Point(21, 99);
            btnAgregarEmpleados.Margin = new Padding(4, 5, 4, 5);
            btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            btnAgregarEmpleados.Size = new Size(510, 112);
            btnAgregarEmpleados.TabIndex = 1;
            btnAgregarEmpleados.Text = "  Empleados";
            btnAgregarEmpleados.UseVisualStyleBackColor = false;
            btnAgregarEmpleados.Click += btnAgregarEmpleados_Click;
            // 
            // btnRegistroUsuario
            // 
            btnRegistroUsuario.BackColor = Color.Green;
            btnRegistroUsuario.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroUsuario.ForeColor = Color.White;
            btnRegistroUsuario.Location = new Point(21, 221);
            btnRegistroUsuario.Margin = new Padding(4, 5, 4, 5);
            btnRegistroUsuario.Name = "btnRegistroUsuario";
            btnRegistroUsuario.Size = new Size(510, 112);
            btnRegistroUsuario.TabIndex = 0;
            btnRegistroUsuario.Text = "Usuarios";
            btnRegistroUsuario.UseVisualStyleBackColor = false;
            btnRegistroUsuario.Click += btnRegistroUsuario_Click;
            // 
            // btnPermisos
            // 
            btnPermisos.BackColor = Color.Green;
            btnPermisos.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPermisos.ForeColor = Color.White;
            btnPermisos.Location = new Point(21, 465);
            btnPermisos.Margin = new Padding(4, 5, 4, 5);
            btnPermisos.Name = "btnPermisos";
            btnPermisos.Size = new Size(510, 112);
            btnPermisos.TabIndex = 4;
            btnPermisos.Text = "Permisos ";
            btnPermisos.UseVisualStyleBackColor = false;
            btnPermisos.Click += btnPermisos_Click;
            // 
            // FrmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 600);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCondiguracion";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel2;
        private Button btnSonreNosotros;
        private Button btnAgregarEmpleados;
        private Button btnRegistroUsuario;
        private PictureBox ptCerrar;
        private Button btnPermisos;
    }
}