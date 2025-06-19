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
        public List<Mascota> listarMascotas()
        {       //invocta al metodo listarMascotas de repositorio
            return repoMascota.listarMascotasModels();
        }

        // Agregar nueva mascota 
        public void agregarMascota(Mascota nuevaMascota)
        {   //invoca al metodoto del repo
            repoMascota.AgregarMascotaModels(nuevaMascota);
        }

        // modificar nueva mascota 
        public void modificarMascota(Mascota nuevaMascota)
        {   //invoca al metodoto del repo
            repoMascota.modificarMascotaModels(nuevaMascota);
        }



        // Eliminar mascota por ID
        public void eliminarMascota(int id)
        {       //invoca del repo
            repoMascota.eliminarMascotaModels(id);
        }

        // Buscar mascota por ID
        public Mascota buscarMascotaPorId(int id)
        {
            //invoca del repo
            return repoMascota.buscarPorIdModels(id);
        }
    }
}
