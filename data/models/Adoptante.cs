using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.models
{
    public class Adoptante
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public string email { get; set; }

        public string motivoAdopcion { get; set; }


    

    public Adoptante()
        {
            //constructor vacio
        }

        public Adoptante(int id, string nombre, string direccion, string telefono, string email, string motivoAdopcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.motivoAdopcion = motivoAdopcion;

        }

        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Dirección: {direccion}, Teléfono: {telefono}, Email: {email}, Motivo de Adopción: {motivoAdopcion}";
        }

    }
}
