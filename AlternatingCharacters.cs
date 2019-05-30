using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class AlternatingCharacters
    {
        // Complete the alternatingCharacters function below.
        public int alternatingCharacters(string s)
        {
            int min = 0;

            for (int i = 0; i < s.Length - 1; i++)//Traverse string
            {
                if (s[i] == (s[i + 1])) //Compare characters
                {
                    min++; //Increment counter
                }
            }

            return min;
        }
    }
}
