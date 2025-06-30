using System;

namespace data.models
{
    public class Solicitud
    {
        public int SolicitudId { get; set; }

        public Mascota Mascota { get; set; }

        public Adoptante Adoptante { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public string Estado { get; set; }

        public Solicitud()
        {
            // Constructor vacío
        }

        public int MascotaId => Mascota?.id ?? 0;
        public int AdoptanteId => Adoptante?.id ?? 0;
        public Solicitud(int solicitudId, Mascota mascota, Adoptante adoptante, DateTime fechaSolicitud, string estado)
        {
            this.SolicitudId = solicitudId;
            this.Mascota = mascota;
            this.Adoptante = adoptante;
            this.FechaSolicitud = fechaSolicitud;
            this.Estado = estado;
        }

        public override string ToString()
        {
            return $"Solicitud ID: {SolicitudId}, Mascota: {Mascota?.nombre}, Adoptante: {Adoptante?.nombre}, Fecha de Solicitud: {FechaSolicitud.ToShortDateString()}, Estado: {Estado}";
        }
    }
}
    