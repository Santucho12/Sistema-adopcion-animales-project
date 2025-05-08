using System;
using System.Collections.Generic;
//importo estos modulos ya que los tiene que conocer logic
using data.models;
using data.repositories;

//se encarga de conectar la logica de data con la interfaz de view
namespace logic.presenter
{
    public class MascotaPresenter
    {           //creo un atributo de tipo repositoriomascota
        private  RepositorioMascota repoMascota;

        //constructor
        public MascotaPresenter()
        {       //lo inicializo en el constructor
            repoMascota = new RepositorioMascota();
        }

        // Listar todas las mascotas
        public List<Mascota> ObtenerMascotas()
        {       //invocta al metodo listarMascotas de repositorio
            return repoMascota.listarMascotas();
        }

        // Agregar nueva mascota 
        public void AgregarMascota(Mascota nuevaMascota)
        {   //invoca al metodoto del repo
            repoMascota.AgregarMascota(nuevaMascota);
        }

        // Agregar mascota existente
        public void agregarMascota(Mascota mascota)
        {
            if (mascota == null || mascota.id <= 0)
                throw new ArgumentException("La mascota debe tener un ID válido.");

            repoMascota.AgregarMascota(mascota);
        }

        // Eliminar mascota por ID
        public void EliminarMascota(int id)
        {       //invoca del repo
            repoMascota.eliminarMascota(id);
        }

        // Buscar mascota por ID
        public Mascota BuscarMascotaPorId(int id)
        {
            //invoca del repo
            return repoMascota.buscarPorId(id);
        }
    }
}
