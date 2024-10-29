namespace WindowsFormHospital
{
    partial class Hospital
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.BtnGestionar = new System.Windows.Forms.Button();
            this.labelHospital = new System.Windows.Forms.Label();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnSanitarios = new System.Windows.Forms.Button();
            this.BtnAdministrativo = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.PanelGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.BtnSalir);
            this.PanelMenu.Controls.Add(this.BtnVisualizar);
            this.PanelMenu.Controls.Add(this.BtnGestionar);
            this.PanelMenu.Location = new System.Drawing.Point(50, 120);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(583, 300);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Salmon;
            this.BtnSalir.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSalir.Location = new System.Drawing.Point(150, 232);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(280, 50);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.SystemColors.Info;
            this.BtnVisualizar.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVisualizar.Location = new System.Drawing.Point(150, 131);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(280, 50);
            this.BtnVisualizar.TabIndex = 1;
            this.BtnVisualizar.Text = "VISUALIZAR";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // BtnGestionar
            // 
            this.BtnGestionar.BackColor = System.Drawing.SystemColors.Info;
            this.BtnGestionar.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGestionar.Location = new System.Drawing.Point(150, 17);
            this.BtnGestionar.Name = "BtnGestionar";
            this.BtnGestionar.Size = new System.Drawing.Size(280, 50);
            this.BtnGestionar.TabIndex = 0;
            this.BtnGestionar.Text = "GESTIONAR";
            this.BtnGestionar.UseVisualStyleBackColor = false;
            this.BtnGestionar.Click += new System.EventHandler(this.BtnGestionar_Click);
            // 
            // labelHospital
            // 
            this.labelHospital.AutoSize = true;
            this.labelHospital.Font = new System.Drawing.Font("Rubik", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospital.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHospital.Location = new System.Drawing.Point(50, 50);
            this.labelHospital.Name = "labelHospital";
            this.labelHospital.Size = new System.Drawing.Size(583, 44);
            this.labelHospital.TabIndex = 1;
            this.labelHospital.Text = "HOSPITALES DE HERENCIA S.A";
            this.labelHospital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHospital.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.BtnMenu);
            this.PanelGestion.Controls.Add(this.BtnSanitarios);
            this.PanelGestion.Controls.Add(this.BtnAdministrativo);
            this.PanelGestion.Controls.Add(this.BtnPacientes);
            this.PanelGestion.Location = new System.Drawing.Point(50, 120);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(583, 300);
            this.PanelGestion.TabIndex = 3;
            this.PanelGestion.Visible = false;
            this.PanelGestion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Salmon;
            this.BtnMenu.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.Location = new System.Drawing.Point(150, 232);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(280, 50);
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.Text = "MENU";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnSanitarios
            // 
            this.BtnSanitarios.BackColor = System.Drawing.SystemColors.Info;
            this.BtnSanitarios.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSanitarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSanitarios.Location = new System.Drawing.Point(150, 159);
            this.BtnSanitarios.Name = "BtnSanitarios";
            this.BtnSanitarios.Size = new System.Drawing.Size(280, 50);
            this.BtnSanitarios.TabIndex = 2;
            this.BtnSanitarios.Text = "SANITARIOS";
            this.BtnSanitarios.UseVisualStyleBackColor = false;
            this.BtnSanitarios.Click += new System.EventHandler(this.BtnSanitarios_Click);
            // 
            // BtnAdministrativo
            // 
            this.BtnAdministrativo.BackColor = System.Drawing.SystemColors.Info;
            this.BtnAdministrativo.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAdministrativo.Location = new System.Drawing.Point(150, 89);
            this.BtnAdministrativo.Name = "BtnAdministrativo";
            this.BtnAdministrativo.Size = new System.Drawing.Size(280, 50);
            this.BtnAdministrativo.TabIndex = 1;
            this.BtnAdministrativo.Text = "ADMINISTRATIVOS";
            this.BtnAdministrativo.UseVisualStyleBackColor = false;
            this.BtnAdministrativo.Click += new System.EventHandler(this.BtnAdministrativo_Click);
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.BackColor = System.Drawing.SystemColors.Info;
            this.BtnPacientes.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPacientes.Location = new System.Drawing.Point(150, 17);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(280, 50);
            this.BtnPacientes.TabIndex = 0;
            this.BtnPacientes.Text = "PACIENTES";
            this.BtnPacientes.UseVisualStyleBackColor = false;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.labelHospital);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelGestion);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hospital";
            this.Text = "HOSPITALES DE HERENCIA S.A";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label labelHospital;
        private System.Windows.Forms.Button BtnGestionar;
        private System.Windows.Forms.Panel PanelGestion;
        private System.Windows.Forms.Button BtnSanitarios;
        private System.Windows.Forms.Button BtnAdministrativo;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnVisualizar;
        private System.Windows.Forms.Button BtnMenu;
    }
}

