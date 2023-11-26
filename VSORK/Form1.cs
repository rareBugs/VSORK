namespace VSORK
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber;
        string theOperators;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeShortenerForCalculatorButtons(string value)
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "-0")
            {
                txtDisplay.Text = value;
            }
            else if (!txtDisplay.Text.Contains(",") || value != ",")
            {
                txtDisplay.Text += value;
            }
        }

        private void buttonCalc0_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("0");
        }

        private void buttonCalc1_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("1");
        }

        private void buttonCalc2_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("2");
        }

        private void buttonCalc3_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("3");
        }

        private void buttonCalc4_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("4");
        }

        private void buttonCalc5_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("5");
        }

        private void buttonCalc6_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("6");
        }

        private void buttonCalc7_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("7");
        }

        private void buttonCalc8_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("8");
        }

        private void buttonCalc9_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons("9");
        }

        private void buttonCalcDecimal_Click(object sender, EventArgs e)
        {
            CodeShortenerForCalculatorButtons(",");
        }

        private void buttonCalcEquals_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(txtDisplay.Text);

            switch (theOperators)
            {
                case "+":
                    txtDisplay.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (firstNumber / secondNumber).ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonCalcDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            theOperators = "/";
            txtDisplay.Text = "";
        }

        private void buttonCalcMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            theOperators = "*";
            txtDisplay.Text = "";
        }

        private void buttonCalcSubstract_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            theOperators = "-";
            txtDisplay.Text = "";
        }

        private void buttonCalcAddition_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            theOperators = "+";
            txtDisplay.Text = "";
        }

        private void buttonCalcPlusMinus_Click(object sender, EventArgs e)
        {
            double plusMinus = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * plusMinus);
        }

        private void buttonCalcC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void buttonCalcCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            string adam, eve;

            adam = Convert.ToString(firstNumber);
            eve = Convert.ToString(secondNumber);

            adam = "";
            eve = "";
        }

        private void buttonCalcBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")

            {
                txtDisplay.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10VårAndel_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}