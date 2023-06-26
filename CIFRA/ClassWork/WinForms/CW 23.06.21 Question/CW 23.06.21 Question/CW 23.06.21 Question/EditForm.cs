using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_23._06._21_Question
{
    struct Question
    {
        public string question;
        public int countQuestion;
        public Answer[] answers;
    }

    struct Answer
    {
        public string answer;
        public bool yesno;
    }

    public partial class EditForm : Form
    {
        private int y = 0;
        private List<Question> questions;
        private int count = 0;

        public EditForm()
        {
            InitializeComponent();
            questions = new List<Question>();
        }

        private void btAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl answerControl = new AnswerControl();
            answerControl.Top = y;
            
            plAnswers.Controls.Add(answerControl);
            y += answerControl.Height;
        }

        private void btAddQuestion_Click(object sender, EventArgs e)
        {
            tbQuestion.Clear();
            plAnswers.Controls.Clear();
            y = 0;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Question question = new Question(); 
            question.question = tbQuestion.Text;

            List <Answer> list = new List<Answer>();
            for (int i = 0; i < plAnswers.Controls.Count; i++)
            {
                Answer answer = new Answer();
                answer.answer = ((AnswerControl)plAnswers.Controls[i]).tbAnswer.Text;

                answer.yesno = ((AnswerControl)plAnswers.Controls[i]).cbYesNo.Checked;

                list.Add(answer);
            }
            question.countQuestion = list.Count;

            question.answers = list.ToArray();
            questions.Add(question);
            count++;

            if (questions.Count == count)
            {
                MessageBox.Show("Вопрос успешно сохранен");
            }
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить тест?", "Сохранение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "*.dat|*.dat";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate)))
                    {
                        foreach (Question q in questions)
                        {
                            writer.Write(q.question);
                            writer.Write(q.countQuestion);
                            foreach (Answer ans in q.answers)
                            {
                                writer.Write(ans.answer);
                                writer.Write(ans.yesno);
                            }
                        }
                    }
                }
            }  
        }
    }
}
