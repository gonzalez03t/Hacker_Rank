using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacke_Rank
{
    class MinimumSwaps2
    {
        public int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            int size = arr.Length;
            int L = 0;
            int temp = 0;

            while (size > 0)
            {
                for (int i = 0; i < size; i++) //find largest number
                {
                    if (arr[L] < arr[i])
                    {
                        L = i;
                    }
                }

                if (L != size - 1)
                {
                    temp = arr[L];
                    arr[L] = arr[size - 1];
                    arr[size - 1] = temp;
                    swaps++;
                    size--;
                    L = 0;
                }
                else
                {
                    size--;
                    L = 0;
                }
            }
            
            Console.WriteLine(swaps);
            return swaps;
        }
    }
}
