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

namespace view
{
    public partial class agregarMascotaForm : Form
    {
        public agregarMascotaForm()
        {
            InitializeComponent();
        }

        private void buttonAgregarEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota nuevaMascota = new Mascota();

                nuevaMascota.nombre = textBoxAgregarNombre.Text;
                nuevaMascota.especie = textBoxAgregarEspecie.Text;
                nuevaMascota.raza = textBoxAgregarRaza.Text;
                nuevaMascota.edad = (int)numericUpDownAgregarEdad.Value;
                nuevaMascota.sexo = radioButtonAgregarMacho.Checked ? "Macho" : "Hembra";
                nuevaMascota.estadoAdopcion = radioButtonAgregarDisponible.Checked ? "Disponible" : "Adoptado";
                nuevaMascota.fechaLlegada = dateTimePickerAgregarFecha.Value;
                nuevaMascota.descripcion = textBoxAgregarDescripcion.Text;

                MascotaPresenter listaMascotas = new MascotaPresenter();
                listaMascotas.agregarMascota(nuevaMascota);

                MessageBox.Show("Mascota agregada correctamente.");

               

                this.Close(); // Cierra el formulario si lo deseas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar mascota: " + ex.Message);
            }
        }

       
    }
}
