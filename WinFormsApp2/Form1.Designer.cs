namespace WinFormsApp2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReadFromDatabase = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCountWordsNumber = new System.Windows.Forms.Button();
            this.lblStatusCountWordsNumber = new System.Windows.Forms.Label();
            this.lblStatusReadTextFromDatabase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadFromDatabase = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabReadFromDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReadFromDatabase);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 531);
            this.tabControl1.TabIndex = 6;
            // 
            // tabReadFromDatabase
            // 
            this.tabReadFromDatabase.Controls.Add(this.pictureBox1);
            this.tabReadFromDatabase.Controls.Add(this.btnCountWordsNumber);
            this.tabReadFromDatabase.Controls.Add(this.lblStatusCountWordsNumber);
            this.tabReadFromDatabase.Controls.Add(this.lblStatusReadTextFromDatabase);
            this.tabReadFromDatabase.Controls.Add(this.label2);
            this.tabReadFromDatabase.Controls.Add(this.label1);
            this.tabReadFromDatabase.Controls.Add(this.btnReadFromDatabase);
            this.tabReadFromDatabase.Location = new System.Drawing.Point(4, 24);
            this.tabReadFromDatabase.Name = "tabReadFromDatabase";
            this.tabReadFromDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabReadFromDatabase.Size = new System.Drawing.Size(899, 503);
            this.tabReadFromDatabase.TabIndex = 0;
            this.tabReadFromDatabase.Text = "Read a text from database";
            this.tabReadFromDatabase.UseVisualStyleBackColor = true;
            this.tabReadFromDatabase.Click += new System.EventHandler(this.tabReadFromDatabase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Image = global::WinFormsApp2.Properties.Resources.White_png_120;
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 70);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCountWordsNumber
            // 
            this.btnCountWordsNumber.Enabled = false;
            this.btnCountWordsNumber.Location = new System.Drawing.Point(188, 209);
            this.btnCountWordsNumber.Name = "btnCountWordsNumber";
            this.btnCountWordsNumber.Size = new System.Drawing.Size(218, 28);
            this.btnCountWordsNumber.TabIndex = 6;
            this.btnCountWordsNumber.Text = "Count number of words in a text";
            this.btnCountWordsNumber.UseVisualStyleBackColor = true;
            this.btnCountWordsNumber.Click += new System.EventHandler(this.btnCountWordsNumber_Click);
            // 
            // lblStatusCountWordsNumber
            // 
            this.lblStatusCountWordsNumber.AutoSize = true;
            this.lblStatusCountWordsNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusCountWordsNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatusCountWordsNumber.Location = new System.Drawing.Point(480, 221);
            this.lblStatusCountWordsNumber.Name = "lblStatusCountWordsNumber";
            this.lblStatusCountWordsNumber.Size = new System.Drawing.Size(10, 15);
            this.lblStatusCountWordsNumber.TabIndex = 5;
            this.lblStatusCountWordsNumber.Text = ":";
            // 
            // lblStatusReadTextFromDatabase
            // 
            this.lblStatusReadTextFromDatabase.AutoSize = true;
            this.lblStatusReadTextFromDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusReadTextFromDatabase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatusReadTextFromDatabase.Location = new System.Drawing.Point(480, 171);
            this.lblStatusReadTextFromDatabase.Name = "lblStatusReadTextFromDatabase";
            this.lblStatusReadTextFromDatabase.Size = new System.Drawing.Size(10, 15);
            this.lblStatusReadTextFromDatabase.TabIndex = 4;
            this.lblStatusReadTextFromDatabase.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.";
            // 
            // btnReadFromDatabase
            // 
            this.btnReadFromDatabase.Location = new System.Drawing.Point(188, 162);
            this.btnReadFromDatabase.Name = "btnReadFromDatabase";
            this.btnReadFromDatabase.Size = new System.Drawing.Size(219, 24);
            this.btnReadFromDatabase.TabIndex = 0;
            this.btnReadFromDatabase.Text = "Read a text from database";
            this.btnReadFromDatabase.UseVisualStyleBackColor = true;
            this.btnReadFromDatabase.Click += new System.EventHandler(this.btnReadFromDatabase_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read a text from a local file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(899, 503);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Read a text from windows form";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabReadFromDatabase.ResumeLayout(false);
            this.tabReadFromDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabReadFromDatabase;
        private PictureBox pictureBox1;
        private Button btnCountWordsNumber;
        private Label lblStatusCountWordsNumber;
        private Label lblStatusReadTextFromDatabase;
        private Label label2;
        private Label label1;
        private Button btnReadFromDatabase;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}