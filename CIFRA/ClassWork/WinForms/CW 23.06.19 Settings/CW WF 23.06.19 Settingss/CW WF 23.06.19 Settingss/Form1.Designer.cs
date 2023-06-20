namespace CW_WF_23._06._19_Settingss
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
            lbSettings = new Label();
            lbPosition = new Label();
            SuspendLayout();
            // 
            // lbSettings
            // 
            lbSettings.AutoSize = true;
            lbSettings.Location = new Point(95, 82);
            lbSettings.Margin = new Padding(6, 0, 6, 0);
            lbSettings.Name = "lbSettings";
            lbSettings.Size = new Size(0, 32);
            lbSettings.TabIndex = 0;
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(59, 48);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(119, 32);
            lbPosition.TabIndex = 1;
            lbPosition.Text = "form1.top";
            lbPosition.Click += lbPosition_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 960);
            Controls.Add(lbPosition);
            Controls.Add(lbSettings);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSettings;
        private Label lbPosition;
    }
}