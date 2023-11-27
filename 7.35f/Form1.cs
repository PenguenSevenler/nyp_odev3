namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (numberinput.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numberinput.Text))
            {
                long number = Convert.ToInt64(numberinput.Text);

                static long SumOfDigits(long number)
                {
                    if (number == 0)
                        return 0;
                    else
                        return number % 10 + SumOfDigits(Convert.ToInt32(number / 10));
                }

                long sumof = SumOfDigits(number);

                sumofdigits.Text = sumof.ToString();
            }
            else
                sumofdigits.Text = 0.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }



}