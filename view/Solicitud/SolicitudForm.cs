using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using logic.presenter;
using view.Home;
using data.models; // Importa el modelo

namespace view.Solicitud
{
    public partial class SolicitudForm : Form
    {
        private SolicitudPresenter presenter;

        public SolicitudForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            presenter = new SolicitudPresenter();
        }

        private void SolicitudForm_Load(object sender, EventArgs e)
        {
            recargarDgv();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarSolicitudForm buscarSolicitud = new buscarSolicitudForm();

            if (buscarSolicitud.ShowDialog() == DialogResult.OK)
            {
                string idIngresado = buscarSolicitud.IdIngresado;

                if (int.TryParse(idIngresado, out int id))
                {
                    data.models.Solicitud solicitud = presenter.BuscarSolicitudPorId(id);

                    if (solicitud != null)
                    {
                        MessageBox.Show($"Solicitud encontrada: {solicitud.Estado}, {solicitud.FechaSolicitud.ToShortDateString()}");
                    }
                    else
                    {
                        MessageBox.Show("Solicitud no encontrada.");
                    }
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            agregarSolicitudForm agregarSolicitud = new agregarSolicitudForm();
            agregarSolicitud.FormClosed += (s, args) => recargarDgv();
            agregarSolicitud.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Código comentado. Se puede revisar si querés activarlo.
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarSolicitudForm eliminarSolicitud = new eliminarSolicitudForm(presenter);
            eliminarSolicitud.FormClosed += (s, args) => recargarDgv();
            eliminarSolicitud.ShowDialog();
        }

        private void recargarDgv()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvSolicitudes, new object[] { true });

            List<data.models.Solicitud> solicitudes = presenter.ListarSolicitudes();
            dgvSolicitudes.DataSource = solicitudes;

            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSolicitudes.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvSolicitudes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSolicitudes.EnableHeadersVisualStyles = false;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 5, 0, 5);
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSolicitudes.ColumnHeadersHeight = 40;

            dgvSolicitudes.BorderStyle = BorderStyle.None;
            dgvSolicitudes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSolicitudes.GridColor = Color.LightGray;
            dgvSolicitudes.RowHeadersVisible = false;

            dgvSolicitudes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvSolicitudes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            var colDescripcion = dgvSolicitudes.Columns["descripcion"];
            var colTipo = dgvSolicitudes.Columns["tipo"];
            var colFecha = dgvSolicitudes.Columns["fecha"];
            var colId = dgvSolicitudes.Columns["id"];

            if (colDescripcion != null)
            {
                colDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                colDescripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colDescripcion.DefaultCellStyle.Padding = new Padding(16, 4, 16, 4);
                colTipo.Width = 130;
                colFecha.Width = 130;
                colId.Width = 90;
                colDescripcion.Width = 290;
            }

            foreach (DataGridViewRow row in dgvSolicitudes.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.DefaultCellStyle.Padding = new Padding(0);
            }

            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            HomeForm Menu = new HomeForm();
            Menu.ShowDialog();
        }
    }
}
