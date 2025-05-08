using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using data.models;
using System.Drawing;

namespace view
{
    public partial class mascotaForm : Form
    {       //atributo de presenter
        private MascotaPresenter presenter;

        //constructor
        public mascotaForm()
        {   //ejecuta el codigo del designer
            InitializeComponent();
            // Inicializar el presenter
            presenter = new MascotaPresenter();
        }

        private void mascotaForm_Load(object sender, EventArgs e)
        {//a la lista mascotas le asigna el metodo de presenter obtener mascotas proveniente del repo(listarMascotas)
            List<Mascota> mascotas = presenter.ObtenerMascotas();
            //le asigna al dgv  la lista de mascotas de arriba
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

            // Actualiza el DataGridView cuando se cierre el formulario de agregar
            agregarMascota.FormClosed += (s, args) =>
            {
                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = presenter.ObtenerMascotas();
            };

            agregarMascota.ShowDialog();
        }



    }

}
