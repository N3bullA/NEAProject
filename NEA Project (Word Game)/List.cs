using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class List
    {
        protected string line = string.Empty;
        private int index;
        protected int maxWordLength = 0;

        protected Random rnd = new Random();
        protected string[] words;
        protected List<string> tempList = new List<string>();

        public List(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    tempList.Add(line);
                    if (line.Length > maxWordLength)
                    {
                        maxWordLength = line.Length;
                    }
                }
                words = tempList.ToArray();
                tempList.Clear();
            }

            MergeSort(words);
        }
        public string GetWord(int index)
        {
            return words[index];
        }
        public string[] GetWordChars(int index)
        {
            List<string> tempList = new List<string>();

            for (int i = 0; i < words[index].Length; i++)
            {
                tempList.Add(words[index][i].ToString());
            }
            string[] characters = tempList.ToArray();

            return characters;
        }

        public void RollRandomIndex()
        {
            index = rnd.Next(0, words.Length);
        }
        public int GetIndex()
        {
            return index;
        }
        public int GetWordCount()
        {
            return words.Length;
        }
        public int GetMaximumWordLength()
        {
            return maxWordLength;
        }

        // Merge Sort - Dividing arrays in two
        public static void MergeSort(string[] words)
        {
            if (words.Length < 2)
            {
                return;
            }
            else
            {
                int midpoint = words.Length / 2;
                string[] leftHalf = new string[midpoint];
                Array.Copy(words, leftHalf, midpoint);
                string[] rightHalf = new string[words.Length - midpoint];
                Array.Copy(words, midpoint, rightHalf, 0, words.Length - midpoint);

                MergeSort(leftHalf);
                MergeSort(rightHalf);

                Merge(words, leftHalf, rightHalf);
            }
        }

        // Merge Sort - Merging two arrays into one
        public static void Merge(string[] words, string[] leftHalf, string[] rightHalf)
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
