using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.models;
using data.repositories;

namespace logic.presenter
{
    public class AdoptantePresenter
    {
        private RepositorioAdoptante repoAdoptante;
    public AdoptantePresenter()
        {
            repoAdoptante = new RepositorioAdoptante();
        }
        public List<Adoptante> listarAdoptantes()
        {
            return repoAdoptante.listarAdoptantesModel();
        }

        public void agregarAdoptante(Adoptante nuevo)
        {
            repoAdoptante.AgregarAdoptanteModel(nuevo);
        }

        public void modificarAdoptante(Adoptante modificado)
        {
            repoAdoptante.ModificarAdoptanteModel(modificado);
        }

        public void eliminarAdoptante(int id)
        {
            repoAdoptante.EliminarAdoptanteModel(id);
        }

        public Adoptante buscarAdoptantePorId(int id)
        {
            return repoAdoptante.BuscarAdoptantePorIdModel(id);
        }
    }

    }
