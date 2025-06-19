using data.models;
using logic.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data.models;


namespace view.Adoptante
{
    public partial class agregarAdoptanteForm1 : Form
    {
        public agregarAdoptanteForm1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                data.models.Adoptante AdoptanteNuevo = new data.models.Adoptante();


                AdoptanteNuevo.nombre = textBoxAgregarNombre.Text;
                AdoptanteNuevo.direccion = textBoxAgregarDireccion.Text;
                AdoptanteNuevo.telefono = textBoxAgregarTelefono.Text;
                AdoptanteNuevo.email = textBoxEmail.Text;
                AdoptanteNuevo.motivoAdopcion = textBoxAgregarMotivo.Text;


                AdoptantePresenter listaAdoptantes = new AdoptantePresenter();
                listaAdoptantes.agregarAdoptante(AdoptanteNuevo);

                MessageBox.Show("Adoptante agregado correctamente.");



                this.Close(); // Cierra el formulario si lo deseas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar adoptante: " + ex.Message);
            }
        }
    }
}