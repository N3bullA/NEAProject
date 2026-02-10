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
        bool closeForm = false;

        public Options(string[] settings, int maximumWordLength)
        {
            InitializeComponent();

            maxWordLength = maximumWordLength;

            if (settings[0] == "true")
            {
                PromptRootOption.Checked = true;
            }

            PromptLengthOptionText.Text = settings[2];
            InputLengthOptionText.Text = settings[3];

            if (settings[4] == "true")
            {
                EnableTimerOption.Checked = true;
                TimerLength.Enabled = true;
                TimerLengthLabel.Enabled = true;
            }

            TimerLength.Text = settings[5];

            if (settings[6] == "true")
            {
                StringModeOption.Checked = true;
            }

            if (settings[7] == "true")
            {
                DynamicTimerOption.Checked = true;
            }

            TimerIncrement.Text = settings[8];

            ErrorTextPromptLength.Text = "";
            ErrorTextInputLength.Text = "";
            ErrorTextTimerLength.Text = "";

            SaveButton.DialogResult = DialogResult.Yes;
        }
        public string GetPromptRootOption() // Boolean Option
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
        public string GetMinPromptLength() // String Option
        {
            return PromptLengthOptionText.Text;
        }
        public string GetMinInputLength() // String Option
        {
            return InputLengthOptionText.Text;
        }
        public string GetTimerOption()
        {
            if (EnableTimerOption.Checked)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        } // Boolean Option
        public string GetTimerLength() // String Option
        {
            return TimerLength.Text;
        }
        public string GetStringModeOption()
        {
            if (StringModeOption.Checked)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        } // Boolean Option
        public string GetDynamicTimerOption()
        {
            if (DynamicTimerOption.Checked)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        public string GetTimerIncrement()
        {
            return TimerIncrement.Text;
        }

        public void SetPromptLengthError(bool valid)
        {
            if (valid)
            {
                ErrorTextPromptLength.Text = "";
            }
            else
            {
                ErrorTextPromptLength.Text = "Must be a number above 0";
            }
        }
        private void PromptLengthOptionText_TextChanged(object sender, EventArgs e)
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
        public bool PromptLengthOptionValidation()
        {
            if (!NumbersOnly(PromptLengthOptionText.Text))
            {
                ErrorTextPromptLength.Text = "Value must only contain numbers";
                return false;
            }
            else if (PromptLengthOptionText.Text.Length <= 0)
            {
                ErrorTextPromptLength.Text = "The field cannot be blank";
                return false;
            }
            else if (NumbersOnly(InputLengthOptionText.Text) && InputLengthOptionText.Text.Length > 0)
            {
                if (Convert.ToInt32(PromptLengthOptionText.Text) < Convert.ToInt32(InputLengthOptionText.Text))
                {
                    ErrorTextPromptLength.Text = "Value must be greater than the minimum input length";
                    return false;
                }
            }

            if (Convert.ToInt32(PromptLengthOptionText.Text) < 5)
            {
                ErrorTextPromptLength.Text = "Value must be greater than 5";
                return false;
            }
            else if (Convert.ToInt32(PromptLengthOptionText.Text) > maxWordLength)
            {
                ErrorTextPromptLength.Text = "There are no words longer than this value";
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
            else if (NumbersOnly(PromptLengthOptionText.Text) && PromptLengthOptionText.Text.Length > 0)
            {
                if (Convert.ToInt32(PromptLengthOptionText.Text) < Convert.ToInt32(InputLengthOptionText.Text))
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
            if (PromptLengthOptionValidation() && InputLengthOptionValidation() && TimerLengthOptionValidation() && TimerIncrementOptionValidation())
            {
                SaveButton.DialogResult = DialogResult.Yes;
            }
            else
            {
                SaveButton.DialogResult = DialogResult.None;
            }
        }
    }
}
