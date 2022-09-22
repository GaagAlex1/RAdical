using Dangl.Calculator;

namespace Radical_ver._2._0
{
    public partial class Form1 : Form
    {
        static string CalculateDigits(string line, int dg)
        {
            return Convert.ToString(Math.Round(Math.Sqrt(Convert.ToDouble(line)), dg));
        }
        static string CalculateComplexDigits(string line,int dg)
        {
            return "±" + Convert.ToString(Math.Round(Math.Sqrt(Math.Abs(Convert.ToDouble(line))), dg)) + "i";
        }

        static string ConvertEquation(string line)
        {
            var calculation = Calculator.Calculate(line);
            double c = calculation.Result;
            return c.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            } else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            else textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = ConvertEquation(textBox1.Text);
            if (Convert.ToDouble(textBox1.Text) >= 0) textBox1.Text = CalculateDigits(textBox1.Text, Convert.ToInt32(numericUpDown1.Text));
            else textBox1.Text = CalculateComplexDigits(textBox1.Text, Convert.ToInt32(numericUpDown1.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = ConvertEquation(textBox1.Text);
            if (Convert.ToDouble(textBox1.Text) > 0) textBox1.Text = "(" + "-" + textBox1.Text + ")";
            else if (Convert.ToDouble(textBox1.Text) < 0) textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length-1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "00";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += '^';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += '-';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += '*';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += '/';
        }
    }
}