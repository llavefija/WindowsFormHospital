namespace WindowsFormHospital
{
    partial class ModificarPacientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelModificar = new System.Windows.Forms.Panel();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.comboBoxGravedad = new System.Windows.Forms.ComboBox();
            this.richTextBoxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.labelGravedad = new System.Windows.Forms.Label();
            this.labelFechaBaja = new System.Windows.Forms.Label();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.BtnBorrarCampos = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.panelModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificar
            // 
            this.panelModificar.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.panelModificar.Controls.Add(this.comboBoxSexo);
            this.panelModificar.Controls.Add(this.comboBoxGravedad);
            this.panelModificar.Controls.Add(this.richTextBoxDiagnostico);
            this.panelModificar.Controls.Add(this.dateTimePickerFechaBaja);
            this.panelModificar.Controls.Add(this.dateTimePickerFechaAlta);
            this.panelModificar.Controls.Add(this.textBoxMail);
            this.panelModificar.Controls.Add(this.textBoxDireccion);
            this.panelModificar.Controls.Add(this.textBoxDNI);
            this.panelModificar.Controls.Add(this.textBoxNombre);
            this.panelModificar.Controls.Add(this.labelDiagnostico);
            this.panelModificar.Controls.Add(this.labelGravedad);
            this.panelModificar.Controls.Add(this.labelFechaBaja);
            this.panelModificar.Controls.Add(this.labelFechaAlta);
            this.panelModificar.Controls.Add(this.labelSexo);
            this.panelModificar.Controls.Add(this.labelMail);
            this.panelModificar.Controls.Add(this.labelDireccion);
            this.panelModificar.Controls.Add(this.labelDNI);
            this.panelModificar.Controls.Add(this.labelFechaNacimiento);
            this.panelModificar.Controls.Add(this.labelPaciente);
            this.panelModificar.Controls.Add(this.BtnBorrarCampos);
            this.panelModificar.Controls.Add(this.BtnAplicar);
            this.panelModificar.Location = new System.Drawing.Point(1, 0);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(769, 329);
            this.panelModificar.TabIndex = 30;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(178, 43);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerFechaNacimiento.TabIndex = 31;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "NoEspecificar",
            "Hombre",
            "Mujer"});
            this.comboBoxSexo.Location = new System.Drawing.Point(178, 163);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(250, 24);
            this.comboBoxSexo.TabIndex = 30;
            // 
            // comboBoxGravedad
            // 
            this.comboBoxGravedad.FormattingEnabled = true;
            this.comboBoxGravedad.Items.AddRange(new object[] {
            "Perfecto ",
            "Leve ",
            "Moderada ",
            "Grave ",
            "Critica "});
            this.comboBoxGravedad.Location = new System.Drawing.Point(178, 261);
            this.comboBoxGravedad.Name = "comboBoxGravedad";
            this.comboBoxGravedad.Size = new System.Drawing.Size(250, 24);
            this.comboBoxGravedad.TabIndex = 29;
            // 
            // richTextBoxDiagnostico
            // 
            this.richTextBoxDiagnostico.Location = new System.Drawing.Point(438, 37);
            this.richTextBoxDiagnostico.Name = "richTextBoxDiagnostico";
            this.richTextBoxDiagnostico.Size = new System.Drawing.Size(323, 214);
            this.richTextBoxDiagnostico.TabIndex = 26;
            this.richTextBoxDiagnostico.Text = "";
            // 
            // dateTimePickerFechaBaja
            // 
            this.dateTimePickerFechaBaja.Location = new System.Drawing.Point(178, 229);
            this.dateTimePickerFechaBaja.Name = "dateTimePickerFechaBaja";
            this.dateTimePickerFechaBaja.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerFechaBaja.TabIndex = 25;
            // 
            // dateTimePickerFechaAlta
            // 
            this.dateTimePickerFechaAlta.Location = new System.Drawing.Point(178, 197);
            this.dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
            this.dateTimePickerFechaAlta.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerFechaAlta.TabIndex = 24;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(178, 135);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(250, 22);
            this.textBoxMail.TabIndex = 23;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(178, 105);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(250, 22);
            this.textBoxDireccion.TabIndex = 22;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(178, 76);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(250, 22);
            this.textBoxDNI.TabIndex = 21;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(178, 14);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(250, 22);
            this.textBoxNombre.TabIndex = 19;
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnostico.Location = new System.Drawing.Point(434, 14);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(103, 20);
            this.labelDiagnostico.TabIndex = 18;
            this.labelDiagnostico.Text = "Diagnostico";
            // 
            // labelGravedad
            // 
            this.labelGravedad.AutoSize = true;
            this.labelGravedad.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGravedad.Location = new System.Drawing.Point(4, 261);
            this.labelGravedad.Name = "labelGravedad";
            this.labelGravedad.Size = new System.Drawing.Size(92, 20);
            this.labelGravedad.TabIndex = 17;
            this.labelGravedad.Text = "*Gravedad";
            // 
            // labelFechaBaja
            // 
            this.labelFechaBaja.AutoSize = true;
            this.labelFechaBaja.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaBaja.Location = new System.Drawing.Point(4, 231);
            this.labelFechaBaja.Name = "labelFechaBaja";
            this.labelFechaBaja.Size = new System.Drawing.Size(115, 20);
            this.labelFechaBaja.TabIndex = 16;
            this.labelFechaBaja.Text = "Fecha de baja";
            this.labelFechaBaja.Click += new System.EventHandler(this.label13_Click);
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaAlta.Location = new System.Drawing.Point(4, 197);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(112, 20);
            this.labelFechaAlta.TabIndex = 15;
            this.labelFechaAlta.Text = "Fecha de alta";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(4, 166);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(48, 20);
            this.labelSexo.TabIndex = 14;
            this.labelSexo.Text = "Sexo";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(4, 135);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(39, 20);
            this.labelMail.TabIndex = 13;
            this.labelMail.Text = "Mail";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(4, 105);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(82, 20);
            this.labelDireccion.TabIndex = 12;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(4, 76);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(46, 20);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "*DNI";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(4, 45);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(155, 20);
            this.labelFechaNacimiento.TabIndex = 10;
            this.labelFechaNacimiento.Text = "*Fecha nacimiento";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaciente.Location = new System.Drawing.Point(4, 14);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(150, 20);
            this.labelPaciente.TabIndex = 7;
            this.labelPaciente.Text = "*Nombre paciente";
            // 
            // BtnBorrarCampos
            // 
            this.BtnBorrarCampos.BackColor = System.Drawing.Color.Salmon;
            this.BtnBorrarCampos.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBorrarCampos.Location = new System.Drawing.Point(438, 272);
            this.BtnBorrarCampos.Name = "BtnBorrarCampos";
            this.BtnBorrarCampos.Size = new System.Drawing.Size(217, 42);
            this.BtnBorrarCampos.TabIndex = 8;
            this.BtnBorrarCampos.Text = "BORRAR CAMPOS";
            this.BtnBorrarCampos.UseVisualStyleBackColor = false;
            this.BtnBorrarCampos.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnAplicar.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAplicar.Location = new System.Drawing.Point(666, 272);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(95, 42);
            this.BtnAplicar.TabIndex = 7;
            this.BtnAplicar.Text = "APLICAR";
            this.BtnAplicar.UseVisualStyleBackColor = false;
            this.BtnAplicar.Click += new System.EventHandler(this.button6_Click);
            // 
            // ModificarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelModificar);
            this.Name = "ModificarPacientes";
            this.Size = new System.Drawing.Size(773, 334);
            this.panelModificar.ResumeLayout(false);
            this.panelModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnostico;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaBaja;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAlta;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.Label labelGravedad;
        private System.Windows.Forms.Label labelFechaBaja;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Button BtnBorrarCampos;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxGravedad;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
    }
}
