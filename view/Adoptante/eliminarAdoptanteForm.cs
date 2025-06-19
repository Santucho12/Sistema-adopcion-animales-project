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
    public partial class eliminarAdoptanteForm: Form
    {
        public eliminarAdoptanteForm()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id;

            // Validar que el ID sea un número
            if (int.TryParse(textBoxIngreseId.Text, out id))
            {
                try
                {   
                    AdoptantePresenter presenter = new AdoptantePresenter();
                    presenter.eliminarAdoptante(id);
                    MessageBox.Show("Mascota eliminada correctamente.");
                    this.Close(); // Esto permite refrescar el DataGridView en el formulario principal
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la mascota: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID válido.");
            }
        }
    }
}
