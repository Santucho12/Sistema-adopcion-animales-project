using System;


///definir los atributos y constructor de la clase
namespace data.models
{
    public class Mascota
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string descripcion { get; set; }
        public string estadoAdopcion { get; set; }
        public DateTime fechaLlegada { get; set; }

        public Mascota()
        {
            // constructor vacio
        }

        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Especie: {especie}, Raza: {raza}, Edad: {edad}, Sexo: {sexo}, Descripción: {descripcion}, Estado de Adopción: {estadoAdopcion}, Fecha de Llegada: {fechaLlegada.ToShortDateString()}";
        }


        // constructorr con parametros
        public Mascota(int id, string nombre, string especie, string raza, int edad, string sexo, string descripcion, string estadoAdopcion, DateTime fechaLlegada)
        {
            this.id = id;
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo;
            this.descripcion = descripcion;
            this.estadoAdopcion = estadoAdopcion;
            this.fechaLlegada = fechaLlegada;
        }
    }
}
