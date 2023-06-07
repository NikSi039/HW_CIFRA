namespace Zhalusi
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

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal price= 0;

            try
            {
                double width = double.Parse(tbWidth.Text);
                double height = double.Parse(tbHeight.Text);

                switch (cbMaterial.SelectedIndex)
                {
                    case 0: price = 500; break;
                    case 1: price = 1000; break;
                    case 2: price = 800; break;
                    case 3: price = 300; break;
                }

                lbResult.Text = ((decimal)width * (decimal)height * price).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}