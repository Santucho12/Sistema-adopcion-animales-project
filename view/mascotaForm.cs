using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using data.models;

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
        }

       
    }
}
