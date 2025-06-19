namespace view
{
    partial class adoptanteForm
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
            this.dgvAdoptantes = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonModificarForm = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdoptantes
            // 
            this.dgvAdoptantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdoptantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoptantes.Location = new System.Drawing.Point(-26, 279);
            this.dgvAdoptantes.Name = "dgvAdoptantes";
            this.dgvAdoptantes.RowHeadersWidth = 51;
            this.dgvAdoptantes.RowTemplate.Height = 24;
            this.dgvAdoptantes.Size = new System.Drawing.Size(1938, 711);
            this.dgvAdoptantes.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 20.8F);
            this.labelTitulo.Location = new System.Drawing.Point(788, 88);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(383, 40);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Datos de los adoptantes";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(59, 162);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(214, 57);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonModificarForm
            // 
            this.buttonModificarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonModificarForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificarForm.Location = new System.Drawing.Point(1177, 162);
            this.buttonModificarForm.Name = "buttonModificarForm";
            this.buttonModificarForm.Size = new System.Drawing.Size(230, 57);
            this.buttonModificarForm.TabIndex = 8;
            this.buttonModificarForm.Text = "Modificar";
            this.buttonModificarForm.UseVisualStyleBackColor = false;
            this.buttonModificarForm.Click += new System.EventHandler(this.buttonModificarForm_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(1637, 162);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(214, 57);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(452, 162);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(214, 57);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click_1);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRegresar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRegresar.Location = new System.Drawing.Point(12, 12);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(147, 40);
            this.buttonRegresar.TabIndex = 11;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // adoptanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificarForm);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvAdoptantes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adoptanteForm";
            this.Text = "Base de datos de los adoptantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.adoptanteForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdoptantes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonModificarForm;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonRegresar;
    }
}