namespace calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "";

            TxtResultado.Text += boton.Text;
        }
        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(TxtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                TxtResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                TxtResultado.Text = Numero1.ToString();
            }
            else
            {
                TxtResultado.Text = "0";
            }

        }

        private void BotonResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(TxtResultado.Text);
            if (Operador == '+')
            {
                TxtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(TxtResultado.Text);
            }
            else if (Operador == '-')
            {
                TxtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(TxtResultado.Text);
            }
            else if (Operador == 'X')
            {
                TxtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(TxtResultado.Text);
            }
            else if (Operador == '/')
            {
                    TxtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(TxtResultado.Text);
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {

        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "0";
        }

        private void BotonPunto_Click(object sender, EventArgs e)
        {
            if (!TxtResultado.Text.Contains("."))
            {
                TxtResultado.Text += ".";
            }
        }

        private void BotonSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(TxtResultado.Text);
            Numero1 *= -1;
            TxtResultado.Text = Numero1.ToString();
        }
    }
}
