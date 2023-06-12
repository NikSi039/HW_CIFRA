namespace Calculator
{
    public partial class Form1 : Form
    {
        const int bw = 50, bh = 50; // Размер кнопок
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
            int k = 0;
            int x, y;
            y = tbResult.Bottom + dy;


            for (int i = 0; i < 4; i++)
            {
                x = dx;

                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 3) && (j == 0)))
                    {
                        btn[k] = new Button();
                        btn[k].Font = new Font(this.Font.FontFamily, 16);
                        btn[k].SetBounds(x, y, bw, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();

                        btn[k].Click += new System.EventHandler(this.Button_Click!);

                        // Изменение цвета
                        //if (btnTag[k] < 0)
                        //{
                        //    btn[k].BackColor = SystemColors.ControlDark;
                        //}

                        this.Controls.Add(this.btn[k]);
                        x+= bw + dx;
                        k++;

                       
                    }
                    else
                    {
                        btn[k] = new Button();
                        btn[k].Font = new Font(this.Font.FontFamily, 16);
                        btn[k].SetBounds(x, y, bw * 2 + dx, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();

                        btn[k].Click += new System.EventHandler(this.Button_Click!);

                        this.Controls.Add(this.btn[k]);
                        x+=2*bw +2 *dx;
                        k++;
                        j++;
                    }
                }
                    y+= bh + dy;
            }
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Button? btn =(Button) sender ;

            if (Convert.ToInt32(btn.Tag) > 0)
            {
                if (fd)
                {
                    tbResult.Text = btn.Text;
                    fd = false; 
                }
                else
                {
                    tbResult.Text += btn.Text;    
                }
                return;
            }

            if (Convert.ToInt32(btn.Tag) == 0)
            {
                if (fd)
                {
                    tbResult.Text = btn.Text;
                }
                if (tbResult.Text != "0")
                {
                    tbResult.Text += btn.Text;
                }
                return;
            }





        }







        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }


    }
}