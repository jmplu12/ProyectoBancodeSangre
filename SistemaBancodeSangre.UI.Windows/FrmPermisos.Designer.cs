namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmPermisos
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
            label2 = new Label();
            panel2 = new Panel();
            btnGuardar = new Button();
            gbPermisos = new GroupBox();
            checkBox1 = new CheckBox();
            chkNuevaReserva = new CheckBox();
            chkDistribucion = new CheckBox();
            chkControlInventario = new CheckBox();
            chkCitas = new CheckBox();
            chkAnaliticas = new CheckBox();
            chkReportes = new CheckBox();
            chkConfiguracion = new CheckBox();
            chkEmpleados = new CheckBox();
            chkUsuarios = new CheckBox();
            chkEntrega = new CheckBox();
            chkSolicitudes = new CheckBox();
            chkInventario = new CheckBox();
            chkProcesamiento = new CheckBox();
            chkAnalisis = new CheckBox();
            chkMuestras = new CheckBox();
            chkDonaciones = new CheckBox();
            chkDonantes = new CheckBox();
            cboUsuarios = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            gbPermisos.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(827, 119);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(663, 60);
            label2.TabIndex = 0;
            label2.Text = "PERMISOS DEL SISTEMA";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(gbPermisos);
            panel2.Controls.Add(cboUsuarios);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 511);
            panel2.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(504, 29);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(209, 34);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gbPermisos
            // 
            gbPermisos.Controls.Add(checkBox1);
            gbPermisos.Controls.Add(chkNuevaReserva);
            gbPermisos.Controls.Add(chkDistribucion);
            gbPermisos.Controls.Add(chkControlInventario);
            gbPermisos.Controls.Add(chkCitas);
            gbPermisos.Controls.Add(chkAnaliticas);
            gbPermisos.Controls.Add(chkReportes);
            gbPermisos.Controls.Add(chkConfiguracion);
            gbPermisos.Controls.Add(chkEmpleados);
            gbPermisos.Controls.Add(chkUsuarios);
            gbPermisos.Controls.Add(chkEntrega);
            gbPermisos.Controls.Add(chkSolicitudes);
            gbPermisos.Controls.Add(chkInventario);
            gbPermisos.Controls.Add(chkProcesamiento);
            gbPermisos.Controls.Add(chkAnalisis);
            gbPermisos.Controls.Add(chkMuestras);
            gbPermisos.Controls.Add(chkDonaciones);
            gbPermisos.Controls.Add(chkDonantes);
            gbPermisos.Location = new Point(22, 83);
            gbPermisos.Name = "gbPermisos";
            gbPermisos.Size = new Size(741, 409);
            gbPermisos.TabIndex = 2;
            gbPermisos.TabStop = false;
            gbPermisos.Text = "Permisos del Usuario";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(495, 344);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 29);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Gestion Usuario";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkNuevaReserva
            // 
            chkNuevaReserva.AutoSize = true;
            chkNuevaReserva.Location = new Point(495, 285);
            chkNuevaReserva.Name = "chkNuevaReserva";
            chkNuevaReserva.Size = new Size(169, 29);
            chkNuevaReserva.TabIndex = 16;
            chkNuevaReserva.Text = "Nuevas Reservas";
            chkNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // chkDistribucion
            // 
            chkDistribucion.AutoSize = true;
            chkDistribucion.Location = new Point(495, 180);
            chkDistribucion.Name = "chkDistribucion";
            chkDistribucion.Size = new Size(133, 29);
            chkDistribucion.TabIndex = 15;
            chkDistribucion.Text = "Distribucion";
            chkDistribucion.UseVisualStyleBackColor = true;
            // 
            // chkControlInventario
            // 
            chkControlInventario.AutoSize = true;
            chkControlInventario.Location = new Point(495, 231);
            chkControlInventario.Name = "chkControlInventario";
            chkControlInventario.Size = new Size(181, 29);
            chkControlInventario.TabIndex = 14;
            chkControlInventario.Text = "Control Inventario";
            chkControlInventario.UseVisualStyleBackColor = true;
            // 
            // chkCitas
            // 
            chkCitas.AutoSize = true;
            chkCitas.Location = new Point(292, 180);
            chkCitas.Name = "chkCitas";
            chkCitas.Size = new Size(76, 29);
            chkCitas.TabIndex = 13;
            chkCitas.Text = "Citas";
            chkCitas.UseVisualStyleBackColor = true;
            // 
            // chkAnaliticas
            // 
            chkAnaliticas.AutoSize = true;
            chkAnaliticas.Location = new Point(495, 130);
            chkAnaliticas.Name = "chkAnaliticas";
            chkAnaliticas.Size = new Size(112, 29);
            chkAnaliticas.TabIndex = 12;
            chkAnaliticas.Text = "Analiticas";
            chkAnaliticas.UseVisualStyleBackColor = true;
            // 
            // chkReportes
            // 
            chkReportes.AutoSize = true;
            chkReportes.Location = new Point(495, 70);
            chkReportes.Name = "chkReportes";
            chkReportes.Size = new Size(108, 29);
            chkReportes.TabIndex = 11;
            chkReportes.Text = "Reportes";
            chkReportes.UseVisualStyleBackColor = true;
            // 
            // chkConfiguracion
            // 
            chkConfiguracion.AutoSize = true;
            chkConfiguracion.Location = new Point(292, 344);
            chkConfiguracion.Name = "chkConfiguracion";
            chkConfiguracion.Size = new Size(149, 29);
            chkConfiguracion.TabIndex = 10;
            chkConfiguracion.Text = "Configuracion";
            chkConfiguracion.UseVisualStyleBackColor = true;
            // 
            // chkEmpleados
            // 
            chkEmpleados.AutoSize = true;
            chkEmpleados.Location = new Point(292, 285);
            chkEmpleados.Name = "chkEmpleados";
            chkEmpleados.Size = new Size(126, 29);
            chkEmpleados.TabIndex = 9;
            chkEmpleados.Text = "Empleados";
            chkEmpleados.UseVisualStyleBackColor = true;
            // 
            // chkUsuarios
            // 
            chkUsuarios.AutoSize = true;
            chkUsuarios.Location = new Point(292, 231);
            chkUsuarios.Name = "chkUsuarios";
            chkUsuarios.Size = new Size(106, 29);
            chkUsuarios.TabIndex = 8;
            chkUsuarios.Text = "Usuarios";
            chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEntrega
            // 
            chkEntrega.AutoSize = true;
            chkEntrega.Location = new Point(292, 130);
            chkEntrega.Name = "chkEntrega";
            chkEntrega.Size = new Size(98, 29);
            chkEntrega.TabIndex = 7;
            chkEntrega.Text = "Entrega";
            chkEntrega.UseVisualStyleBackColor = true;
            // 
            // chkSolicitudes
            // 
            chkSolicitudes.AutoSize = true;
            chkSolicitudes.Location = new Point(292, 70);
            chkSolicitudes.Name = "chkSolicitudes";
            chkSolicitudes.Size = new Size(123, 29);
            chkSolicitudes.TabIndex = 6;
            chkSolicitudes.Text = "Solicitudes";
            chkSolicitudes.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            chkInventario.AutoSize = true;
            chkInventario.Location = new Point(52, 344);
            chkInventario.Name = "chkInventario";
            chkInventario.Size = new Size(117, 29);
            chkInventario.TabIndex = 5;
            chkInventario.Text = "Inventario";
            chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkProcesamiento
            // 
            chkProcesamiento.AutoSize = true;
            chkProcesamiento.Location = new Point(52, 285);
            chkProcesamiento.Name = "chkProcesamiento";
            chkProcesamiento.Size = new Size(165, 29);
            chkProcesamiento.TabIndex = 4;
            chkProcesamiento.Text = "Procesar Sangre";
            chkProcesamiento.UseVisualStyleBackColor = true;
            // 
            // chkAnalisis
            // 
            chkAnalisis.AutoSize = true;
            chkAnalisis.Location = new Point(52, 231);
            chkAnalisis.Name = "chkAnalisis";
            chkAnalisis.Size = new Size(97, 29);
            chkAnalisis.TabIndex = 3;
            chkAnalisis.Text = "Análisis";
            chkAnalisis.UseVisualStyleBackColor = true;
            // 
            // chkMuestras
            // 
            chkMuestras.AutoSize = true;
            chkMuestras.Location = new Point(52, 180);
            chkMuestras.Name = "chkMuestras";
            chkMuestras.Size = new Size(110, 29);
            chkMuestras.TabIndex = 2;
            chkMuestras.Text = "Muestras";
            chkMuestras.UseVisualStyleBackColor = true;
            // 
            // chkDonaciones
            // 
            chkDonaciones.AutoSize = true;
            chkDonaciones.Location = new Point(52, 130);
            chkDonaciones.Name = "chkDonaciones";
            chkDonaciones.Size = new Size(169, 29);
            chkDonaciones.TabIndex = 1;
            chkDonaciones.Text = "Nueva Donación";
            chkDonaciones.UseVisualStyleBackColor = true;
            // 
            // chkDonantes
            // 
            chkDonantes.AutoSize = true;
            chkDonantes.Location = new Point(52, 70);
            chkDonantes.Name = "chkDonantes";
            chkDonantes.Size = new Size(188, 29);
            chkDonantes.TabIndex = 0;
            chkDonantes.Text = "Registrar Donantes";
            chkDonantes.UseVisualStyleBackColor = true;
            // 
            // cboUsuarios
            // 
            cboUsuarios.FormattingEnabled = true;
            cboUsuarios.Location = new Point(147, 25);
            cboUsuarios.Name = "cboUsuarios";
            cboUsuarios.Size = new Size(182, 33);
            cboUsuarios.TabIndex = 1;
            cboUsuarios.SelectedIndexChanged += cboUsuarios_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // FrmPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 692);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmPermisos";
            Load += FrmPermisos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gbPermisos.ResumeLayout(false);
            gbPermisos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private GroupBox gbPermisos;
        private CheckBox chkDonantes;
        private ComboBox cboUsuarios;
        private Label label1;
        private CheckBox chkUsuarios;
        private CheckBox chkEntrega;
        private CheckBox chkSolicitudes;
        private CheckBox chkInventario;
        private CheckBox chkProcesamiento;
        private CheckBox chkAnalisis;
        private CheckBox chkMuestras;
        private CheckBox chkDonaciones;
        private CheckBox chkControlInventario;
        private CheckBox chkCitas;
        private CheckBox chkAnaliticas;
        private CheckBox chkReportes;
        private CheckBox chkConfiguracion;
        private CheckBox chkEmpleados;
        private CheckBox chkDistribucion;
        private CheckBox checkBox1;
        private CheckBox chkNuevaReserva;
        private Button btnGuardar;
    }
}