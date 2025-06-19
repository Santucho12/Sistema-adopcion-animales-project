namespace view.Adoptante
{
    partial class buscarAdoptanteForm
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
            this.buttonBuscarAdoptante = new System.Windows.Forms.Button();
            this.textBoxBuscarAdoptante = new System.Windows.Forms.TextBox();
            this.labelBuscarAdoptanteFormId = new System.Windows.Forms.Label();
            this.labelFormbuscarAdoptanteTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuscarAdoptante
            // 
            this.buttonBuscarAdoptante.Location = new System.Drawing.Point(313, 156);
            this.buttonBuscarAdoptante.Name = "buttonBuscarAdoptante";
            this.buttonBuscarAdoptante.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarAdoptante.TabIndex = 7;
            this.buttonBuscarAdoptante.Text = "Enviar";
            this.buttonBuscarAdoptante.UseVisualStyleBackColor = true;
            this.buttonBuscarAdoptante.Click += new System.EventHandler(this.buttonBuscarAdoptante_Click);
            // 
            // textBoxBuscarAdoptante
            // 
            this.textBoxBuscarAdoptante.Location = new System.Drawing.Point(243, 127);
            this.textBoxBuscarAdoptante.Name = "textBoxBuscarAdoptante";
            this.textBoxBuscarAdoptante.Size = new System.Drawing.Size(145, 22);
            this.textBoxBuscarAdoptante.TabIndex = 6;
            // 
            // labelBuscarAdoptanteFormId
            // 
            this.labelBuscarAdoptanteFormId.AutoSize = true;
            this.labelBuscarAdoptanteFormId.Location = new System.Drawing.Point(157, 127);
            this.labelBuscarAdoptanteFormId.Name = "labelBuscarAdoptanteFormId";
            this.labelBuscarAdoptanteFormId.Size = new System.Drawing.Size(66, 16);
            this.labelBuscarAdoptanteFormId.TabIndex = 5;
            this.labelBuscarAdoptanteFormId.Text = "Ingrese id";
            // 
            // labelFormbuscarAdoptanteTitulo
            // 
            this.labelFormbuscarAdoptanteTitulo.AutoSize = true;
            this.labelFormbuscarAdoptanteTitulo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.labelFormbuscarAdoptanteTitulo.Location = new System.Drawing.Point(129, 81);
            this.labelFormbuscarAdoptanteTitulo.Name = "labelFormbuscarAdoptanteTitulo";
            this.labelFormbuscarAdoptanteTitulo.Size = new System.Drawing.Size(252, 27);
            this.labelFormbuscarAdoptanteTitulo.TabIndex = 4;
            this.labelFormbuscarAdoptanteTitulo.Text = "Buscar mascota por id";
            // 
            // buscarAdoptanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.buttonBuscarAdoptante);
            this.Controls.Add(this.textBoxBuscarAdoptante);
            this.Controls.Add(this.labelBuscarAdoptanteFormId);
            this.Controls.Add(this.labelFormbuscarAdoptanteTitulo);
            this.Name = "buscarAdoptanteForm";
            this.Text = "buscarAdoptanteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarAdoptante;
        private System.Windows.Forms.TextBox textBoxBuscarAdoptante;
        private System.Windows.Forms.Label labelBuscarAdoptanteFormId;
        private System.Windows.Forms.Label labelFormbuscarAdoptanteTitulo;
    }
}