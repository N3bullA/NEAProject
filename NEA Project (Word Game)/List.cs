using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class List
    {
        private int index;
        protected int maxWordLength = 0;
        protected string[] words;

        public List(string filename)
        {
            string line = string.Empty;
            List<string> tempList = new List<string>();

            using (StreamReader sr = new StreamReader(filename)) // Reading the text file
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "" && !ContainsNonLetters(line.ToLower())) // Only add words if they don't have non-letter characters
                    {
                        tempList.Add(line.ToLower());
                        if (line.Length > maxWordLength)
                        {
                            maxWordLength = line.Length;
                        }
                    }
                }
                words = tempList.ToArray();
                tempList.Clear();
            }

            MergeSort(words);
        }
        public string GetWord(int index) // Returns the word at the specified index
        {
            return words[index];
        }
        public void RollRandomIndex() // Rolls a random index in the array to return for fetching the prompt
        {
            Random rnd = new Random();
            index = rnd.Next(0, words.Length);
        }
        public int GetIndex() // Returns the currently selected index
        {
            return index;
        }
        public int GetWordCount() // Returns the size of the word list
        {
            return words.Length;
        }
        public int GetMaximumWordLength() // Returns the length of the longest word in the list
        {
            return maxWordLength;
        }
        public bool ContainsNonLetters(string word) // Returns whether a queried word contains a non-letter character
        {
            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] < 97 || (int)word[i] > 122)
                {
                    return true;
                }
            }
            return false;
        }
        public static void MergeSort(string[] words) // Merge Sort - Dividing arrays in two
        {
            if (words.Length < 2)
            {
                return; // Return if the array only contains one element
            }
            else
            {
                int midpoint = words.Length / 2;
                string[] leftHalf = new string[midpoint];
                Array.Copy(words, leftHalf, midpoint);
                string[] rightHalf = new string[words.Length - midpoint];
                Array.Copy(words, midpoint, rightHalf, 0, words.Length - midpoint);

                // Recursion - splitting up the newly split arrays further

                MergeSort(leftHalf);
                MergeSort(rightHalf);

                Merge(words, leftHalf, rightHalf);
            }
        } 
        public static void Merge(string[] words, string[] leftHalf, string[] rightHalf) // Merge Sort - Merging two arrays into one
        {
            int index1 = 0;
            int index2 = 0;
            int indexMerged = 0;
            int wordSizeIndex = 0;
            bool wordChecked = false;

            while (index1 < leftHalf.Length && index2 < rightHalf.Length)
            {
                while (!wordChecked)
                {
                    if (leftHalf[index1] == rightHalf[index2] || (int)leftHalf[index1][wordSizeIndex] < (int)rightHalf[index2][wordSizeIndex])
                    {
                        words[indexMerged] = leftHalf[index1];
                        wordChecked = true;
                        index1++;
                    }
                    else if ((int)leftHalf[index1][wordSizeIndex] > (int)rightHalf[index2][wordSizeIndex])
                    {
                        words[indexMerged] = rightHalf[index2];
                        wordChecked = true;
                        index2++;
                    }
                    else
                    {
                        wordSizeIndex++;
                        if (wordSizeIndex >= leftHalf[index1].Length && wordSizeIndex < rightHalf[index2].Length)
                        {
                            words[indexMerged] = leftHalf[index1];
                            wordChecked = true;
                            index1++;
                        }
                        else if (wordSizeIndex >= rightHalf[index2].Length && wordSizeIndex < leftHalf[index1].Length)
                        {
                            words[indexMerged] = rightHalf[index2];
                            wordChecked = true;
                            index2++;
                        }
                    }
                }
                indexMerged++;
                wordSizeIndex = 0;
                wordChecked = false;
            }

            while (index1 < leftHalf.Length)
            {
                words[indexMerged] = leftHalf[index1];
                index1++;
                indexMerged++;
            }
            while (index2 < rightHalf.Length)
            {
                words[indexMerged] = rightHalf[index2];
                index2++;
                indexMerged++;
            }
        }
    }
}
