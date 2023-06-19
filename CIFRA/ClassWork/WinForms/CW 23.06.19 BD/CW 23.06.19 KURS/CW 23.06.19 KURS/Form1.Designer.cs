namespace CW_23._06._19_KURS
{
    partial class frmKurs
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.nudRubbles = new System.Windows.Forms.NumericUpDown();
            this.nudKopeek = new System.Windows.Forms.NumericUpDown();
            this.cbCurrent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKopeek)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(23, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(85, 158);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // nudRubbles
            // 
            this.nudRubbles.Location = new System.Drawing.Point(23, 108);
            this.nudRubbles.Name = "nudRubbles";
            this.nudRubbles.Size = new System.Drawing.Size(112, 23);
            this.nudRubbles.TabIndex = 3;
            // 
            // nudKopeek
            // 
            this.nudKopeek.Location = new System.Drawing.Point(141, 108);
            this.nudKopeek.Name = "nudKopeek";
            this.nudKopeek.Size = new System.Drawing.Size(82, 23);
            this.nudKopeek.TabIndex = 4;
            // 
            // cbCurrent
            // 
            this.cbCurrent.FormattingEnabled = true;
            this.cbCurrent.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "POUND"});
            this.cbCurrent.Location = new System.Drawing.Point(23, 66);
            this.cbCurrent.Name = "cbCurrent";
            this.cbCurrent.Size = new System.Drawing.Size(197, 23);
            this.cbCurrent.TabIndex = 5;
            // 
            // frmKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCurrent);
            this.Controls.Add(this.nudKopeek);
            this.Controls.Add(this.nudRubbles);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmKurs";
            this.Text = "Курс валюты";
            ((System.ComponentModel.ISupportInitialize)(this.nudRubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKopeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btAdd;
        private NumericUpDown nudRubbles;
        private NumericUpDown nudKopeek;
        private ComboBox cbCurrent;
    }
}