using data.models;
using data.repositories;
using System.Collections.Generic;

namespace logic.presenter
{
    public class SolicitudPresenter
    {
        private RepositorioSolicitud repoSolicitud;

        public SolicitudPresenter()
        {
            repoSolicitud = new RepositorioSolicitud();
        }

        public List<Solicitud> ListarSolicitudes()
        {
            return repoSolicitud.ListarSolicitudesModel();
        }

        public void AgregarSolicitud(Solicitud nueva)
        {
            repoSolicitud.AgregarSolicitudModel(nueva);
        }

        public void ModificarSolicitud(Solicitud modificada)
        {
            repoSolicitud.ModificarSolicitudModel(modificada);
        }

        public void EliminarSolicitud(int id)
        {
            repoSolicitud.EliminarSolicitudModel(id);
        }

        public Solicitud BuscarSolicitudPorId(int id)
        {
            return repoSolicitud.BuscarPorIDModel(id);
        }
    }
}
