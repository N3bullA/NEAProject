namespace NEA_Project__Word_Game_
{
    partial class GameWindow
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
            components = new System.ComponentModel.Container();
            ResetButton = new Button();
            GuessBox = new TextBox();
            wordList = new ListBox();
            PromptLabel = new Label();
            EnterButton = new Button();
            OptionsButton = new Button();
            TopLabel = new Label();
            ErrorText = new Label();
            SaveButton = new Button();
            label2 = new Label();
            ScoreDisplay = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            TimerText = new Label();
            DefinitionButton = new Button();
            DeleteWordButton = new Button();
            UsingTheWord = new Label();
            EndOfGamePromptText = new Label();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(24, 92);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(109, 29);
            ResetButton.TabIndex = 0;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // GuessBox
            // 
            GuessBox.BackColor = SystemColors.Window;
            GuessBox.BorderStyle = BorderStyle.FixedSingle;
            GuessBox.ForeColor = SystemColors.Desktop;
            GuessBox.Location = new Point(156, 94);
            GuessBox.Name = "GuessBox";
            GuessBox.Size = new Size(183, 27);
            GuessBox.TabIndex = 2;
            GuessBox.KeyDown += GuessBox_KeyDown;
            // 
            // wordList
            // 
            wordList.ColumnWidth = 80;
            wordList.FormattingEnabled = true;
            wordList.HorizontalExtent = 50;
            wordList.HorizontalScrollbar = true;
            wordList.Items.AddRange(new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" });
            wordList.Location = new Point(156, 170);
            wordList.MultiColumn = true;
            wordList.Name = "wordList";
            wordList.ScrollAlwaysVisible = true;
            wordList.Size = new Size(248, 264);
            wordList.Sorted = true;
            wordList.TabIndex = 0;
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PromptLabel.Location = new Point(154, 47);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new Size(0, 35);
            PromptLabel.TabIndex = 9;
            PromptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(343, 93);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(61, 29);
            EnterButton.TabIndex = 10;
            EnterButton.Text = "ENTER";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // OptionsButton
            // 
            OptionsButton.Location = new Point(24, 124);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(109, 29);
            OptionsButton.TabIndex = 11;
            OptionsButton.Text = "Options";
            OptionsButton.UseVisualStyleBackColor = true;
            OptionsButton.Click += OptionsButton_Click;
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI", 9F);
            TopLabel.Location = new Point(156, 27);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(254, 20);
            TopLabel.TabIndex = 12;
            TopLabel.Text = "How many words can you make with:";
            // 
            // ErrorText
            // 
            ErrorText.AutoSize = true;
            ErrorText.Font = new Font("Segoe UI", 7F);
            ErrorText.ForeColor = Color.Red;
            ErrorText.Location = new Point(155, 123);
            ErrorText.Name = "ErrorText";
            ErrorText.Size = new Size(0, 15);
            ErrorText.TabIndex = 13;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.Highlight;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Segoe UI", 11F);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(192, 488);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(165, 42);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Finish Game";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 454);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 15;
            label2.Text = "Your Score:";
            // 
            // ScoreDisplay
            // 
            ScoreDisplay.AutoSize = true;
            ScoreDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreDisplay.Location = new Point(277, 454);
            ScoreDisplay.Name = "ScoreDisplay";
            ScoreDisplay.Size = new Size(0, 20);
            ScoreDisplay.TabIndex = 16;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // TimerText
            // 
            TimerText.AutoSize = true;
            TimerText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerText.Location = new Point(24, 18);
            TimerText.Name = "TimerText";
            TimerText.Size = new Size(109, 46);
            TimerText.TabIndex = 17;
            TimerText.Text = "00:00";
            TimerText.TextAlign = ContentAlignment.MiddleCenter;
            TimerText.Visible = false;
            // 
            // DefinitionButton
            // 
            DefinitionButton.Location = new Point(24, 170);
            DefinitionButton.Name = "DefinitionButton";
            DefinitionButton.Size = new Size(109, 29);
            DefinitionButton.TabIndex = 18;
            DefinitionButton.Text = "Definition";
            DefinitionButton.UseVisualStyleBackColor = true;
            // 
            // DeleteWordButton
            // 
            DeleteWordButton.Location = new Point(24, 202);
            DeleteWordButton.Name = "DeleteWordButton";
            DeleteWordButton.Size = new Size(109, 29);
            DeleteWordButton.TabIndex = 19;
            DeleteWordButton.Text = "Delete";
            DeleteWordButton.UseVisualStyleBackColor = true;
            // 
            // UsingTheWord
            // 
            UsingTheWord.AutoSize = true;
            UsingTheWord.Font = new Font("Segoe UI", 9F);
            UsingTheWord.Location = new Point(155, 88);
            UsingTheWord.Name = "UsingTheWord";
            UsingTheWord.Size = new Size(0, 20);
            UsingTheWord.TabIndex = 20;
            // 
            // EndOfGamePromptText
            // 
            EndOfGamePromptText.AutoSize = true;
            EndOfGamePromptText.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndOfGamePromptText.Location = new Point(154, 107);
            EndOfGamePromptText.Name = "EndOfGamePromptText";
            EndOfGamePromptText.Size = new Size(0, 35);
            EndOfGamePromptText.TabIndex = 21;
            EndOfGamePromptText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 578);
            Controls.Add(EndOfGamePromptText);
            Controls.Add(UsingTheWord);
            Controls.Add(DeleteWordButton);
            Controls.Add(DefinitionButton);
            Controls.Add(TimerText);
            Controls.Add(ScoreDisplay);
            Controls.Add(label2);
            Controls.Add(SaveButton);
            Controls.Add(ErrorText);
            Controls.Add(TopLabel);
            Controls.Add(OptionsButton);
            Controls.Add(EnterButton);
            Controls.Add(PromptLabel);
            Controls.Add(wordList);
            Controls.Add(GuessBox);
            Controls.Add(ResetButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameWindow";
            Text = "Game Window";
            Load += GameWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetButton;
        private TextBox GuessBox;
        private ListBox wordList;
        private Label PromptLabel;
        private Button EnterButton;
        private Button OptionsButton;
        private Label TopLabel;
        private Label ErrorText;
        private Button SaveButton;
        private Label label2;
        private Label ScoreDisplay;
        private System.Windows.Forms.Timer Timer;
        private Label TimerText;
        private Button DefinitionButton;
        private Button DeleteWordButton;
        private Label UsingTheWord;
        private Label EndOfGamePromptText;
    }
}
