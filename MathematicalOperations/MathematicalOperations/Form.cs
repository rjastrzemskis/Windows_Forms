using System;
using System.Windows.Forms;

namespace MathematicalOperations
{
    public partial class MathematicalOperations : Form
    {
        public MathematicalOperations()
        {
            InitializeComponent();
        }

        double firstNumber = 0;
        double result = 0;
        double powResult = 1;

        private void NumbersClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (textBox1.Text.Length == 0 && btn.Text == ",")
            {
                textBox1.Text = "0";
                textBox1.Text += btn.Text;
            }
            else if (!textBox1.Text.Contains(",") || btn.Text != ",")
            {
                textBox1.Text += btn.Text;
            }
        
        firstNumber = Convert.ToDouble(textBox1.Text);
        }

        private void OperationsOnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text != string.Empty)
            {
                switch (btn.Text)
                {
                    case "-":
                        firstNumber -= result;
                        result = firstNumber;
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "+":
                        firstNumber += result;
                        result = firstNumber;
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "/":
                        firstNumber /= result;
                        result = firstNumber;
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "x":
                        firstNumber *= result;
                        result = firstNumber;
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "pow":
                        firstNumber = Math.Pow(firstNumber, powResult);
                        result = firstNumber;
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(powResult).ToString();
                        break;
                    case "sin":
                        result = Math.Sin(firstNumber);
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "cos":
                        result = Math.Cos(firstNumber);
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    case "sqrt":
                        result = Math.Sqrt(firstNumber);
                        powResult = result;
                        textBox2.Text = Convert.ToDouble(result).ToString();
                        break;
                    default:
                        result = Convert.ToDouble(textBox1.Text);
                        powResult = result;
                        textBox2.Text = textBox1.Text;
                        textBox1.Text = string.Empty;
                        break;
                }
            }

            textBox1.Text = string.Empty;
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "C":
                    textBox1.Text = string.Empty;
                    break;
                default:
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    result = 0;
                    powResult = 1;
                    break;
            }
        }
    }
}
