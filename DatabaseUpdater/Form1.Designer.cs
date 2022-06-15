namespace DatabaseUpdater
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
            this.SelectDBLabel = new System.Windows.Forms.Label();
            this.SelectDBButton = new System.Windows.Forms.Button();
            this.SelectCSVLabel = new System.Windows.Forms.Label();
            this.SelectcsvButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectDBLabel
            // 
            this.SelectDBLabel.AutoSize = true;
            this.SelectDBLabel.Location = new System.Drawing.Point(20, 19);
            this.SelectDBLabel.Name = "SelectDBLabel";
            this.SelectDBLabel.Size = new System.Drawing.Size(87, 15);
            this.SelectDBLabel.TabIndex = 0;
            this.SelectDBLabel.Text = "Select a DB file.";
            // 
            // SelectDBButton
            // 
            this.SelectDBButton.Location = new System.Drawing.Point(24, 63);
            this.SelectDBButton.Name = "SelectDBButton";
            this.SelectDBButton.Size = new System.Drawing.Size(75, 23);
            this.SelectDBButton.TabIndex = 1;
            this.SelectDBButton.Text = "Select DB";
            this.SelectDBButton.UseVisualStyleBackColor = true;
            this.SelectDBButton.Click += new System.EventHandler(this.SelectDBButton_Click);
            // 
            // SelectCSVLabel
            // 
            this.SelectCSVLabel.AutoSize = true;
            this.SelectCSVLabel.Location = new System.Drawing.Point(378, 38);
            this.SelectCSVLabel.Name = "SelectCSVLabel";
            this.SelectCSVLabel.Size = new System.Drawing.Size(242, 15);
            this.SelectCSVLabel.TabIndex = 2;
            this.SelectCSVLabel.Text = "Select a csv file that contains file checksums.";
            // 
            // SelectcsvButton
            // 
            this.SelectcsvButton.Location = new System.Drawing.Point(452, 75);
            this.SelectcsvButton.Name = "SelectcsvButton";
            this.SelectcsvButton.Size = new System.Drawing.Size(75, 23);
            this.SelectcsvButton.TabIndex = 3;
            this.SelectcsvButton.Text = "Select csv";
            this.SelectcsvButton.UseVisualStyleBackColor = true;
            this.SelectcsvButton.Click += new System.EventHandler(this.SelectcsvButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(452, 191);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SelectcsvButton);
            this.Controls.Add(this.SelectCSVLabel);
            this.Controls.Add(this.SelectDBButton);
            this.Controls.Add(this.SelectDBLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SelectDBLabel;
        private Button SelectDBButton;
        private Label SelectCSVLabel;
        private Button SelectcsvButton;
        private Button UpdateButton;
    }
}