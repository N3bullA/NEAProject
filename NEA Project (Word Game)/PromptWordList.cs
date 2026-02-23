using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class PromptWordList : List
    {
        int maxWordLength = 0;
        public PromptWordList(string filename, string rootWords, int minimumLength, int maximumLength) : base(filename)
        {
            ReadFile(filename, rootWords, minimumLength, maximumLength);
            MergeSort(words);
        }
        public void ReadFile(string filename, string rootWords, int minimumLength, int maximumLength)
        {
            string line = string.Empty;
            List<string> tempList = new List<string>();

            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (line != "" && line.Length >= minimumLength && line.Length <= maximumLength && !ContainsNonLetters(line))
                    // Ensures the word fits the criteria outlined by the current settings configuration
                    // (i.e. between the specified prompt length range)
                    {
                        if (rootWords == "true" && !Root(line))
                        {
                        }
                        else
                        {
                            tempList.Add(line);
                            if (line.Length > maxWordLength)
                            {
                                maxWordLength = line.Length;
                            }
                        }
                    }
                }
                words = tempList.ToArray();
                tempList.Clear();
            }
        }
        public int GetMaximumWordLength()
        {
            return maxWordLength;
        }
        public bool Root(string word) // Omits any word that uses any of the listed prefixes/suffixes
        {
            string[] prefixes = {"un", "de", "in", "ab", "im", "re", "bi", "co",
                "il", "ex", "pro", "hyp", "dys", "dis", "neo", "non", "mal", "sub",
                "pre", "mis", "equi", "mega", "mono", "over", "tele", "poly", "anti",
                "super", "hydro" };
            foreach (string prefix in prefixes)
            {
                if (word.Substring(0, prefix.Length) == prefix)
                {
                    return false;
                }
            }

            string[] suffixes = { "s", "ly", "ed", "er", "ic", "ae", "al", "ty",
                "um", "er", "ize", "ive", "ion", "ble", "ing", "ise", "ate", "ite",
                "ent", "ify", "ism", "ness", "ance", "esque" };
            foreach (string suffix in suffixes)
            {
                if (word.Substring(word.Length - suffix.Length, suffix.Length) == suffix)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
