namespace CW_23._06._21_Question
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int countQuestion;
        private int currentQuestion;

        public Form1()
        {
            InitializeComponent();
            questions = new List<Question>();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.Show();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void çàãðóçèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "*.dat|*.dat";

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(openFD.FileName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        Question question = new Question();
                        question.question = reader.ReadString();
                        question.countQuestion = reader.ReadInt32();

                        List<Answer> answerList = new List<Answer>();
                        for (int i = 0; i < question.countQuestion; i++)
                        {
                            Answer answer = new Answer();
                            answer.answer = reader.ReadString();
                            answer.yesno = reader.ReadBoolean();
                            answerList.Add(answer);
                        }
                        question.answers = answerList.ToArray();
                        questions.Add(question);
                    }
                    countQuestion = questions.Count;
                    currentQuestion = 0;    

                    GroupBox label = new GroupBox();
                    label.Text = questions[currentQuestion].question;

                    int y = 0;
                    label.Top = y;

                    plQuestions.Controls.Add(label);
                    y += 20;

                    for (int i = 0; i < questions[currentQuestion].answers.Length; i++)
                    {
                        RadioButton radio = new RadioButton();
                        radio.Text = questions[currentQuestion].answers[i].answer;
                        radio.Top = y;
                        label.Controls.Add(radio);
                        y += 20;
                    }
                    plQuestions.Controls.Add(label);    
                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            plQuestions.Controls.Clear();

            GroupBox label = new GroupBox();
            label.Text = questions[currentQuestion].question;

            int y = 0;
            label.Top = y;

            plQuestions.Controls.Add(label);
            y += 20;

            for (int i = 0; i < questions[currentQuestion].answers.Length; i++)
            {
                RadioButton radio = new RadioButton();
                radio.Text = questions[currentQuestion].answers[i].answer;
                radio.Top = y;
                label.Controls.Add(radio);
                y += 20;
            }
            plQuestions.Controls.Add(label);
        }
    }
}