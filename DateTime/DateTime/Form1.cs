using System.Data.SqlTypes;

namespace sqlDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = dateTimePicker1.Value;
            lblFecha.Text = Fecha.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dias = Convert.ToDouble(txtDias.Text);
            dateTimePicker1.Value = DateTime.Today.AddDays(dias);

            
        }
    }
}
