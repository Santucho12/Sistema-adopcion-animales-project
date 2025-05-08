using data.models;
using data.repositories;
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
    public partial class modificarMascotaForm: Form
    {
        public int mascotaId { get; set; }

        public modificarMascotaForm()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de la mascota que se desea modificar
                int mascotaId = this.mascotaId;  // Usamos el ID que se pasó desde mascotaForm
                MessageBox.Show("ID recibido en modificarMascotaForm: " + mascotaId.ToString());  // Depuración: Verificamos el ID

                // Crear una instancia de la clase MascotaPresenter
                MascotaPresenter presenter = new MascotaPresenter();

                // Buscar la mascota con el ID proporcionado
                Mascota mascotaExistente = presenter.BuscarMascotaPorId(mascotaId);

                if (mascotaExistente != null)
                {
                    // Si la mascota existe, actualizar sus atributos con los nuevos valores del formulario
                    mascotaExistente.nombre = textBoxModificarNombre.Text;
                    mascotaExistente.especie = textBoxModificarEspecie.Text;
                    mascotaExistente.raza = textBoxModificarRaza.Text;
                    mascotaExistente.edad = (int)numericUpDownModificar.Value;
                    mascotaExistente.sexo = radioButtonMacho.Checked ? "Macho" : "Hembra";
                    mascotaExistente.estadoAdopcion = radioButtonModificarDisponible.Checked ? "Disponible" : "Adoptada";
                    mascotaExistente.fechaLlegada = dateTimePickerModificarFecha.Value;
                    mascotaExistente.descripcion = textBoxModificarDescripcion.Text;

                    // Llamar al método para actualizar la mascota en la base de datos o lista
                    presenter.ModificarMascota(mascotaExistente);

                    // Confirmación
                    MessageBox.Show("Mascota modificada correctamente.");

                    // Cerrar el formulario
                    this.Close();
                }
                else
                {
                    // Si no se encuentra la mascota con ese ID
                    MessageBox.Show("No se encontró una mascota con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la mascota: " + ex.Message);
            }
        }



        private void labelModificarId_Click(object sender, EventArgs e)
        {

        }
    }
}
