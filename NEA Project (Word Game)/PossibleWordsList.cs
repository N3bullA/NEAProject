using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class PossibleWordsList : List
    {
        public PossibleWordsList(string filename, string prompt, bool stringModeSetting, string minInputLength) : base(filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (PossibleWord(line, prompt) && line.Length >= Convert.ToInt32(minInputLength))
                    {
                        tempList.Add(line);
                    }
                }
                words = tempList.ToArray();
                tempList.Clear();
            }

            MergeSort(words);
        }

        public bool PossibleWord(string target, string prompt)
        {
            int index = 0;
            int[] usedChars = new int[prompt.Length - 1];

            for (int i = 0; i < target.Length; i++)
            {
                for (int j = 0; j < prompt.Length - 1; j++)
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
