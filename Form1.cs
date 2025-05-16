namespace Calculator
{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string option;
        int num1 ;
        int num2 ;
        string CalTotal;
        int res;


        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txtdisplay.Text += "1";
        }
        private void Btn_2_Click(object sender, EventArgs e)
        {
             Txtdisplay.Text += "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
             Txtdisplay.Text += "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txtdisplay.Text += "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txtdisplay.Text += "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
             Txtdisplay.Text += "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txtdisplay.Text += "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
           Txtdisplay.Text += "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
             Txtdisplay.Text +="9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
             Txtdisplay.Text += "0";
        }

        private void Txtequal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtdisplay.Text, out num2))
            {
                // Perform the calculation
                if (option == "+")
                    res = num1 + num2;
                else if (option == "-")
                    res = num1 - num2;
                else if (option == "*")
                    res = num1 * num2;
                else if (option == "/")
                {
                    if (num2 != 0)
                        res = num1 / num2;
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                }


               
                Txtdisplay.Text = res.ToString();
                Txtdisplay.Text = $"{num1} {option} {num2} = {res}";

            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void Txtclear_Click(object sender, EventArgs e)
        {
           Txtdisplay.Clear();
        }

        private void Btnplus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtdisplay.Text, out num1))
            {
                option = "+";
                Txtdisplay.Clear(); // Prepare for second number input
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }


        private void Btnminus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtdisplay.Text, out num1))
            {
                option = "-";
                Txtdisplay.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number first.");
            }
        }


        private void Btnmultiply_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtdisplay.Text, out num1))
            {
                option = "*";
                Txtdisplay.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number first.");
            }
        }

        private void Btndivide_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtdisplay.Text, out num1))
            {
                option = "/";
                Txtdisplay.Clear(); // Clear textbox so user can enter second number
            }
            else
            {
                MessageBox.Show("Please enter a valid number first.");
            }
        }


        private void Txtdisplay_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
