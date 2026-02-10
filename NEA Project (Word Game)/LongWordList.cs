using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class LongWordList : List
    {
        public LongWordList(string filename, int minimumLength) : base(filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length >= minimumLength)
                    {
                        tempList.Add(line);
                    }                  
                }
                words = tempList.ToArray();
            }

            MergeSort(words);
        }
    }
}
