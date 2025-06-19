namespace view.Solicitud
{
    partial class agregarSolicitudForm
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
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxAgregarAdoptanteId = new System.Windows.Forms.TextBox();
            this.textBoxAgregarMascotaId = new System.Windows.Forms.TextBox();
            this.labelAgregarFecha = new System.Windows.Forms.Label();
            this.labelAgregarAdoptanteId = new System.Windows.Forms.Label();
            this.labelAgregarMascotaId = new System.Windows.Forms.Label();
            this.labelAgregarTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(387, 304);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(90, 30);
            this.buttonAgregar.TabIndex = 66;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(168, 215);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(50, 16);
            this.labelEstado.TabIndex = 64;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxAgregarAdoptanteId
            // 
            this.textBoxAgregarAdoptanteId.Location = new System.Drawing.Point(224, 129);
            this.textBoxAgregarAdoptanteId.Name = "textBoxAgregarAdoptanteId";
            this.textBoxAgregarAdoptanteId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAgregarAdoptanteId.TabIndex = 62;
            // 
            // textBoxAgregarMascotaId
            // 
            this.textBoxAgregarMascotaId.Location = new System.Drawing.Point(224, 84);
            this.textBoxAgregarMascotaId.Name = "textBoxAgregarMascotaId";
            this.textBoxAgregarMascotaId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAgregarMascotaId.TabIndex = 60;
            // 
            // labelAgregarFecha
            // 
            this.labelAgregarFecha.AutoSize = true;
            this.labelAgregarFecha.Location = new System.Drawing.Point(169, 170);
            this.labelAgregarFecha.Name = "labelAgregarFecha";
            this.labelAgregarFecha.Size = new System.Drawing.Size(45, 16);
            this.labelAgregarFecha.TabIndex = 58;
            this.labelAgregarFecha.Text = "Fecha";
            // 
            // labelAgregarAdoptanteId
            // 
            this.labelAgregarAdoptanteId.AutoSize = true;
            this.labelAgregarAdoptanteId.Location = new System.Drawing.Point(117, 129);
            this.labelAgregarAdoptanteId.Name = "labelAgregarAdoptanteId";
            this.labelAgregarAdoptanteId.Size = new System.Drawing.Size(101, 16);
            this.labelAgregarAdoptanteId.TabIndex = 57;
            this.labelAgregarAdoptanteId.Text = "Id de adoptante";
            // 
            // labelAgregarMascotaId
            // 
            this.labelAgregarMascotaId.AutoSize = true;
            this.labelAgregarMascotaId.Location = new System.Drawing.Point(126, 84);
            this.labelAgregarMascotaId.Name = "labelAgregarMascotaId";
            this.labelAgregarMascotaId.Size = new System.Drawing.Size(92, 16);
            this.labelAgregarMascotaId.TabIndex = 56;
            this.labelAgregarMascotaId.Text = "Id de mascota";
            // 
            // labelAgregarTitulo
            // 
            this.labelAgregarTitulo.AutoSize = true;
            this.labelAgregarTitulo.Font = new System.Drawing.Font("Arial", 14.8F);
            this.labelAgregarTitulo.Location = new System.Drawing.Point(219, 34);
            this.labelAgregarTitulo.Name = "labelAgregarTitulo";
            this.labelAgregarTitulo.Size = new System.Drawing.Size(205, 28);
            this.labelAgregarTitulo.TabIndex = 55;
            this.labelAgregarTitulo.Text = "Agregar Solicitud";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 22);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 20);
            this.radioButton1.TabIndex = 68;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aprobada";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(300, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 20);
            this.radioButton2.TabIndex = 69;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "rechazada";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(409, 234);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 20);
            this.radioButton3.TabIndex = 70;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pendiente";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // agregarSolicitudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 577);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxAgregarAdoptanteId);
            this.Controls.Add(this.textBoxAgregarMascotaId);
            this.Controls.Add(this.labelAgregarFecha);
            this.Controls.Add(this.labelAgregarAdoptanteId);
            this.Controls.Add(this.labelAgregarMascotaId);
            this.Controls.Add(this.labelAgregarTitulo);
            this.Name = "agregarSolicitudForm";
            this.Text = "agregarSolicitudForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxAgregarAdoptanteId;
        private System.Windows.Forms.TextBox textBoxAgregarMascotaId;
        private System.Windows.Forms.Label labelAgregarFecha;
        private System.Windows.Forms.Label labelAgregarAdoptanteId;
        private System.Windows.Forms.Label labelAgregarMascotaId;
        private System.Windows.Forms.Label labelAgregarTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}