using Python.Runtime;
using Dangl.Calculator;
using System.Text.RegularExpressions;


namespace Radical_ver._2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string SimplifyExp(string line)
        {
            if (!line.Contains("^")) return "sqrt" + line;

            line = line.Replace("^", "e");
            Regex r = new Regex(@"e(\d+)");
            MatchCollection matches = r.Matches(line);

            foreach (Match match in matches)
                line = line.Replace(match.Value, "^(" + match.Groups[1].Value + "/2)");


            r = new Regex(@"e(\w+)");
            matches = r.Matches(line);

            foreach (Match match in matches)
                line = line.Replace(match.Value, "^(" + match.Groups[1].Value + "/2)");

            return line;
        }

        static string Algebra(string line)
        {
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                dynamic sympy = Py.Import("sympy");
                dynamic simplification = sympy.simplify;
                dynamic factor = sympy.factor;

                line = factor(line).ToString();
                line = line.Replace("**", "^");

                string[] factors = line.Split('*');
                for (int i = 0; i < factors.Length; i++)
                {
                    factors[i] = SimplifyExp(factors[i]);
                    if (i == 0) line = factors[i];
                    else line += "*" + factors[i];
                }
            }
            return line;
        }

        static string Arithmetic(string line,int dg)
        {
            line = "sqrt(" + line + ")";

            var expr = Calculator.Calculate(line);

            double res = Math.Round(Convert.ToDouble((expr.Result)),dg);
            return res.ToString();
        }

        static string CalculateExpr(string line, int dg)
        {
            if (!line.Any(Char.IsLetter)) line = Arithmetic(line, dg);
            else line = Algebra(line);
            line = line.Replace("**", "^");

            return line;
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
            textBox1.Text = CalculateExpr(textBox1.Text, Convert.ToInt32(numericUpDown1.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {   if (textBox1.Text != "0")
            {
                if (textBox1.Text[0] == '-' && textBox1.Text[1] == '(') textBox1.Text = textBox1.Text.Substring(2, textBox1.Text.Length - 3);
                else textBox1.Text = "-(" + textBox1.Text + ")";
            }
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
            if (textBox1.Text != "0") textBox1.Text += '-';
            else textBox1.Text = "-";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += '*';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += '/';
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text = Math.PI.ToString();
            if (textBox1.Text == "0")
            {
                textBox1.Text = Math.PI.ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "cot(";
            if (textBox1.Text == "0") textBox1.Text = "cot(";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "sin(";
            if (textBox1.Text == "0") textBox1.Text = "sin(";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "cos(";
            if (textBox1.Text == "0") textBox1.Text = "cos(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "tan(";
            if (textBox1.Text == "0") textBox1.Text = "tan(";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "arcsin(";
            if (textBox1.Text == "0") textBox1.Text = "arcsin(";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "arccos(";
            if (textBox1.Text == "0") textBox1.Text = "arccos(";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "arctan(";
            if (textBox1.Text == "0") textBox1.Text = "arctan(";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "arccot(";
            if (textBox1.Text == "0") textBox1.Text = "arccot(";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(textBox1.Text[textBox1.Text.Length - 1])) textBox1.Text += "(";
            if (textBox1.Text == "0") textBox1.Text = "(";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }
    }
}