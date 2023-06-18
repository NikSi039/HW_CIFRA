namespace CW_23._06._12_WF_Galary
{
    public partial class Form1 : Form
    {
        int pbw, pbh, pbX, pbY;
        string fpath;
        int count;

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
            folderBrowseDialog.Description = "Выберите папку, в которой находятся иллюстрации";
            folderBrowseDialog.ShowNewFolderButton = false;

            if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                fpath = folderBrowseDialog.SelectedPath;
                lbPath.Text = fpath;    
              if (!FillListBox(folderBrowseDialog.SelectedPath))
              {
                pbImage.Image = null;
              }
            }
        }

        private void cbExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox(fpath);
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            if (!btNext.Enabled) btNext.Enabled = true;
            if (lbFiles.SelectedIndex > 0) lbFiles.SelectedIndex--;
            if (lbFiles.SelectedIndex == 0)  btPrev.Enabled = false;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (!btPrev.Enabled)  btPrev.Enabled = true;
            if (lbFiles.SelectedIndex < count -1) lbFiles.SelectedIndex++;
            if (lbFiles.SelectedIndex == count-1) btNext.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
            pbw = pbImage.Width;
            pbh = pbImage.Height;
            pbX = pbImage.Location.X;
            pbY = pbImage.Location.Y;

            lbFiles.Sorted = true;  

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            fpath = di.FullName; 
            lbPath.Text = fpath;

            cbExtention.SelectedIndex = 0;

            FillListBox(fpath);

            btPrev.Enabled = false;
        }

        private bool FillListBox(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles(cbExtention.SelectedItem.ToString()!);

            count = fi.Length;

            lbFiles.Items.Clear();

            foreach (FileInfo fc in fi) lbFiles.Items.Add(fc.Name);

            lbPath.Text = path;

            if (fi.Length == 0)  return false;
            else
            {
                lbFiles.SelectedIndex = 0;
                LoadImage();
                return true;
            }
        }

        private void LoadImage()
        {
            double mh, mw;
            pbImage.Visible = false;
            pbImage.Left = pbX;
            pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbImage.Image = new Bitmap(fpath + @"\" + lbFiles.SelectedItem.ToString());

            // Масштабирование

            if (pbImage.Image.Width > pbw || pbImage.Image.Height > pbh)
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                mw = (double)pbh/ (double)pbImage.Image.Width;  
                mh = (double)pbh/ (double)pbImage.Image.Height;

                if (mh < mw)
                {
                    pbImage.Width = Convert.ToInt16(pbImage.Image.Width * mh);
                    pbImage.Height = pbh;
                }
                else
                {
                    pbImage.Width = pbw;
                    pbImage.Height = Convert.ToInt16(pbImage.Image.Height * mw);    
                }
            }

            pbImage.Left = pbX + (pbw - pbImage.Width) / 2;
            pbImage.Top = pbY + (pbh - pbImage.Height) / 2; 

            pbImage.Visible = true;
        }
    }
}