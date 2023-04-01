namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal primeirovalor = 0.0m;
        private decimal segundovalor = 0.0m;
        private decimal resultado = 0.0m;
        private string operadores = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            primeirovalor = 0.0m;
            segundovalor = 0.0m;
            textBox1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            primeirovalor = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operadores = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            primeirovalor = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operadores = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operadores)
            {
                case "-":
                    segundovalor = decimal.Parse(textBox1.Text);
                    resultado = primeirovalor - segundovalor;
                    textBox1.Text = resultado.ToString();
                    break;
                case "+":
                    segundovalor = decimal.Parse(textBox1.Text);
                    resultado = primeirovalor + segundovalor;
                    textBox1.Text = resultado.ToString();
                    break;
                case "*":
                    segundovalor = decimal.Parse(textBox1.Text);
                    resultado = primeirovalor * segundovalor;
                    textBox1.Text = resultado.ToString();
                    break;
                case "/":
                    segundovalor = decimal.Parse(textBox1.Text);
                    resultado = primeirovalor / segundovalor;
                    textBox1.Text = resultado.ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            primeirovalor = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operadores = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            primeirovalor = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operadores = "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}