using System;
using System.Collections.Generic;
using System.Windows.Forms;
using logic.presenter;
using data.models;
using System.Drawing;

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
            recargarDgv();

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
               recargarDgv();
            };

            agregarMascota.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminarMascotaForm eliminarMascota = new eliminarMascotaForm();

            eliminarMascota.FormClosed += (s, args) =>
            {
                recargarDgv();
            };

            eliminarMascota.ShowDialog();
        }

        private void buttonModificarForm_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentCell != null)
            {
                // Verifica si la celda seleccionada pertenece a la columna "Id"
                string nombreColumna = dgvMascotas.Columns[dgvMascotas.CurrentCell.ColumnIndex].Name;

                if (nombreColumna == "id")
                {
                    int rowIndex = dgvMascotas.CurrentCell.RowIndex;
                    object valorId = dgvMascotas.Rows[rowIndex].Cells["id"].Value;

                    if (valorId != null && int.TryParse(valorId.ToString(), out int mascotaId))
                    {
                        MessageBox.Show("ID seleccionado: " + mascotaId.ToString());

                        modificarMascotaForm modificarMascota = new modificarMascotaForm
                        {
                            mascotaId = mascotaId
                        };

                        modificarMascota.FormClosed += (s, args) => recargarDgv();
                        modificarMascota.ShowDialog();
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

      
        private void recargarDgv()
        {
            // 🔧 Activar doble buffer para scroll más fluido
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvMascotas, new object[] { true });

            List<Mascota> mascotas = presenter.ObtenerMascotas();
            dgvMascotas.DataSource = mascotas;

            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMascotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvMascotas.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvMascotas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 🟧 Estilo de encabezado (gris oscuro, blanco, centrado)
            dgvMascotas.EnableHeadersVisualStyles = false;
            dgvMascotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); // Gris oscuro
            dgvMascotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMascotas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMascotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMascotas.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 5, 0, 5);
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMascotas.ColumnHeadersHeight = 40;

            // 🟨 Estilo general del DGV
            dgvMascotas.BorderStyle = BorderStyle.None;
            dgvMascotas.CellBorderStyle = DataGridViewCellBorderStyle.None; // más suave
            dgvMascotas.GridColor = Color.LightGray;
            dgvMascotas.RowHeadersVisible = false;

            // 🟩 Estilo de filas alternadas (blanco y gris claro)
            dgvMascotas.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMascotas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // 🟦 Estilo especial para columna Descripción
            var colDescripcion = dgvMascotas.Columns["descripcion"];
            var colSexo = dgvMascotas.Columns["Sexo"];
            var colEdad = dgvMascotas.Columns["Edad"];
            var colId = dgvMascotas.Columns["Id"];

            if (colDescripcion != null)
            {
                colDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                colDescripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colDescripcion.DefaultCellStyle.Padding = new Padding(16, 4, 16, 4); // Simula 2 espacios
                colSexo.Width = 130;
                colEdad.Width = 130;
                colId.Width = 90;
                colDescripcion.Width = 290;
            }

            // 🟪 Asegurar uniformidad fila por fila
            foreach (DataGridViewRow row in dgvMascotas.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.DefaultCellStyle.Padding = new Padding( 0 );
            }
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



    }

}

