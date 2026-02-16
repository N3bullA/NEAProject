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
            PromptLabel = new Label();
            EnterButton = new Button();
            OptionsButton = new Button();
            TopLabel = new Label();
            ErrorText = new Label();
            SaveButton = new Button();
            ScoreLabel = new Label();
            ScoreDisplay = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            TimerText = new Label();
            UsingTheWord = new Label();
            EndOfGamePromptText = new Label();
            HelpButton = new Button();
            WelcomeLabel = new Label();
            PlayButton = new Button();
            MenuOptionsButton = new Button();
            QuitButton = new Button();
            WordList = new ListBox();
            ExitButton = new Button();
            DefineButton = new Button();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.Enabled = false;
            ResetButton.Location = new Point(24, 92);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(109, 29);
            ResetButton.TabIndex = 0;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Visible = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // GuessBox
            // 
            GuessBox.BackColor = SystemColors.Window;
            GuessBox.BorderStyle = BorderStyle.FixedSingle;
            GuessBox.Enabled = false;
            GuessBox.ForeColor = SystemColors.Desktop;
            GuessBox.Location = new Point(156, 94);
            GuessBox.Name = "GuessBox";
            GuessBox.Size = new Size(183, 27);
            GuessBox.TabIndex = 2;
            GuessBox.Visible = false;
            GuessBox.KeyDown += GuessBox_KeyDown;
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
            EnterButton.Enabled = false;
            EnterButton.Location = new Point(343, 93);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(61, 29);
            EnterButton.TabIndex = 10;
            EnterButton.Text = "ENTER";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Visible = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // OptionsButton
            // 
            OptionsButton.Enabled = false;
            OptionsButton.Location = new Point(24, 201);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(109, 29);
            OptionsButton.TabIndex = 11;
            OptionsButton.Text = "Options";
            OptionsButton.UseVisualStyleBackColor = true;
            OptionsButton.Visible = false;
            OptionsButton.Click += OptionsButton_Click;
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI", 9F);
            TopLabel.Location = new Point(156, 27);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(0, 20);
            TopLabel.TabIndex = 12;
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
            SaveButton.Enabled = false;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Segoe UI", 11F);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(192, 488);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(165, 42);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Finish Game";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(192, 454);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(0, 20);
            ScoreLabel.TabIndex = 15;
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
            // HelpButton
            // 
            HelpButton.Location = new Point(499, 537);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(54, 29);
            HelpButton.TabIndex = 22;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(175, 81);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(208, 57);
            WelcomeLabel.TabIndex = 23;
            WelcomeLabel.Text = "Welcome";
            // 
            // PlayButton
            // 
            PlayButton.BackColor = SystemColors.Highlight;
            PlayButton.FlatStyle = FlatStyle.Popup;
            PlayButton.Font = new Font("Segoe UI", 15F);
            PlayButton.ForeColor = Color.White;
            PlayButton.Location = new Point(222, 184);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(117, 44);
            PlayButton.TabIndex = 24;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // MenuOptionsButton
            // 
            MenuOptionsButton.BackColor = SystemColors.ButtonFace;
            MenuOptionsButton.FlatStyle = FlatStyle.Popup;
            MenuOptionsButton.Font = new Font("Segoe UI", 15F);
            MenuOptionsButton.ForeColor = Color.Black;
            MenuOptionsButton.Location = new Point(222, 250);
            MenuOptionsButton.Name = "MenuOptionsButton";
            MenuOptionsButton.Size = new Size(117, 44);
            MenuOptionsButton.TabIndex = 25;
            MenuOptionsButton.Text = "Options";
            MenuOptionsButton.UseVisualStyleBackColor = false;
            MenuOptionsButton.Click += MenuOptionsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = SystemColors.ButtonFace;
            QuitButton.FlatStyle = FlatStyle.Popup;
            QuitButton.Font = new Font("Segoe UI", 15F);
            QuitButton.ForeColor = Color.Black;
            QuitButton.Location = new Point(222, 315);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(117, 44);
            QuitButton.TabIndex = 26;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // WordList
            // 
            WordList.ColumnWidth = 80;
            WordList.Enabled = false;
            WordList.FormattingEnabled = true;
            WordList.Location = new Point(156, 170);
            WordList.MultiColumn = true;
            WordList.Name = "WordList";
            WordList.ScrollAlwaysVisible = true;
            WordList.Size = new Size(248, 264);
            WordList.Sorted = true;
            WordList.TabIndex = 27;
            WordList.Visible = false;
            WordList.SelectedIndexChanged += WordList_SelectedIndexChanged;
            // 
            // ExitButton
            // 
            ExitButton.Enabled = false;
            ExitButton.Location = new Point(24, 123);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(109, 29);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Visible = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // DefineButton
            // 
            DefineButton.Enabled = false;
            DefineButton.Location = new Point(24, 170);
            DefineButton.Name = "DefineButton";
            DefineButton.Size = new Size(109, 29);
            DefineButton.TabIndex = 29;
            DefineButton.Text = "Define";
            DefineButton.UseVisualStyleBackColor = true;
            DefineButton.Visible = false;
            DefineButton.Click += DefineButton_Click;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 578);
            Controls.Add(DefineButton);
            Controls.Add(ExitButton);
            Controls.Add(WordList);
            Controls.Add(QuitButton);
            Controls.Add(MenuOptionsButton);
            Controls.Add(PlayButton);
            Controls.Add(WelcomeLabel);
            Controls.Add(HelpButton);
            Controls.Add(EndOfGamePromptText);
            Controls.Add(UsingTheWord);
            Controls.Add(TimerText);
            Controls.Add(ScoreDisplay);
            Controls.Add(ScoreLabel);
            Controls.Add(SaveButton);
            Controls.Add(ErrorText);
            Controls.Add(TopLabel);
            Controls.Add(OptionsButton);
            Controls.Add(EnterButton);
            Controls.Add(PromptLabel);
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
        private Label PromptLabel;
        private Button EnterButton;
        private Button OptionsButton;
        private Label TopLabel;
        private Label ErrorText;
        private Button SaveButton;
        private Label ScoreLabel;
        private Label ScoreDisplay;
        private System.Windows.Forms.Timer Timer;
        private Label TimerText;
        private Label UsingTheWord;
        private Label EndOfGamePromptText;
        private Button HelpButton;
        private Label WelcomeLabel;
        private Button PlayButton;
        private Button MenuOptionsButton;
        private Button QuitButton;
        private ListBox WordList;
        private Button ExitButton;
        private Button DefineButton;
    }
}
