using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_23._06._21_Question
{
    struct Question
    {
        public string question;
        public Answer[] answers;
    }

    struct Answer
    {
        public string answer;
        public bool yesno;
    }

    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
    }
}
