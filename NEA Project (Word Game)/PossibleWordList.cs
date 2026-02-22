using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class PossibleWordList : List
    {
        public PossibleWordList(string filename, string prompt, int minInputLength, string stringModeActive, char lastInputLetter) : base(filename)
        {
            string line = string.Empty;
            List<string> tempList = new List<string>();

            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (line != "" && !ContainsNonLetters(line) && PossibleWord(line, prompt) && line.Length >= minInputLength && line != prompt)
                        // Selection to ensure all words fit the settings configuration and the prompt
                    {
                        if (stringModeActive == "true" && line[0] != lastInputLetter && lastInputLetter != '0')
                            // Extra selection for when String Mode is active
                        {
                        }
                        else
                        {
                            tempList.Add(line);
                        }
                    }
                }
                words = tempList.ToArray();
                tempList.Clear();
            }
            MergeSort(words);
        }

        public bool PossibleWord(string target, string prompt) // Ensures each word uses only letters found in the prompt
        {
            int index = 0;
            int[] usedChars = new int[prompt.Length];

            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < prompt.Length; j++)
                {
                    if (prompt[j] == target[i] && usedChars[j] != 1)
                    {
                        index++;
                        usedChars[j] = 1;
                        j = prompt.Length;
                    }
                }
            }

            if (index == target.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
