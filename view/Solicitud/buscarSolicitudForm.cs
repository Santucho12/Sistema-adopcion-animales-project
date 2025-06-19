using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Solicitud
{
    public partial class buscarSolicitudForm: Form
    {
        public string IdIngresado { get; private set; } // Propiedad para almacenar el ID ingresado
        public buscarSolicitudForm()
        {
            InitializeComponent();
        }

        private void buttonBuscarMascotaForm_Click(object sender, EventArgs e)
        {
            IdIngresado = textBoxBuscarMascotaForm.Text;  // Guardás el valor
            this.DialogResult = DialogResult.OK; // Indicás que todo fue correcto
            this.Close(); // Cerrás el formulario
        }
    }
}
