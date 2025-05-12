namespace view
{
    partial class buscarMascotaForm
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
            this.labelFormbuscarMascotaTitulo = new System.Windows.Forms.Label();
            this.labelBuscarMascotaFormId = new System.Windows.Forms.Label();
            this.textBoxBuscarMascotaForm = new System.Windows.Forms.TextBox();
            this.buttonBuscarMascotaForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFormbuscarMascotaTitulo
            // 
            this.labelFormbuscarMascotaTitulo.AutoSize = true;
            this.labelFormbuscarMascotaTitulo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.labelFormbuscarMascotaTitulo.Location = new System.Drawing.Point(76, 27);
            this.labelFormbuscarMascotaTitulo.Name = "labelFormbuscarMascotaTitulo";
            this.labelFormbuscarMascotaTitulo.Size = new System.Drawing.Size(252, 27);
            this.labelFormbuscarMascotaTitulo.TabIndex = 0;
            this.labelFormbuscarMascotaTitulo.Text = "Buscar mascota por id";
            // 
            // labelBuscarMascotaFormId
            // 
            this.labelBuscarMascotaFormId.AutoSize = true;
            this.labelBuscarMascotaFormId.Location = new System.Drawing.Point(104, 73);
            this.labelBuscarMascotaFormId.Name = "labelBuscarMascotaFormId";
            this.labelBuscarMascotaFormId.Size = new System.Drawing.Size(66, 16);
            this.labelBuscarMascotaFormId.TabIndex = 1;
            this.labelBuscarMascotaFormId.Text = "Ingrese id";
            // 
            // textBoxBuscarMascotaForm
            // 
            this.textBoxBuscarMascotaForm.Location = new System.Drawing.Point(190, 73);
            this.textBoxBuscarMascotaForm.Name = "textBoxBuscarMascotaForm";
            this.textBoxBuscarMascotaForm.Size = new System.Drawing.Size(145, 22);
            this.textBoxBuscarMascotaForm.TabIndex = 2;
            // 
            // buttonBuscarMascotaForm
            // 
            this.buttonBuscarMascotaForm.Location = new System.Drawing.Point(260, 102);
            this.buttonBuscarMascotaForm.Name = "buttonBuscarMascotaForm";
            this.buttonBuscarMascotaForm.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarMascotaForm.TabIndex = 3;
            this.buttonBuscarMascotaForm.Text = "Enviar";
            this.buttonBuscarMascotaForm.UseVisualStyleBackColor = true;
            this.buttonBuscarMascotaForm.Click += new System.EventHandler(this.buttonBuscarMascotaForm_Click_1);
            // 
            // buscarMascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 539);
            this.Controls.Add(this.buttonBuscarMascotaForm);
            this.Controls.Add(this.textBoxBuscarMascotaForm);
            this.Controls.Add(this.labelBuscarMascotaFormId);
            this.Controls.Add(this.labelFormbuscarMascotaTitulo);
            this.Name = "buscarMascotaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormbuscarMascotaTitulo;
        private System.Windows.Forms.Label labelBuscarMascotaFormId;
        private System.Windows.Forms.TextBox textBoxBuscarMascotaForm;
        private System.Windows.Forms.Button buttonBuscarMascotaForm;
    }
}