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
        public frmKurs()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(Application.StartupPath + @"usd.dat");

            if (!fi.Exists)
            {
                fi.Create();
            }
       
            using (BinaryWriter writer = new BinaryWriter(fi.OpenWrite()))
            {
                Current current = new Current();
                current.name = cbCurrent.SelectedItem.ToString()!;
                current.kurs = decimal.Parse(nudRubbles.Value.ToString() + "," + nudKopeek.Value.ToString());
                current.date = DateOnly.Parse(dtpDate.Value.ToShortDateString());

                writer.Write(current.name);
                writer.Write(current.kurs);
                writer.Write(current.date.ToShortDateString());
            }
        }
    }
}