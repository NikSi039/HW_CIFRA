namespace firstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btResult_Click(object sender, EventArgs e)
        {
            try
            {
                decimal kurs = decimal.Parse(tbKurs.Text.Replace(".",","));
                int dollars = int.Parse(tbDollar.Text);
                decimal result = kurs * dollars;
                lbResult.Text = $"{dollars}$ = {result} рублей";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}