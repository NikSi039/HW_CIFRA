namespace CW_WF_23._07._23_Diagramm
{
    struct Kurs
    {
        public DateOnly data { get; set; }
        public decimal kurs { get; set; }
    }

    public partial class FormKurs : Form
    {
        private List<Kurs> kurses;

        public FormKurs()
        {
            InitializeComponent();

            kurses = new List<Kurs>();

            plGraf.Paint += new PaintEventHandler(drawDiagram!);





        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.dat|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(File.Create(saveFileDialog.FileName)))
                {
                    for (int i = 0; i < dgvKurs.RowCount -1; i++)
                    {
                        string data = dgvKurs.Rows[i].Cells[0].Value.ToString()!;
                        decimal k = Decimal.Parse(dgvKurs.Rows[i].Cells[1].Value.ToString()!);

                        bw.Write(data);
                        bw.Write(k);


                    }
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.dat|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader br = new BinaryReader(File.Open(openFileDialog.FileName,FileMode.Open)))
                {
                    dgvKurs.Rows.Clear();
                    kurses.Clear();
                    int i = 0;
                    while (br.PeekChar() > -1)
                    {
                        Kurs kurs = new Kurs();
                        kurs.data = DateOnly.Parse(br.ReadString());
                        kurs.kurs = br.ReadDecimal();
                        kurses.Add(kurs);

                        dgvKurs.Rows.Add();
                        dgvKurs.Rows[i].Cells[0].Value = kurs.data;
                        dgvKurs.Rows[i].Cells[1].Value = kurs.kurs;
                        i++;
                    }
                }

                this.plGraf.Refresh();
           
            }
        }

        private void drawDiagram(object sender, PaintEventArgs args)
        {
            Graphics g = args.Graphics;

            Font dfont = new Font("Tahoma", 9);
            Font hfont = new Font("Tahoma", 14, FontStyle.Regular);

            string header = "Изменение курса валют";

            int wh = (int)g.MeasureString(header,hfont).Width;
            int x = (plGraf.Width - wh) / 2;

            g.DrawString(header, hfont, Brushes.DarkGreen, x, 5);

            if (kurses.Count != 0)
            {
                decimal max = kurses[0].kurs;
                decimal min = 0;

                for (int i = 0; i < kurses.Count; i++)
                {
                    if (kurses[i].kurs > max)
                    {
                        max = kurses[i].kurs;
                    }
                }

                int x1, y1;
                int w, h;

                w = (plGraf.Width - 10 * 5 * (kurses.Count - 1)) / kurses.Count;
                x1 = 10;

                for (int i = 0; i < kurses.Count; i++)
                {
                    y1 = plGraf.Height - 10 - (int)((plGraf.Height - 100) * (kurses[i].kurs - min) / (max - min));
                    g.DrawString(kurses[i].kurs.ToString(), dfont, Brushes.Black, x1, y1 - 10);

                    h = plGraf.Height - y1 - 10 + 1;
                    g.FillRectangle(Brushes.ForestGreen, x1, y1, w, h);
                    g.DrawRectangle(Pens.Black, x1,y1,w,h);
                   
                    x1 += w + 5;
                }
            }

           

        }

        private void plGraf_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dgvKurs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKurs.SelectedRows.Count != 0)
            {
                Kurs kurs = new Kurs();
                kurs.data = DateOnly.Parse(dgvKurs.SelectedRows[0].Cells[1].Value.ToString()!);
                kurs.kurs = decimal.Parse(dgvKurs.SelectedRows[1].Cells[1].Value.ToString()!);
                kurses.Add(kurs);
                this.plGraf.Refresh();
            }

          
        }
    }
}