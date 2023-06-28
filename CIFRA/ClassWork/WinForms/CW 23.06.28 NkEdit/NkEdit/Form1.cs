namespace NkEdit
{
    public partial class NKEdit : Form
    {
        private string fn = string.Empty;
        private bool docChanged = false;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private PrintDialog printDialog;
        private FontDialog fontDialog;

        public NKEdit()
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Text = string.Empty;

            this.Text = "NkEdit - ����� ��������";

            toolStrip1.Visible = true;

            ParamToolStripMenuItem.Checked = true;

            openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "�����|*.txt";
            openFileDialog.Title = "������� ��������";
            openFileDialog.Multiselect = false;

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "�����|*.txt";
            saveFileDialog.Title = "��������� ��������";

            printDialog = new PrintDialog();

            fontDialog = new FontDialog();


        }

        private async void OpenDocument()
        {
            openFileDialog.FileName = String.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog.FileName;
                this.Text = fn;

                using (StreamReader sr = new StreamReader(fn))
                {
                    textBox1.Text = await sr.ReadToEndAsync();
                    textBox1.SelectionStart = textBox1.TextLength;
                }
            }
        }

        private int SaveDocument()
        {
            int result = 0;

            if (fn == String.Empty)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog.FileName;
                    this.Text = fn;
                }
                else
                {
                    result = -1;
                }
            }

            if (fn != String.Empty)
            {
                FileInfo fi = new FileInfo(fn);
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteAsync(textBox1.Text);
                }
            }
            return result;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = String.Empty;

            if (docChanged == true)
            {

                Save();
            }

            OpenDocument();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                Save();
            }
        }

        private void Save()
        {
            DialogResult dr = MessageBox.Show("��������� ���������?", "NKEdit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            switch (dr)
            {
                case DialogResult.Yes:
                    if (SaveDocument() == 0)
                    {
                        textBox1.Clear();
                        docChanged = false;
                    }
                    break;
                case DialogResult.No:
                    textBox1.Clear();
                    docChanged = false;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0)
            {
                docChanged = true;
            }

            
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� ������������� ������ ������� ����������?", "NKEdit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (docChanged)
                {
                    Save();
                }

                Close();
            }
            
            
           
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void ParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            ParamToolStripMenuItem.Checked = !ParamToolStripMenuItem.Checked;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

                fontDialog.Font = textBox1.Font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog.Font;
                }



          
        }

        private void ��������ToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void ����������ToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void ��������ToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}