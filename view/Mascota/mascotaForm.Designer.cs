namespace view
{
    partial class mascotaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede Agregar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificarForm = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(-2, 240);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 24;
            this.dgvMascotas.Size = new System.Drawing.Size(1920, 800);
            this.dgvMascotas.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20.8F);
            this.labelTitulo.Location = new System.Drawing.Point(796, 45);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(363, 40);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Datos de las mascotas";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRegresar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRegresar.Location = new System.Drawing.Point(12, 45);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(132, 40);
            this.buttonRegresar.TabIndex = 8;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(463, 137);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(214, 57);
            this.buttonAgregar.TabIndex = 14;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(1648, 137);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(214, 57);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonModificarForm
            // 
            this.buttonModificarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonModificarForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificarForm.Location = new System.Drawing.Point(1188, 137);
            this.buttonModificarForm.Name = "buttonModificarForm";
            this.buttonModificarForm.Size = new System.Drawing.Size(230, 57);
            this.buttonModificarForm.TabIndex = 12;
            this.buttonModificarForm.Text = "Modificar";
            this.buttonModificarForm.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(70, 137);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(214, 57);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // mascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificarForm);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvMascotas);
            this.MinimizeBox = false;
            this.Name = "mascotaForm";
            this.Text = "Base de datos de mascotas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mascotaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificarForm;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

