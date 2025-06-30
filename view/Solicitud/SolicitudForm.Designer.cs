namespace view.Solicitud
{
    partial class solicitudForm
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
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificarForm = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRegresar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRegresar.Location = new System.Drawing.Point(9, 79);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(132, 40);
            this.buttonRegresar.TabIndex = 15;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20.8F);
            this.labelTitulo.Location = new System.Drawing.Point(793, 79);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(375, 40);
            this.labelTitulo.TabIndex = 10;
            this.labelTitulo.Text = "Datos de las solicitudes";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(-5, 274);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.RowHeadersWidth = 51;
            this.dgvSolicitudes.RowTemplate.Height = 24;
            this.dgvSolicitudes.Size = new System.Drawing.Size(1920, 800);
            this.dgvSolicitudes.TabIndex = 9;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(449, 164);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(214, 57);
            this.buttonAgregar.TabIndex = 19;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(1634, 164);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(214, 57);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonModificarForm
            // 
            this.buttonModificarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonModificarForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificarForm.Location = new System.Drawing.Point(1174, 164);
            this.buttonModificarForm.Name = "buttonModificarForm";
            this.buttonModificarForm.Size = new System.Drawing.Size(230, 57);
            this.buttonModificarForm.TabIndex = 17;
            this.buttonModificarForm.Text = "Modificar";
            this.buttonModificarForm.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(56, 164);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(214, 57);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // solicitudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificarForm);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "solicitudForm";
            this.Text = "solicitudForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.solicitudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarForm;
        private System.Windows.Forms.Button buttonBuscar;
    }
}