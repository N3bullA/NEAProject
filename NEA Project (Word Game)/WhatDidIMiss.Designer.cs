namespace NEA_Project__Word_Game_
{
    partial class WhatDidIMiss
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
            WordList = new ListBox();
            label1 = new Label();
            DefineButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // WordList
            // 
            WordList.FormattingEnabled = true;
            WordList.Location = new Point(20, 63);
            WordList.Name = "WordList";
            WordList.ScrollAlwaysVisible = true;
            WordList.Size = new Size(234, 404);
            WordList.TabIndex = 0;
            WordList.SelectedIndexChanged += WordList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 1;
            label1.Text = "All words you have missed:";
            // 
            // DefineButton
            // 
            DefineButton.BackColor = SystemColors.Highlight;
            DefineButton.Enabled = false;
            DefineButton.FlatStyle = FlatStyle.Popup;
            DefineButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefineButton.ForeColor = Color.White;
            DefineButton.Location = new Point(20, 483);
            DefineButton.Name = "DefineButton";
            DefineButton.Size = new Size(90, 41);
            DefineButton.TabIndex = 30;
            DefineButton.Text = "Define";
            DefineButton.UseVisualStyleBackColor = false;
            DefineButton.Click += DefineButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 483);
            label2.Name = "label2";
            label2.Size = new Size(132, 40);
            label2.TabIndex = 31;
            label2.Text = "Select a word here\r\nto define it.\r\n";
            // 
            // WhatDidIMiss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 542);
            Controls.Add(label2);
            Controls.Add(DefineButton);
            Controls.Add(label1);
            Controls.Add(WordList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WhatDidIMiss";
            Text = "What did I miss?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox WordList;
        private Label label1;
        private Button DefineButton;
        private Label label2;
    }
}