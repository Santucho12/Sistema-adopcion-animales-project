namespace view.Home
{
    partial class HomeForm
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
            this.buttonVerMascotas = new System.Windows.Forms.Button();
            this.buttonVerAdoptantes = new System.Windows.Forms.Button();
            this.buttonVerSolicitudes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVerMascotas
            // 
            this.buttonVerMascotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerMascotas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVerMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonVerMascotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerMascotas.Location = new System.Drawing.Point(81, 429);
            this.buttonVerMascotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerMascotas.Name = "buttonVerMascotas";
            this.buttonVerMascotas.Size = new System.Drawing.Size(293, 107);
            this.buttonVerMascotas.TabIndex = 45;
            this.buttonVerMascotas.Text = "Ver Mascotas";
            this.buttonVerMascotas.UseVisualStyleBackColor = false;
            this.buttonVerMascotas.Click += new System.EventHandler(this.buttonVerMascotas_Click);
            // 
            // buttonVerAdoptantes
            // 
            this.buttonVerAdoptantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerAdoptantes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVerAdoptantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonVerAdoptantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerAdoptantes.Location = new System.Drawing.Point(627, 429);
            this.buttonVerAdoptantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerAdoptantes.Name = "buttonVerAdoptantes";
            this.buttonVerAdoptantes.Size = new System.Drawing.Size(293, 107);
            this.buttonVerAdoptantes.TabIndex = 46;
            this.buttonVerAdoptantes.Text = "Ver Adoptantes";
            this.buttonVerAdoptantes.UseVisualStyleBackColor = false;
            this.buttonVerAdoptantes.Click += new System.EventHandler(this.buttonVerAdoptantes_Click);
            // 
            // buttonVerSolicitudes
            // 
            this.buttonVerSolicitudes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerSolicitudes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVerSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonVerSolicitudes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerSolicitudes.Location = new System.Drawing.Point(1145, 429);
            this.buttonVerSolicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerSolicitudes.Name = "buttonVerSolicitudes";
            this.buttonVerSolicitudes.Size = new System.Drawing.Size(293, 107);
            this.buttonVerSolicitudes.TabIndex = 47;
            this.buttonVerSolicitudes.Text = "Ver Solicitudes";
            this.buttonVerSolicitudes.UseVisualStyleBackColor = false;
            this.buttonVerSolicitudes.Click += new System.EventHandler(this.buttonVerSolicitudes_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.buttonVerSolicitudes);
            this.Controls.Add(this.buttonVerAdoptantes);
            this.Controls.Add(this.buttonVerMascotas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2218, 1218);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1018, 1018);
            this.Name = "HomeForm";
            this.Text = "Sistema de adopcion de mascotas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonVerMascotas;
        private System.Windows.Forms.Button buttonVerAdoptantes;
        private System.Windows.Forms.Button buttonVerSolicitudes;
    }
}