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
            this.rb3_4 = new System.Windows.Forms.RadioButton();
            this.rb9_12 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrice18_24 = new System.Windows.Forms.TextBox();
            this.tbPrice12_15 = new System.Windows.Forms.TextBox();
            this.tbPrice9_12 = new System.Windows.Forms.TextBox();
            this.tbPrice3_4 = new System.Windows.Forms.TextBox();
            this.rb12_15 = new System.Windows.Forms.RadioButton();
            this.rb18_24 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb3_4
            // 
            this.rb3_4.AutoSize = true;
            this.rb3_4.Location = new System.Drawing.Point(9, 57);
            this.rb3_4.Margin = new System.Windows.Forms.Padding(5);
            this.rb3_4.Name = "rb3_4";
            this.rb3_4.Size = new System.Drawing.Size(59, 29);
            this.rb3_4.TabIndex = 0;
            this.rb3_4.TabStop = true;
            this.rb3_4.Text = "3x4";
            this.rb3_4.UseVisualStyleBackColor = true;
            // 
            // rb9_12
            // 
            this.rb9_12.AutoSize = true;
            this.rb9_12.Location = new System.Drawing.Point(9, 115);
            this.rb9_12.Margin = new System.Windows.Forms.Padding(5);
            this.rb9_12.Name = "rb9_12";
            this.rb9_12.Size = new System.Drawing.Size(69, 29);
            this.rb9_12.TabIndex = 1;
            this.rb9_12.TabStop = true;
            this.rb9_12.Text = "9x12";
            this.rb9_12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrice18_24);
            this.groupBox1.Controls.Add(this.tbPrice12_15);
            this.groupBox1.Controls.Add(this.tbPrice9_12);
            this.groupBox1.Controls.Add(this.tbPrice3_4);
            this.groupBox1.Controls.Add(this.rb12_15);
            this.groupBox1.Controls.Add(this.rb18_24);
            this.groupBox1.Controls.Add(this.rb3_4);
            this.groupBox1.Controls.Add(this.rb9_12);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(346, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер фото и цена";
            // 
            // tbPrice18_24
            // 
            this.tbPrice18_24.Location = new System.Drawing.Point(181, 229);
            this.tbPrice18_24.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice18_24.Name = "tbPrice18_24";
            this.tbPrice18_24.Size = new System.Drawing.Size(155, 32);
            this.tbPrice18_24.TabIndex = 8;
            this.tbPrice18_24.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbPrice12_15
            // 
            this.tbPrice12_15.Location = new System.Drawing.Point(181, 173);
            this.tbPrice12_15.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice12_15.Name = "tbPrice12_15";
            this.tbPrice12_15.Size = new System.Drawing.Size(155, 32);
            this.tbPrice12_15.TabIndex = 7;
            // 
            // tbPrice9_12
            // 
            this.tbPrice9_12.Location = new System.Drawing.Point(181, 115);
            this.tbPrice9_12.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice9_12.Name = "tbPrice9_12";
            this.tbPrice9_12.Size = new System.Drawing.Size(155, 32);
            this.tbPrice9_12.TabIndex = 6;
            // 
            // tbPrice3_4
            // 
            this.tbPrice3_4.Location = new System.Drawing.Point(181, 57);
            this.tbPrice3_4.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice3_4.Name = "tbPrice3_4";
            this.tbPrice3_4.Size = new System.Drawing.Size(155, 32);
            this.tbPrice3_4.TabIndex = 5;
            // 
            // rb12_15
            // 
            this.rb12_15.AutoSize = true;
            this.rb12_15.Location = new System.Drawing.Point(9, 173);
            this.rb12_15.Margin = new System.Windows.Forms.Padding(5);
            this.rb12_15.Name = "rb12_15";
            this.rb12_15.Size = new System.Drawing.Size(79, 29);
            this.rb12_15.TabIndex = 3;
            this.rb12_15.TabStop = true;
            this.rb12_15.Text = "12x15";
            this.rb12_15.UseVisualStyleBackColor = true;
            // 
            // rb18_24
            // 
            this.rb18_24.AutoSize = true;
            this.rb18_24.Location = new System.Drawing.Point(9, 232);
            this.rb18_24.Margin = new System.Windows.Forms.Padding(5);
            this.rb18_24.Name = "rb18_24";
            this.rb18_24.Size = new System.Drawing.Size(79, 29);
            this.rb18_24.TabIndex = 2;
            this.rb18_24.TabStop = true;
            this.rb18_24.Text = "18x24";
            this.rb18_24.UseVisualStyleBackColor = true;
            this.rb18_24.CheckedChanged += new System.EventHandler(this.rb18_24_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите количество фото";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(86, 429);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(219, 32);
            this.tbCount.TabIndex = 6;
            this.tbCount.TextChanged += new System.EventHandler(this.tbCount_TextChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(136, 485);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(116, 50);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(28, 570);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(327, 170);
            this.lbResult.TabIndex = 8;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 749);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOTO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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