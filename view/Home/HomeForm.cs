using System;
using System.Drawing;
using System.Windows.Forms;
// Asegúrate que el namespace de SolicitudForm es view.Solicitud y que está en el proyecto referenciado
using view.Solicitud;

namespace view.Home
{
    public partial class HomeForm : Form
    {
        private Button buttonVerMascotas;
        private Button buttonVerAdoptantes;
        private Button buttonVerSolicitudes;
        private Label titulo;
        private Label subtitulo;
        private Label footer;

        public HomeForm()
        {
            InitializeComponent();
            this.Text = "🐾 Sistema de adopción de mascotas";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(245, 245, 245); // Gris claro
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarControles();

            // Redibujar todo cuando se cambia el tamaño
            this.Resize += (s, e) =>
            {
                Controls.Clear();
                InicializarControles();
            };
        }

        private void InicializarControles()
        {
            // Título
            titulo = new Label();
            titulo.Text = "Bienvenido al sistema para adoptar mascotas";
            titulo.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(30, 30, 30);
            titulo.AutoSize = true;
            this.Controls.Add(titulo);

            // Centrar título
            titulo.Location = new Point((this.ClientSize.Width - titulo.Width) / 2, 130);

            // Subtítulo
            subtitulo = new Label();
            subtitulo.Text = "Utilizá los botones para administrar mascotas, adoptantes y solicitudes.";
            subtitulo.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            subtitulo.ForeColor = Color.FromArgb(80, 80, 80);
            subtitulo.AutoSize = true;
            this.Controls.Add(subtitulo);

            // Centrar subtítulo justo debajo del título
            subtitulo.Location = new Point((this.ClientSize.Width - subtitulo.Width) / 2, titulo.Bottom + 25);

            // Estilo común de botones
            Size botonSize = new Size(180, 60);
            Font fuenteBoton = new Font("Segoe UI", 12, FontStyle.Regular);
            Color colorBoton = Color.FromArgb(33, 150, 243);

            // Separación entre botones y posición inicial
            int separacion = 40;
            int totalAnchoBotones = (botonSize.Width * 3) + (separacion * 2);
            int startX = (this.ClientSize.Width - totalAnchoBotones) / 2;
            int startY = subtitulo.Bottom + 90;

            // Botones
            buttonVerMascotas = CrearBoton("🐶 Ver Mascotas", new Point(startX, startY), botonSize, fuenteBoton, colorBoton);
            buttonVerAdoptantes = CrearBoton("👤 Ver Adoptantes", new Point(startX + botonSize.Width + separacion, startY), botonSize, fuenteBoton, colorBoton);
            buttonVerSolicitudes = CrearBoton("📄 Ver Solicitudes", new Point(startX + (botonSize.Width + separacion) * 2, startY), botonSize, fuenteBoton, colorBoton);

            // Eventos
            buttonVerMascotas.Click += buttonVerMascotas_Click;
            buttonVerAdoptantes.Click += buttonVerAdoptantes_Click;
            buttonVerSolicitudes.Click += buttonVerSolicitudes_Click;

            // Agregar botones al formulario
            this.Controls.Add(buttonVerMascotas);
            this.Controls.Add(buttonVerAdoptantes);
            this.Controls.Add(buttonVerSolicitudes);
        }

        private Button CrearBoton(string texto, Point ubicacion, Size size, Font fuente, Color colorFondo)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Font = fuente;
            boton.Size = size;
            boton.Location = ubicacion;
            boton.BackColor = colorFondo;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
            return boton;
        }

        private void buttonVerMascotas_Click(object sender, EventArgs e)
        {
            mascotaForm verMascotas = new mascotaForm();
            verMascotas.ShowDialog();
        }

        private void buttonVerAdoptantes_Click(object sender, EventArgs e)
        {
            adoptanteForm verAdoptantes = new adoptanteForm();
            verAdoptantes.ShowDialog();
        }

        private void buttonVerSolicitudes_Click(object sender, EventArgs e)
        {
            // Aquí debe existir la clase SolicitudForm en view.Solicitud
            solicitudForm verSolicitudes = new solicitudForm();
            verSolicitudes.ShowDialog();
        }
    }
}
