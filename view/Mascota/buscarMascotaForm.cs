using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class buscarMascotaForm: Form
    {   
        public string IdIngresado { get; private set; } 
        public buscarMascotaForm()
        {
            InitializeComponent();
        }

        private void buttonBuscarMascotaForm_Click_1(object sender, EventArgs e)
        {
            IdIngresado = textBoxBuscarMascotaForm.Text;  // Guardás el valor
            this.DialogResult = DialogResult.OK; // Indicás que todo fue correcto
            this.Close(); // Cerrás el formulario
        }

        private void textBoxBuscarMascotaForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBuscarMascotaFormId_Click(object sender, EventArgs e)
        {

        }

        private void labelFormbuscarMascotaTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
