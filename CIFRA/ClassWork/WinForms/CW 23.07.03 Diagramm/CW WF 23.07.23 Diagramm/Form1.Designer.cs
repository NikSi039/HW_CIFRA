namespace CW_WF_23._07._23_Diagramm
{
    partial class FormKurs
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
            this.btLoad = new System.Windows.Forms.Button();
            this.plGraf = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvKurs = new System.Windows.Forms.DataGridView();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btLoad.Location = new System.Drawing.Point(12, 407);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(130, 32);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // plGraf
            // 
            this.plGraf.Location = new System.Drawing.Point(302, 12);
            this.plGraf.Name = "plGraf";
            this.plGraf.Size = new System.Drawing.Size(486, 389);
            this.plGraf.TabIndex = 2;
            this.plGraf.SizeChanged += new System.EventHandler(this.plGraf_SizeChanged);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSave.Location = new System.Drawing.Point(148, 407);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(148, 32);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgvKurs
            // 
            this.dgvKurs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnData,
            this.ColumnKurs});
            this.dgvKurs.Location = new System.Drawing.Point(12, 12);
            this.dgvKurs.Name = "dgvKurs";
            this.dgvKurs.RowTemplate.Height = 25;
            this.dgvKurs.Size = new System.Drawing.Size(284, 389);
            this.dgvKurs.TabIndex = 4;
            this.dgvKurs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurs_CellValueChanged);
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            // 
            // ColumnKurs
            // 
            this.ColumnKurs.HeaderText = "Kurs";
            this.ColumnKurs.Name = "ColumnKurs";
            // 
            // FormKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKurs);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.plGraf);
            this.Controls.Add(this.btLoad);
            this.Name = "FormKurs";
            this.Text = "Курс валюты";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btLoad;
        private Panel plGraf;
        private Button btSave;
        private DataGridView dgvKurs;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnKurs;
    }
}