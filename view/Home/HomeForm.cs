using System;
using System.Drawing;
using System.Windows.Forms;
using view.Solicitud;

namespace view.Home
{
    public partial class HomeForm : Form
    {
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tableLayoutPanel;

        public HomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            InicializarComponentesPersonalizados();
        }

        private void InicializarComponentesPersonalizados()
        {
            // Fuente común
            Font fuenteBoton = new Font("Segoe UI", 12F, FontStyle.Bold);
            Font fuenteTitulo = new Font("Segoe UI", 20F, FontStyle.Bold);
            Font fuenteSubtitulo = new Font("Segoe UI", 12F, FontStyle.Regular);

            // Título
            lblTitulo = new Label
            {
                Text = "Bienvenido al sistema para adoptar mascotas",
                Font = fuenteTitulo,
                ForeColor = Color.Black,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Subtítulo
            lblSubtitulo = new Label
            {
                Text = "Elegí una opción para comenzar",
                Font = fuenteSubtitulo,
                ForeColor = Color.DimGray,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Layout principal
            tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                BackColor = Color.White
            };

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Espacio top
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Título
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Subtítulo
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Botones
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F)); // Espacio bottom

            tableLayoutPanel.Controls.Add(lblTitulo, 0, 1);
            tableLayoutPanel.Controls.Add(lblSubtitulo, 0, 2);

            // Panel horizontal para los botones
            FlowLayoutPanel panelBotones = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(10),
                Margin = new Padding(0),
            };


            tableLayoutPanel.Controls.Add(panelBotones, 0, 3);
            this.Controls.Add(tableLayoutPanel);
        }

        private Button CrearBoton(string texto, Font fuente, EventHandler eventoClick)
        {
            Button boton = new Button
            {
                Text = texto,
                Font = fuente,
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 200,
                Height = 60,
                Margin = new Padding(20),
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 0;
            boton.Click += eventoClick;

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
            SolicitudForm verSolicitudes = new SolicitudForm();
            verSolicitudes.ShowDialog();
        }
    }
}
