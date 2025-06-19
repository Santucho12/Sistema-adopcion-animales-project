using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Adoptante
{
    public partial class buscarAdoptanteForm: Form
    {
        public string IdIngresado { get; private set; } // Propiedad para almacenar el ID ingresado
        public buscarAdoptanteForm()
        {
            InitializeComponent();
        }

        private void buttonBuscarAdoptante_Click(object sender, EventArgs e)
        {
            IdIngresado = textBoxBuscarAdoptante.Text;  // Guardás el valor
            this.DialogResult = DialogResult.OK; // Indicás que todo fue correcto
            this.Close(); // Cerrás el formulario
        }
    }
}
