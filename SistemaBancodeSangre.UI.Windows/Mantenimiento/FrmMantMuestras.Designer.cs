namespace SistemaBancodeSangre.UI.Windows.Mantenimiento
{
    partial class FrmMantMuestras
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
            grbMuestras = new GroupBox();
            txtDonanteID = new TextBox();
            label2 = new Label();
            label9 = new Label();
            txtCodMuestra = new TextBox();
            cboEstado = new ComboBox();
            dtFechaToma = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label16 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            txtPulso = new TextBox();
            txtResponsable = new TextBox();
            txtTemperatura = new TextBox();
            txtCantidadM = new TextBox();
            txtPresionArterial = new TextBox();
            txtMuestraID = new TextBox();
            dgManMuestras = new DataGridView();
            pnlEncabezado = new Panel();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            pnlBase.SuspendLayout();
            grbMuestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgManMuestras).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(btnEliminar);
            pnlBase.Controls.Add(btnNuevo);
            pnlBase.Controls.Add(btnGuardar);
            pnlBase.Controls.Add(grbMuestras);
            pnlBase.Controls.Add(dgManMuestras);
            pnlBase.Controls.Add(pnlEncabezado);
            pnlBase.Location = new Point(4, 4);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(1497, 734);
            pnlBase.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1292, 203);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.AppWorkspace;
            btnNuevo.Location = new Point(1292, 153);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(176, 44);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Location = new Point(1292, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(176, 44);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grbMuestras
            // 
            grbMuestras.Controls.Add(txtDonanteID);
            grbMuestras.Controls.Add(label2);
            grbMuestras.Controls.Add(label9);
            grbMuestras.Controls.Add(txtCodMuestra);
            grbMuestras.Controls.Add(cboEstado);
            grbMuestras.Controls.Add(dtFechaToma);
            grbMuestras.Controls.Add(label15);
            grbMuestras.Controls.Add(label14);
            grbMuestras.Controls.Add(label13);
            grbMuestras.Controls.Add(label16);
            grbMuestras.Controls.Add(label12);
            grbMuestras.Controls.Add(label11);
            grbMuestras.Controls.Add(label8);
            grbMuestras.Controls.Add(txtPulso);
            grbMuestras.Controls.Add(txtResponsable);
            grbMuestras.Controls.Add(txtTemperatura);
            grbMuestras.Controls.Add(txtCantidadM);
            grbMuestras.Controls.Add(txtPresionArterial);
            grbMuestras.Controls.Add(txtMuestraID);
            grbMuestras.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grbMuestras.Location = new Point(23, 90);
            grbMuestras.Name = "grbMuestras";
            grbMuestras.Size = new Size(1263, 339);
            grbMuestras.TabIndex = 2;
            grbMuestras.TabStop = false;
            grbMuestras.Text = "Datos Muestras";
            // 
            // txtDonanteID
            // 
            txtDonanteID.Location = new Point(834, 195);
            txtDonanteID.Margin = new Padding(4, 5, 4, 5);
            txtDonanteID.Name = "txtDonanteID";
            txtDonanteID.ReadOnly = true;
            txtDonanteID.Size = new Size(141, 33);
            txtDonanteID.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(686, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 27);
            label2.TabIndex = 48;
            label2.Text = "Donante ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(927, 73);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(248, 27);
            label9.TabIndex = 47;
            label9.Text = "Codigo de la Muestra:";
            // 
            // txtCodMuestra
            // 
            txtCodMuestra.Location = new Point(927, 105);
            txtCodMuestra.Margin = new Padding(4, 5, 4, 5);
            txtCodMuestra.Multiline = true;
            txtCodMuestra.Name = "txtCodMuestra";
            txtCodMuestra.ReadOnly = true;
            txtCodMuestra.Size = new Size(324, 38);
            txtCodMuestra.TabIndex = 46;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "No Activo" });
            cboEstado.Location = new Point(372, 135);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(141, 34);
            cboEstado.TabIndex = 45;
            // 
            // dtFechaToma
            // 
            dtFechaToma.Location = new Point(477, 197);
            dtFechaToma.Margin = new Padding(4, 5, 4, 5);
            dtFechaToma.Name = "dtFechaToma";
            dtFechaToma.Size = new Size(188, 33);
            dtFechaToma.TabIndex = 44;
            dtFechaToma.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(530, 135);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(209, 27);
            label15.TabIndex = 32;
            label15.Text = "Cantidad Muestra:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(270, 138);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(94, 27);
            label14.TabIndex = 33;
            label14.Text = "Estado:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(20, 135);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 27);
            label13.TabIndex = 34;
            label13.Text = "Pulso:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(29, 203);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(160, 27);
            label16.TabIndex = 35;
            label16.Text = "Responsable:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(598, 60);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 27);
            label12.TabIndex = 31;
            label12.Text = "Temperatura:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(272, 60);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(179, 27);
            label11.TabIndex = 36;
            label11.Text = "Precion Alterial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 63);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 27);
            label8.TabIndex = 37;
            label8.Text = "Muestra ID:";
            // 
            // txtPulso
            // 
            txtPulso.Location = new Point(152, 132);
            txtPulso.Margin = new Padding(4, 5, 4, 5);
            txtPulso.Name = "txtPulso";
            txtPulso.Size = new Size(103, 33);
            txtPulso.TabIndex = 41;
            txtPulso.KeyPress += txtPulso_KeyPress;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(190, 197);
            txtResponsable.Margin = new Padding(4, 5, 4, 5);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(241, 33);
            txtResponsable.TabIndex = 40;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(759, 52);
            txtTemperatura.Margin = new Padding(4, 5, 4, 5);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(148, 33);
            txtTemperatura.TabIndex = 39;
            txtTemperatura.KeyPress += txtTemperatura_KeyPress;
            // 
            // txtCantidadM
            // 
            txtCantidadM.Location = new Point(747, 127);
            txtCantidadM.Margin = new Padding(4, 5, 4, 5);
            txtCantidadM.Name = "txtCantidadM";
            txtCantidadM.Size = new Size(160, 33);
            txtCantidadM.TabIndex = 38;
            txtCantidadM.KeyPress += txtCantidadM_KeyPress;
            // 
            // txtPresionArterial
            // 
            txtPresionArterial.Location = new Point(459, 52);
            txtPresionArterial.Margin = new Padding(4, 5, 4, 5);
            txtPresionArterial.Name = "txtPresionArterial";
            txtPresionArterial.Size = new Size(131, 33);
            txtPresionArterial.TabIndex = 43;
            txtPresionArterial.KeyPress += txtPresionArterial_KeyPress;
            // 
            // txtMuestraID
            // 
            txtMuestraID.Location = new Point(152, 60);
            txtMuestraID.Margin = new Padding(4, 5, 4, 5);
            txtMuestraID.Name = "txtMuestraID";
            txtMuestraID.ReadOnly = true;
            txtMuestraID.Size = new Size(103, 33);
            txtMuestraID.TabIndex = 42;
            // 
            // dgManMuestras
            // 
            dgManMuestras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgManMuestras.Location = new Point(11, 448);
            dgManMuestras.Name = "dgManMuestras";
            dgManMuestras.RowHeadersWidth = 62;
            dgManMuestras.RowTemplate.Height = 33;
            dgManMuestras.Size = new Size(1407, 225);
            dgManMuestras.TabIndex = 1;
            dgManMuestras.CellDoubleClick += dgManMuestras_CellDoubleClick;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ActiveCaption;
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Location = new Point(1, -1);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1493, 76);
            pnlEncabezado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 17);
            label1.Name = "label1";
            label1.Size = new Size(254, 33);
            label1.TabIndex = 0;
            label1.Text = "Mantenedor Muestras";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmMantMuestras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 750);
            Controls.Add(pnlBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMantMuestras";
            Text = "FrmMantMuestras";
            Load += FrmMantMuestras_Load;
            pnlBase.ResumeLayout(false);
            grbMuestras.ResumeLayout(false);
            grbMuestras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgManMuestras).EndInit();
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
        private GroupBox grbMuestras;
        private DataGridView dgManMuestras;
        private Panel pnlEncabezado;
        private Label label1;
        private Label label9;
        private TextBox txtCodMuestra;
        private ComboBox cboEstado;
        private DateTimePicker dtFechaToma;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label12;
        private Label label11;
        private Label label8;
        private TextBox txtPulso;
        private TextBox txtResponsable;
        private TextBox txtTemperatura;
        private TextBox txtCantidadM;
        private TextBox txtPresionArterial;
        private TextBox txtMuestraID;
        private TextBox txtDonanteID;
        private Label label2;
        private ErrorProvider errorProvider;
    }
}