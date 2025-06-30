using data.models;
using System;
using System.Collections.Generic;

namespace data.repositories
{
    public class RepositorioSolicitud
    {
        public List<Solicitud> ListarSolicitudesModel()
        {
            List<Solicitud> listaSolicitudes = new List<Solicitud>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Solicitudes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Solicitud aux = new Solicitud();

                    aux.SolicitudId = (int)datos.Lector["SolicitudId"];

                    aux.Mascota = new Mascota
                    {
                        id = (int)datos.Lector["MascotaId"]
                    };

                    aux.Adoptante = new Adoptante
                    {
                        id = (int)datos.Lector["AdoptanteId"]
                    };

                    aux.FechaSolicitud = (DateTime)datos.Lector["FechaSolicitud"];
                    aux.Estado = (string)datos.Lector["Estado"];

                    listaSolicitudes.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return listaSolicitudes;
        }

        public void AgregarSolicitudModel(Solicitud nuevaSolicitud)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Solicitudes (MascotaId, AdoptanteId, FechaSolicitud, Estado) " +
                                     "VALUES (@mascotaId, @adoptanteId, @fechaSolicitud, @estado)");
                datos.comando.Parameters.AddWithValue("@mascotaId", nuevaSolicitud.Mascota.id);
                datos.comando.Parameters.AddWithValue("@adoptanteId", nuevaSolicitud.Adoptante.id);
                datos.comando.Parameters.AddWithValue("@fechaSolicitud", nuevaSolicitud.FechaSolicitud);
                datos.comando.Parameters.AddWithValue("@estado", nuevaSolicitud.Estado);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarSolicitudModel(Solicitud modificada)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Solicitudes SET MascotaId = @mascotaId, AdoptanteId = @adoptanteId, FechaSolicitud = @fechaSolicitud, Estado = @estado WHERE SolicitudId = @solicitudId");
                datos.comando.Parameters.AddWithValue("@mascotaId", modificada.Mascota.id);
                datos.comando.Parameters.AddWithValue("@adoptanteId", modificada.Adoptante.id);
                datos.comando.Parameters.AddWithValue("@fechaSolicitud", modificada.FechaSolicitud);
                datos.comando.Parameters.AddWithValue("@estado", modificada.Estado);
                datos.comando.Parameters.AddWithValue("@solicitudId", modificada.SolicitudId);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void EliminarSolicitudModel(int solicitudId)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Solicitudes WHERE SolicitudId = @solicitudId");
                datos.comando.Parameters.AddWithValue("@solicitudId", solicitudId);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Solicitud BuscarPorIDModel(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Solicitud solicitud = null;
            try
            {
                datos.setearConsulta(
     @"SELECT s.SolicitudId, s.MascotaId, m.Nombre AS NombreMascota,
             s.AdoptanteId, a.Nombre AS NombreAdoptante,
             s.FechaSolicitud, s.Estado
      FROM Solicitudes s
      JOIN Mascotas m ON s.MascotaId = m.Id
      JOIN Adoptantes a ON s.AdoptanteId = a.AdoptanteId
      WHERE s.SolicitudId = @id");


                datos.comando.Parameters.AddWithValue("@id", id);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    solicitud = new Solicitud
                    {
                        SolicitudId = (int)datos.Lector["SolicitudId"],
                        Mascota = new Mascota
                        {
                            id = (int)datos.Lector["MascotaId"],
                            nombre = datos.Lector["NombreMascota"].ToString()
                        },
                        Adoptante = new Adoptante
                        {
                            id = (int)datos.Lector["AdoptanteId"],
                            nombre = datos.Lector["NombreAdoptante"].ToString()
                        },
                        FechaSolicitud = (DateTime)datos.Lector["FechaSolicitud"],
                        Estado = datos.Lector["Estado"].ToString()
                    };

                }
            }
         
               catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarPorIDModel: " + ex.Message);
                throw; // O elimina esta línea si solo quieres ver el error sin interrumpir
            }

     
            finally
            {
                datos.cerrarConexion();
            }
            return solicitud;
        }
    }
}
