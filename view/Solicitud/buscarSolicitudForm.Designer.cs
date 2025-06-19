namespace view.Solicitud
{
    partial class buscarSolicitudForm
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
            this.buttonBuscarMascotaForm = new System.Windows.Forms.Button();
            this.textBoxBuscarMascotaForm = new System.Windows.Forms.TextBox();
            this.labelBuscarMascotaFormId = new System.Windows.Forms.Label();
            this.labelFormbuscarMascotaTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuscarMascotaForm
            // 
            this.buttonBuscarMascotaForm.Location = new System.Drawing.Point(335, 176);
            this.buttonBuscarMascotaForm.Name = "buttonBuscarMascotaForm";
            this.buttonBuscarMascotaForm.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarMascotaForm.TabIndex = 7;
            this.buttonBuscarMascotaForm.Text = "Enviar";
            this.buttonBuscarMascotaForm.UseVisualStyleBackColor = true;
            this.buttonBuscarMascotaForm.Click += new System.EventHandler(this.buttonBuscarMascotaForm_Click);
            // 
            // textBoxBuscarMascotaForm
            // 
            this.textBoxBuscarMascotaForm.Location = new System.Drawing.Point(265, 147);
            this.textBoxBuscarMascotaForm.Name = "textBoxBuscarMascotaForm";
            this.textBoxBuscarMascotaForm.Size = new System.Drawing.Size(145, 22);
            this.textBoxBuscarMascotaForm.TabIndex = 6;
            // 
            // labelBuscarMascotaFormId
            // 
            this.labelBuscarMascotaFormId.AutoSize = true;
            this.labelBuscarMascotaFormId.Location = new System.Drawing.Point(179, 147);
            this.labelBuscarMascotaFormId.Name = "labelBuscarMascotaFormId";
            this.labelBuscarMascotaFormId.Size = new System.Drawing.Size(66, 16);
            this.labelBuscarMascotaFormId.TabIndex = 5;
            this.labelBuscarMascotaFormId.Text = "Ingrese id";
            // 
            // labelFormbuscarMascotaTitulo
            // 
            this.labelFormbuscarMascotaTitulo.AutoSize = true;
            this.labelFormbuscarMascotaTitulo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.labelFormbuscarMascotaTitulo.Location = new System.Drawing.Point(151, 101);
            this.labelFormbuscarMascotaTitulo.Name = "labelFormbuscarMascotaTitulo";
            this.labelFormbuscarMascotaTitulo.Size = new System.Drawing.Size(252, 27);
            this.labelFormbuscarMascotaTitulo.TabIndex = 4;
            this.labelFormbuscarMascotaTitulo.Text = "Buscar mascota por id";
            // 
            // buscarSolicitudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.buttonBuscarMascotaForm);
            this.Controls.Add(this.textBoxBuscarMascotaForm);
            this.Controls.Add(this.labelBuscarMascotaFormId);
            this.Controls.Add(this.labelFormbuscarMascotaTitulo);
            this.Name = "buscarSolicitudForm";
            this.Text = "buscarSolicitudForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarMascotaForm;
        private System.Windows.Forms.TextBox textBoxBuscarMascotaForm;
        private System.Windows.Forms.Label labelBuscarMascotaFormId;
        private System.Windows.Forms.Label labelFormbuscarMascotaTitulo;
    }
}