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
        static void deleteUnneededChar(ref string model, ref string inspected, ref int total) {
            string temp = "";
            for (int i = 0; i < inspected.Length; i++) {
                if (!model.Contains(inspected[i])) {
                    total++;
                }
                else {
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
            int size = a.Length;
            int frequencyA = 0;
            int frequencyB = 0;
            int dif = 0;

            for (int i = 0; i < size; i++) //loop as many times as size(variable) of the string
            {
                if (!(a[i] == '!'))
                {
                    foreach (char c in a) //Count ia in a put value in frequencyA
                        if (c == a[i]) frequencyA++; Console.WriteLine(frequencyA);
                    foreach (char c in b) //Count ia in b put value in frequencyB
                        if (c == a[i]) frequencyB++; Console.WriteLine(frequencyB);

                    dif = frequencyA - frequencyB; Console.WriteLine("dif: " + dif);
                    char temp = a[i];
                    if (dif < 0) //if difference < 0
                    {
                        a = a.Replace(temp, '!');
                        b = b.Replace(temp, '!');
                        total = total + Math.Abs(dif);
                    }
                    else if (dif > 0) //if difference > 0
                    {
                        a = a.Replace(temp, '!'); 
                        b = b.Replace(temp, '!');
                        total = total + dif;
                    }
                    frequencyA = 0; frequencyB = 0; dif = 0; //Reset values
                }

            }
            Console.WriteLine("First tring modified: " + a);
            Console.WriteLine("Second tring modified: " + b);
            Console.WriteLine("Deletions: " + total);
            return total;
        }
    }
}
