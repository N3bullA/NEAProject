using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project__Word_Game_
{
    public partial class Options : Form
    {
        int maxWordLength;

        public Options(string[] settings, int maximumWordLength)
        {
            InitializeComponent();

            maxWordLength = maximumWordLength;

            // Setting each element in the options interface to reflect the player's configured settings

            if (settings[0] == "true")
            {
                PromptRootOption.Checked = true;
            }

            PromptMinLengthOptionText.Text = settings[1];
            PromptMaxLengthOptionText.Text = settings[2];
            InputLengthOptionText.Text = settings[3];
            SelectionOptionInitialisation(settings);

            if (settings[7] == "true")
            {
                EnableTimerOption.Checked = true;
                TimerLength.Enabled = true;
                TimerLengthLabel.Enabled = true;
            }

            else
            {
                TimerLength.Enabled = false;
                TimerLengthLabel.Enabled = false;
                DynamicTimerOption.Enabled = false;
                TimerIncrement.Enabled = false;
                TimerIncrementLabel.Enabled = false;
            }

            TimerLength.Text = settings[8];

            if (settings[9] == "true")
            {
                DynamicTimerOption.Checked = true;
            }
            else
            {
                TimerIncrement.Enabled = false;
                TimerIncrementLabel.Enabled = false;
            }

            TimerIncrement.Text = settings[10];

            if (settings[11] == "true")
            {
                StringModeOption.Checked = true;
                RandomModeOption.Enabled = false;
                ScoreFormatSelection.Enabled = false;
                ScoreFormattingLabel.Enabled = false;
            }
            if (settings[12] == "true")
            {
                RandomModeOption.Checked = true;
                StringModeOption.Enabled = false;
                ScoreFormatSelection.Enabled = false;
                ScoreFormattingLabel.Enabled = false;
            }

            ErrorTextPromptLength.Text = "";
            ErrorTextInputLength.Text = "";
            ErrorTextTimerLength.Text = "";

            SaveButton.DialogResult = DialogResult.Yes;
        }
        public void SelectionOptionInitialisation(string[] settings)
        {
            switch (Convert.ToInt32(settings[4]))
            {
                case (int)DictionaryType.IELTS:
                    PromptSelectionDatabase.SetItemChecked(0, true);
                    PromptSelectionDatabase.SetSelected(0, true);
                    break;
                case (int)DictionaryType.DictionaryAPI:
                    PromptSelectionDatabase.SetItemChecked(1, true);
                    PromptSelectionDatabase.SetSelected(1, true);
                    break;
                case (int)DictionaryType.JUST_WORDS:
                    PromptSelectionDatabase.SetItemChecked(2, true);
                    PromptSelectionDatabase.SetSelected(2, true);
                    break;
                case (int)DictionaryType.Infochimps:
                    PromptSelectionDatabase.SetItemChecked(3, true);
                    PromptSelectionDatabase.SetSelected(3, true);
                    break;
            }
            switch (Convert.ToInt32(settings[5]))
            {
                case (int)DictionaryType.DictionaryAPI:
                    WordListSelectionDatabase.SetItemChecked(0, true);
                    WordListSelectionDatabase.SetSelected(0, true);
                    break;
                case (int)DictionaryType.JUST_WORDS:
                    WordListSelectionDatabase.SetItemChecked(1, true);
                    WordListSelectionDatabase.SetSelected(1, true);
                    break;
                case (int)DictionaryType.Infochimps:
                    WordListSelectionDatabase.SetItemChecked(2, true);
                    WordListSelectionDatabase.SetSelected(2, true);
                    break;
            }
            switch (Convert.ToInt32(settings[6]))
            {
                case (int)ScoreFormatting.Discrete:
                    ScoreFormatSelection.SetItemChecked(0, true);
                    ScoreFormatSelection.SetSelected(0, true);
                    break;
                case (int)ScoreFormatting.Percentage:
                    ScoreFormatSelection.SetItemChecked(1, true);
                    ScoreFormatSelection.SetSelected(1, true);
                    break;
                case (int)ScoreFormatting.Both:
                    ScoreFormatSelection.SetItemChecked(2, true);
                    ScoreFormatSelection.SetSelected(2, true);
                    break;
                case (int)ScoreFormatting.Neither:
                    ScoreFormatSelection.SetItemChecked(3, true);
                    ScoreFormatSelection.SetSelected(3, true);
                    break;
            }
        }

        // Methods retrieving the data stored in each UI element:
        public string GetPromptRootOption()
        {
            if (PromptRootOption.Checked)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        public string GetMinPromptLength()
        {
            return PromptMinLengthOptionText.Text;
        }
        public string GetMaxPromptLength()
        {
            return PromptMaxLengthOptionText.Text;
        }
        public string GetMinInputLength()
        {
            return InputLengthOptionText.Text;
        }
        public string GetSelectedPromptDictionary()
        {
            return PromptSelectionDatabase.SelectedIndex.ToString();
        }
        public string GetSelectedAllDictionary()
        {
            return (WordListSelectionDatabase.SelectedIndex + 1).ToString();
        }
        public string GetScoreFormatting()
        {
            return ScoreFormatSelection.SelectedIndex.ToString();
        }
        public string GetTimerOption()
        {
            if (EnableTimerOption.Checked) { return "true"; }
            else { return "false"; }
        }
        public string GetTimerLength()
        {
            return TimerLength.Text;
        }
        public string GetDynamicTimerOption()
        {
            if (DynamicTimerOption.Checked) { return "true"; }
            else { return "false"; }
        }
        public string GetTimerIncrement()
        {
            return TimerIncrement.Text;
        }
        public string GetStringModeOption()
        {
            if (StringModeOption.Checked) { return "true"; }
            else { return "false"; }
        }
        public string GetRandomModeOption()
        {
            if (RandomModeOption.Checked) { return "true"; }
            else { return "false"; }
        }
        private void PromptMinLengthOptionText_TextChanged(object sender, EventArgs e)
        {
            AllInputValidation();
        }
        private void PromptMaxLengthOptionText_TextChanged(object sender, EventArgs e)
        {
            AllInputValidation();
        }
        private void InputLengthOptionText_TextChanged(object sender, EventArgs e)
        {
            AllInputValidation();
        }
        private void TimerLength_TextChanged(object sender, EventArgs e)
        {
            AllInputValidation();
        }
        private void TimerIncrement_TextChanged(object sender, EventArgs e)
        {
            AllInputValidation();
        }
        private void EnableTimerOption_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableTimerOption.Checked)
            {
                TimerLength.Enabled = true;
                TimerLengthLabel.Enabled = true;
                DynamicTimerOption.Enabled = true;

                if (DynamicTimerOption.Checked)
                {
                    TimerIncrement.Enabled = true;
                    TimerIncrementLabel.Enabled = true;
                }
            }
            else
            {
                TimerLength.Enabled = false;
                TimerLengthLabel.Enabled = false;
                DynamicTimerOption.Enabled = false;
                TimerIncrement.Enabled = false;
                TimerIncrementLabel.Enabled = false;
            }
        }
        private void DynamicTimerOption_CheckedChanged(object sender, EventArgs e)
        {
            if (DynamicTimerOption.Checked)
            {
                TimerIncrement.Enabled = true;
                TimerIncrementLabel.Enabled = true;
            }
            else
            {
                TimerIncrement.Enabled = false;
                TimerIncrementLabel.Enabled = false;
            }
        }
        private void StringModeOption_CheckedChanged(object sender, EventArgs e)
        {
            if (StringModeOption.Checked)
            {
                ScoreFormatSelection.Enabled = false;
                ScoreFormattingLabel.Enabled = false;
                RandomModeOption.Enabled = false;
            }
            else
            {
                ScoreFormatSelection.Enabled = true;
                ScoreFormattingLabel.Enabled = true;
                RandomModeOption.Enabled = true;
            }
        }
        private void RandomModeOption_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomModeOption.Checked)
            {
                ScoreFormatSelection.Enabled = false;
                ScoreFormattingLabel.Enabled = false;
                StringModeOption.Enabled = false;
            }
            else
            {
                ScoreFormatSelection.Enabled = true;
                ScoreFormattingLabel.Enabled = true;
                StringModeOption.Enabled = true;
            }
        }
        private void PromptSelectionDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PromptSelectionDatabase.SelectedItem == PromptSelectionDatabase.Items[0])
            {
                PromptSelectionDatabase.SetItemChecked(0, true);
                PromptSelectionDatabase.SetItemChecked(1, false);
                PromptSelectionDatabase.SetItemChecked(2, false);
                PromptSelectionDatabase.SetItemChecked(3, false);
            }
            else if (PromptSelectionDatabase.SelectedItem == PromptSelectionDatabase.Items[1])
            {
                PromptSelectionDatabase.SetItemChecked(0, false);
                PromptSelectionDatabase.SetItemChecked(1, true);
                PromptSelectionDatabase.SetItemChecked(2, false);
                PromptSelectionDatabase.SetItemChecked(3, false);
            }
            else if (PromptSelectionDatabase.SelectedItem == PromptSelectionDatabase.Items[2])
            {
                PromptSelectionDatabase.SetItemChecked(0, false);
                PromptSelectionDatabase.SetItemChecked(1, false);
                PromptSelectionDatabase.SetItemChecked(2, true);
                PromptSelectionDatabase.SetItemChecked(3, false);
            }
            else if (PromptSelectionDatabase.SelectedItem == PromptSelectionDatabase.Items[3])
            {
                PromptSelectionDatabase.SetItemChecked(0, false);
                PromptSelectionDatabase.SetItemChecked(1, false);
                PromptSelectionDatabase.SetItemChecked(2, false);
                PromptSelectionDatabase.SetItemChecked(3, true);
            }
        }
        private void WordListSelectionDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WordListSelectionDatabase.SelectedItem == WordListSelectionDatabase.Items[0])
            {
                WordListSelectionDatabase.SetItemChecked(0, true);
                WordListSelectionDatabase.SetItemChecked(1, false);
                WordListSelectionDatabase.SetItemChecked(2, false);
            }
            else if (WordListSelectionDatabase.SelectedItem == WordListSelectionDatabase.Items[1])
            {
                WordListSelectionDatabase.SetItemChecked(0, false);
                WordListSelectionDatabase.SetItemChecked(1, true);
                WordListSelectionDatabase.SetItemChecked(2, false);
            }
            else if (WordListSelectionDatabase.SelectedItem == WordListSelectionDatabase.Items[2])
            {
                WordListSelectionDatabase.SetItemChecked(0, false);
                WordListSelectionDatabase.SetItemChecked(1, false);
                WordListSelectionDatabase.SetItemChecked(2, true);
            }
        }
        private void ScoreFormatSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScoreFormatSelection.SelectedItem == ScoreFormatSelection.Items[0])
            {
                ScoreFormatSelection.SetItemChecked(0, true);
                ScoreFormatSelection.SetItemChecked(1, false);
                ScoreFormatSelection.SetItemChecked(2, false);
                ScoreFormatSelection.SetItemChecked(3, false);
            }
            else if (ScoreFormatSelection.SelectedItem == ScoreFormatSelection.Items[1])
            {
                ScoreFormatSelection.SetItemChecked(0, false);
                ScoreFormatSelection.SetItemChecked(1, true);
                ScoreFormatSelection.SetItemChecked(2, false);
                ScoreFormatSelection.SetItemChecked(3, false);
            }
            else if (ScoreFormatSelection.SelectedItem == ScoreFormatSelection.Items[2])
            {
                ScoreFormatSelection.SetItemChecked(0, false);
                ScoreFormatSelection.SetItemChecked(1, false);
                ScoreFormatSelection.SetItemChecked(2, true);
                ScoreFormatSelection.SetItemChecked(3, false);
            }
            else if (ScoreFormatSelection.SelectedItem == ScoreFormatSelection.Items[3])
            {
                ScoreFormatSelection.SetItemChecked(0, false);
                ScoreFormatSelection.SetItemChecked(1, false);
                ScoreFormatSelection.SetItemChecked(2, false);
                ScoreFormatSelection.SetItemChecked(3, true);
            }
        }
        public bool NumbersOnly(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 48 || (int)text[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }

        // Input validation for each option
        public bool PromptMinLengthOptionValidation()
        {
            if (!NumbersOnly(PromptMinLengthOptionText.Text) || !NumbersOnly(PromptMaxLengthOptionText.Text))
            {
                ErrorTextPromptLength.Text = "Values must only contain numbers";
                return false;
            }
            else if (PromptMinLengthOptionText.Text.Length <= 0 || PromptMaxLengthOptionText.Text.Length <= 0)
            {
                ErrorTextPromptLength.Text = "These fields cannot be blank";
                return false;
            }
            else if (NumbersOnly(InputLengthOptionText.Text) && InputLengthOptionText.Text.Length > 0)
            {
                if (Convert.ToInt32(PromptMinLengthOptionText.Text) < Convert.ToInt32(InputLengthOptionText.Text))
                {
                    ErrorTextPromptLength.Text = "Values must be greater than the min. input length";
                    return false;
                }
            }

            if (Convert.ToInt32(PromptMinLengthOptionText.Text) < 5)
            {
                ErrorTextPromptLength.Text = "Values must be greater than 5";
                return false;
            }
            else if (Convert.ToInt32(PromptMinLengthOptionText.Text) > maxWordLength)
            {
                ErrorTextPromptLength.Text = "There are no words longer than this value";
                return false;
            }
            else if (Convert.ToInt32(PromptMinLengthOptionText.Text) > Convert.ToInt32(PromptMaxLengthOptionText.Text))
            {
                ErrorTextPromptLength.Text = "Invalid range";
                return false;
            }
            else
            {
                ErrorTextPromptLength.Text = "";
                return true;
            }
        }
        public bool InputLengthOptionValidation()
        {
            if (!NumbersOnly(InputLengthOptionText.Text))
            {
                ErrorTextInputLength.Text = "Value must only contain numbers";
                return false;
            }
            else if (InputLengthOptionText.Text.Length <= 0)
            {
                ErrorTextInputLength.Text = "The field cannot be blank";
                return false;
            }
            else if (NumbersOnly(PromptMinLengthOptionText.Text) && PromptMinLengthOptionText.Text.Length > 0)
            {
                if (Convert.ToInt32(PromptMinLengthOptionText.Text) < Convert.ToInt32(InputLengthOptionText.Text))
                {
                    ErrorTextInputLength.Text = "Value must be less than the minimum prompt length";
                    return false;
                }
            }
            if (Convert.ToInt32(InputLengthOptionText.Text) <= 0)
            {
                ErrorTextInputLength.Text = "Value must be greater than 0";
                return false;
            }
            else if (Convert.ToInt32(InputLengthOptionText.Text) > maxWordLength)
            {
                ErrorTextInputLength.Text = "There are no words longer than this value";
                return false;
            }
            else
            {
                ErrorTextInputLength.Text = "";
                return true;
            }
        }
        public bool TimerLengthOptionValidation()
        {
            if (!NumbersOnly(TimerLength.Text))
            {
                ErrorTextTimerLength.Text = "Value must only contain numbers";
                return false;
            }
            else if (TimerLength.Text.Length <= 0)
            {
                ErrorTextTimerLength.Text = "The field cannot be blank";
                return false;
            }
            else if (Convert.ToInt32(TimerLength.Text) <= 0)
            {
                ErrorTextTimerLength.Text = "Value must be greater than 0";
                return false;
            }
            else
            {
                ErrorTextTimerLength.Text = "";
                return true;
            }
        }
        public bool TimerIncrementOptionValidation()
        {
            if (!NumbersOnly(TimerIncrement.Text))
            {
                ErrorTextTimerIncrement.Text = "Value must only contain numbers";
                return false;
            }
            else if (TimerIncrement.Text.Length <= 0)
            {
                ErrorTextTimerIncrement.Text = "The field cannot be blank";
                return false;
            }
            else if (Convert.ToInt32(TimerIncrement.Text) <= 0)
            {
                ErrorTextTimerIncrement.Text = "Value must be greater than 0";
                return false;
            }
            else
            {
                ErrorTextTimerIncrement.Text = "";
                return true;
            }
        }
        private void AllInputValidation()
        {
            bool[] validations = { PromptMinLengthOptionValidation(),
                InputLengthOptionValidation(),
                TimerLengthOptionValidation(),
                TimerIncrementOptionValidation() };

            foreach (var validation in validations)
            {
                if (!validation)
                {
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                    return;
                }
            }
            SaveButton.Enabled = true;
            SaveButton.BackColor = Color.FromKnownColor(KnownColor.Highlight);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            PromptSelectionDatabase.SetItemChecked(PromptSelectionDatabase.SelectedIndex, true);
            WordListSelectionDatabase.SetItemChecked(WordListSelectionDatabase.SelectedIndex, true);
            ScoreFormatSelection.SetItemChecked(ScoreFormatSelection.SelectedIndex, true);
        }
    }
}
