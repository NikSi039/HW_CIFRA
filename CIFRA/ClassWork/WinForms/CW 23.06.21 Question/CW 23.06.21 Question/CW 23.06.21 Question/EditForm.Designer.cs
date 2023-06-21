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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAddAnswer = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAddQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вопрос";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 147);
            this.textBox1.TabIndex = 1;
            // 
            // btAddAnswer
            // 
            this.btAddAnswer.Location = new System.Drawing.Point(12, 292);
            this.btAddAnswer.Name = "btAddAnswer";
            this.btAddAnswer.Size = new System.Drawing.Size(122, 50);
            this.btAddAnswer.TabIndex = 2;
            this.btAddAnswer.Text = "Добавить ответ";
            this.btAddAnswer.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(174, 292);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 50);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 157);
            this.panel1.TabIndex = 4;
            // 
            // btAddQuestion
            // 
            this.btAddQuestion.Location = new System.Drawing.Point(12, 2);
            this.btAddQuestion.Name = "btAddQuestion";
            this.btAddQuestion.Size = new System.Drawing.Size(119, 54);
            this.btAddQuestion.TabIndex = 5;
            this.btAddQuestion.Text = "Добавить вопрос";
            this.btAddQuestion.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btAddQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAddAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Редактор тестов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btAddAnswer;
        private Button btSave;
        private Panel panel1;
        private Button btAddQuestion;
    }
}