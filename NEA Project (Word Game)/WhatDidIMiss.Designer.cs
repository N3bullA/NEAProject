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
            tempbox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tempbox
            // 
            tempbox.FormattingEnabled = true;
            tempbox.Location = new Point(20, 63);
            tempbox.Name = "tempbox";
            tempbox.ScrollAlwaysVisible = true;
            tempbox.Size = new Size(234, 404);
            tempbox.TabIndex = 0;
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
            // WhatDidIMiss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 496);
            Controls.Add(label1);
            Controls.Add(tempbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WhatDidIMiss";
            Text = "What did I miss?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tempbox;
        private Label label1;
    }
}