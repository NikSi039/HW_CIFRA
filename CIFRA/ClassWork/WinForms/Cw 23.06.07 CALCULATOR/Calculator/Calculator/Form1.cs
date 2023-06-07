namespace Calculator
{
    public partial class Form1 : Form
    {
        const int bw = 40, bh = 22; // Размер кнопок
        const int dx = 5, dy = 5; // Расстояние между кнопками

        Button[] btn = new Button[15];

        char[] btnText = {'7','8','9','+',
                           '4','5','6','-',
                           '1','2','3','=',
                            '0',',','C'};
        int[] btnTag = {7,8,9,-3,
                        4,5,6,-4,
                         1,2,3,-2,
                         0,-1,5};

        double ac = 0;// аккумулятор
        int cp = 0;// код операции
        private Boolean fd = true;


        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(4 * bw + 5 * dx, 5 * bh + 7 * dy);
            tbResult.SetBounds(dx, dy, 4 * bw + 3 * dx, bh);
            tbResult.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}