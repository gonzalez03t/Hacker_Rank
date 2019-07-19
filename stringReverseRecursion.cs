using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class stringReverseRecursion
    {
        public string reverseString(string str) //jesus
        {
            string reversed = "";

            if(str.Length == 0)
            {
                return str;
            }
                        
            reversed = reverseString(str.Substring(1)) + str[0];
            Console.WriteLine("New: " + reversed);
            return reversed;
        }
    }
}

//stack 1 = call(esus) + j
//stack 2 = call(sus) + e
//stack 3 = call(us) + s
//stack 4 = call(s) + u
//stack 5 = call() + s
//call() return = empty string
//empty string + s = s
//s + u = su
//su + s = sus
//sus + e = suse
//suse + j = susej
