using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class MakingAnagrams
    {
        //Eliminate all characters from inspected not present in model
        public void deleteUnneededChar(ref string model, ref string inspected, ref int total)
        {
            string temp = "";

            for (int i = 0; i < inspected.Length; i++)
            {
                if (!model.Contains(inspected[i]))
                {
                    total++;
                }
                else
                {
                    temp = String.Concat(temp, Char.ToString(inspected[i]));
                }
            }

            inspected = temp;
        }

        // Complete the makeAnagram function below.
        public int makeAnagram(string a, string b)
        {
            int total = 0;
            Console.WriteLine("First string: " + a);
            Console.WriteLine("Second string: " + b);

            deleteUnneededChar(ref a, ref b, ref total); //Eliminate unecessary characters
            deleteUnneededChar(ref b, ref a, ref total); //Eliminate unecessary characters


            //loop as many times as size(variable) of the string
                //Count ia in a put value in frequencyA
                //Count ia in b put value in frequencyB
                //Difference = frequencyA - frequencyB
                    //if difference < 0
                        //Eliminate character in b unsigned difference times
                        //Total++ on each deletion
                    //if difference > 0
                        //Eliminate character in a difference times
                        //Total++ on each deletion







            
            Console.WriteLine("First tring modified: " + a);
            Console.WriteLine("Second tring modified: " + b);
            Console.WriteLine("Deletions: " + total);
            return total;
        }
    }
}
