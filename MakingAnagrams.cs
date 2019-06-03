using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class MakingAnagrams
    {
        // Complete the makeAnagram function below.
        public int makeAnagram(string a, string b)
        {
            int total = 0;
            string temp = "";
            Console.WriteLine(temp);

            //Eliminate unecessary characters
            for (int i = 0; i < b.Length; i++)
            {
                if(!a.Contains(b[i]))
                {
                    total++;
                }
                else
                {
                    temp = String.Concat(temp, Char.ToString(b[i]));
                }
            }

            Console.WriteLine(temp);
            return total;
        }
    }
}
