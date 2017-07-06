namespace SanityArchiver
{
    partial class Decompress
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
            this.LeftDisplay = new System.Windows.Forms.ListBox();
            this.LeftBox = new System.Windows.Forms.ListBox();
            this.BackLeft = new System.Windows.Forms.Button();
            this.CompressLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FreeSpaceAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.myConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReadText = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.saveText = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Hidden = new System.Windows.Forms.Button();
            this.regex = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Label();
            this.FromPath = new System.Windows.Forms.TextBox();
            this.ToPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoveTo = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SetDestination = new System.Windows.Forms.Button();
            this.SetFilePath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copyMove = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Occupied = new System.Windows.Forms.Label();
            this.OccupiedAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftDisplay
            // 
            this.LeftDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftDisplay.FormattingEnabled = true;
            this.LeftDisplay.ItemHeight = 22;
            this.LeftDisplay.Location = new System.Drawing.Point(0, 59);
            this.LeftDisplay.Name = "LeftDisplay";
            this.LeftDisplay.Size = new System.Drawing.Size(606, 576);
            this.LeftDisplay.TabIndex = 0;
            this.LeftDisplay.DoubleClick += new System.EventHandler(this.LeftDisplay_DoubleClick);
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
            // BackLeft
            // 
            this.BackLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackLeft.Location = new System.Drawing.Point(531, 12);
            this.BackLeft.Name = "BackLeft";
            this.BackLeft.Size = new System.Drawing.Size(75, 49);
            this.BackLeft.TabIndex = 3;
            this.BackLeft.Text = "Back";
            this.BackLeft.UseVisualStyleBackColor = true;
            this.BackLeft.Click += new System.EventHandler(this.BackLeft_Click);
            // 
            // CompressLeft
            // 
            this.CompressLeft.Location = new System.Drawing.Point(773, 399);
            this.CompressLeft.Name = "CompressLeft";
            this.CompressLeft.Size = new System.Drawing.Size(92, 30);
            this.CompressLeft.TabIndex = 4;
            this.CompressLeft.Text = "Compress";
            this.CompressLeft.UseVisualStyleBackColor = true;
            this.CompressLeft.Click += new System.EventHandler(this.CompressLeft_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 6;
            this.label1.Tag = "0";
            this.label1.Text = "Free space:";
            // 
            // FreeSpaceAmount
            // 
            this.FreeSpaceAmount.AutoSize = true;
            this.FreeSpaceAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FreeSpaceAmount.Location = new System.Drawing.Point(234, 9);
            this.FreeSpaceAmount.Name = "FreeSpaceAmount";
            this.FreeSpaceAmount.Size = new System.Drawing.Size(47, 22);
            this.FreeSpaceAmount.TabIndex = 7;
            this.FreeSpaceAmount.Tag = "0";
            this.FreeSpaceAmount.Text = "NaN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Decompress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myConsole
            // 
            this.myConsole.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myConsole.Location = new System.Drawing.Point(612, 109);
            this.myConsole.Multiline = true;
            this.myConsole.Name = "myConsole";
            this.myConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myConsole.Size = new System.Drawing.Size(531, 283);
            this.myConsole.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(808, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Console";
            // 
            // ReadText
            // 
            this.ReadText.Location = new System.Drawing.Point(612, 398);
            this.ReadText.Name = "ReadText";
            this.ReadText.Size = new System.Drawing.Size(133, 31);
            this.ReadText.TabIndex = 11;
            this.ReadText.Text = "Open textfile";
            this.ReadText.UseVisualStyleBackColor = true;
            this.ReadText.Click += new System.EventHandler(this.ReadText_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(896, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Encrypt file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(896, 436);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(97, 29);
            this.Decrypt.TabIndex = 13;
            this.Decrypt.Text = "Decrypt file";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // saveText
            // 
            this.saveText.Location = new System.Drawing.Point(612, 435);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(143, 31);
            this.saveText.TabIndex = 14;
            this.saveText.Text = "Save to text";
            this.saveText.UseVisualStyleBackColor = true;
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1046, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 51);
            this.button3.TabIndex = 15;
            this.button3.Text = "Toggle Read-Only";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(1046, 457);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(97, 58);
            this.Hidden.TabIndex = 16;
            this.Hidden.Text = "Toggle Hidden";
            this.Hidden.UseVisualStyleBackColor = true;
            this.Hidden.Click += new System.EventHandler(this.Hidden_Click);
            // 
            // regex
            // 
            this.regex.Location = new System.Drawing.Point(0, 641);
            this.regex.Name = "regex";
            this.regex.Size = new System.Drawing.Size(185, 22);
            this.regex.TabIndex = 17;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(192, 641);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(12, 666);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(0, 17);
            this.Location.TabIndex = 19;
            // 
            // FromPath
            // 
            this.FromPath.Location = new System.Drawing.Point(0, 31);
            this.FromPath.Name = "FromPath";
            this.FromPath.Size = new System.Drawing.Size(261, 22);
            this.FromPath.TabIndex = 20;
            // 
            // ToPath
            // 
            this.ToPath.Location = new System.Drawing.Point(0, 83);
            this.ToPath.Name = "ToPath";
            this.ToPath.Size = new System.Drawing.Size(261, 22);
            this.ToPath.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MoveTo);
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.SetDestination);
            this.panel1.Controls.Add(this.SetFilePath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FromPath);
            this.panel1.Controls.Add(this.ToPath);
            this.panel1.Location = new System.Drawing.Point(612, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 199);
            this.panel1.TabIndex = 22;
            // 
            // MoveTo
            // 
            this.MoveTo.Location = new System.Drawing.Point(133, 145);
            this.MoveTo.Name = "MoveTo";
            this.MoveTo.Size = new System.Drawing.Size(75, 37);
            this.MoveTo.TabIndex = 27;
            this.MoveTo.Text = "Move to";
            this.MoveTo.UseVisualStyleBackColor = true;
            this.MoveTo.Click += new System.EventHandler(this.MoveTo_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(41, 145);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 37);
            this.CopyButton.TabIndex = 26;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SetDestination
            // 
            this.SetDestination.Location = new System.Drawing.Point(267, 82);
            this.SetDestination.Name = "SetDestination";
            this.SetDestination.Size = new System.Drawing.Size(111, 46);
            this.SetDestination.TabIndex = 25;
            this.SetDestination.Text = "Set destination";
            this.SetDestination.UseVisualStyleBackColor = true;
            this.SetDestination.Click += new System.EventHandler(this.SetDestination_Click);
            // 
            // SetFilePath
            // 
            this.SetFilePath.Location = new System.Drawing.Point(267, 8);
            this.SetFilePath.Name = "SetFilePath";
            this.SetFilePath.Size = new System.Drawing.Size(111, 46);
            this.SetFilePath.TabIndex = 24;
            this.SetFilePath.Text = "Set file path";
            this.SetFilePath.UseVisualStyleBackColor = true;
            this.SetFilePath.Click += new System.EventHandler(this.SetFilePath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Destination path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "File path:";
            // 
            // copyMove
            // 
            this.copyMove.Location = new System.Drawing.Point(1046, 521);
            this.copyMove.Name = "copyMove";
            this.copyMove.Size = new System.Drawing.Size(97, 63);
            this.copyMove.TabIndex = 23;
            this.copyMove.Text = "Copy/Move file";
            this.copyMove.UseVisualStyleBackColor = true;
            this.copyMove.Click += new System.EventHandler(this.copyMove_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1046, 603);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 46);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete file";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Occupied
            // 
            this.Occupied.AutoSize = true;
            this.Occupied.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Occupied.Location = new System.Drawing.Point(126, 31);
            this.Occupied.Name = "Occupied";
            this.Occupied.Size = new System.Drawing.Size(147, 22);
            this.Occupied.TabIndex = 25;
            this.Occupied.Text = "Occupied space: ";
            // 
            // OccupiedAmount
            // 
            this.OccupiedAmount.AutoSize = true;
            this.OccupiedAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OccupiedAmount.Location = new System.Drawing.Point(279, 34);
            this.OccupiedAmount.Name = "OccupiedAmount";
            this.OccupiedAmount.Size = new System.Drawing.Size(47, 22);
            this.OccupiedAmount.TabIndex = 26;
            this.OccupiedAmount.Text = "NaN";
            // 
            // Decompress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1155, 713);
            this.Controls.Add(this.OccupiedAmount);
            this.Controls.Add(this.Occupied);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.copyMove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.regex);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReadText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myConsole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FreeSpaceAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftDisplay);
            this.Controls.Add(this.CompressLeft);
            this.Controls.Add(this.BackLeft);
            this.Controls.Add(this.LeftBox);
            this.Name = "Decompress";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LeftBox;
        private System.Windows.Forms.ListBox LeftDisplay;
        private System.Windows.Forms.Button BackLeft;
        private System.Windows.Forms.Button CompressLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FreeSpaceAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox myConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReadText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button saveText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Hidden;
        private System.Windows.Forms.TextBox regex;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox FromPath;
        private System.Windows.Forms.TextBox ToPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetDestination;
        private System.Windows.Forms.Button SetFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button copyMove;
        private System.Windows.Forms.Button MoveTo;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Occupied;
        private System.Windows.Forms.Label OccupiedAmount;
    }
}

