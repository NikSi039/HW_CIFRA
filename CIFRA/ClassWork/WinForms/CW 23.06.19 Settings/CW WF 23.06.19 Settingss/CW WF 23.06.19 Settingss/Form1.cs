using CW_WF_23._06._19_Settingss.Properties;

namespace CW_WF_23._06._19_Settingss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Settings.Default.Left;
            this.Top = Settings.Default.Top;
            this.Width = Settings.Default.Width;
            this.Height = Settings.Default.Height;
            lbSettings.Text = Settings.Default.Top + " " + Settings.Default.Left;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Left = this.Left;
            Settings.Default.Top = this.Top;
            Settings.Default.Width = this.Width;
            Settings.Default.Height = this.Height;
            Settings.Default.Save();
        }

        private void lbPosition_Click(object sender, EventArgs e)
        {
            lbPosition.Text = Top + " " + Left;
        }
    }
}