namespace NEA_Project__Word_Game_
{
    public partial class GameWindow : Form
    {
        public List allWords;
        public LongWordList longWords;
        public PossibleWordsList possibleWords;

        public int timerIncrement;
        public bool stringModeActive = false;
        public bool dynamicTimerActive = false;
        public bool gameEnded = false;

        public int s;
        public int m;

        public string prompt = string.Empty;
        public int score = 0;
        public string[] settings;
        public List<string> tempList = new List<string>();

        public GameWindow()
        {
            InitializeComponent();

            // Read the options text file and converting it to an array

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

            // Declare instances of the List objects

            allWords = new List("Dictionary.txt");
            longWords = new LongWordList("Dictionary.txt", settings[0], Convert.ToInt32(settings[2]));
        }
        public void GameWindow_Load(object sender, EventArgs e)
        {
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Count down one second every 1000 ticks

            s--;
            TimerText.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            if (s == 0 && m == 0) // Stop the timer once it reaches 0
            {
                Timer.Stop();
                GuessBox.Enabled = false;
                EnterButton.Enabled = false;
                GuessBox.Text = "";
                ErrorText.Text = "Your time is up!";
            }
            if (s == 0) // Count down one minute every time the seconds display reaches 0
            {
                s = 60;
                m--;
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Show confirmation message

            DialogResult choice = MessageBox.Show("Are you sure you want to reset? \nThis game will not be saved.",
                "Confirm Reset?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (choice == DialogResult.Yes) // If the player confirms the game reset
            {
                WordList.Items.Clear();
                GuessBox.Text = string.Empty;
                gameEnded = false;

                // Change the interface back to the game interface when a new game starts

                longWords.RollRandomIndex();
                TopLabel.Text = "How many words can you make with: ";
                prompt = longWords.GetWord(longWords.GetIndex());
                PromptLabel.Text = prompt;
                possibleWords = new PossibleWordsList("Dictionary.txt", prompt, stringModeActive, settings[3]);
                score = 0;

                InitialiseSettings();

                UsingTheWord.Text = "";
                EndOfGamePromptText.Text = "";
                ResetButton.Text = "Reset";
                SaveButton.Text = "Finish Game";

                GuessBox.Enabled = true;
                GuessBox.Visible = true;
                EnterButton.Enabled = true;
                EnterButton.Visible = true;
                ErrorText.Text = string.Empty;
            }
        }
        private void OptionsButton_Click(object sender, EventArgs e)
        {
            SetOptions();
        }

        private void SetOptions()
        {
            Options OptionsForm = new Options(settings, longWords.GetMaximumWordLength());
            DialogResult input = OptionsForm.ShowDialog();
            if (input == DialogResult.Yes)
            {
                // Convert all inputs in the options menu to values stored in the "settings" array

                settings[0] = OptionsForm.GetPromptRootOption();
                settings[2] = OptionsForm.GetMinPromptLength();
                settings[3] = OptionsForm.GetMinInputLength();
                settings[4] = OptionsForm.GetTimerOption();
                settings[5] = OptionsForm.GetTimerLength();
                settings[6] = OptionsForm.GetStringModeOption();
                settings[7] = OptionsForm.GetDynamicTimerOption();
                settings[8] = OptionsForm.GetTimerIncrement();

                // Writes all the options into the "Options.txt" text file

                StreamWriter sw = new StreamWriter("Options.txt");
                foreach (string option in settings)
                {
                    sw.WriteLine(option);
                }
                sw.Close();
            }
        }
        private void GuessBox_KeyDown(object sender, KeyEventArgs e) // Detects if the player presses ENTER when typing
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                GuessSubmitted();
            }
        }
        private void EnterButton_Click(object sender, EventArgs e) // Detects if the player presses the ENTER button to submit a guess
        {
            GuessSubmitted();
        }
        private void GuessSubmitted()
        {
            if (ValidInput(GuessBox.Text.ToLower(),
                    prompt.Length,
                    longWords.GetWordChars(longWords.GetIndex()),
                    Convert.ToInt32(settings[3])) == "true") // Add the word to the word list and increment the score if the input is valid
            {
                ErrorText.Text = string.Empty;
                WordList.Items.Add(GuessBox.Text.ToLower());
                score++;

                if (stringModeActive)
                {
                    ScoreDisplay.Text = score.ToString();
                }
                else
                {
                    ScoreDisplay.Text = $"{score.ToString()} / {possibleWords.GetWordCount()}";
                }

                if (dynamicTimerActive) // Increment the timer if the "Dynamic Timer" option is enabled
                {
                    s += timerIncrement;
                    while (s > 59)
                    {
                        s -= 60;
                        m++;
                    }
                    TimerText.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }
            }
            else // Display the appropriate error message
            {
                ErrorText.Text = ValidInput(GuessBox.Text.ToLower(),
                    prompt.Length,
                    longWords.GetWordChars(longWords.GetIndex()),
                    Convert.ToInt32(settings[3]));
            }
            GuessBox.Text = string.Empty;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (gameEnded) // If the "What Did I Miss" button is pressed (after the game ended)
            {
                // Create a list of all the possible words a player missed

                string[] missedWords;
                List<string> templist = new List<string>();
                bool addWord = true;

                for (int i = 0; i < possibleWords.GetWordCount(); i++)
                {
                    for (int j = 0; j < score; j++)
                    {
                        if (possibleWords.GetWord(i) == WordList.Items[j].ToString())
                        {
                            addWord = false;
                        }
                    }
                    if (addWord)
                    {
                        templist.Add(possibleWords.GetWord(i));
                    }
                    addWord = true;
                }

                missedWords = templist.ToArray();
                WhatDidIMiss missedWordsForm = new WhatDidIMiss(missedWords);
                missedWordsForm.ShowDialog(); // Display the list
            }
            else
            {
                gameEnded = true;

                // Change the interface to display a summary of their game

                Timer.Stop();
                GuessBox.Enabled = false;
                GuessBox.Visible = false;
                EnterButton.Enabled = false;
                EnterButton.Visible = false;
                GuessBox.Text = "";
                ResetButton.Text = "New Game";
                ErrorText.Text = "";

                SaveButton.Text = "What did I miss?";
                EndOfGamePromptText.Text = PromptLabel.Text;
                TopLabel.Text = "Congratulations! You have named";
                PromptLabel.Text = $"{score.ToString()} / {possibleWords.GetWordCount()} words";
                UsingTheWord.Text = "using the word";
            }
        }
        private string ValidInput(string input, int wordLength, string[] characters, int minInputLength)
        {
            int index = 0;
            int[] usedIndexes = new int[prompt.Length];

            // Instantly return an invalid error message if the input is longer than the prompt itself

            if (input.Length > prompt.Length)
            {
                return "Your input uses letters not found in the prompt";
            }
            else if (input.Length < minInputLength)
            {
                return $"Your input cannot be less than {minInputLength.ToString()} characters long";
            }
            else if (input == prompt)
            {
                return "Your input cannot be the same as the prompt";
            }

            // Checking if the word has already been entered

            for (int i = score - 1; i >= 0; i--)
            {
                if (input == WordList.Items[i].ToString())
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

                for (int j = 0; j < prompt.Length; j++)
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
                if (input[0] != WordList.Items[score - 1].ToString()[WordList.Items[score - 1].ToString().Length - 1])
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
        private bool BinarySearch(string input, int searchSize) // Binary Search algorithmm
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
                    // Alphabetically compares the first letter of each word.
                    // If they are the same, the program iterates to the second letter and so on until all letters have been checked
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
                        else // Longer words are alphabetically later than shorter words
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

        }
        private void InitialiseSettings() // Properly sets up the next game to reflect all the selected options
        {
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

            if (settings[6] == "true")
            {
                stringModeActive = true;
                WordList.Sorted = false;
                ScoreDisplay.Text = score.ToString();
            }
            else
            {
                stringModeActive = false;
                WordList.Sorted = true;
                ScoreDisplay.Text = $"{score.ToString()} / {possibleWords.GetWordCount()}";
            }

            if (settings[7] == "true")
            {
                dynamicTimerActive = true;
            }
            else
            {
                dynamicTimerActive = false;
            }

            timerIncrement = Convert.ToInt32(settings[8]);
        }
        private void HelpButton_Click(object sender, EventArgs e) // Shows the help window
        {
            HowToPlay help = new HowToPlay();
            help.ShowDialog();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Display the game interface after the player presses PLAY

            ScoreLabel.Text = "Your score:";
            GuessBox.Enabled = true;
            GuessBox.Visible = true;
            EnterButton.Enabled = true;
            EnterButton.Visible = true;
            WordList.Enabled = true;
            WordList.Visible = true;
            SaveButton.Enabled = true;
            SaveButton.Visible = true;
            ResetButton.Enabled = true;
            ResetButton.Visible = true;
            OptionsButton.Enabled = true;
            OptionsButton.Visible = true;
            ExitButton.Enabled = true;
            ExitButton.Visible = true;
            TimerText.Enabled = true;

            WelcomeLabel.Text = "";
            PlayButton.Enabled = false;
            PlayButton.Visible = false;
            MenuOptionsButton.Enabled = false;
            MenuOptionsButton.Visible = false;
            QuitButton.Enabled = false;
            QuitButton.Visible = false;

            longWords.RollRandomIndex();
            TopLabel.Text = "How many words can you make with: ";
            ScoreLabel.Text = "Your score:";
            prompt = longWords.GetWord(longWords.GetIndex());
            PromptLabel.Text = prompt;

            possibleWords = new PossibleWordsList("Dictionary.txt", prompt, stringModeActive, settings[3]);

            InitialiseSettings();
        }

        private void MenuOptionsButton_Click(object sender, EventArgs e)
        {
            SetOptions();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit to the main menu?",
                "Confirm Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (choice == DialogResult.Yes)
            {
                ScoreLabel.Text = "";
                GuessBox.Enabled = false;
                GuessBox.Visible = false;
                EnterButton.Enabled = false;
                EnterButton.Visible = false;
                WordList.Enabled = false;
                WordList.Visible = false;
                SaveButton.Enabled = false;
                SaveButton.Visible = false;
                ResetButton.Enabled = false;
                ResetButton.Visible = false;
                OptionsButton.Enabled = false;
                OptionsButton.Visible = false;
                Timer.Stop();
                Timer.Enabled = false;
                TimerText.Enabled = false;
                TimerText.Visible = false;
                ExitButton.Enabled = false;
                ExitButton.Visible = false;
                ErrorText.Text = "";
                UsingTheWord.Text = "";
                PromptLabel.Text = "";
                TopLabel.Text = "";
                ScoreDisplay.Text = "";
                EndOfGamePromptText.Text = "";

                WelcomeLabel.Text = "Welcome";
                PlayButton.Enabled = true;
                PlayButton.Visible = true;
                MenuOptionsButton.Enabled = true;
                MenuOptionsButton.Visible = true;
                QuitButton.Enabled = true;
                QuitButton.Visible = true;
            }
        }
    }
}
