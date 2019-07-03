using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class EqualStacks
    {
        public int stackH(int[] s)
        {
            int h = 0;
            for (int i = 0; i < s.Length; i++)
            {
                h = h + s[i];
            }
            return h;
        }
        public Stack<int> arrToStack(int[] arr)
        {
            Stack<int> s = new Stack<int>();

            for(int i = (arr.Length - 1); i >= 0; i--)
            {
                s.Push(arr[i]);
            }
            return s;
        }
        public int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            //Variable declaration
            Stack<int> s1 = arrToStack(h1);
            Stack<int> s2 = arrToStack(h2);
            Stack<int> s3 = arrToStack(h3);
            int sh1 = stackH(h1);
            int sh2 = stackH(h2);
            int sh3 = stackH(h3);

            while (true)
            {
                if (sh1 > sh2 || sh1 > sh3)
                {
                    sh1 = sh1 - s1.Pop();
                }
                if (sh2 > sh1 || sh2 > sh3)
                {
                    sh2 = sh2 - s2.Pop();
                }
                if (sh3 > sh1 || sh3 > sh2)
                {
                    sh3 = sh3 - s3.Pop();
                }
                if(sh1 == sh2 && sh2 == sh3)
                {
                    break;
                }
            }
            return sh1;
        }
    }
}
