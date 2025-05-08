using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using data.models;

namespace view
{
    public partial class mascotaForm : Form
    {
        // Atributo de presenter
        private MascotaPresenter presenter;

        // Constructor
        public mascotaForm()
        {
            // Ejecuta el código del diseñador
            InitializeComponent();
            // Inicializar el presenter
            presenter = new MascotaPresenter();
        }

        private void mascotaForm_Load(object sender, EventArgs e)
        {
            // A la lista de mascotas le asigna el método de presenter obtener mascotas proveniente del repo (listarMascotas)
            List<Mascota> mascotas = presenter.ObtenerMascotas();
            // Le asigna al dgv la lista de mascotas de arriba
            dgvMascotas.DataSource = mascotas;
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de búsqueda
            buscarMascotaForm buscarMascota = new buscarMascotaForm();

            // Mostrar el formulario y esperar a que el usuario lo cierre
            if (buscarMascota.ShowDialog() == DialogResult.OK)  // Verificamos si el formulario se cerró correctamente
            {
                // Obtener el ID ingresado por el usuario
                string idIngresado = buscarMascota.IdIngresado;

                int id = 0;
                if (int.TryParse(idIngresado, out id))  // Convertimos el valor de texto a entero
                {
                    // Crear una instancia de MascotaPresenter (si no la tienes ya creada)
                    MascotaPresenter mascotaPresenter = new MascotaPresenter();

                    // Llamar a BuscarMascotaPorId con el ID ingresado
                    Mascota mascota = mascotaPresenter.BuscarMascotaPorId(id);

                    // Si la mascota se encuentra, mostrar sus datos
                    if (mascota != null)
                    {
                        MessageBox.Show($"Mascota encontrada: {mascota.nombre}, {mascota.especie}");
                    }
                    else
                    {
                        MessageBox.Show("Mascota no encontrada.");
                    }
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            agregarMascotaForm agregarMascota = new agregarMascotaForm();

            // Actualiza el DataGridView cuando se cierre el formulario de Agregar
            agregarMascota.FormClosed += (s, args) =>
            {
                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = presenter.ObtenerMascotas();
            };

            agregarMascota.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarMascotaForm eliminarMascota = new eliminarMascotaForm();

            eliminarMascota.FormClosed += (s, args) =>
            {
                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = presenter.ObtenerMascotas();
            };

            eliminarMascota.ShowDialog();
        }

        private void buttonModificarForm_Click(object sender, EventArgs e)
        {
            // Asegúrate de que se haya seleccionado una fila en el DataGridView
            if (dgvMascotas.SelectedRows.Count > 0)
            {
                // Obtener el ID de la mascota seleccionada (suponiendo que el ID está en la primera columna)
                int mascotaId = Convert.ToInt32(dgvMascotas.SelectedRows[0].Cells[0].Value);
                MessageBox.Show("ID seleccionado: " + mascotaId.ToString());  // Depuración: Verificamos el ID

                // Crear una instancia del formulario de modificación
                modificarMascotaForm modificarMascota = new modificarMascotaForm();

                // Pasamos el ID de la mascota a modificar
                modificarMascota.mascotaId = mascotaId;

                // Manejar el evento FormClosed para actualizar el DataGridView después de cerrar el formulario
                modificarMascota.FormClosed += (s, args) =>
                {
                    // Actualizar el DataGridView con las mascotas modificadas
                    dgvMascotas.DataSource = null;  // Limpiar la fuente de datos
                    dgvMascotas.DataSource = presenter.ObtenerMascotas();  // Volver a cargar los datos
                };

                // Mostrar el formulario de modificación
                modificarMascota.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona la flecha al lado del ID de una mascota para modificar.");
            }
        }

    }
}
