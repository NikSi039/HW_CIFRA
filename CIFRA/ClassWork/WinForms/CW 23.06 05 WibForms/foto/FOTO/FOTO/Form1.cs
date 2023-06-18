namespace FOTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btOk.Enabled = false;
        }

        private void tbCount_TextChanged(object sender, EventArgs e)
        {
            if (tbCount.Text.Length != 0) btOk.Enabled = true;
            else btOk.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            if (rb3_4.Checked) price = decimal.Parse(tbPrice3_4.Text);
            if (rb9_12.Checked) price = decimal.Parse(tbPrice9_12.Text);
            if (rb12_15.Checked) price = decimal.Parse(tbPrice12_15.Text);
            if (rb18_24.Checked) price = decimal.Parse(tbPrice18_24.Text);

            lbResult.Text = "Итого:" + (int.Parse(tbCount.Text) * price).ToString("C");
        }
    }
}