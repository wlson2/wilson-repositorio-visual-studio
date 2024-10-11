namespace calculadora_de_KM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double consMin = Convert.ToDouble(txtConsMin.Text);
            double consMax = Convert.ToDouble(txtConsMax.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);

            for (double consumo = consMin; consumo <= consMax; consumo++)
            {
                double costoPorKm = (consumo / 100) * (precio / 3.785);
                double kmPorGalon = (100 / consumo) * 3.785;

                dataGridView1.Rows.Add(consumo.ToString("0.00"), costoPorKm.ToString("0.00"), kmPorGalon.ToString("0.00"));

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtConsMin.Clear();
            txtConsMax.Clear();
            txtPrecio.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
