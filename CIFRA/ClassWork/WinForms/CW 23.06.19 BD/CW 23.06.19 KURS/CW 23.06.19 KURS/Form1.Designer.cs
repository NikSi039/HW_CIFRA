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
            dtpDate = new DateTimePicker();
            btAdd = new Button();
            nudRubbles = new NumericUpDown();
            nudKopeek = new NumericUpDown();
            cbCurrent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRubbles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKopeek).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(43, 55);
            dtpDate.Margin = new Padding(6, 6, 6, 6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(368, 39);
            dtpDate.TabIndex = 0;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(158, 337);
            btAdd.Margin = new Padding(6, 6, 6, 6);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(139, 49);
            btAdd.TabIndex = 2;
            btAdd.Text = "Добавить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // nudRubbles
            // 
            nudRubbles.Location = new Point(43, 230);
            nudRubbles.Margin = new Padding(6, 6, 6, 6);
            nudRubbles.Name = "nudRubbles";
            nudRubbles.Size = new Size(208, 39);
            nudRubbles.TabIndex = 3;
            // 
            // nudKopeek
            // 
            nudKopeek.Location = new Point(262, 230);
            nudKopeek.Margin = new Padding(6, 6, 6, 6);
            nudKopeek.Name = "nudKopeek";
            nudKopeek.Size = new Size(152, 39);
            nudKopeek.TabIndex = 4;
            // 
            // cbCurrent
            // 
            cbCurrent.FormattingEnabled = true;
            cbCurrent.Items.AddRange(new object[] { "USD", "EURO", "POUND" });
            cbCurrent.Location = new Point(43, 141);
            cbCurrent.Margin = new Padding(6, 6, 6, 6);
            cbCurrent.Name = "cbCurrent";
            cbCurrent.Size = new Size(362, 40);
            cbCurrent.TabIndex = 5;
            // 
            // frmKurs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(cbCurrent);
            Controls.Add(nudKopeek);
            Controls.Add(nudRubbles);
            Controls.Add(btAdd);
            Controls.Add(dtpDate);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmKurs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Курс валюты";
            ((System.ComponentModel.ISupportInitialize)nudRubbles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKopeek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btAdd;
        private NumericUpDown nudRubbles;
        private NumericUpDown nudKopeek;
        private ComboBox cbCurrent;
    }
}