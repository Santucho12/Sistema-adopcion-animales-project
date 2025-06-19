using data.models;
using System;
using System.Collections.Generic;



namespace data.repositories
{
    public class RepositorioMascota
    {
        public List<Mascota> listarMascotasModels()
        {
            List<Mascota> listaMascotas = new List<Mascota>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Mascotas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Mascota aux = new Mascota();
                    aux.id = (int)datos.Lector["Id"];
                    aux.nombre = (string)datos.Lector["nombre"];
                    aux.especie = (string)datos.Lector["especie"];
                    aux.raza = (string)datos.Lector["raza"];
                    aux.edad = (int)datos.Lector["edad"];
                    aux.sexo = (string)datos.Lector["sexo"];
                    aux.descripcion = (string)datos.Lector["descripcion"];
                    aux.estadoAdopcion = (string)datos.Lector["estadoAdopcion"];
                    aux.fechaLlegada = (DateTime)datos.Lector["fechaLlegada"];

                    listaMascotas.Add(aux);
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

            return listaMascotas;       
        }

        public void AgregarMascotaModels(Mascota nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO Mascotas (nombre, especie, raza, edad, sexo, descripcion, estadoAdopcion, fechaLlegada) " +
                                     "VALUES (@nombre, @especie, @raza, @edad, @sexo, @descripcion, @estadoAdopcion, @fechaLlegada)");

                datos.comando.Parameters.AddWithValue("@nombre", nueva.nombre);
                datos.comando.Parameters.AddWithValue("@especie", nueva.especie);
                datos.comando.Parameters.AddWithValue("@raza", nueva.raza);
                datos.comando.Parameters.AddWithValue("@edad", nueva.edad);
                datos.comando.Parameters.AddWithValue("@sexo", nueva.sexo);
                datos.comando.Parameters.AddWithValue("@descripcion", nueva.descripcion);
                datos.comando.Parameters.AddWithValue("@estadoAdopcion", nueva.estadoAdopcion);
                datos.comando.Parameters.AddWithValue("@fechaLlegada", nueva.fechaLlegada);

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


        public void modificarMascotaModels(Mascota nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "UPDATE Mascotas SET ";
                List<string> campos = new List<string>();

                // Agregamos solo los campos que tienen valores válidos
                if (!string.IsNullOrWhiteSpace(nueva.nombre))
                {
                    campos.Add("nombre = @nombre");
                    datos.comando.Parameters.AddWithValue("@nombre", nueva.nombre);
                }
                if (!string.IsNullOrWhiteSpace(nueva.especie))
                {
                    campos.Add("especie = @especie");
                    datos.comando.Parameters.AddWithValue("@especie", nueva.especie);
                }
                if (!string.IsNullOrWhiteSpace(nueva.raza))
                {
                    campos.Add("raza = @raza");
                    datos.comando.Parameters.AddWithValue("@raza", nueva.raza);
                }
                if (nueva.edad != null && nueva.edad >= 0) // edad puede ser 0
                {
                    campos.Add("edad = @edad");
                    datos.comando.Parameters.AddWithValue("@edad", nueva.edad);
                }
                if (!string.IsNullOrWhiteSpace(nueva.sexo))
                {
                    campos.Add("sexo = @sexo");
                    datos.comando.Parameters.AddWithValue("@sexo", nueva.sexo);
                }
                if (!string.IsNullOrWhiteSpace(nueva.descripcion))
                {
                    campos.Add("descripcion = @descripcion");
                    datos.comando.Parameters.AddWithValue("@descripcion", nueva.descripcion);
                }
                if (!string.IsNullOrWhiteSpace(nueva.estadoAdopcion))
                {
                    campos.Add("estadoAdopcion = @estadoAdopcion");
                    datos.comando.Parameters.AddWithValue("@estadoAdopcion", nueva.estadoAdopcion);
                }
                if (nueva.fechaLlegada != null && nueva.fechaLlegada != DateTime.MinValue)
                {
                    campos.Add("fechaLlegada = @fechaLlegada");
                    datos.comando.Parameters.AddWithValue("@fechaLlegada", nueva.fechaLlegada);
                }

                // Si no hay campos válidos, no ejecutamos nada
                if (campos.Count == 0)
                    return;

                // Construcción de la consulta
                consulta += string.Join(", ", campos);
                consulta += " WHERE id = @id";
                datos.comando.Parameters.AddWithValue("@id", nueva.id);

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

        public void eliminarMascotaModels(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM Mascotas WHERE id=@id");
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

        public Mascota buscarPorIdModels(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Mascotas WHERE id=@id");
                datos.comando.Parameters.AddWithValue("@id", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Mascota aux = new Mascota();
                    aux.id = (int)datos.Lector["id"];
                    aux.nombre = (string)datos.Lector["nombre"];
                    aux.especie = (string)datos.Lector["especie"];
                    aux.raza = (string)datos.Lector["raza"];
                    aux.edad = (int)datos.Lector["edad"];
                    aux.sexo = (string)datos.Lector["sexo"];
                    aux.descripcion = (string)datos.Lector["descripcion"];
                    aux.estadoAdopcion = (string)datos.Lector["estadoAdopcion"];
                    aux.fechaLlegada = (DateTime)datos.Lector["fechaLlegada"];

                    return aux;
                }

                return null;
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
