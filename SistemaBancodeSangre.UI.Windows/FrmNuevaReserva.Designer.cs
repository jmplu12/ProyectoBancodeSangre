namespace SistemaBancodeSangre.UI.Windows
{
    partial class FrmNuevaReserva
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
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgrgar = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtTipoSangre = new ComboBox();
            TxtPrioridad = new ComboBox();
            txtFecha = new DateTimePicker();
            txtCantidad = new TextBox();
            txtMotivo = new TextBox();
            txtSolicitante = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgrgar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(48, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 759);
            panel1.TabIndex = 12;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(817, 648);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(186, 38);
            btnActualizar.TabIndex = 41;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(1142, 648);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 38);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgrgar
            // 
            btnAgrgar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgrgar.Location = new Point(488, 648);
            btnAgrgar.Margin = new Padding(4, 5, 4, 5);
            btnAgrgar.Name = "btnAgrgar";
            btnAgrgar.Size = new Size(186, 38);
            btnAgrgar.TabIndex = 39;
            btnAgrgar.Text = "Agregar";
            btnAgrgar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(488, 303);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(840, 250);
            dataGridView1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTipoSangre);
            panel2.Controls.Add(TxtPrioridad);
            panel2.Controls.Add(txtFecha);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(txtMotivo);
            panel2.Controls.Add(txtSolicitante);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(15, 273);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 413);
            panel2.TabIndex = 37;
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.FormattingEnabled = true;
            txtTipoSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtTipoSangre.Location = new Point(207, 260);
            txtTipoSangre.Margin = new Padding(4, 5, 4, 5);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.Size = new Size(229, 33);
            txtTipoSangre.TabIndex = 29;
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.FormattingEnabled = true;
            TxtPrioridad.Location = new Point(207, 86);
            TxtPrioridad.Margin = new Padding(4, 5, 4, 5);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(229, 33);
            TxtPrioridad.TabIndex = 29;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(207, 148);
            txtFecha.Margin = new Padding(4, 5, 4, 5);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(229, 31);
            txtFecha.TabIndex = 28;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(207, 318);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(229, 31);
            txtCantidad.TabIndex = 27;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(207, 198);
            txtMotivo.Margin = new Padding(4, 5, 4, 5);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(229, 31);
            txtMotivo.TabIndex = 27;
            // 
            // txtSolicitante
            // 
            txtSolicitante.Location = new Point(207, 28);
            txtSolicitante.Margin = new Padding(4, 5, 4, 5);
            txtSolicitante.Name = "txtSolicitante";
            txtSolicitante.Size = new Size(229, 31);
            txtSolicitante.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 322);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(109, 27);
            label6.TabIndex = 26;
            label6.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 27);
            label3.TabIndex = 26;
            label3.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 262);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 27);
            label5.TabIndex = 26;
            label5.Text = "Tipo de Sangre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 26;
            label1.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 202);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 27);
            label4.TabIndex = 26;
            label4.Text = "Motivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 32);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(123, 27);
            label8.TabIndex = 26;
            label8.Text = "Solicitante";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1332, 128);
            panel3.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(559, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 43);
            label2.TabIndex = 0;
            label2.Text = "Nueva Reserva";
            // 
            // FrmNuevaReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 815);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmNuevaReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevaReserva";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgrgar;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox txtTipoSangre;
        private ComboBox TxtPrioridad;
        private DateTimePicker txtFecha;
        private TextBox txtCantidad;
        private TextBox txtMotivo;
        private TextBox txtSolicitante;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label8;
        private Panel panel3;
        private Label label2;
    }
}