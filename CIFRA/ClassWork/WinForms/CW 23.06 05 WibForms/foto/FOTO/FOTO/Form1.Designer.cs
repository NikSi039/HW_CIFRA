namespace FOTO
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
            rb3_4 = new RadioButton();
            rb9_12 = new RadioButton();
            groupBox1 = new GroupBox();
            tbPrice18_24 = new TextBox();
            tbPrice12_15 = new TextBox();
            tbPrice9_12 = new TextBox();
            tbPrice3_4 = new TextBox();
            rb12_15 = new RadioButton();
            rb18_24 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            tbCount = new TextBox();
            btOk = new Button();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rb3_4
            // 
            rb3_4.AutoSize = true;
            rb3_4.Location = new Point(9, 57);
            rb3_4.Margin = new Padding(5);
            rb3_4.Name = "rb3_4";
            rb3_4.Size = new Size(110, 55);
            rb3_4.TabIndex = 0;
            rb3_4.TabStop = true;
            rb3_4.Text = "3x4";
            rb3_4.UseVisualStyleBackColor = true;
            // 
            // rb9_12
            // 
            rb9_12.AutoSize = true;
            rb9_12.Location = new Point(9, 115);
            rb9_12.Margin = new Padding(5);
            rb9_12.Name = "rb9_12";
            rb9_12.Size = new Size(130, 55);
            rb9_12.TabIndex = 1;
            rb9_12.TabStop = true;
            rb9_12.Text = "9x12";
            rb9_12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPrice18_24);
            groupBox1.Controls.Add(tbPrice12_15);
            groupBox1.Controls.Add(tbPrice9_12);
            groupBox1.Controls.Add(tbPrice3_4);
            groupBox1.Controls.Add(rb12_15);
            groupBox1.Controls.Add(rb18_24);
            groupBox1.Controls.Add(rb3_4);
            groupBox1.Controls.Add(rb9_12);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 20);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(346, 342);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размер фото и цена";
            // 
            // tbPrice18_24
            // 
            tbPrice18_24.Location = new Point(181, 229);
            tbPrice18_24.Margin = new Padding(5);
            tbPrice18_24.Name = "tbPrice18_24";
            tbPrice18_24.Size = new Size(155, 57);
            tbPrice18_24.TabIndex = 8;
            // 
            // tbPrice12_15
            // 
            tbPrice12_15.Location = new Point(181, 173);
            tbPrice12_15.Margin = new Padding(5);
            tbPrice12_15.Name = "tbPrice12_15";
            tbPrice12_15.Size = new Size(155, 57);
            tbPrice12_15.TabIndex = 7;
            // 
            // tbPrice9_12
            // 
            tbPrice9_12.Location = new Point(181, 115);
            tbPrice9_12.Margin = new Padding(5);
            tbPrice9_12.Name = "tbPrice9_12";
            tbPrice9_12.Size = new Size(155, 57);
            tbPrice9_12.TabIndex = 6;
            // 
            // tbPrice3_4
            // 
            tbPrice3_4.Location = new Point(181, 57);
            tbPrice3_4.Margin = new Padding(5);
            tbPrice3_4.Name = "tbPrice3_4";
            tbPrice3_4.Size = new Size(155, 57);
            tbPrice3_4.TabIndex = 5;
            // 
            // rb12_15
            // 
            rb12_15.AutoSize = true;
            rb12_15.Location = new Point(9, 173);
            rb12_15.Margin = new Padding(5);
            rb12_15.Name = "rb12_15";
            rb12_15.Size = new Size(150, 55);
            rb12_15.TabIndex = 3;
            rb12_15.TabStop = true;
            rb12_15.Text = "12x15";
            rb12_15.UseVisualStyleBackColor = true;
            // 
            // rb18_24
            // 
            rb18_24.AutoSize = true;
            rb18_24.Location = new Point(9, 232);
            rb18_24.Margin = new Padding(5);
            rb18_24.Name = "rb18_24";
            rb18_24.Size = new Size(150, 55);
            rb18_24.TabIndex = 2;
            rb18_24.TabStop = true;
            rb18_24.Text = "18x24";
            rb18_24.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 75);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 57);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 367);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(469, 51);
            label1.TabIndex = 5;
            label1.Text = "Введите количество фото";
            // 
            // tbCount
            // 
            tbCount.Location = new Point(188, 421);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(219, 57);
            tbCount.TabIndex = 6;
            tbCount.TextChanged += tbCount_TextChanged;
            // 
            // btOk
            // 
            btOk.Location = new Point(239, 484);
            btOk.Name = "btOk";
            btOk.Size = new Size(116, 50);
            btOk.TabIndex = 7;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // lbResult
            // 
            lbResult.Location = new Point(132, 570);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(327, 170);
            lbResult.TabIndex = 8;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 749);
            Controls.Add(lbResult);
            Controls.Add(btOk);
            Controls.Add(tbCount);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FOTO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb3_4;
        private RadioButton rb9_12;
        private GroupBox groupBox1;
        private TextBox tbPrice3_4;
        private RadioButton rb12_15;
        private RadioButton rb18_24;
        private TextBox textBox1;
        private TextBox tbPrice18_24;
        private TextBox tbPrice12_15;
        private TextBox tbPrice9_12;
        private Label label1;
        private TextBox tbCount;
        private Button btOk;
        private Label lbResult;
    }
}