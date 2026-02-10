namespace NEA_Project__Word_Game_
{
    public partial class GameWindow : Form
    {
        public List allWords;
        public LongWordList longWords;
        public bool stringModeActive = false;

        public int s;
        public int m;

        public int score = 0;
        public string[] settings;
        public List<string> tempList = new List<string>();

        public GameWindow()
        {
            InitializeComponent();

            string line;
            using StreamReader srOptions = new StreamReader("Options.txt");
            {
                while ((line = srOptions.ReadLine()) != null)
                {
                    tempList.Add(line);
                }
            }
            settings = tempList.ToArray();
            tempList.Clear();

            allWords = new List("Dictionary.txt");
            longWords = new LongWordList("Dictionary.txt", Convert.ToInt32(settings[2]));

            if (settings[4] == "true")
            {
                TimerText.Visible = true;
                s = Convert.ToInt32(settings[5]) % 60;
                m = Convert.ToInt32(settings[5]) / 60;

                TimerText.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }

            if (settings[6] == "true")
            {
                stringModeActive = true;
            }
        }
        public void GameWindow_Load(object sender, EventArgs e)
        {
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            TimerText.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s--.ToString().PadLeft(2, '0'));
            if (s < 0 && m == 0)
            {
                Timer.Stop();
                GuessBox.Enabled = false;
                EnterButton.Enabled = false;
                GuessBox.Text = "";
                ErrorText.Text = "Your time is up!";
            }
            if (s == -1)
            {
                s = 59;
                m--;
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to reset? \nYour current game will be saved automatically",
                "Confirm Reset?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (choice == DialogResult.Yes)
            {
                wordList.Items.Clear();
                GuessBox.Text = string.Empty;

                longWords.RollRandomIndex();
                PromptLabel.Text = longWords.GetWord(longWords.GetIndex());

                score = 0;
                ScoreDisplay.Text = score.ToString();
                if (settings[4] == "true")
                {
                    s = Convert.ToInt32(settings[5]) % 60;
                    m = Convert.ToInt32(settings[5]) / 60;
                    TimerText.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    TimerText.Visible = true;
                    Timer.Enabled = true;
                    Timer.Start();
                }
                else
                {
                    TimerText.Visible = false;
                    Timer.Enabled = false;
                    Timer.Stop();
                }

                GuessBox.Enabled = true;
                EnterButton.Enabled = true;
                ErrorText.Text = string.Empty;
            }

            if (settings[6] == "true")
            {
                stringModeActive = true;
            }
            else
            {
                stringModeActive = false;
            }
        }
        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Options OptionsForm = new Options(settings, longWords.GetMaximumWordLength());
            DialogResult input = OptionsForm.ShowDialog();
            if (input == DialogResult.Yes)
            {
                settings[0] = OptionsForm.GetPromptRootOption();
                settings[1] = OptionsForm.GetInputRootOption();

                if (settings[2] != OptionsForm.GetMinPromptLength())
                {
                    if (InputValidation(OptionsForm.GetMinPromptLength()))
                    {
                        settings[2] = OptionsForm.GetMinPromptLength();
                        longWords = new LongWordList("Dictionary.txt", Convert.ToInt32(settings[2]));
                    }
                    else
                    {
                        OptionsForm.SetPromptLengthError(InputValidation(OptionsForm.GetMinPromptLength()));
                    }
                }

                settings[3] = OptionsForm.GetMinInputLength();
                settings[4] = OptionsForm.GetTimerOption();
                settings[5] = OptionsForm.GetTimerLength();
                settings[6] = OptionsForm.GetStringModeOption();

                if (InputValidation(OptionsForm.GetMinPromptLength()) && InputValidation(settings[3]) && InputValidation(settings[5]))
                {
                    StreamWriter sw = new StreamWriter("Options.txt");
                    foreach (string option in settings)
                    {
                        sw.WriteLine(option);
                    }
                    sw.Close();
                }
            }
        }
        private void GuessBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                GuessSubmitted();
            }
        } // Detects if the player presses ENTER when typing - this merely serves as a shortcut to make the user experience smoother
        private void EnterButton_Click(object sender, EventArgs e)
        {
            GuessSubmitted();
        } // Detects if the player presses the ENTER button to submit a guess

        private void GuessSubmitted()
        {
            if (ValidInput(GuessBox.Text.ToLower(),
                    longWords.GetWord(longWords.GetIndex()).Length,
                    longWords.GetWordChars(longWords.GetIndex()),
                    Convert.ToInt32(settings[3])) == "true")
            {
                ErrorText.Text = string.Empty;
                wordList.Items.Add(GuessBox.Text.ToLower());
                score++;
                ScoreDisplay.Text = score.ToString();
            }
            else
            {
                ErrorText.Text = ValidInput(GuessBox.Text.ToLower(),
                    longWords.GetWord(longWords.GetIndex()).Length,
                    longWords.GetWordChars(longWords.GetIndex()),
                    Convert.ToInt32(settings[3]));
            }
            GuessBox.Text = string.Empty;
        }
        private bool InputValidation(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] < 48 || (int)input[i] > 57)
                {
                    return false;
                }

                if (Convert.ToInt32(input) <= 0)
                {
                    return false;
                }
            }

            return true;
        }
        private string ValidInput(string input, int wordLength, string[] characters, int minInputLength)
        {
            int index = 0;
            int[] usedIndexes = new int[wordLength];

            // Instantly return an invalid error message if the input is longer than the prompt itself

            if (input.Length > wordLength)
            {
                return "Your input uses letters not found in the prompt";
            }
            else if (input.Length < minInputLength)
            {
                return $"Your input cannot be less than {minInputLength.ToString()} characters long";
            }
            else if (input == longWords.GetWord(longWords.GetIndex()))
            {
                return "Your input cannot be the same as the prompt";
            }

            // Checking if the word has already been entered

            for (int i = score - 1; i >= 0; i--)
            {
                if (input == wordList.Items[i].ToString())
                {
                    return "You have already entered this word";
                }
            }

            // Checking each letter in the input

            for (int i = 0; i < input.Length; i++)
            {
                // Returning an invalid error message if there's a non-letter character in the input

                if ((char)input[i] < 97 || (char)input[i] > 122)
                {
                    return "Your input must contain only letters";
                }

                // Comparing each letter in the input to each letter in the prompt:
                // - If a letter in the input matches a letter in the prompt, a counter goes up and an item is added to an array at the index of the used character
                //   This array is used to determine if a letter in the prompt has already been used to match a letter in the input. If that is the case, the character is ignored

                for (int j = 0; j < wordLength; j++)
                {
                    if (input[i].ToString() == characters[j] && usedIndexes[j] != 1)
                    {
                        index++;
                        usedIndexes[j] = 1;
                        break;
                    }
                }
            }

            if (stringModeActive && score > 0)
            {
                if (input[0] != wordList.Items[score - 1].ToString()[wordList.Items[score - 1].ToString().Length - 1])
                {
                    return "First letter of the input must be the last letter of the previous input";
                }
            }

            // If all the letters are valid (resulting in the index variable being equal to the input's length) and the input is a word in the dictionary, return true.

            if (index == input.Length && BinarySearch(input, allWords.GetWordCount()))
            {
                return "true";
            }
            else
            {
                if (index != input.Length)
                {
                    return "Your input uses letters not found in the prompt";
                }
                else
                {
                    return "Your input is not a valid word";
                }
            }
        }

        private bool BinarySearch(string input, int searchSize)
        {
            int front = 0;
            int back = searchSize - 1;
            int index = (front + back) / 2;
            int wordSizeIndex = 0;
            string selectedWord = allWords.GetWord(index);
            bool wordChecked = false;

            while (front <= back)
            {
                if (input == selectedWord)
                {
                    return true;
                }
                else
                {
                    while (!wordChecked)
                    {
                        if ((int)selectedWord[wordSizeIndex] > (int)input[wordSizeIndex])
                        {
                            back = index - 1;
                            wordChecked = true;
                        }
                        else if ((int)selectedWord[wordSizeIndex] < (int)input[wordSizeIndex])
                        {
                            front = index + 1;
                            wordChecked = true;
                        }
                        else
                        {
                            wordSizeIndex++;
                            if (wordSizeIndex >= selectedWord.Length)
                            {
                                front = index + 1;
                                wordChecked = true;
                            }
                            else if (wordSizeIndex >= input.Length)
                            {
                                back = index - 1;
                                wordChecked = true;
                            }
                        }
                    }
                }

                index = (front + back) / 2;
                selectedWord = allWords.GetWord(index);
                wordSizeIndex = 0;
                wordChecked = false;
            }

            return false;

        } // Binary Search Algorithm


    }
}
