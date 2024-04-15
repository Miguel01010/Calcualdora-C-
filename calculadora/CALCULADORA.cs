namespace calculadora
{
    public partial class CALCULADORA : Form
    {

        double primero;
        double segundo;
        string operador;
        public CALCULADORA()
        {
            InitializeComponent();
        }

        clase.suma obj = new clase.suma();
        clase.resta obj2 = new clase.resta();
        clase.multiplicacion obj3 = new clase.multiplicacion();
        clase.divicion obj4 = new clase.divicion();



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxScreen.Text >= 2 && tbxScreen(texto[texto.Length - 2]) && tbxScreen q(texto[texto.Length - 1]))
           {
                return "1";
           }

          

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
           
            if (tbxScreen.Text == "0")
            {
                return;

            }

            else
            {
                tbxScreen.Text += "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "1";
            }
            else
            {
             tbxScreen.Text +="1";

            }
        }

        private void btnN2_Click(object sender, EventArgs e)

        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "2";
            }
            else
            {
                tbxScreen.Text += "2";
            }
        }

private void btnN3_Click(object sender, EventArgs e)
        {

            {
                if (tbxScreen.Text == "0" && tbxScreen.Text != null)
                {
                    tbxScreen.Text = "3";
                }
                else
                {
                    tbxScreen.Text += "3";
                }
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "4";
            }
            else
            {
                tbxScreen.Text += "4";
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "5";
            }
            else
            {
                tbxScreen.Text += "5";
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "6";
            }
            else
            {
                tbxScreen.Text += "6";
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "7";
            }
            else
            {
                tbxScreen.Text += "7";
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "8";
            }
            else
            {
                tbxScreen.Text += "8";
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0" && tbxScreen.Text != null)
            {
                tbxScreen.Text = "9";
            }
            else
            {
                tbxScreen.Text += "9";
            }
        }

        private void btnN17_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btnN10_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnN12_Click(object sender, EventArgs e)
        {

            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }


        private void btnN16_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Rest;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;

                case "-":
                    Rest = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = Rest.ToString();
                    break;

                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;

                case "/":
                    Div = obj4.Divicion((primero), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;



            }
        }

        private void btnN14_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnN15_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}
