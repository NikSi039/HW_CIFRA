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
            this.lbKurs = new System.Windows.Forms.ListBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.mcFilter = new System.Windows.Forms.MonthCalendar();
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
            this.btAdd.Location = new System.Drawing.Point(145, 154);
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
            // lbKurs
            // 
            this.lbKurs.FormattingEnabled = true;
            this.lbKurs.ItemHeight = 15;
            this.lbKurs.Location = new System.Drawing.Point(274, 26);
            this.lbKurs.Name = "lbKurs";
            this.lbKurs.Size = new System.Drawing.Size(432, 274);
            this.lbKurs.TabIndex = 6;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(34, 154);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // mcFilter
            // 
            this.mcFilter.Location = new System.Drawing.Point(44, 201);
            this.mcFilter.Name = "mcFilter";
            this.mcFilter.ShowWeekNumbers = true;
            this.mcFilter.TabIndex = 8;
            this.mcFilter.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFilter_DateChanged);
            // 
            // frmKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 469);
            this.Controls.Add(this.mcFilter);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.lbKurs);
            this.Controls.Add(this.cbCurrent);
            this.Controls.Add(this.nudKopeek);
            this.Controls.Add(this.nudRubbles);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtpDate);
            this.Name = "frmKurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс валюты";
            this.Load += new System.EventHandler(this.frmKurs_Load);
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
        private ListBox lbKurs;
        private Button btLoad;
        private MonthCalendar mcFilter;
    }
}