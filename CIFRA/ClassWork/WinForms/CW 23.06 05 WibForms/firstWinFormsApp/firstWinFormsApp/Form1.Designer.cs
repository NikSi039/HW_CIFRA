namespace firstWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbKurs = new TextBox();
            label2 = new Label();
            tbDollar = new TextBox();
            btResult = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(403, 51);
            label1.TabIndex = 0;
            label1.Text = "Введите курс доллара";
            // 
            // tbKurs
            // 
            tbKurs.Location = new Point(289, 115);
            tbKurs.Margin = new Padding(5);
            tbKurs.Name = "tbKurs";
            tbKurs.Size = new Size(381, 57);
            tbKurs.TabIndex = 1;
            tbKurs.KeyPress += tbKurs_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 177);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(559, 102);
            label2.TabIndex = 2;
            label2.Text = "Введите количество долларов \r\nдля покупки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDollar
            // 
            tbDollar.Location = new Point(280, 303);
            tbDollar.Margin = new Padding(5);
            tbDollar.Name = "tbDollar";
            tbDollar.Size = new Size(381, 57);
            tbDollar.TabIndex = 3;
            tbDollar.KeyPress += tbDollar_KeyPress;
            // 
            // btResult
            // 
            btResult.Location = new Point(325, 391);
            btResult.Margin = new Padding(5);
            btResult.Name = "btResult";
            btResult.Size = new Size(283, 103);
            btResult.TabIndex = 4;
            btResult.Text = "Расчитать";
            btResult.UseVisualStyleBackColor = true;
            btResult.Click += btResult_Click;
            // 
            // lbResult
            // 
            lbResult.ForeColor = Color.Red;
            lbResult.Location = new Point(267, 526);
            lbResult.Margin = new Padding(5, 0, 5, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(383, 142);
            lbResult.TabIndex = 5;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 733);
            Controls.Add(lbResult);
            Controls.Add(btResult);
            Controls.Add(tbDollar);
            Controls.Add(label2);
            Controls.Add(tbKurs);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конвертер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbKurs;
        private Label label2;
        private TextBox tbDollar;
        private Button btResult;
        private Label lbResult;
    }
}