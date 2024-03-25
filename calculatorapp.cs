namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";

        public Calculator()
        {
            InitializeComponent();
        }
        //button for dot
        private void btndot(object sender, EventArgs e)
        {
            if (!txtbox.Text.Contains("."))
            {
                txtbox.Text += ".";
            }
        }
        //for all numbers 
        private void btnall(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtbox.Text += button.Text;
        }
        //for addition
        private async void btnplus(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtbox.Text, out result))
            {
                valueFirst = decimal.Parse(txtbox.Text);
                txtbox.Clear();
                operators = "+";
            }
            else
            {
                txtbox.Text = "Please enter a valid number.";
                await Task.Delay(1000);
                Environment.Exit(0);
                return;
            }
        }
        //for subtraction
        private async void btnminus(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtbox.Text, out result))
            {
                valueFirst = decimal.Parse(txtbox.Text);
                txtbox.Clear();
                operators = "-";
            }
            else
            {
                txtbox.Text = "Please enter a valid number.";
                await Task.Delay(1000);
                Environment.Exit(0);
                return;
            }
        }
        //for multiplication
        private async void btntimes(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtbox.Text, out result))
            {
                valueFirst = decimal.Parse(txtbox.Text);
                txtbox.Clear();
                operators = "*";
            }
            else
            {
                txtbox.Text = "Please enter a valid number.";
                await Task.Delay(1000);
                Environment.Exit(0);
                return;
            }
        }
        //for division 
        private async void btndivide(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtbox.Text, out result))
            {
                valueFirst = decimal.Parse(txtbox.Text);
                txtbox.Clear();
                operators = "/";
            }
            else
            {
                txtbox.Text = "Please enter a valid number.";
                await Task.Delay(1000);
                Environment.Exit(0);
                return;
            }
        }
        //for switch
        private async void btnequal(object sender, EventArgs e)
        {
            //for await task
            //This is used for methods that don't return anything (void) but still need to do some work asynchronously. It's like saying, "I'll do this work, but I won't give you any feedback when I'm done."
            

                if (!double.TryParse(txtbox.Text, out double userInput)) // if the user input a letter 
                {
                    txtbox.Text = "Please enter a valid number.";
                    await Task.Delay(1000);
                    Environment.Exit(0);
                    return;
                }
                switch (operators)
                {
                    case "+":
                        valueSecond = decimal.Parse(txtbox.Text);
                        result = valueFirst + valueSecond;           
                        break;
                    case "-":
                        valueSecond = decimal.Parse(txtbox.Text);
                        result = valueFirst - valueSecond;
                        break;
                    case "*":
                        valueSecond = decimal.Parse(txtbox.Text);
                        result = valueFirst * valueSecond;
                        break;
                    case "/":
                        valueSecond = decimal.Parse(txtbox.Text);
                        result = valueFirst / valueSecond;
                        break;
                }
            // Update the valueFirst for the next operation
            valueFirst = result;
            // Update the txtbox.Text with the latest result
            txtbox.Text = result.ToString();
            // Clear the operator
            operators = "";
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtbox.Text = " ";
        }
    }
}