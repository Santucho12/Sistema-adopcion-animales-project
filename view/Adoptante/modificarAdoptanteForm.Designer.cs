namespace view.Adoptante
{
    partial class modificarAdoptanteForm
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxModificareEmail = new System.Windows.Forms.TextBox();
            this.labelIngresarEmail = new System.Windows.Forms.Label();
            this.textBoxModificarMotivo = new System.Windows.Forms.TextBox();
            this.textBoxModificarDireccion = new System.Windows.Forms.TextBox();
            this.textBoxModificarTelefono = new System.Windows.Forms.TextBox();
            this.textBoxModificarNombre = new System.Windows.Forms.TextBox();
            this.labelAgregarMotivo = new System.Windows.Forms.Label();
            this.labelAgregarTelefono = new System.Windows.Forms.Label();
            this.labelAgregarDireccion = new System.Windows.Forms.Label();
            this.labelAgregarNombre = new System.Windows.Forms.Label();
            this.labelModificarTitulo = new System.Windows.Forms.Label();
            this.labelModificarIngrese = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(414, 510);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(90, 30);
            this.buttonAgregar.TabIndex = 54;
            this.buttonAgregar.Text = "Modificar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxModificareEmail
            // 
            this.textBoxModificareEmail.Location = new System.Drawing.Point(260, 264);
            this.textBoxModificareEmail.Name = "textBoxModificareEmail";
            this.textBoxModificareEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxModificareEmail.TabIndex = 53;
            // 
            // labelIngresarEmail
            // 
            this.labelIngresarEmail.AutoSize = true;
            this.labelIngresarEmail.Location = new System.Drawing.Point(189, 264);
            this.labelIngresarEmail.Name = "labelIngresarEmail";
            this.labelIngresarEmail.Size = new System.Drawing.Size(41, 16);
            this.labelIngresarEmail.TabIndex = 52;
            this.labelIngresarEmail.Text = "Email";
            // 
            // textBoxModificarMotivo
            // 
            this.textBoxModificarMotivo.Location = new System.Drawing.Point(222, 371);
            this.textBoxModificarMotivo.Multiline = true;
            this.textBoxModificarMotivo.Name = "textBoxModificarMotivo";
            this.textBoxModificarMotivo.Size = new System.Drawing.Size(282, 133);
            this.textBoxModificarMotivo.TabIndex = 51;
            // 
            // textBoxModificarDireccion
            // 
            this.textBoxModificarDireccion.Location = new System.Drawing.Point(260, 176);
            this.textBoxModificarDireccion.Name = "textBoxModificarDireccion";
            this.textBoxModificarDireccion.Size = new System.Drawing.Size(100, 22);
            this.textBoxModificarDireccion.TabIndex = 50;
            // 
            // textBoxModificarTelefono
            // 
            this.textBoxModificarTelefono.Location = new System.Drawing.Point(260, 217);
            this.textBoxModificarTelefono.Name = "textBoxModificarTelefono";
            this.textBoxModificarTelefono.Size = new System.Drawing.Size(100, 22);
            this.textBoxModificarTelefono.TabIndex = 49;
            // 
            // textBoxModificarNombre
            // 
            this.textBoxModificarNombre.Location = new System.Drawing.Point(260, 131);
            this.textBoxModificarNombre.Name = "textBoxModificarNombre";
            this.textBoxModificarNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxModificarNombre.TabIndex = 48;
            // 
            // labelAgregarMotivo
            // 
            this.labelAgregarMotivo.AutoSize = true;
            this.labelAgregarMotivo.Location = new System.Drawing.Point(175, 342);
            this.labelAgregarMotivo.Name = "labelAgregarMotivo";
            this.labelAgregarMotivo.Size = new System.Drawing.Size(126, 16);
            this.labelAgregarMotivo.TabIndex = 47;
            this.labelAgregarMotivo.Text = "Motivo de adopcion";
            // 
            // labelAgregarTelefono
            // 
            this.labelAgregarTelefono.AutoSize = true;
            this.labelAgregarTelefono.Location = new System.Drawing.Point(186, 217);
            this.labelAgregarTelefono.Name = "labelAgregarTelefono";
            this.labelAgregarTelefono.Size = new System.Drawing.Size(61, 16);
            this.labelAgregarTelefono.TabIndex = 46;
            this.labelAgregarTelefono.Text = "Telefono";
            // 
            // labelAgregarDireccion
            // 
            this.labelAgregarDireccion.AutoSize = true;
            this.labelAgregarDireccion.Location = new System.Drawing.Point(186, 176);
            this.labelAgregarDireccion.Name = "labelAgregarDireccion";
            this.labelAgregarDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelAgregarDireccion.TabIndex = 45;
            this.labelAgregarDireccion.Text = "Direccion";
            // 
            // labelAgregarNombre
            // 
            this.labelAgregarNombre.AutoSize = true;
            this.labelAgregarNombre.Location = new System.Drawing.Point(186, 131);
            this.labelAgregarNombre.Name = "labelAgregarNombre";
            this.labelAgregarNombre.Size = new System.Drawing.Size(56, 16);
            this.labelAgregarNombre.TabIndex = 44;
            this.labelAgregarNombre.Text = "Nombre";
            // 
            // labelModificarTitulo
            // 
            this.labelModificarTitulo.AutoSize = true;
            this.labelModificarTitulo.Font = new System.Drawing.Font("Arial", 14.8F);
            this.labelModificarTitulo.Location = new System.Drawing.Point(230, 23);
            this.labelModificarTitulo.Name = "labelModificarTitulo";
            this.labelModificarTitulo.Size = new System.Drawing.Size(234, 28);
            this.labelModificarTitulo.TabIndex = 43;
            this.labelModificarTitulo.Text = "Modificar adoptante";
            // 
            // labelModificarIngrese
            // 
            this.labelModificarIngrese.AutoSize = true;
            this.labelModificarIngrese.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModificarIngrese.Font = new System.Drawing.Font("Arial", 9.8F);
            this.labelModificarIngrese.ForeColor = System.Drawing.Color.Red;
            this.labelModificarIngrese.Location = new System.Drawing.Point(188, 63);
            this.labelModificarIngrese.Name = "labelModificarIngrese";
            this.labelModificarIngrese.Size = new System.Drawing.Size(329, 19);
            this.labelModificarIngrese.TabIndex = 55;
            this.labelModificarIngrese.Text = "Ingresa solo los datos que deseas modificar";
            // 
            // modificarAdoptanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.labelModificarIngrese);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxModificareEmail);
            this.Controls.Add(this.labelIngresarEmail);
            this.Controls.Add(this.textBoxModificarMotivo);
            this.Controls.Add(this.textBoxModificarDireccion);
            this.Controls.Add(this.textBoxModificarTelefono);
            this.Controls.Add(this.textBoxModificarNombre);
            this.Controls.Add(this.labelAgregarMotivo);
            this.Controls.Add(this.labelAgregarTelefono);
            this.Controls.Add(this.labelAgregarDireccion);
            this.Controls.Add(this.labelAgregarNombre);
            this.Controls.Add(this.labelModificarTitulo);
            this.Name = "modificarAdoptanteForm";
            this.Text = "modificarAdoptanteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxModificareEmail;
        private System.Windows.Forms.Label labelIngresarEmail;
        private System.Windows.Forms.TextBox textBoxModificarMotivo;
        private System.Windows.Forms.TextBox textBoxModificarDireccion;
        private System.Windows.Forms.TextBox textBoxModificarTelefono;
        private System.Windows.Forms.TextBox textBoxModificarNombre;
        private System.Windows.Forms.Label labelAgregarMotivo;
        private System.Windows.Forms.Label labelAgregarTelefono;
        private System.Windows.Forms.Label labelAgregarDireccion;
        private System.Windows.Forms.Label labelAgregarNombre;
        private System.Windows.Forms.Label labelModificarTitulo;
        private System.Windows.Forms.Label labelModificarIngrese;
    }
}