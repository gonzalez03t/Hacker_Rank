using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class MakingAnagrams
    {
        //Eliminate unecessary characters
        public void deleteUnneededChar(ref string a, ref string b, ref int total)
        {
            string temp = "";

            for (int i = 0; i < b.Length; i++)
            {
                if (!a.Contains(b[i]))
                {
                    total++;
                }
                else
                {
                    temp = String.Concat(temp, Char.ToString(b[i]));
                }
            }

            b = temp;
        }

        // Complete the makeAnagram function below.
        public int makeAnagram(string a, string b)
        {
            int total = 0;
            Console.WriteLine("Second string: " + b);

            deleteUnneededChar(ref a, ref b, ref total); //Eliminate unecessary characters

            //Determine if strings are anagrams
            //








            Console.WriteLine("New string " + b);
            Console.WriteLine("First tring: " + a);
            Console.WriteLine("Deletions: " + total);
            return total;
        }
    }
}
