using data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace data.repositories
{
    public class RepositorioAdoptante
    {
        public List<Adoptante> listarAdoptantesModel()
        {
            List<Adoptante> listaAdoptantes = new List<Adoptante>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Adoptantes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Adoptante adoptante = new Adoptante();
                    adoptante.id = (int)datos.Lector["adoptanteId"];
                    adoptante.nombre = (string)datos.Lector["Nombre"];
                    adoptante.direccion = (string)datos.Lector["Direccion"];
                    adoptante.telefono = (string)datos.Lector["Telefono"];
                    adoptante.email = (string)datos.Lector["Email"];
                    adoptante.motivoAdopcion = (string)datos.Lector["MotivoAdopcion"];

                    listaAdoptantes.Add(adoptante);
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

            return listaAdoptantes;
        }
        public void AgregarAdoptanteModel(Adoptante nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Adoptantes (Nombre, Direccion, Telefono, Email, MotivoAdopcion) " +
                                     "VALUES (@nombre, @direccion, @telefono, @email, @motivoAdopcion)");


                datos.comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
                datos.comando.Parameters.AddWithValue("@direccion", nuevo.direccion);
                datos.comando.Parameters.AddWithValue("@telefono", nuevo.telefono);
                datos.comando.Parameters.AddWithValue("@email", nuevo.email);
                datos.comando.Parameters.AddWithValue("@motivoAdopcion", nuevo.motivoAdopcion);


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
        public void ModificarAdoptanteModel(Adoptante modificado)
        {


            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "UPDATE Adoptantes SET";
                List<string> campos = new List<string>();


                if (!string.IsNullOrWhiteSpace(modificado.nombre))
                {
                    campos.Add("Nombre = @nombre");
                    datos.comando.Parameters.AddWithValue("@nombre", modificado.nombre);
                }
                if (!string.IsNullOrWhiteSpace(modificado.direccion)) {

                    campos.Add("Direccion =@direccion");
                    datos.comando.Parameters.AddWithValue("@direccion", modificado.direccion);
                }
                if (!string.IsNullOrWhiteSpace(modificado.telefono))
                {
                    campos.Add("Telefono =@telefono");
                    datos.comando.Parameters.AddWithValue("@telefono",modificado.telefono);

                }
                if (!string.IsNullOrWhiteSpace(modificado.email))
                {
                    campos.Add("Email =@email");
                    datos.comando.Parameters.AddWithValue("@email", modificado.email);
                }
                if (!string.IsNullOrWhiteSpace(modificado.motivoAdopcion))
                {
                    campos.Add("MotivoAdopcion =@motivoAdopcion");
                    datos.comando.Parameters.AddWithValue("@motivoAdopcion", modificado.motivoAdopcion);
                }

                if (campos.Count == 0)
                {
                    return;
                }

                consulta += " " + string.Join(", ", campos) + " WHERE AdoptanteId = @id";
                datos.comando.Parameters.AddWithValue("@id", modificado.id);
                
                datos.setearConsulta(consulta);
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
        public void EliminarAdoptanteModel(int id)
        {

            AccesoDatos datos = new AccesoDatos();

         try
            {
                datos.setearConsulta("DELETE FROM Adoptantes WHERE AdoptanteId = @id");
                datos.comando.Parameters.AddWithValue("@id", id);
                
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

        // El error es un desbalance de llaves en el método BuscarAdoptantePorIdModel.
        // La llave de cierre del bloque else está mal alineada y falta una llave de cierre antes del catch.
        // Así debe quedar el método corregido:

        public Adoptante BuscarAdoptantePorIdModel(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * from Adoptantes where AdoptanteId = @id");
                datos.comando.Parameters.AddWithValue("@id", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Adoptante adoptante = new Adoptante();
                    adoptante.id = (int)datos.Lector["AdoptanteId"];
                    adoptante.nombre = (string)datos.Lector["Nombre"];
                    adoptante.direccion = (string)datos.Lector["Direccion"];
                    adoptante.telefono = (string)datos.Lector["Telefono"];
                    adoptante.email = (string)datos.Lector["Email"];
                    adoptante.motivoAdopcion = (string)datos.Lector["MotivoAdopcion"];
                    return adoptante;
                }
                else
                {
                    return null;
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
        }
    
    }
}