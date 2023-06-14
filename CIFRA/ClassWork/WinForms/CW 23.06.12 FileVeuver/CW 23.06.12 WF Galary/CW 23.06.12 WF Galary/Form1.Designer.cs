namespace CW_23._06._12_WF_Galary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.cbExtention = new System.Windows.Forms.ComboBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 30;
            this.lbFiles.Location = new System.Drawing.Point(21, 24);
            this.lbFiles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(295, 334);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 770);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(21, 369);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(131, 65);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Обзор";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(374, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(509, 334);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(374, 384);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(0, 30);
            this.lbPath.TabIndex = 4;
            // 
            // cbExtention
            // 
            this.cbExtention.FormattingEnabled = true;
            this.cbExtention.Items.AddRange(new object[] {
            "*.jpg",
            "*.bmp",
            "*.png"});
            this.cbExtention.Location = new System.Drawing.Point(173, 369);
            this.cbExtention.Name = "cbExtention";
            this.cbExtention.Size = new System.Drawing.Size(143, 38);
            this.cbExtention.TabIndex = 5;
            this.cbExtention.SelectedIndexChanged += new System.EventHandler(this.cbExtention_SelectedIndexChanged);
            // 
            // btNext
            // 
            this.btNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNext.BackgroundImage")));
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNext.Location = new System.Drawing.Point(786, 378);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(97, 56);
            this.btNext.TabIndex = 6;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrev.BackgroundImage")));
            this.btPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrev.Location = new System.Drawing.Point(678, 378);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(102, 56);
            this.btPrev.TabIndex = 7;
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 446);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.cbExtention);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Галерея";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbFiles;
        private Button button1;
        private Button btBrowse;
        private PictureBox pbImage;
        private Label lbPath;
        private ComboBox cbExtention;
        private Button btNext;
        private Button btPrev;
    }
}