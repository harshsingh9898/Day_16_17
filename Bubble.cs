using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Bubble
    {
        public static void bubble()
        {
            {
                int[] arr = { 25, 41, 3, 7, 9, 15, 63, 108, 47, 84, 1104, 37 };
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                        {
                            // swap temp and arr[i]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                for (int i = 0; i < n; ++i)
                    Console.WriteLine(arr[i] + " ");
            }
                
                
            

        }
    }
}
