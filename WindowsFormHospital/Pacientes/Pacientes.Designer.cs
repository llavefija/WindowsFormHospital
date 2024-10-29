namespace WindowsFormHospital
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.labelPacientes = new System.Windows.Forms.Label();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.panelAñadir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelPacientes
            // 
            this.labelPacientes.AutoSize = true;
            this.labelPacientes.Font = new System.Drawing.Font("Rubik", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPacientes.Location = new System.Drawing.Point(12, 26);
            this.labelPacientes.Name = "labelPacientes";
            this.labelPacientes.Size = new System.Drawing.Size(410, 44);
            this.labelPacientes.TabIndex = 2;
            this.labelPacientes.Text = "Gestion de pacientes";
            this.labelPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnPacientes.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPacientes.Location = new System.Drawing.Point(456, 41);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(95, 29);
            this.BtnPacientes.TabIndex = 3;
            this.BtnPacientes.Text = "Añadir";
            this.BtnPacientes.UseVisualStyleBackColor = false;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.BtnEliminar.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminar.Location = new System.Drawing.Point(672, 41);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 29);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOpciones
            // 
            this.labelOpciones.AutoSize = true;
            this.labelOpciones.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpciones.Location = new System.Drawing.Point(459, 14);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(176, 15);
            this.labelOpciones.TabIndex = 5;
            this.labelOpciones.Text = "*Elije una opcion de gestion.";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Salmon;
            this.BtnMenu.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.Location = new System.Drawing.Point(12, 396);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(95, 42);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.Text = "MENU";
            this.BtnMenu.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.LemonChiffon;
            this.BtnModificar.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnModificar.Location = new System.Drawing.Point(557, 41);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(109, 29);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelAñadir
            // 
            this.panelAñadir.Location = new System.Drawing.Point(12, 76);
            this.panelAñadir.Name = "panelAñadir";
            this.panelAñadir.Size = new System.Drawing.Size(765, 314);
            this.panelAñadir.TabIndex = 0;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.labelOpciones);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnPacientes);
            this.Controls.Add(this.labelPacientes);
            this.Controls.Add(this.panelAñadir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacientes";
            this.Text = "Gestion pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPacientes;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label labelOpciones;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel panelAñadir;
    }
}