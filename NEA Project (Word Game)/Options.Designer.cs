namespace NEA_Project__Word_Game_
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            PromptRootOption = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            EnableTimerOption = new CheckBox();
            TimerLength = new TextBox();
            TimerLengthLabel = new Label();
            StringModeOption = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            PromptMinLengthOptionText = new TextBox();
            InputLengthOptionText = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            ErrorTextPromptLength = new Label();
            ErrorTextInputLength = new Label();
            ErrorTextTimerLength = new Label();
            DynamicTimerOption = new CheckBox();
            TimerIncrement = new TextBox();
            TimerIncrementLabel = new Label();
            ErrorTextTimerIncrement = new Label();
            label3 = new Label();
            PromptMaxLengthOptionText = new TextBox();
            PromptSelectionDatabase = new CheckedListBox();
            label7 = new Label();
            WordListSelectionDatabase = new CheckedListBox();
            label8 = new Label();
            label6 = new Label();
            ScoreFormattingLabel = new Label();
            ScoreFormatSelection = new CheckedListBox();
            RandomModeOption = new CheckBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // PromptRootOption
            // 
            PromptRootOption.AutoSize = true;
            PromptRootOption.Location = new Point(35, 79);
            PromptRootOption.Name = "PromptRootOption";
            PromptRootOption.Size = new Size(385, 24);
            PromptRootOption.TabIndex = 0;
            PromptRootOption.Text = "Limit randomised prompt to exclude prefixes/suffixes";
            PromptRootOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 2;
            label1.Text = "Word Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(510, 33);
            label2.Name = "label2";
            label2.Size = new Size(219, 31);
            label2.TabIndex = 3;
            label2.Text = "Game Settings";
            // 
            // EnableTimerOption
            // 
            EnableTimerOption.AutoSize = true;
            EnableTimerOption.Location = new Point(510, 80);
            EnableTimerOption.Name = "EnableTimerOption";
            EnableTimerOption.Size = new Size(115, 24);
            EnableTimerOption.TabIndex = 4;
            EnableTimerOption.Text = "Enable timer";
            EnableTimerOption.UseVisualStyleBackColor = true;
            EnableTimerOption.CheckedChanged += EnableTimerOption_CheckedChanged;
            // 
            // TimerLength
            // 
            TimerLength.BorderStyle = BorderStyle.FixedSingle;
            TimerLength.Enabled = false;
            TimerLength.Font = new Font("Segoe UI", 8F);
            TimerLength.Location = new Point(529, 108);
            TimerLength.Name = "TimerLength";
            TimerLength.Size = new Size(53, 25);
            TimerLength.TabIndex = 5;
            TimerLength.TextAlign = HorizontalAlignment.Center;
            TimerLength.TextChanged += TimerLength_TextChanged;
            // 
            // TimerLengthLabel
            // 
            TimerLengthLabel.AutoSize = true;
            TimerLengthLabel.Enabled = false;
            TimerLengthLabel.Location = new Point(586, 110);
            TimerLengthLabel.Name = "TimerLengthLabel";
            TimerLengthLabel.Size = new Size(125, 20);
            TimerLengthLabel.TabIndex = 6;
            TimerLengthLabel.Text = "Time (in seconds)";
            // 
            // StringModeOption
            // 
            StringModeOption.AutoSize = true;
            StringModeOption.Location = new Point(510, 200);
            StringModeOption.Name = "StringModeOption";
            StringModeOption.Size = new Size(174, 24);
            StringModeOption.TabIndex = 7;
            StringModeOption.Text = "Enable \"String Mode\"";
            StringModeOption.UseVisualStyleBackColor = true;
            StringModeOption.CheckedChanged += StringModeOption_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 110);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 8;
            label4.Text = "Prompt length range:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 141);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 9;
            label5.Text = "Minimum input length:";
            // 
            // PromptMinLengthOptionText
            // 
            PromptMinLengthOptionText.BorderStyle = BorderStyle.FixedSingle;
            PromptMinLengthOptionText.Font = new Font("Segoe UI", 7F);
            PromptMinLengthOptionText.Location = new Point(186, 110);
            PromptMinLengthOptionText.Name = "PromptMinLengthOptionText";
            PromptMinLengthOptionText.PlaceholderText = "Min";
            PromptMinLengthOptionText.Size = new Size(34, 23);
            PromptMinLengthOptionText.TabIndex = 10;
            PromptMinLengthOptionText.TextAlign = HorizontalAlignment.Center;
            PromptMinLengthOptionText.TextChanged += PromptMinLengthOptionText_TextChanged;
            // 
            // InputLengthOptionText
            // 
            InputLengthOptionText.BorderStyle = BorderStyle.FixedSingle;
            InputLengthOptionText.Font = new Font("Segoe UI", 7F);
            InputLengthOptionText.Location = new Point(196, 141);
            InputLengthOptionText.Name = "InputLengthOptionText";
            InputLengthOptionText.Size = new Size(34, 23);
            InputLengthOptionText.TabIndex = 11;
            InputLengthOptionText.TextAlign = HorizontalAlignment.Center;
            InputLengthOptionText.TextChanged += InputLengthOptionText_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.Highlight;
            SaveButton.DialogResult = DialogResult.Yes;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Segoe UI", 11F);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(33, 491);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(143, 42);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Save Changes";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ScrollBar;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI", 11F);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(186, 491);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(95, 42);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // ErrorTextPromptLength
            // 
            ErrorTextPromptLength.AutoSize = true;
            ErrorTextPromptLength.Font = new Font("Segoe UI", 5F);
            ErrorTextPromptLength.ForeColor = Color.Red;
            ErrorTextPromptLength.Location = new Point(267, 116);
            ErrorTextPromptLength.Name = "ErrorTextPromptLength";
            ErrorTextPromptLength.Size = new Size(0, 12);
            ErrorTextPromptLength.TabIndex = 17;
            // 
            // ErrorTextInputLength
            // 
            ErrorTextInputLength.AutoSize = true;
            ErrorTextInputLength.Font = new Font("Segoe UI", 5F);
            ErrorTextInputLength.ForeColor = Color.Red;
            ErrorTextInputLength.Location = new Point(236, 147);
            ErrorTextInputLength.Name = "ErrorTextInputLength";
            ErrorTextInputLength.Size = new Size(0, 12);
            ErrorTextInputLength.TabIndex = 18;
            // 
            // ErrorTextTimerLength
            // 
            ErrorTextTimerLength.AutoSize = true;
            ErrorTextTimerLength.Font = new Font("Segoe UI", 5F);
            ErrorTextTimerLength.ForeColor = Color.Red;
            ErrorTextTimerLength.Location = new Point(717, 115);
            ErrorTextTimerLength.Name = "ErrorTextTimerLength";
            ErrorTextTimerLength.Size = new Size(0, 12);
            ErrorTextTimerLength.TabIndex = 19;
            // 
            // DynamicTimerOption
            // 
            DynamicTimerOption.AutoSize = true;
            DynamicTimerOption.Location = new Point(508, 141);
            DynamicTimerOption.Name = "DynamicTimerOption";
            DynamicTimerOption.Size = new Size(174, 24);
            DynamicTimerOption.TabIndex = 20;
            DynamicTimerOption.Text = "Dynamic Timer Mode";
            DynamicTimerOption.UseVisualStyleBackColor = true;
            DynamicTimerOption.CheckedChanged += DynamicTimerOption_CheckedChanged;
            // 
            // TimerIncrement
            // 
            TimerIncrement.BorderStyle = BorderStyle.FixedSingle;
            TimerIncrement.Enabled = false;
            TimerIncrement.Font = new Font("Segoe UI", 8F);
            TimerIncrement.Location = new Point(529, 169);
            TimerIncrement.Name = "TimerIncrement";
            TimerIncrement.Size = new Size(53, 25);
            TimerIncrement.TabIndex = 21;
            TimerIncrement.TextAlign = HorizontalAlignment.Center;
            TimerIncrement.TextChanged += TimerIncrement_TextChanged;
            // 
            // TimerIncrementLabel
            // 
            TimerIncrementLabel.AutoSize = true;
            TimerIncrementLabel.Enabled = false;
            TimerIncrementLabel.Location = new Point(588, 171);
            TimerIncrementLabel.Name = "TimerIncrementLabel";
            TimerIncrementLabel.Size = new Size(200, 20);
            TimerIncrementLabel.TabIndex = 22;
            TimerIncrementLabel.Text = "Timer increment (in seconds)";
            // 
            // ErrorTextTimerIncrement
            // 
            ErrorTextTimerIncrement.AutoSize = true;
            ErrorTextTimerIncrement.Font = new Font("Segoe UI", 5F);
            ErrorTextTimerIncrement.ForeColor = Color.Red;
            ErrorTextTimerIncrement.Location = new Point(788, 176);
            ErrorTextTimerIncrement.Name = "ErrorTextTimerIncrement";
            ErrorTextTimerIncrement.Size = new Size(0, 12);
            ErrorTextTimerIncrement.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(529, 227);
            label3.Name = "label3";
            label3.Size = new Size(320, 45);
            label3.TabIndex = 24;
            label3.Text = "\"String Mode\" is where your next input must begin with the\r\nsame letter as the last letter of your previous input.\r\n   e.g. HIT -> TABLE -> EARLY -> YEAST";
            // 
            // PromptMaxLengthOptionText
            // 
            PromptMaxLengthOptionText.BorderStyle = BorderStyle.FixedSingle;
            PromptMaxLengthOptionText.Font = new Font("Segoe UI", 7F);
            PromptMaxLengthOptionText.Location = new Point(226, 110);
            PromptMaxLengthOptionText.Name = "PromptMaxLengthOptionText";
            PromptMaxLengthOptionText.PlaceholderText = "Max";
            PromptMaxLengthOptionText.Size = new Size(34, 23);
            PromptMaxLengthOptionText.TabIndex = 25;
            PromptMaxLengthOptionText.TextAlign = HorizontalAlignment.Center;
            PromptMaxLengthOptionText.TextChanged += PromptMaxLengthOptionText_TextChanged;
            // 
            // PromptSelectionDatabase
            // 
            PromptSelectionDatabase.BackColor = SystemColors.Menu;
            PromptSelectionDatabase.BorderStyle = BorderStyle.None;
            PromptSelectionDatabase.CheckOnClick = true;
            PromptSelectionDatabase.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PromptSelectionDatabase.FormattingEnabled = true;
            PromptSelectionDatabase.Items.AddRange(new object[] { "IELTS (recommended)", "DictionaryAPI", "JUST WORDS!", "Infochimps" });
            PromptSelectionDatabase.Location = new Point(59, 249);
            PromptSelectionDatabase.Name = "PromptSelectionDatabase";
            PromptSelectionDatabase.Size = new Size(161, 80);
            PromptSelectionDatabase.TabIndex = 26;
            PromptSelectionDatabase.SelectedIndexChanged += PromptSelectionDatabase_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 226);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 28;
            label7.Text = "For prompts:";
            // 
            // WordListSelectionDatabase
            // 
            WordListSelectionDatabase.BackColor = SystemColors.Menu;
            WordListSelectionDatabase.BorderStyle = BorderStyle.None;
            WordListSelectionDatabase.CheckOnClick = true;
            WordListSelectionDatabase.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WordListSelectionDatabase.FormattingEnabled = true;
            WordListSelectionDatabase.Items.AddRange(new object[] { "DictionaryAPI (recommended)", "JUST WORDS!", "Infochimps" });
            WordListSelectionDatabase.Location = new Point(231, 249);
            WordListSelectionDatabase.Name = "WordListSelectionDatabase";
            WordListSelectionDatabase.Size = new Size(203, 60);
            WordListSelectionDatabase.TabIndex = 29;
            WordListSelectionDatabase.SelectedIndexChanged += WordListSelectionDatabase_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 226);
            label8.Name = "label8";
            label8.Size = new Size(163, 20);
            label8.TabIndex = 30;
            label8.Text = "For the whole word list:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 200);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 27;
            label6.Text = "Dictionary database:";
            // 
            // ScoreFormattingLabel
            // 
            ScoreFormattingLabel.AutoSize = true;
            ScoreFormattingLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ScoreFormattingLabel.Location = new Point(35, 345);
            ScoreFormattingLabel.Name = "ScoreFormattingLabel";
            ScoreFormattingLabel.Size = new Size(128, 20);
            ScoreFormattingLabel.TabIndex = 31;
            ScoreFormattingLabel.Text = "Score formatting:";
            // 
            // ScoreFormatSelection
            // 
            ScoreFormatSelection.BackColor = SystemColors.Menu;
            ScoreFormatSelection.BorderStyle = BorderStyle.None;
            ScoreFormatSelection.CheckOnClick = true;
            ScoreFormatSelection.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreFormatSelection.FormattingEnabled = true;
            ScoreFormatSelection.Items.AddRange(new object[] { "Score / Total", "Score / Percentage of total", "Both total & percentage", "Neither" });
            ScoreFormatSelection.Location = new Point(59, 368);
            ScoreFormatSelection.Name = "ScoreFormatSelection";
            ScoreFormatSelection.Size = new Size(183, 80);
            ScoreFormatSelection.TabIndex = 32;
            ScoreFormatSelection.SelectedIndexChanged += ScoreFormatSelection_SelectedIndexChanged;
            // 
            // RandomModeOption
            // 
            RandomModeOption.AutoSize = true;
            RandomModeOption.Location = new Point(510, 275);
            RandomModeOption.Name = "RandomModeOption";
            RandomModeOption.Size = new Size(191, 24);
            RandomModeOption.TabIndex = 33;
            RandomModeOption.Text = "Enable \"Random Mode\"";
            RandomModeOption.UseVisualStyleBackColor = true;
            RandomModeOption.CheckedChanged += RandomModeOption_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(531, 302);
            label10.Name = "label10";
            label10.Size = new Size(428, 45);
            label10.TabIndex = 34;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 167);
            label11.Name = "label11";
            label11.Size = new Size(381, 20);
            label11.TabIndex = 35;
            label11.Text = "__  __  __  __  __  __  __  __  __  __  __  __  __  __  __  __  __  __  __\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(465, 33);
            label12.Name = "label12";
            label12.Size = new Size(14, 360);
            label12.TabIndex = 36;
            label12.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n\r\n";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 564);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(RandomModeOption);
            Controls.Add(ScoreFormatSelection);
            Controls.Add(ScoreFormattingLabel);
            Controls.Add(label8);
            Controls.Add(WordListSelectionDatabase);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PromptSelectionDatabase);
            Controls.Add(PromptMaxLengthOptionText);
            Controls.Add(label3);
            Controls.Add(ErrorTextTimerIncrement);
            Controls.Add(TimerIncrementLabel);
            Controls.Add(TimerIncrement);
            Controls.Add(DynamicTimerOption);
            Controls.Add(ErrorTextTimerLength);
            Controls.Add(ErrorTextInputLength);
            Controls.Add(ErrorTextPromptLength);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(InputLengthOptionText);
            Controls.Add(PromptMinLengthOptionText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StringModeOption);
            Controls.Add(TimerLengthLabel);
            Controls.Add(TimerLength);
            Controls.Add(EnableTimerOption);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PromptRootOption);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Options";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox PromptRootOption;
        private Label label1;
        private Label label2;
        private CheckBox EnableTimerOption;
        private TextBox TimerLength;
        private Label TimerLengthLabel;
        private CheckBox StringModeOption;
        private Label label4;
        private Label label5;
        private TextBox PromptMinLengthOptionText;
        private TextBox InputLengthOptionText;
        private Button SaveButton;
        private Button CancelButton;
        private Label ErrorTextPromptLength;
        private Label ErrorTextInputLength;
        private Label ErrorTextTimerLength;
        private CheckBox DynamicTimerOption;
        private TextBox TimerIncrement;
        private Label TimerIncrementLabel;
        private Label ErrorTextTimerIncrement;
        private Label label3;
        private TextBox PromptMaxLengthOptionText;
        private CheckedListBox PromptSelectionDatabase;
        private Label label7;
        private CheckedListBox WordListSelectionDatabase;
        private Label label8;
        private Label label6;
        private Label ScoreFormattingLabel;
        private CheckedListBox ScoreFormatSelection;
        private CheckBox RandomModeOption;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}