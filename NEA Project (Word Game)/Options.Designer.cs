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
            PromptRootOption = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            EnableTimerOption = new CheckBox();
            TimerLength = new TextBox();
            TimerLengthLabel = new Label();
            StringModeOption = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            PromptLengthOptionText = new TextBox();
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
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 2;
            label1.Text = "Word Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 190);
            label2.Name = "label2";
            label2.Size = new Size(199, 31);
            label2.TabIndex = 3;
            label2.Text = "Game Settings";
            // 
            // EnableTimerOption
            // 
            EnableTimerOption.AutoSize = true;
            EnableTimerOption.Location = new Point(35, 237);
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
            TimerLength.Location = new Point(54, 265);
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
            TimerLengthLabel.Location = new Point(111, 267);
            TimerLengthLabel.Name = "TimerLengthLabel";
            TimerLengthLabel.Size = new Size(125, 20);
            TimerLengthLabel.TabIndex = 6;
            TimerLengthLabel.Text = "Time (in seconds)";
            // 
            // StringModeOption
            // 
            StringModeOption.AutoSize = true;
            StringModeOption.Location = new Point(35, 357);
            StringModeOption.Name = "StringModeOption";
            StringModeOption.Size = new Size(174, 24);
            StringModeOption.TabIndex = 7;
            StringModeOption.Text = "Enable \"String Mode\"";
            StringModeOption.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 110);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 8;
            label4.Text = "Minimum prompt length:";
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
            // PromptLengthOptionText
            // 
            PromptLengthOptionText.BorderStyle = BorderStyle.FixedSingle;
            PromptLengthOptionText.Font = new Font("Segoe UI", 7F);
            PromptLengthOptionText.Location = new Point(214, 110);
            PromptLengthOptionText.Name = "PromptLengthOptionText";
            PromptLengthOptionText.Size = new Size(34, 23);
            PromptLengthOptionText.TabIndex = 10;
            PromptLengthOptionText.TextAlign = HorizontalAlignment.Center;
            PromptLengthOptionText.TextChanged += PromptLengthOptionText_TextChanged;
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
            SaveButton.Location = new Point(33, 457);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(143, 42);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Save Changes";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ScrollBar;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI", 11F);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(186, 457);
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
            ErrorTextPromptLength.Location = new Point(254, 116);
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
            ErrorTextTimerLength.Location = new Point(242, 272);
            ErrorTextTimerLength.Name = "ErrorTextTimerLength";
            ErrorTextTimerLength.Size = new Size(0, 12);
            ErrorTextTimerLength.TabIndex = 19;
            // 
            // DynamicTimerOption
            // 
            DynamicTimerOption.AutoSize = true;
            DynamicTimerOption.Location = new Point(33, 298);
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
            TimerIncrement.Location = new Point(54, 326);
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
            TimerIncrementLabel.Location = new Point(113, 328);
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
            ErrorTextTimerIncrement.Location = new Point(313, 333);
            ErrorTextTimerIncrement.Name = "ErrorTextTimerIncrement";
            ErrorTextTimerIncrement.Size = new Size(0, 12);
            ErrorTextTimerIncrement.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(54, 384);
            label3.Name = "label3";
            label3.Size = new Size(320, 45);
            label3.TabIndex = 24;
            label3.Text = "\"String Mode\" is where your next input must begin with the\r\nsame letter as the last letter of your previous input.\r\n   e.g. HIT -> TABLE -> EARLY -> YEAST";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 533);
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
            Controls.Add(PromptLengthOptionText);
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
        private TextBox PromptLengthOptionText;
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
    }
}