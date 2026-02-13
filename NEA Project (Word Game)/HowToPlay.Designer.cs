namespace NEA_Project__Word_Game_
{
    partial class HowToPlay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 35);
            label1.Name = "label1";
            label1.Size = new Size(193, 41);
            label1.TabIndex = 0;
            label1.Text = "Instructions:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 112);
            label2.Name = "label2";
            label2.Size = new Size(230, 20);
            label2.TabIndex = 1;
            label2.Text = "You will be given a random word.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 141);
            label3.Name = "label3";
            label3.Size = new Size(478, 40);
            label3.TabIndex = 2;
            label3.Text = "Your objective is to list as many words as you can using only the letters \r\nin the word you have been given.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 191);
            label4.Name = "label4";
            label4.Size = new Size(444, 40);
            label4.TabIndex = 3;
            label4.Text = "You can learn about new words along they way by selecting them \r\nand searching up their definition.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 241);
            label5.Name = "label5";
            label5.Size = new Size(472, 40);
            label5.TabIndex = 4;
            label5.Text = "You may time yourself, or impose limitations to the words you can list \r\nthrough game options.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 291);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 5;
            label6.Text = "Good luck!";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ScrollBar;
            CloseButton.DialogResult = DialogResult.OK;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(241, 332);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(92, 41);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // HowToPlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 416);
            Controls.Add(CloseButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HowToPlay";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CloseButton;
    }
}