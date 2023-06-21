namespace CW_23._06._19_KURS
{
    struct Current
    {
        public string name;
        public DateOnly date;
        public decimal kurs;
    }

    public partial class frmKurs : Form
    {
        private FileInfo fi;
        private OpenFileDialog ofd; 

        public frmKurs()
        {
            InitializeComponent();

            ofd =  new OpenFileDialog();
            ofd.Filter = "dat|*.dat";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (fi!= null)
            {
                try
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(fi.FullName, FileMode.Append)))
                    {
                        Current current = new Current();
                        current.name = cbCurrent.SelectedItem.ToString()!;
                        current.kurs = decimal.Parse(nudRubbles.Value.ToString() + "," + nudKopeek.Value.ToString());
                        current.date = DateOnly.Parse(dtpDate.Value.ToShortDateString());

                        writer.Write(current.name);
                        writer.Write(current.kurs);
                        writer.Write(current.date.ToShortDateString());
                    }
                    UpdateKurs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Âûבונטעו פאיכ");
            }
        }

        private void frmKurs_Load(object sender, EventArgs e)
        {
            UpdateKurs();
        }

        void UpdateKurs()
        {
            lbKurs.Items.Clear();

            if (fi != null)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fi.FullName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        decimal kurs = reader.ReadDecimal();
                        DateOnly date = DateOnly.Parse(reader.ReadString());

                        lbKurs.Items.Add(name + " " + date + " " + kurs);
                    }
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fi = new FileInfo(ofd.FileName);

            UpdateKurs();
        }

        private void mcFilter_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbKurs.Items.Clear();

            if (fi != null)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fi.FullName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        decimal kurs = reader.ReadDecimal();
                        DateTime date = DateTime.Parse(reader.ReadString());

                        if (date >= mcFilter.SelectionStart && date <= mcFilter.SelectionEnd)
                        {

                            lbKurs.Items.Add(name + " " + date + " " + kurs);
                        }

                    }
                }
            }
        }
    }
}