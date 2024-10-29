namespace WindowsFormHospital
{
    partial class BusquedaPacientes
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
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonBuscarNombre = new System.Windows.Forms.Button();
            this.buttonBuscarDNI = new System.Windows.Forms.Button();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.textBoxBuscarNombre = new System.Windows.Forms.TextBox();
            this.textBoxBuscarDNI = new System.Windows.Forms.TextBox();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.labelBuscarDNI = new System.Windows.Forms.Label();
            this.listBoxusuarios = new System.Windows.Forms.ListBox();
            this.panelBusqueda.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.buttonConfirmar);
            this.panelBusqueda.Controls.Add(this.buttonBuscarNombre);
            this.panelBusqueda.Controls.Add(this.buttonBuscarDNI);
            this.panelBusqueda.Controls.Add(this.labelUsuarios);
            this.panelBusqueda.Controls.Add(this.panelUsuarios);
            this.panelBusqueda.Controls.Add(this.textBoxBuscarNombre);
            this.panelBusqueda.Controls.Add(this.textBoxBuscarDNI);
            this.panelBusqueda.Controls.Add(this.labelBuscarNombre);
            this.panelBusqueda.Controls.Add(this.labelBuscarDNI);
            this.panelBusqueda.Location = new System.Drawing.Point(3, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(765, 267);
            this.panelBusqueda.TabIndex = 30;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConfirmar.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmar.Location = new System.Drawing.Point(560, 11);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(189, 66);
            this.buttonConfirmar.TabIndex = 30;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonBuscarNombre
            // 
            this.buttonBuscarNombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBuscarNombre.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscarNombre.Location = new System.Drawing.Point(459, 48);
            this.buttonBuscarNombre.Name = "buttonBuscarNombre";
            this.buttonBuscarNombre.Size = new System.Drawing.Size(95, 29);
            this.buttonBuscarNombre.TabIndex = 25;
            this.buttonBuscarNombre.Text = "Buscar";
            this.buttonBuscarNombre.UseVisualStyleBackColor = false;
            // 
            // buttonBuscarDNI
            // 
            this.buttonBuscarDNI.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBuscarDNI.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscarDNI.Location = new System.Drawing.Point(459, 11);
            this.buttonBuscarDNI.Name = "buttonBuscarDNI";
            this.buttonBuscarDNI.Size = new System.Drawing.Size(95, 29);
            this.buttonBuscarDNI.TabIndex = 24;
            this.buttonBuscarDNI.Text = "Buscar";
            this.buttonBuscarDNI.UseVisualStyleBackColor = false;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(4, 97);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(185, 20);
            this.labelUsuarios.TabIndex = 23;
            this.labelUsuarios.Text = "Usuarios encontrados:";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.listBoxusuarios);
            this.panelUsuarios.Location = new System.Drawing.Point(8, 121);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(741, 139);
            this.panelUsuarios.TabIndex = 22;
            // 
            // textBoxBuscarNombre
            // 
            this.textBoxBuscarNombre.Location = new System.Drawing.Point(203, 55);
            this.textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            this.textBoxBuscarNombre.Size = new System.Drawing.Size(250, 22);
            this.textBoxBuscarNombre.TabIndex = 21;
            // 
            // textBoxBuscarDNI
            // 
            this.textBoxBuscarDNI.Location = new System.Drawing.Point(203, 15);
            this.textBoxBuscarDNI.Name = "textBoxBuscarDNI";
            this.textBoxBuscarDNI.Size = new System.Drawing.Size(250, 22);
            this.textBoxBuscarDNI.TabIndex = 20;
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.Location = new System.Drawing.Point(4, 57);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(157, 20);
            this.labelBuscarNombre.TabIndex = 19;
            this.labelBuscarNombre.Text = "Buscar por nombre";
            // 
            // labelBuscarDNI
            // 
            this.labelBuscarDNI.AutoSize = true;
            this.labelBuscarDNI.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarDNI.Location = new System.Drawing.Point(4, 15);
            this.labelBuscarDNI.Name = "labelBuscarDNI";
            this.labelBuscarDNI.Size = new System.Drawing.Size(126, 20);
            this.labelBuscarDNI.TabIndex = 18;
            this.labelBuscarDNI.Text = "Buscar por DNI";
            // 
            // listBoxusuarios
            // 
            this.listBoxusuarios.FormattingEnabled = true;
            this.listBoxusuarios.ItemHeight = 16;
            this.listBoxusuarios.Location = new System.Drawing.Point(4, 4);
            this.listBoxusuarios.Name = "listBoxusuarios";
            this.listBoxusuarios.Size = new System.Drawing.Size(734, 132);
            this.listBoxusuarios.TabIndex = 0;
            // 
            // BusquedaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBusqueda);
            this.Name = "BusquedaPacientes";
            this.Size = new System.Drawing.Size(772, 272);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonBuscarNombre;
        private System.Windows.Forms.Button buttonBuscarDNI;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.TextBox textBoxBuscarNombre;
        private System.Windows.Forms.TextBox textBoxBuscarDNI;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.Label labelBuscarDNI;
        private System.Windows.Forms.ListBox listBoxusuarios;
    }
}
