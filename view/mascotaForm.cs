using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using data.models;

namespace view
{
    public partial class mascotaForm : Form
    {
        private MascotaPresenter presenter;

        public mascotaForm()
        {
            InitializeComponent();
            presenter = new MascotaPresenter();
        }

        private void mascotaForm_Load(object sender, EventArgs e)
        {
            CargarMascotas();
        }

        private void CargarMascotas()
        {
            List<Mascota> mascotas = presenter.ObtenerMascotas();

            // Suponiendo que tenés un DataGridView llamado dgvMascotas
            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = mascotas;
        }

       
    }
}
