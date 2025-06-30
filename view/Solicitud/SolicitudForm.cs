using data.models;
using logic.presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using view.Home;

namespace view.Solicitud
{
    public partial class solicitudForm : Form
    {
        private SolicitudPresenter presenter;

        public solicitudForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            presenter = new SolicitudPresenter();
        }

        private void solicitudForm_Load(object sender, EventArgs e)
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
                        string mensaje = "Solicitud encontrada:" + Environment.NewLine +
                                         "ID: " + solicitud.SolicitudId + Environment.NewLine +
                                         "Mascota: " + (solicitud.Mascota != null ? solicitud.Mascota.nombre : "N/A") + Environment.NewLine +
                                         "Adoptante: " + (solicitud.Adoptante != null ? solicitud.Adoptante.nombre : "N/A") + Environment.NewLine +
                                         "Fecha: " + solicitud.FechaSolicitud.ToShortDateString() + Environment.NewLine +
                                         "Estado: " + solicitud.Estado;
                        MessageBox.Show(mensaje, "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Solicitud no encontrada.");
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido.");
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Implementar lógica para agregar solicitud
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Implementar lógica para eliminar solicitud
        }

        private void buttonModificarForm_Click(object sender, EventArgs e)
        {
            // Implementar lógica para modificar solicitud
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            HomeForm Menu = new HomeForm();
            Menu.ShowDialog();
        }

        private void recargarDgv()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvSolicitudes, new object[] { true });

            List<data.models.Solicitud> solicitudes = presenter.ListarSolicitudes();

            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.Columns.Clear();

            // Columnas personalizadas
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Solicitud ID",
                DataPropertyName = "SolicitudId",
                Name = "SolicitudId"
            });

            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mascota",
                DataPropertyName = "MascotaId",
                Name = "MascotaId"
            });

            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Adoptante",
                DataPropertyName = "AdoptanteId",
                Name = "AdoptanteId"
            });

            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Solicitud",
                DataPropertyName = "FechaSolicitud",
                Name = "FechaSolicitud"
            });

            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                Name = "Estado"
            });

            dgvSolicitudes.DataSource = solicitudes;

            // Estilos visuales
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

            foreach (DataGridViewRow row in dgvSolicitudes.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.DefaultCellStyle.Padding = new Padding(0);
            }

            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
