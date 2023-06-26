namespace CW_23._06._21_Question
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.plAnswers = new System.Windows.Forms.Panel();
            this.btAddQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вопрос";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(12, 103);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(776, 147);
            this.tbQuestion.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 256);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 50);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить ответ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAddAnswer_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(166, 256);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(141, 50);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // plAnswers
            // 
            this.plAnswers.AutoScroll = true;
            this.plAnswers.Location = new System.Drawing.Point(12, 312);
            this.plAnswers.Name = "plAnswers";
            this.plAnswers.Size = new System.Drawing.Size(776, 193);
            this.plAnswers.TabIndex = 4;
            // 
            // btAddQuestion
            // 
            this.btAddQuestion.Location = new System.Drawing.Point(12, 2);
            this.btAddQuestion.Name = "btAddQuestion";
            this.btAddQuestion.Size = new System.Drawing.Size(119, 54);
            this.btAddQuestion.TabIndex = 5;
            this.btAddQuestion.Text = "Добавить вопрос";
            this.btAddQuestion.UseVisualStyleBackColor = true;
            this.btAddQuestion.Click += new System.EventHandler(this.btAddQuestion_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btAddQuestion);
            this.Controls.Add(this.plAnswers);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Редактор тестов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbQuestion;
        private Button btAdd;
        private Button btSave;
        private Panel plAnswers;
        private Button btAddQuestion;
    }
}