namespace SanityArchiver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftBrowser = new System.Windows.Forms.WebBrowser();
            this.RightBrowser = new System.Windows.Forms.WebBrowser();
            this.LeftBox = new System.Windows.Forms.ListBox();
            this.RightBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CompressLeft = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LeftBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightBrowser, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeftBrowser
            // 
            this.LeftBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftBrowser.Location = new System.Drawing.Point(3, 3);
            this.LeftBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.LeftBrowser.Name = "LeftBrowser";
            this.LeftBrowser.Size = new System.Drawing.Size(489, 603);
            this.LeftBrowser.TabIndex = 0;
            // 
            // RightBrowser
            // 
            this.RightBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightBrowser.Location = new System.Drawing.Point(498, 3);
            this.RightBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.RightBrowser.Name = "RightBrowser";
            this.RightBrowser.Size = new System.Drawing.Size(489, 603);
            this.RightBrowser.TabIndex = 1;
            // 
            // LeftBox
            // 
            this.LeftBox.FormattingEnabled = true;
            this.LeftBox.ItemHeight = 16;
            this.LeftBox.Location = new System.Drawing.Point(0, 1);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(120, 52);
            this.LeftBox.TabIndex = 1;
            this.LeftBox.SelectedIndexChanged += new System.EventHandler(this.LeftBox_SelectedIndexChanged);
            // 
            // RightBox
            // 
            this.RightBox.FormattingEnabled = true;
            this.RightBox.ItemHeight = 16;
            this.RightBox.Location = new System.Drawing.Point(498, 1);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(131, 52);
            this.RightBox.TabIndex = 2;
            this.RightBox.SelectedIndexChanged += new System.EventHandler(this.RightBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompressLeft
            // 
            this.CompressLeft.Location = new System.Drawing.Point(126, 31);
            this.CompressLeft.Name = "CompressLeft";
            this.CompressLeft.Size = new System.Drawing.Size(75, 23);
            this.CompressLeft.TabIndex = 5;
            this.CompressLeft.Text = "Compress";
            this.CompressLeft.UseVisualStyleBackColor = true;
            this.CompressLeft.Click += new System.EventHandler(this.CompressLeft_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(208, 1);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(284, 52);
            this.Display.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(992, 665);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.CompressLeft);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.LeftBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser LeftBrowser;
        private System.Windows.Forms.WebBrowser RightBrowser;
        private System.Windows.Forms.ListBox LeftBox;
        private System.Windows.Forms.ListBox RightBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CompressLeft;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button button1;
    }
}

