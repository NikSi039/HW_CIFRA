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
               // lbResult.Text = $"{dollars}$ = {result} рублей";
               lbResult.Text = dollars + "$=" + result.ToString("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbKurs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>='0' && e.KeyChar<='9')  return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbKurs.Text.IndexOf(',')!= -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char)Keys.Enter) tbDollar.Focus();
                return;
            }
            e.Handled = true;
           
        }

        private void tbDollar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbDollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbKurs.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) btResult.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
