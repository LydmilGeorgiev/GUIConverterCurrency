namespace GUIConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertCurrency(sender, e);
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            const decimal ConversionCoefficient = 1.95583m;

            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN / ConversionCoefficient;

            this.resultLabel.Text = $"{amountBGN} BGN = {amountEUR:f2} EUR";
        }
    }
}