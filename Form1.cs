namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operator1 = ""; 
        private double result = 0; 
        private bool isOperatorClicked = false;
        private double lastOperand = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked) 
            {
                txtDisplay.Text = "";
                isOperatorClicked = false;
            }

            Button? btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                operator1 = btn.Text;
                result = double.Parse(txtDisplay.Text);
                isOperatorClicked = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                operator1 = btn.Text;
                result = double.Parse(txtDisplay.Text);
                isOperatorClicked = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // This appears to be the multiply button handler
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                Button? btn = sender as Button;
                if (btn != null)
                {
                    // If there's a pending operation, perform it first
                    if (!string.IsNullOrEmpty(operator1))
                    {
                        double secondNum = double.Parse(txtDisplay.Text);

                        switch (operator1)
                        {
                            case "+": result += secondNum; break;
                            case "-": result -= secondNum; break;
                            case "*": result *= secondNum; break;
                            case "/":
                                if (secondNum == 0)
                                {
                                    MessageBox.Show("Cannot divide by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                result /= secondNum;
                                break;
                        }

                        txtDisplay.Text = result.ToString();
                    }
                    else
                    {
                        result = double.Parse(txtDisplay.Text);
                    }

                    operator1 = btn.Text;
                    isOperatorClicked = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                operator1 = btn.Text;
                result = double.Parse(txtDisplay.Text);
                isOperatorClicked = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double secondNum;

            if (isOperatorClicked || string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                secondNum = lastOperand;
            }
            else
            {
                secondNum = double.Parse(txtDisplay.Text);
                lastOperand = secondNum;
            }

            switch (operator1)
            {
                case "+": result += secondNum; break;
                case "-": result -= secondNum; break;
                case "×": result *= secondNum; break;
                case "÷":
                    if (secondNum == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result /= secondNum;
                    break;
            }

            txtDisplay.Text = result.ToString();
            isOperatorClicked = false; // Reset the flag here
            operator1 = ""; // Clear the operator
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            result = 0;
            operator1 = "";
            isOperatorClicked = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(txtDisplay.Text);
                num /= 100;
                txtDisplay.Text = num.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for percentage conversion.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
