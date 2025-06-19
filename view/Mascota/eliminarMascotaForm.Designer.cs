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
            this.labelEliminarId.Location = new System.Drawing.Point(88, 55);
            this.labelEliminarId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarId.Name = "labelEliminarId";
            this.labelEliminarId.Size = new System.Drawing.Size(61, 15);
            this.labelEliminarId.TabIndex = 0;
            this.labelEliminarId.Text = "Ingrese id";
            this.labelEliminarId.Click += new System.EventHandler(this.labelEliminarId_Click);
            // 
            // labelEliminarTitulo
            // 
            this.labelEliminarTitulo.AutoSize = true;
            this.labelEliminarTitulo.Font = new System.Drawing.Font("Arial", 17.8F);
            this.labelEliminarTitulo.Location = new System.Drawing.Point(76, 7);
            this.labelEliminarTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarTitulo.Name = "labelEliminarTitulo";
            this.labelEliminarTitulo.Size = new System.Drawing.Size(243, 35);
            this.labelEliminarTitulo.TabIndex = 1;
            this.labelEliminarTitulo.Text = "Eliminar mascota";
            this.labelEliminarTitulo.Click += new System.EventHandler(this.labelEliminarTitulo_Click);
            // 
            // textBoxIngreseId
            // 
            this.textBoxIngreseId.Location = new System.Drawing.Point(152, 53);
            this.textBoxIngreseId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIngreseId.Name = "textBoxIngreseId";
            this.textBoxIngreseId.Size = new System.Drawing.Size(97, 20);
            this.textBoxIngreseId.TabIndex = 2;
            this.textBoxIngreseId.TextChanged += new System.EventHandler(this.textBoxIngreseId_TextChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(181, 77);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(68, 28);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // eliminarMascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 366);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxIngreseId);
            this.Controls.Add(this.labelEliminarTitulo);
            this.Controls.Add(this.labelEliminarId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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