using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class factorial
    {
        public int factorialF(int n)
        {
            if(n == 1 || n == 0) //if n = 1 or 0 return 1
            {
                return 1;
            }

            Console.WriteLine(n);
            //else call the function again with n -1
            return n * factorialF(n - 1);            
        }
    }
}
