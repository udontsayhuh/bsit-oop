namespace calcu_oop
{
    public partial class Form1 : Form //form 1 inherits properties and methods from base "Forms" Class
    {
        //Encapsulates both data(num1,num2) access to them is controlled via method
        public Form1()
        {
            InitializeComponent();
        }


        string CalResult;
        int num1;
        int num2;
        string numerator;
        int result;



        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn7.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Calculating the input
            numerator = "+";
            num1 = int.Parse(txtResult.Text);

            txtResult.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //Calculating the input
            numerator = "-";
            num1 = int.Parse(txtResult.Text);

            txtResult.Clear();
        }
        private void txtResult_Click(object sender, EventArgs e)
        {
            char[] allowedCharacters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/' };

            foreach (char c in txtResult.Text)
            {
                if (!allowedCharacters.Contains(c))
                {
                    MessageBox.Show("Invalid input. Only numerical values and operators '+', '-', '*', '/' are allowed.");
                    return; // Terminate the program
                }
            }

            // If the input contains only allowed characters you can proceed with the rest of your code
            int num1, num2;
            char op;

            if (int.TryParse(txtResult.Text, out num1))
            {
                // Process num1 as a number
            }
            else if (char.TryParse(txtResult.Text, out op))
            {
                // Process op as an operator
            }
            else if (int.TryParse(txtResult.Text, out num2))
            {
                // Process num2 as a number
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn6.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn0.Text;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Calculating the input
            numerator = "*";
            num1 = int.Parse(txtResult.Text);

            txtResult.Clear();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            //Calculating the input
            numerator = "/";
            num1 = int.Parse(txtResult.Text);

            txtResult.Clear();
        }
        //PolymorphismImplementation
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtResult.Text);

            if (numerator.Equals("+"))
                result = num1 + num2;

            if (numerator.Equals("-"))
                result = num1 - num2;


            if (numerator.Equals("*"))
                result = num1 * num2;

            if (numerator.Equals("/"))
                result = num1 / num2;

            txtResult.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
