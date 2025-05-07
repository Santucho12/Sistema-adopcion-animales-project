using System;
using System.Collections.Generic;
using data.models;
using data.repositories;

namespace logic.presenter
{
    public class MascotaPresenter
    {
        private readonly RepositorioMascota repositorio;

        public MascotaPresenter()
        {
            repositorio = new RepositorioMascota();
        }

        // Listar todas las mascotas
        public List<Mascota> ObtenerMascotas()
        {
            return repositorio.listarMascotas();
        }

        // Agregar nueva mascota con validación
        public void AgregarMascota(Mascota nuevaMascota)
        {
            if (nuevaMascota == null)
                throw new ArgumentNullException(nameof(nuevaMascota), "La mascota no puede ser nula.");

            if (string.IsNullOrWhiteSpace(nuevaMascota.nombre))
                throw new ArgumentException("El nombre de la mascota es obligatorio.");

            repositorio.agregarMascota(nuevaMascota);
        }

        // Modificar mascota existente
        public void ModificarMascota(Mascota mascota)
        {
            if (mascota == null || mascota.id <= 0)
                throw new ArgumentException("La mascota debe tener un ID válido.");

            repositorio.modificarMascota(mascota);
        }

        // Eliminar mascota por ID
        public void EliminarMascota(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor a cero.");

            repositorio.eliminarMascota(id);
        }

        // Buscar mascota por ID
        public Mascota BuscarMascotaPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor a cero.");

            return repositorio.buscarPorId(id);
        }
    }
}
