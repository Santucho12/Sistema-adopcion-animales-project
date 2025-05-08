namespace view
{
    partial class eliminarMascotaForm
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
            this.labelEliminarId = new System.Windows.Forms.Label();
            this.labelEliminarTitulo = new System.Windows.Forms.Label();
            this.textBoxIngreseId = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEliminarId
            // 
            this.labelEliminarId.AutoSize = true;
            this.labelEliminarId.Location = new System.Drawing.Point(117, 68);
            this.labelEliminarId.Name = "labelEliminarId";
            this.labelEliminarId.Size = new System.Drawing.Size(66, 16);
            this.labelEliminarId.TabIndex = 0;
            this.labelEliminarId.Text = "Ingrese id";
            // 
            // labelEliminarTitulo
            // 
            this.labelEliminarTitulo.AutoSize = true;
            this.labelEliminarTitulo.Font = new System.Drawing.Font("Arial", 17.8F);
            this.labelEliminarTitulo.Location = new System.Drawing.Point(101, 9);
            this.labelEliminarTitulo.Name = "labelEliminarTitulo";
            this.labelEliminarTitulo.Size = new System.Drawing.Size(243, 35);
            this.labelEliminarTitulo.TabIndex = 1;
            this.labelEliminarTitulo.Text = "Eliminar mascota";
            // 
            // textBoxIngreseId
            // 
            this.textBoxIngreseId.Location = new System.Drawing.Point(203, 65);
            this.textBoxIngreseId.Name = "textBoxIngreseId";
            this.textBoxIngreseId.Size = new System.Drawing.Size(128, 22);
            this.textBoxIngreseId.TabIndex = 2;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(255, 94);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // eliminarMascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxIngreseId);
            this.Controls.Add(this.labelEliminarTitulo);
            this.Controls.Add(this.labelEliminarId);
            this.Name = "eliminarMascotaForm";
            this.Text = "eliminarMascotaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEliminarId;
        private System.Windows.Forms.Label labelEliminarTitulo;
        private System.Windows.Forms.TextBox textBoxIngreseId;
        private System.Windows.Forms.Button buttonEliminar;
    }
}