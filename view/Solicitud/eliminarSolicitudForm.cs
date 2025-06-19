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

namespace view.Solicitud
{
    public partial class eliminarSolicitudForm: Form
    {   
        private SolicitudPresenter presenter;
        public eliminarSolicitudForm(SolicitudPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;   
        }

        public eliminarSolicitudForm()
        {
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id;

            // Validar que el ID sea un número
            if (int.TryParse(textBoxIngreseId.Text, out id))
            {
                try
                {
                    presenter.EliminarSolicitud(id);
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

        private void textBoxIngreseId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEliminarTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labelEliminarId_Click(object sender, EventArgs e)
        {

        }
    }
}
