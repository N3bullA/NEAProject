using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class LongWordList : List
    {
        public LongWordList(string filename, string rootWords, int minimumLength) : base(filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (line.Length >= minimumLength)
                    {
                        if (rootWords == "true")
                        {
                            if (Root(line))
                            {
                                tempList.Add(line);
                            }
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
        public bool Root(string word)
        {
            if (word.Substring(0, 2) == "un" || word.Substring(0, 2) == "de" || word.Substring(0, 2) == "in" || word.Substring(0, 2) == "ab" || word.Substring(0, 2) == "im" ||
                word.Substring(0, 2) == "re" || word.Substring(0, 2) == "bi" || word.Substring(0, 2) == "co" || word.Substring(0, 2) == "il" || word.Substring(0, 2) == "ex" ||
                word.Substring(0, 3) == "pro" || word.Substring(0, 3) == "hyp" || word.Substring(0, 3) == "dys" || word.Substring(0, 3) == "dis" || word.Substring(0, 3) == "neo" ||
                word.Substring(0, 3) == "non" || word.Substring(0, 3) == "mal" || word.Substring(0, 3) == "sub" || word.Substring(0, 3) == "pre" || word.Substring(0, 3) == "mis" ||
                word.Substring(0, 4) == "equi" || word.Substring(0, 4) == "mega" || word.Substring(0, 4) == "mono" || word.Substring(0, 4) == "over" || word.Substring(0, 4) == "tele" ||
                word.Substring(0, 4) == "poly" || word.Substring(0, 4) == "anti" || word.Substring(0, 5) == "super" || word.Substring(0, 5) == "hydro")
            {
                return false;
            }
            else if (word[word.Length-1] == 's' || word.Substring(word.Length-2, 2) == "ly" || word.Substring(word.Length-2, 2) == "ed" || word.Substring(word.Length-2, 2) == "ce" ||
                word.Substring(word.Length - 2, 2) == "ic" || word.Substring(word.Length-2, 2) == "ae" || word.Substring(word.Length-2, 2) == "al" || word.Substring(word.Length-2, 2) == "ty" || 
                word.Substring(word.Length-2, 2) == "um" || word.Substring(word.Length-2, 2) == "er" || word.Substring(word.Length-3, 3) == "ize" || word.Substring(word.Length-3, 3) == "ive" ||  
                word.Substring(word.Length-3, 3) == "ion" || word.Substring(word.Length-3, 3) == "ble" || word.Substring(word.Length - 3, 3) == "ing" ||  word.Substring(word.Length-3, 3) == "ise" || 
                word.Substring(word.Length-3, 3) == "ate" || word.Substring(word.Length-3, 3) == "ite" || word.Substring(word.Length-3, 3) == "ent" || word.Substring(word.Length-3, 3) == "ify" ||
                word.Substring(word.Length-3, 3) == "ism" || word.Substring(word.Length-4, 4) == "ness" || word.Substring(word.Length - 4, 4) == "ance" || word.Substring(word.Length-5, 5) == "esque")
            {
                return false;
            }

            return true;
        }
    }
}
