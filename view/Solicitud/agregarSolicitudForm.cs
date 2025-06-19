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
    public partial class agregarSolicitudForm : Form
    {
        public agregarSolicitudForm()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                data.models.Solicitud SolicitudNueva = new data.models.Solicitud();


                SolicitudNueva.Mascota = new data.models.Mascota { id = int.Parse(textBoxAgregarMascotaId.Text) };
                SolicitudNueva.Adoptante = new data.models.Adoptante { id = int.Parse(textBoxAgregarAdoptanteId.Text) };
                SolicitudNueva.FechaSolicitud = dateTimePicker1.Value;
                SolicitudNueva.Estado = radioButton1.Checked ? "Aprobado" :
                radioButton2.Checked ? "Rechazado" :
                radioButton3.Checked ? "Pendiente" : "Sin seleccionar";


                SolicitudPresenter listaSolicitudes = new SolicitudPresenter();
                listaSolicitudes.AgregarSolicitud(SolicitudNueva);

                MessageBox.Show("solicitud agregada correctamente.");



                this.Close(); // Cierra el formulario si lo deseas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar solicitud: " + ex.Message);
            }
        }
    }


}

