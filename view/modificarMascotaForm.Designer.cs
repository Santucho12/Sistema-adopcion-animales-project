namespace view
{
    partial class modificarMascotaForm
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
            this.labelModificarTitulo = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelModificarIngrese = new System.Windows.Forms.Label();
            this.labelModificarNombre = new System.Windows.Forms.Label();
            this.labelModificarEspecie = new System.Windows.Forms.Label();
            this.labelModificarRaza = new System.Windows.Forms.Label();
            this.labelModificarSexo = new System.Windows.Forms.Label();
            this.labelModificarEdad = new System.Windows.Forms.Label();
            this.labelModificarFecha = new System.Windows.Forms.Label();
            this.labelModificarAdopcion = new System.Windows.Forms.Label();
            this.labelModificarDescripcion = new System.Windows.Forms.Label();
            this.textBoxModificarDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxModificarRaza = new System.Windows.Forms.TextBox();
            this.textBoxModificarEspecie = new System.Windows.Forms.TextBox();
            this.textBoxModificarNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownModificar = new System.Windows.Forms.NumericUpDown();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.radioButtonModificarHembra = new System.Windows.Forms.RadioButton();
            this.radioButtonModificarDisponible = new System.Windows.Forms.RadioButton();
            this.radioButtonModificarAdoptada = new System.Windows.Forms.RadioButton();
            this.dateTimePickerModificarFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModificarTitulo
            // 
            this.labelModificarTitulo.AutoSize = true;
            this.labelModificarTitulo.Font = new System.Drawing.Font("Arial", 14.8F);
            this.labelModificarTitulo.Location = new System.Drawing.Point(199, 24);
            this.labelModificarTitulo.Name = "labelModificarTitulo";
            this.labelModificarTitulo.Size = new System.Drawing.Size(219, 28);
            this.labelModificarTitulo.TabIndex = 0;
            this.labelModificarTitulo.Text = "Modificar mascota";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(481, 642);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(80, 35);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // labelModificarIngrese
            // 
            this.labelModificarIngrese.AutoSize = true;
            this.labelModificarIngrese.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModificarIngrese.Font = new System.Drawing.Font("Arial", 9.8F);
            this.labelModificarIngrese.ForeColor = System.Drawing.Color.Red;
            this.labelModificarIngrese.Location = new System.Drawing.Point(142, 61);
            this.labelModificarIngrese.Name = "labelModificarIngrese";
            this.labelModificarIngrese.Size = new System.Drawing.Size(329, 19);
            this.labelModificarIngrese.TabIndex = 3;
            this.labelModificarIngrese.Text = "Ingresa solo los datos que deseas modificar";
            // 
            // labelModificarNombre
            // 
            this.labelModificarNombre.AutoSize = true;
            this.labelModificarNombre.Location = new System.Drawing.Point(162, 120);
            this.labelModificarNombre.Name = "labelModificarNombre";
            this.labelModificarNombre.Size = new System.Drawing.Size(56, 16);
            this.labelModificarNombre.TabIndex = 5;
            this.labelModificarNombre.Text = "Nombre";
            // 
            // labelModificarEspecie
            // 
            this.labelModificarEspecie.AutoSize = true;
            this.labelModificarEspecie.Location = new System.Drawing.Point(162, 160);
            this.labelModificarEspecie.Name = "labelModificarEspecie";
            this.labelModificarEspecie.Size = new System.Drawing.Size(57, 16);
            this.labelModificarEspecie.TabIndex = 6;
            this.labelModificarEspecie.Text = "Especie";
            // 
            // labelModificarRaza
            // 
            this.labelModificarRaza.AutoSize = true;
            this.labelModificarRaza.Location = new System.Drawing.Point(162, 206);
            this.labelModificarRaza.Name = "labelModificarRaza";
            this.labelModificarRaza.Size = new System.Drawing.Size(39, 16);
            this.labelModificarRaza.TabIndex = 7;
            this.labelModificarRaza.Text = "Raza";
            // 
            // labelModificarSexo
            // 
            this.labelModificarSexo.AutoSize = true;
            this.labelModificarSexo.Location = new System.Drawing.Point(162, 290);
            this.labelModificarSexo.Name = "labelModificarSexo";
            this.labelModificarSexo.Size = new System.Drawing.Size(38, 16);
            this.labelModificarSexo.TabIndex = 8;
            this.labelModificarSexo.Text = "Sexo";
            // 
            // labelModificarEdad
            // 
            this.labelModificarEdad.AutoSize = true;
            this.labelModificarEdad.Location = new System.Drawing.Point(162, 248);
            this.labelModificarEdad.Name = "labelModificarEdad";
            this.labelModificarEdad.Size = new System.Drawing.Size(40, 16);
            this.labelModificarEdad.TabIndex = 9;
            this.labelModificarEdad.Text = "Edad";
            // 
            // labelModificarFecha
            // 
            this.labelModificarFecha.AutoSize = true;
            this.labelModificarFecha.Location = new System.Drawing.Point(162, 382);
            this.labelModificarFecha.Name = "labelModificarFecha";
            this.labelModificarFecha.Size = new System.Drawing.Size(113, 16);
            this.labelModificarFecha.TabIndex = 10;
            this.labelModificarFecha.Text = "Fecha de llegada";
            // 
            // labelModificarAdopcion
            // 
            this.labelModificarAdopcion.AutoSize = true;
            this.labelModificarAdopcion.Location = new System.Drawing.Point(162, 337);
            this.labelModificarAdopcion.Name = "labelModificarAdopcion";
            this.labelModificarAdopcion.Size = new System.Drawing.Size(129, 16);
            this.labelModificarAdopcion.TabIndex = 11;
            this.labelModificarAdopcion.Text = "Estado de adopcion";
            // 
            // labelModificarDescripcion
            // 
            this.labelModificarDescripcion.AutoSize = true;
            this.labelModificarDescripcion.Location = new System.Drawing.Point(162, 422);
            this.labelModificarDescripcion.Name = "labelModificarDescripcion";
            this.labelModificarDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelModificarDescripcion.TabIndex = 12;
            this.labelModificarDescripcion.Text = "Descripcion";
            // 
            // textBoxModificarDescripcion
            // 
            this.textBoxModificarDescripcion.Location = new System.Drawing.Point(231, 451);
            this.textBoxModificarDescripcion.Multiline = true;
            this.textBoxModificarDescripcion.Name = "textBoxModificarDescripcion";
            this.textBoxModificarDescripcion.Size = new System.Drawing.Size(330, 185);
            this.textBoxModificarDescripcion.TabIndex = 15;
            // 
            // textBoxModificarRaza
            // 
            this.textBoxModificarRaza.Location = new System.Drawing.Point(255, 206);
            this.textBoxModificarRaza.Name = "textBoxModificarRaza";
            this.textBoxModificarRaza.Size = new System.Drawing.Size(88, 22);
            this.textBoxModificarRaza.TabIndex = 16;
            // 
            // textBoxModificarEspecie
            // 
            this.textBoxModificarEspecie.Location = new System.Drawing.Point(255, 160);
            this.textBoxModificarEspecie.Name = "textBoxModificarEspecie";
            this.textBoxModificarEspecie.Size = new System.Drawing.Size(88, 22);
            this.textBoxModificarEspecie.TabIndex = 17;
            // 
            // textBoxModificarNombre
            // 
            this.textBoxModificarNombre.Location = new System.Drawing.Point(255, 120);
            this.textBoxModificarNombre.Name = "textBoxModificarNombre";
            this.textBoxModificarNombre.Size = new System.Drawing.Size(88, 22);
            this.textBoxModificarNombre.TabIndex = 18;
            // 
            // numericUpDownModificar
            // 
            this.numericUpDownModificar.Location = new System.Drawing.Point(241, 248);
            this.numericUpDownModificar.Name = "numericUpDownModificar";
            this.numericUpDownModificar.Size = new System.Drawing.Size(132, 22);
            this.numericUpDownModificar.TabIndex = 19;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.Location = new System.Drawing.Point(229, 290);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(69, 20);
            this.radioButtonMacho.TabIndex = 20;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho";
            this.radioButtonMacho.UseVisualStyleBackColor = true;
            // 
            // radioButtonModificarHembra
            // 
            this.radioButtonModificarHembra.AutoSize = true;
            this.radioButtonModificarHembra.Location = new System.Drawing.Point(350, 290);
            this.radioButtonModificarHembra.Name = "radioButtonModificarHembra";
            this.radioButtonModificarHembra.Size = new System.Drawing.Size(77, 20);
            this.radioButtonModificarHembra.TabIndex = 21;
            this.radioButtonModificarHembra.TabStop = true;
            this.radioButtonModificarHembra.Text = "Hembra";
            this.radioButtonModificarHembra.UseVisualStyleBackColor = true;
            // 
            // radioButtonModificarDisponible
            // 
            this.radioButtonModificarDisponible.AutoSize = true;
            this.radioButtonModificarDisponible.Location = new System.Drawing.Point(297, 335);
            this.radioButtonModificarDisponible.Name = "radioButtonModificarDisponible";
            this.radioButtonModificarDisponible.Size = new System.Drawing.Size(93, 20);
            this.radioButtonModificarDisponible.TabIndex = 22;
            this.radioButtonModificarDisponible.TabStop = true;
            this.radioButtonModificarDisponible.Text = "Disponible";
            this.radioButtonModificarDisponible.UseVisualStyleBackColor = true;
            // 
            // radioButtonModificarAdoptada
            // 
            this.radioButtonModificarAdoptada.AutoSize = true;
            this.radioButtonModificarAdoptada.Location = new System.Drawing.Point(396, 333);
            this.radioButtonModificarAdoptada.Name = "radioButtonModificarAdoptada";
            this.radioButtonModificarAdoptada.Size = new System.Drawing.Size(88, 20);
            this.radioButtonModificarAdoptada.TabIndex = 23;
            this.radioButtonModificarAdoptada.TabStop = true;
            this.radioButtonModificarAdoptada.Text = "Adoptada";
            this.radioButtonModificarAdoptada.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerModificarFecha
            // 
            this.dateTimePickerModificarFecha.Location = new System.Drawing.Point(309, 382);
            this.dateTimePickerModificarFecha.Name = "dateTimePickerModificarFecha";
            this.dateTimePickerModificarFecha.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerModificarFecha.TabIndex = 24;
            // 
            // modificarMascotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 694);
            this.Controls.Add(this.dateTimePickerModificarFecha);
            this.Controls.Add(this.radioButtonModificarAdoptada);
            this.Controls.Add(this.radioButtonModificarDisponible);
            this.Controls.Add(this.radioButtonModificarHembra);
            this.Controls.Add(this.radioButtonMacho);
            this.Controls.Add(this.numericUpDownModificar);
            this.Controls.Add(this.textBoxModificarNombre);
            this.Controls.Add(this.textBoxModificarEspecie);
            this.Controls.Add(this.textBoxModificarRaza);
            this.Controls.Add(this.textBoxModificarDescripcion);
            this.Controls.Add(this.labelModificarDescripcion);
            this.Controls.Add(this.labelModificarAdopcion);
            this.Controls.Add(this.labelModificarFecha);
            this.Controls.Add(this.labelModificarEdad);
            this.Controls.Add(this.labelModificarSexo);
            this.Controls.Add(this.labelModificarRaza);
            this.Controls.Add(this.labelModificarEspecie);
            this.Controls.Add(this.labelModificarNombre);
            this.Controls.Add(this.labelModificarIngrese);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelModificarTitulo);
            this.Name = "modificarMascotaForm";
            this.Text = "Modificar mascota";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarTitulo;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelModificarIngrese;
        private System.Windows.Forms.Label labelModificarNombre;
        private System.Windows.Forms.Label labelModificarEspecie;
        private System.Windows.Forms.Label labelModificarRaza;
        private System.Windows.Forms.Label labelModificarSexo;
        private System.Windows.Forms.Label labelModificarEdad;
        private System.Windows.Forms.Label labelModificarFecha;
        private System.Windows.Forms.Label labelModificarAdopcion;
        private System.Windows.Forms.Label labelModificarDescripcion;
        private System.Windows.Forms.TextBox textBoxModificarDescripcion;
        private System.Windows.Forms.TextBox textBoxModificarRaza;
        private System.Windows.Forms.TextBox textBoxModificarEspecie;
        private System.Windows.Forms.TextBox textBoxModificarNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownModificar;
        private System.Windows.Forms.RadioButton radioButtonMacho;
        private System.Windows.Forms.RadioButton radioButtonModificarHembra;
        private System.Windows.Forms.RadioButton radioButtonModificarDisponible;
        private System.Windows.Forms.RadioButton radioButtonModificarAdoptada;
        private System.Windows.Forms.DateTimePicker dateTimePickerModificarFecha;
    }
}