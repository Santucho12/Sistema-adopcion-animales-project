using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using AdoptanteModel = data.models.Adoptante;
using System.Drawing;
using view.Adoptante;
using data.models;
using view.Home;

namespace view
{
    public partial class adoptanteForm : Form
    {
        private AdoptantePresenter presenter;

        public adoptanteForm()
        {
            InitializeComponent();
            presenter = new AdoptantePresenter();
        }

      
        private void recargarDgv()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvAdoptantes, new object[] { true });

            this.WindowState = FormWindowState.Maximized;

            List<AdoptanteModel> adoptantes = presenter.listarAdoptantes();

            dgvAdoptantes.DataSource = adoptantes;

            dgvAdoptantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdoptantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdoptantes.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvAdoptantes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdoptantes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAdoptantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvAdoptantes.EnableHeadersVisualStyles = false;
            dgvAdoptantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvAdoptantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAdoptantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdoptantes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAdoptantes.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 5, 0, 5);
            dgvAdoptantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAdoptantes.ColumnHeadersHeight = 40;

            dgvAdoptantes.BorderStyle = BorderStyle.None;
            dgvAdoptantes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAdoptantes.GridColor = Color.LightGray;
            dgvAdoptantes.RowHeadersVisible = false;

            dgvAdoptantes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAdoptantes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            var colId = dgvAdoptantes.Columns["Id"];
            var colNombre = dgvAdoptantes.Columns["Nombre"];
            var colTelefono = dgvAdoptantes.Columns["Telefono"];
            var colMotivo = dgvAdoptantes.Columns["motivoAdopcion"];

            if (colId != null)
            {
                colId.Width = 150;
                colNombre.Width = 200;
                colTelefono.Width = 180;
                colMotivo.Width = 300;
            }

            foreach (DataGridViewRow row in dgvAdoptantes.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.DefaultCellStyle.Padding = new Padding(0);
            }

            dgvAdoptantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void adoptanteForm_Load_1(object sender, EventArgs e)
        {
            recargarDgv();
        }

       

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de búsqueda
            buscarAdoptanteForm buscarAdoptante = new buscarAdoptanteForm();

            // Mostrar el formulario y esperar a que el usuario lo cierre
            if (buscarAdoptante.ShowDialog() == DialogResult.OK)  // Verificamos si el formulario se cerró correctamente
            {
                // Obtener el ID ingresado por el usuario
                string idIngresado = buscarAdoptante.IdIngresado;

                int id = 0;
                if (int.TryParse(idIngresado, out id))  // Convertimos el valor de texto a entero
                {
                    // Crear una instancia de MascotaPresenter (si no la tienes ya creada)
                    AdoptantePresenter adoptantePresenter = new AdoptantePresenter();

                    // Llamar a BuscarMascotaPorId con el ID ingresado
                    data.models.Adoptante adoptante = adoptantePresenter.buscarAdoptantePorId(id);


                    // Si la mascota se encuentra, mostrar sus datos
                    if (adoptante != null)
                    {
                        MessageBox.Show($"Adoptante encontrado:\nNombre: {adoptante.nombre}\nDirección: {adoptante.direccion}\nTeléfono: {adoptante.telefono}");

                    }
                    else
                    {
                        MessageBox.Show("adoptante no encontrada.");
                    }
                }
            }

        }

      

        private void buttonModificarForm_Click(object sender, EventArgs e)
        {
            if (dgvAdoptantes.CurrentCell != null)
            {
                // Verifica si la celda seleccionada pertenece a la columna "Id"
                string nombreColumna = dgvAdoptantes.Columns[dgvAdoptantes.CurrentCell.ColumnIndex].Name;

                if (nombreColumna == "id")
                {
                    int rowIndex = dgvAdoptantes.CurrentCell.RowIndex;
                    object valorId = dgvAdoptantes.Rows[rowIndex].Cells["id"].Value;

                    if (valorId != null && int.TryParse(valorId.ToString(), out int AdoptanteId))
                    {
                        MessageBox.Show("ID seleccionado: " + AdoptanteId.ToString());

                        modificarAdoptanteForm modificarAdoptante = new modificarAdoptanteForm
                        {
                            AdoptanteId = AdoptanteId
                        };

                        modificarAdoptante.FormClosed += (s, args) => recargarDgv();
                        modificarAdoptante.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debes hacer clic en una celda de la columna 'Id' para modificar.", "Columna incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una celda de la columna 'Id' antes de continuar.", "Ninguna celda seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarAdoptanteForm eliminarAdoptante = new eliminarAdoptanteForm();

            eliminarAdoptante.FormClosed += (s, args) =>
            {
                recargarDgv();
            };

            eliminarAdoptante.ShowDialog();
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            {
                agregarAdoptanteForm1 agregarAdoptante = new agregarAdoptanteForm1();


                // Actualiza el DataGridView cuando se cierre el formulario de Agregar
                agregarAdoptante.FormClosed += (s, args) =>
                {
                    recargarDgv();
                };

                agregarAdoptante.ShowDialog();
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            HomeForm Menu = new HomeForm();


            // Actualiza el DataGridView cuando se cierre el formulario de Agregar


            Menu.ShowDialog();
        }
        }
    
}
