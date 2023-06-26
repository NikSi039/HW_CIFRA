namespace CW_23._06._21_Question
{
    partial class AnswerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.cbYesNo = new System.Windows.Forms.CheckBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(13, 13);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(461, 23);
            this.tbAnswer.TabIndex = 0;
            // 
            // cbYesNo
            // 
            this.cbYesNo.AutoSize = true;
            this.cbYesNo.Location = new System.Drawing.Point(511, 15);
            this.cbYesNo.Name = "cbYesNo";
            this.cbYesNo.Size = new System.Drawing.Size(88, 19);
            this.cbYesNo.TabIndex = 1;
            this.cbYesNo.Text = "Правильно";
            this.cbYesNo.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(643, 11);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Удалить";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.cbYesNo);
            this.Controls.Add(this.tbAnswer);
            this.Name = "AnswerControl";
            this.Size = new System.Drawing.Size(776, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tbAnswer;
        public CheckBox cbYesNo;
        public Button btRemove;
    }
}
