﻿namespace firstWinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDollar = new System.Windows.Forms.TextBox();
            this.btResult = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите курс доллара";
            // 
            // tbKurs
            // 
            this.tbKurs.Location = new System.Drawing.Point(91, 105);
            this.tbKurs.Margin = new System.Windows.Forms.Padding(5);
            this.tbKurs.Name = "tbKurs";
            this.tbKurs.Size = new System.Drawing.Size(381, 32);
            this.tbKurs.TabIndex = 1;
            this.tbKurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKurs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите количество долларов для покупки";
            // 
            // tbDollar
            // 
            this.tbDollar.Location = new System.Drawing.Point(91, 217);
            this.tbDollar.Margin = new System.Windows.Forms.Padding(5);
            this.tbDollar.Name = "tbDollar";
            this.tbDollar.Size = new System.Drawing.Size(381, 32);
            this.tbDollar.TabIndex = 3;
            this.tbDollar.TextChanged += new System.EventHandler(this.tbDollar_TextChanged);
            this.tbDollar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDollar_KeyPress);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(214, 303);
            this.btResult.Margin = new System.Windows.Forms.Padding(5);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(118, 38);
            this.btResult.TabIndex = 4;
            this.btResult.Text = "Расчитать";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // lbResult
            // 
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(91, 390);
            this.lbResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(383, 142);
            this.lbResult.TabIndex = 5;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 565);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.tbDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKurs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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