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

namespace view.Adoptante
{
    public partial class modificarAdoptanteForm: Form
    {
        public int AdoptanteId { get; set; }
        public modificarAdoptanteForm()
        {

            InitializeComponent();

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de la adoptante que se desea modificar
                int AdoptanteId = this.AdoptanteId;  // Usamos el ID que se pasó desde adoptanteForm
                MessageBox.Show("ID recibido en modificarAdoptanteForm: " + AdoptanteId.ToString());  // Depuración: Verificamos el ID

                // Crear una instancia de la clase adoptantePresenter
                AdoptantePresenter presenter = new AdoptantePresenter();

                // Buscar la adoptante con el ID proporcionado
                data.models.Adoptante adoptanteExistente = presenter.buscarAdoptantePorId(AdoptanteId);

                if (adoptanteExistente != null)
                {
                    // Si el adoptante existe, actualizar sus atributos con los nuevos valores del formulario
                    adoptanteExistente.nombre = textBoxModificarNombre.Text;
                    adoptanteExistente.direccion = textBoxModificarDireccion.Text;
                    adoptanteExistente.telefono = textBoxModificarTelefono.Text;
                    adoptanteExistente.email = textBoxModificareEmail.Text;
                    adoptanteExistente.motivoAdopcion = textBoxModificarMotivo.Text;

                    // Llamar al método para actualizar la doptante en la base de datos o lista
                    presenter.modificarAdoptante(adoptanteExistente);

                    // Confirmación
                    MessageBox.Show("Adoptante modificado correctamente.");

                    // Cerrar el formulario
                    this.Close();
                }
                else
                {
                    // Si no se encuentra la adoptante con ese ID
                    MessageBox.Show("No se encontró el adoptant con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al adoptante la mascota: " + ex.Message);
            }
        }
    }
    
}
