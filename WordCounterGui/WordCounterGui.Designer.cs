namespace WordCounterGui
{
    partial class WordCounterGui
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
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.WordCountLabel = new System.Windows.Forms.Label();
            this.CharCountLabel = new System.Windows.Forms.Label();
            this.WhiteSpaceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.AutoSize = true;
            this.EnterTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTextLabel.Location = new System.Drawing.Point(8, 9);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(201, 24);
            this.EnterTextLabel.TabIndex = 0;
            this.EnterTextLabel.Text = "Please enter some text";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(12, 36);
            this.UserText.Multiline = true;
            this.UserText.Name = "UserText";
            this.UserText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserText.Size = new System.Drawing.Size(424, 172);
            this.UserText.TabIndex = 1;
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountButton.Location = new System.Drawing.Point(361, 214);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 26);
            this.CountButton.TabIndex = 2;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // WordCountLabel
            // 
            this.WordCountLabel.AutoSize = true;
            this.WordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCountLabel.Location = new System.Drawing.Point(12, 256);
            this.WordCountLabel.Name = "WordCountLabel";
            this.WordCountLabel.Size = new System.Drawing.Size(59, 20);
            this.WordCountLabel.TabIndex = 3;
            this.WordCountLabel.Text = "Words:";
            // 
            // CharCountLabel
            // 
            this.CharCountLabel.AutoSize = true;
            this.CharCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharCountLabel.Location = new System.Drawing.Point(12, 296);
            this.CharCountLabel.Name = "CharCountLabel";
            this.CharCountLabel.Size = new System.Drawing.Size(91, 20);
            this.CharCountLabel.TabIndex = 4;
            this.CharCountLabel.Text = "Characters:";
            // 
            // WhiteSpaceCheckBox
            // 
            this.WhiteSpaceCheckBox.AutoSize = true;
            this.WhiteSpaceCheckBox.Location = new System.Drawing.Point(13, 223);
            this.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox";
            this.WhiteSpaceCheckBox.Size = new System.Drawing.Size(119, 17);
            this.WhiteSpaceCheckBox.TabIndex = 5;
            this.WhiteSpaceCheckBox.Text = "Count white spaces";
            this.WhiteSpaceCheckBox.UseVisualStyleBackColor = true;
            this.WhiteSpaceCheckBox.CheckedChanged += new System.EventHandler(this.WhiteSpaceCheckBox_CheckedChanged);
            // 
            // WordCounterGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 337);
            this.Controls.Add(this.WhiteSpaceCheckBox);
            this.Controls.Add(this.CharCountLabel);
            this.Controls.Add(this.WordCountLabel);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.EnterTextLabel);
            this.Name = "WordCounterGui";
            this.Text = "WordCounter";
            this.Load += new System.EventHandler(this.WordCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterTextLabel;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label WordCountLabel;
        private System.Windows.Forms.Label CharCountLabel;
        private System.Windows.Forms.CheckBox WhiteSpaceCheckBox;
    }
}

