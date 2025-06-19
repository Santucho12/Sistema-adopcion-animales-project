namespace view.Solicitud
{
    partial class eliminarSolicitudForm
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxIngreseId = new System.Windows.Forms.TextBox();
            this.labelEliminarTitulo = new System.Windows.Forms.Label();
            this.labelEliminarId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(278, 156);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 34);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxIngreseId
            // 
            this.textBoxIngreseId.Location = new System.Drawing.Point(240, 126);
            this.textBoxIngreseId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIngreseId.Name = "textBoxIngreseId";
            this.textBoxIngreseId.Size = new System.Drawing.Size(128, 22);
            this.textBoxIngreseId.TabIndex = 6;
            this.textBoxIngreseId.TextChanged += new System.EventHandler(this.textBoxIngreseId_TextChanged);
            // 
            // labelEliminarTitulo
            // 
            this.labelEliminarTitulo.AutoSize = true;
            this.labelEliminarTitulo.Font = new System.Drawing.Font("Arial", 17.8F);
            this.labelEliminarTitulo.Location = new System.Drawing.Point(138, 70);
            this.labelEliminarTitulo.Name = "labelEliminarTitulo";
            this.labelEliminarTitulo.Size = new System.Drawing.Size(243, 35);
            this.labelEliminarTitulo.TabIndex = 5;
            this.labelEliminarTitulo.Text = "Eliminar mascota";
            this.labelEliminarTitulo.Click += new System.EventHandler(this.labelEliminarTitulo_Click);
            // 
            // labelEliminarId
            // 
            this.labelEliminarId.AutoSize = true;
            this.labelEliminarId.Location = new System.Drawing.Point(154, 129);
            this.labelEliminarId.Name = "labelEliminarId";
            this.labelEliminarId.Size = new System.Drawing.Size(66, 16);
            this.labelEliminarId.TabIndex = 4;
            this.labelEliminarId.Text = "Ingrese id";
            this.labelEliminarId.Click += new System.EventHandler(this.labelEliminarId_Click);
            // 
            // eliminarSolicitudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxIngreseId);
            this.Controls.Add(this.labelEliminarTitulo);
            this.Controls.Add(this.labelEliminarId);
            this.Name = "eliminarSolicitudForm";
            this.Text = "eliminarSolicitudForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxIngreseId;
        private System.Windows.Forms.Label labelEliminarTitulo;
        private System.Windows.Forms.Label labelEliminarId;
    }
}