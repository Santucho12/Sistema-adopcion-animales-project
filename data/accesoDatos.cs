using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso ado.net y este using me permite los sqlcommand,conexion y executedatareader
using System.Data.SqlClient;

//define conexiones a bd para el uso de las funciones de la clase
namespace data
{
    class AccesoDatos
    {
        private SqlConnection conexion;
        //publico porque quiero que se pueda acceder para setear la consulta
        public SqlCommand comando;
        private SqlDataReader lector;
        //tiene la funcion de obtener para que de afuera se pueda saber que contiene para recorrerlo
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //constructor de la case accesodatos,nace con los datos para conectarse a la base de datos
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=SANTIAGO\\SQLEXPRESS ; database=AdopcionMascotas ; Integrated Security=True");
            //se establece el comando que se va a usar posteriormente para setear la consulta
            comando = new SqlCommand();
        }

        //recibe la consulta como un string
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            //la asigna a comando
            comando.CommandText = consulta;
        }

        //traer todos los datos de la db
        public void ejecutarLectura()
        {
            //establece la conexion
            comando.Connection = conexion;

            try
            {
                //abre la conexion
                conexion.Open();
                //ejecuta executereader porque es solo lectura(select)
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {   //establece la conexion
            comando.Connection = conexion;

            try
            {
                //abre la conexion
                conexion.Open();
                //a diferencia de la lectura aca se usa executenonqueery ya que es una accion(update,insert,delete)
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {   //si el lector esta vacio lo cierra,uego cierra la conexion
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
