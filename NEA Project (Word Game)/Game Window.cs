namespace NEA_Project__Word_Game_
{
    public partial class GameWindow : Form
    {
        public List allWords;
        public PromptWordList promptWords;
        public PossibleWordList possibleWords;

        public string[] files = { "IELTS_Dictionary.txt", 
            "DictionaryAPI_Dictionary.txt", 
            "JUSTWORDS_Dictionary.txt", 
            "Infochimps_Dictionary.txt" };
        public bool gameEnded = false;
        public bool definePrompt = true;

        public int seconds;
        public int minutes;

        public string prompt = string.Empty;
        public int score = 0;
        public string[] fileSettings = new string[12];
        public string[] gameSettings = new string[13];
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
                    if (line.Length > 0)
                    {
                        tempList.Add(line);
                    }
                }
            }
            fileSettings = tempList.ToArray();
            tempList.Clear();

            allWords = new List(files[Convert.ToInt32(fileSettings[5])]);
        }
        public void GameWindow_Load(object sender, EventArgs e)
        {
        }
        public void NewGame()
        {
            definePrompt = true;
            score = 0;
            Array.Copy(fileSettings, gameSettings, fileSettings.Length);
            NewPromptWords(); // Create new instance of the prompt words
                              // this is to update the list if the player changed settings

            promptWords.RollRandomIndex();
            prompt = promptWords.GetWord(promptWords.GetIndex());
            PromptLabel.Text = prompt;

            if (gameSettings[12] == "false") // Change formatting if Random Mode is enabled
            {
                TopLabel.Text = "How many words can you make with: ";
            }
            else
            {
                TopLabel.Text = "Make a word using: ";
            }

            if (gameSettings[11] == "false" && gameSettings[12] == "false")
            {
                NewPossibleWords(); // Creates instance of all possible words for score display calculation
                                    // It's not calculated otherwise for optimisation purposes.
            }        

            InitialiseSettings();
        }
        private void SetOptions()
        {
            NewPromptWords();
            Options optionsForm = new Options(fileSettings, promptWords.GetMaximumWordLength());
            DialogResult input = optionsForm.ShowDialog();
            if (input == DialogResult.Yes)
            {
                // Convert all inputs in the options menu to values stored in the "fileSettings" array

                fileSettings[0] = optionsForm.GetPromptRootOption();
                fileSettings[1] = optionsForm.GetMinPromptLength();
                fileSettings[2] = optionsForm.GetMaxPromptLength();
                fileSettings[3] = optionsForm.GetMinInputLength();
                fileSettings[4] = optionsForm.GetSelectedPromptDictionary();
                fileSettings[5] = optionsForm.GetSelectedAllDictionary();
                fileSettings[6] = optionsForm.GetScoreFormatting();
                fileSettings[7] = optionsForm.GetTimerOption();
                fileSettings[8] = optionsForm.GetTimerLength();
                fileSettings[9] = optionsForm.GetDynamicTimerOption();
                fileSettings[10] = optionsForm.GetTimerIncrement();
                fileSettings[11] = optionsForm.GetStringModeOption();
                fileSettings[12] = optionsForm.GetRandomModeOption();

                // Writes all the options into the "Options.txt" text file

                StreamWriter sw = new StreamWriter("Options.txt");
                foreach (string option in fileSettings)
                {
                    sw.WriteLine(option);
                }
                sw.Close();
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

                NewGame();

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
                    promptWords.GetWordChars(promptWords.GetIndex()),
                    Convert.ToInt32(gameSettings[3]), gameSettings[11]) == "true") 
                    // Add the word to the word list and increment the score if the input is valid
            {
                ErrorText.Text = string.Empty;
                WordList.Items.Add(GuessBox.Text.ToLower());
                score++;

                if (gameSettings[12] == "true") 
                    // Generate a new prompt if Random Mode is enabled & force display the default score format
                    // if Random Mode or String Mode is enabled
                {
                    promptWords.RollRandomIndex();
                    prompt = promptWords.GetWord(promptWords.GetIndex());
                    PromptLabel.Text = prompt;
                    ScoreDisplay.Text = $"{score}";
                }
                else if (gameSettings[11] == "true")
                {
                    ScoreDisplay.Text = $"{score}";
                }
                else
                {
                    ScoreDisplay.Text = ScoreFormat(Convert.ToInt32(gameSettings[6]), gameSettings[11], gameSettings[12]);
                }

                if (gameSettings[9] == "true") // Increment the timer if the "Dynamic Timer" option is enabled
                {
                    seconds += Convert.ToInt32(gameSettings[10]);
                    while (seconds > 59)
                    {
                        seconds -= 60;
                        minutes++;
                    }
                    TimerText.Text = String.Format("{0}:{1}", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
                }
            }
            else // Display the appropriate error message
            {
                ErrorText.Text = ValidInput(GuessBox.Text.ToLower(),
                    promptWords.GetWordChars(promptWords.GetIndex()),
                    Convert.ToInt32(gameSettings[3]), gameSettings[11]);
            }
            GuessBox.Text = string.Empty;
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Switching to the game interface

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
            DefineButton.Enabled = true;
            DefineButton.Visible = true;
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

            NewGame();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit to the main menu?", // Confirmation menu
                "Confirm Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (choice == DialogResult.Yes)
            {
                // Switching back to the startup menu interface

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
                DefineButton.Enabled = false;
                DefineButton.Visible = false;
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
                GuessBox.Text = "";

                WelcomeLabel.Text = "Welcome";
                PlayButton.Enabled = true;
                PlayButton.Visible = true;
                MenuOptionsButton.Enabled = true;
                MenuOptionsButton.Visible = true;
                QuitButton.Enabled = true;
                QuitButton.Visible = true;

                WordList.Items.Clear();
                score = 0;
            }
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
                        if (possibleWords.GetWord(i) == WordList.Items[j].ToString()) // Checking if the word has already been entered by the player
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

                if (gameSettings[12] == "true") // Display a different summary menu depending on what gamemode the player is playing
                {
                    TopLabel.Text = "";
                    PromptLabel.Text = $"You have named {score} words";
                    UsingTheWord.Text = "with randomised words!";
                    EndOfGamePromptText.Text = $"You failed on {prompt}";
                    NewPossibleWords();
                }
                else
                {
                    EndOfGamePromptText.Text = PromptLabel.Text;
                    TopLabel.Text = "Congratulations! You have named";
                    UsingTheWord.Text = "using the word";

                    if (gameSettings[11] == "true")
                    {
                        PromptLabel.Text = $"{score} words";
                        NewPossibleWords(); // Calculate possible words only after the game is done if String Mode or Random Mode is enabled
                    }
                    else
                    {
                        PromptLabel.Text = $"{ScoreFormat(Convert.ToInt32(gameSettings[6]), gameSettings[11], gameSettings[12])} words";
                    }
                }                  
            }
        }
        private string ScoreFormat(int formatIndex, string stringMode, string randomMode)
            // Determines which format the score display should be, specified by the options menu
        {
            double percentage = (double)score / possibleWords.GetWordCount() * 100;
            if (stringMode == "true" || randomMode == "true")
            {
                return $"{score}";
            }
            switch (formatIndex)
            {
                case 0:
                    return $"{score} / {possibleWords.GetWordCount()}";
                case 1:
                    return $"{score} ({percentage:0.00}%)";
                case 2:
                    return $"{score} / {possibleWords.GetWordCount()} ({percentage:0.00}%)";
                case 3:
                    return $"{score}";
            }
            return $"{score}";
        }
        private void InitialiseSettings() // Properly sets up the next game to reflect all the selected options
        {
            if (gameSettings[7] == "true") // Enable timer
            {
                seconds = Convert.ToInt32(gameSettings[8]) % 60;
                minutes = Convert.ToInt32(gameSettings[8]) / 60;
                TimerText.Text = String.Format("{0}:{1}", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
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

            if (gameSettings[11] == "true" || gameSettings[12] == "true") // Format the score display
            {
                WordList.Sorted = false;
                ScoreDisplay.Text = score.ToString();
            }
            else
            {
                WordList.Sorted = true;
                ScoreDisplay.Text = ScoreFormat(Convert.ToInt32(gameSettings[6]), gameSettings[11], gameSettings[12]);
            }
        }
        private string ValidInput(string input, string[] characters, int minInputLength, string stringModeActive) // Input validation algorithm
        {
            int validationIndex = 0;
            int[] usedIndexes = new int[prompt.Length];

            if (input.Length > prompt.Length) // Instantly return an invalid error message if the input is longer than the prompt itself
            {
                return "Your input uses letters not found in the prompt";
            }
            else if (input.Length < minInputLength) // Return error message if the length of the input is
                                                    // below the minimum threshold specified in the options menu
            {
                return $"Your input cannot be less than {minInputLength.ToString()} characters long";
            }
            else if (input == prompt) // Return error message if the input is the same as the prompt
            {
                return "Your input cannot be the same as the prompt";
            }

            for (int i = score - 1; i >= 0; i--) // Checking if the word has already been entered
            {
                if (input == WordList.Items[i].ToString())
                {
                    return "You have already entered this word";
                }
            }

            for (int i = 0; i < input.Length; i++) // Checking each letter in the input
            {
                // Returning an invalid error message if there's a non-letter character in the input

                if ((char)input[i] < 97 || (char)input[i] > 122)
                {
                    return "Your input must contain only letters";
                }

                // Comparing each letter in the input to each letter in the prompt:
                // - If a letter in the input matches a letter in the prompt, a counter goes up and an item
                // is added to an array at the index of the used character
                // - This array is used to determine if a letter in the prompt has already been used to match a letter in the input.
                // If that is the case, the character is ignored

                for (int j = 0; j < prompt.Length; j++)
                {
                    if (input[i].ToString() == characters[j] && usedIndexes[j] != 1)
                    {
                        validationIndex++;
                        usedIndexes[j] = 1;
                        break;
                    }
                }
            }

            if (stringModeActive == "true" && score > 0) // Checking if the input begins with the last letter of the previous input if String Mode is enabled
            {
                if (input[0] != WordList.Items[score - 1].ToString()[WordList.Items[score - 1].ToString().Length - 1])
                {
                    return "First letter of the input must be the last letter of the previous input";
                }
            }

            if (validationIndex == input.Length && BinarySearch(input, allWords.GetWordCount())) // If all the letters are valid and the input is a
                                                                                                 // word in the dictionary, return true.
            {
                return "true";
            }
            else
            {
                if (validationIndex != input.Length)
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
        static async Task GetDefinition(string word)
        {
            DefinitionLookup lookup = new DefinitionLookup();
            MessageBox.Show(await lookup.GetDefinitionAsync(word));
        }
        private void DefineButton_Click(object sender, EventArgs e) // Detect when to define the prompt or the selected word
        {
            if (definePrompt)
            {
                GetDefinition(prompt);
            }
            else
            {
                GetDefinition(WordList.SelectedItem.ToString());
            }
        }
        private void WordList_SelectedIndexChanged(object sender, EventArgs e) 
            // Detect when the player has selected a word to avoid the program defining the prompt
        {
            definePrompt = false;
        }
        private void Timer_Tick(object sender, EventArgs e) // Count down one second every 1000 ticks
        {
            seconds--;
            if (seconds <= -1)
            {
                seconds = 59;
                minutes--;
            }
            TimerText.Text = String.Format("{0}:{1}", minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));

            if (seconds == 0 && minutes == 0) // Stop the timer once it reaches 0
            {
                Timer.Stop();
                GuessBox.Enabled = false;
                EnterButton.Enabled = false;
                GuessBox.Text = "";
                ErrorText.Text = "Your time is up!";
            }
        }
        private void OptionsButton_Click(object sender, EventArgs e)
        {
            SetOptions();
        }
        private void MenuOptionsButton_Click(object sender, EventArgs e)
        {
            SetOptions();
        }
        private void HelpButton_Click(object sender, EventArgs e) // Shows the help window
        {
            HowToPlay helpForm = new HowToPlay();
            helpForm.ShowDialog();
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NewPromptWords()
        {
            promptWords = new PromptWordList(files[Convert.ToInt32(gameSettings[4])], 
                fileSettings[0],
                Convert.ToInt32(fileSettings[1]), 
                Convert.ToInt32(fileSettings[2]));
        } // Create new instance of prompt words
        private void NewPossibleWords()
        {
            if (score == 0)
            {
                possibleWords = new PossibleWordList(files[Convert.ToInt32(gameSettings[5])], 
                    prompt,
                    Convert.ToInt32(gameSettings[3]), 
                    gameSettings[11], '0');
            }
            else
            {
                possibleWords = new PossibleWordList(files[Convert.ToInt32(gameSettings[5])],
                   prompt,
                   Convert.ToInt32(gameSettings[3]), 
                   gameSettings[11], 
                   WordList.Items[score-1].ToString()[WordList.Items[score-1].ToString().Length-1]);
            }
            
        } // Create new instance of possible words for a prompt
    }
}
