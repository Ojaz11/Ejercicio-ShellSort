using System.Windows.Forms;

namespace ShellSort
{
    public partial class Form1 : Form
    {
        List<Floreria> florerias = new List<Floreria>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarData();
            DateTime hoy = DateTime.Today;
            DateTime ultimoDia = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
            dtpFecha.MinDate = hoy;    
            dtpFecha.MaxDate = ultimoDia; 
        }

        public void ConfigurarData()
        {
            dgvDatos.ColumnCount = 4;
            dgvDatos.Columns[0].Name = "Nombre del cliente";
            dgvDatos.Columns[1].Name = "Nombre del ramo";
            dgvDatos.Columns[2].Name = "Precio";
            dgvDatos.Columns[3].Name = "Fecha de entrega";
        }

        public void LlenarData()
        {
            dgvDatos.Rows.Clear();

            foreach (var flores in florerias)
            {
                string ramos = string.Join(", ", flores.NombreProducto.Select(p => p.Nombre));
                decimal total = flores.NombreProducto.Sum(p => p.Precio);

                dgvDatos.Rows.Add(flores.NombreCliente, ramos, total, flores.FechaEntrega.ToShortDateString());
            }

            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ColorearFilas()
        {
            int total = dgvDatos.Rows.Count;

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    // Primer pedido (más urgente)
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (i == total - 1)
                {
                    // Último pedido (menos urgente)
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    // Todos los intermedios
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        public void Limpiar()
        {
            txtNombreCliente.Clear();
            cbCondolencias.SelectedIndex = -1;
            cbElegantes.SelectedIndex = -1;
            cbRamosRomanticos.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            txtNombreCliente.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = dtpFecha.Value.Day;
                int mes = dtpFecha.Value.Month;
                int año = DateTime.Today.Year;
                DateTime fecha = new DateTime(año, mes, dia);
                Floreria pedido = new Floreria(txtNombreCliente.Text, fecha);

                var ramoCondolencia = pedido.productosDisponibles.FirstOrDefault(p => p.Nombre == cbCondolencias.Text);
                var ramoElegante = pedido.productosDisponibles.FirstOrDefault(p => p.Nombre == cbElegantes.Text);
                var ramoRomatico = pedido.productosDisponibles.FirstOrDefault(p => p.Nombre == cbRamosRomanticos.Text);

                if (ramoCondolencia != null || ramoElegante != null || ramoRomatico != null)
                {
                    if (ramoCondolencia != null)
                    {
                        pedido.NombreProducto.Add(ramoCondolencia);
                    }
                    if (ramoElegante != null)
                    {
                        pedido.NombreProducto.Add(ramoElegante);
                    }
                    if (ramoRomatico != null)
                    {
                        pedido.NombreProducto.Add(ramoRomatico);
                    }

                    florerias.Add(pedido);
                    LlenarData();
                    MessageBox.Show("Pedido agregado con éxito.", "PRACTICA-ITSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ese ramo no está disponible.", "PRACTICA-ITSL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("¡Ingresa los datos correctamente!", "PRACTICA-ITSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcomodar_Click(object sender, EventArgs e)
        {
            if (florerias.Count == 0)
            {
                MessageBox.Show("¡No hay pedidos para acomodar!", "PRACTICA-ITSL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ShellSortAscendente.ShellSort(florerias);
                LlenarData();
                ColorearFilas();
            }
        }

        private void cbRamosRomanticos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
