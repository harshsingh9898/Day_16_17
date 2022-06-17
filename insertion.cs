using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class insertion
    {
        public static void intsort()
        {
            int val, flag;
            int[] arr = { 25, 41, 3, 7, 9, 15, 63, 108, 47, 84, 1104, 37 };
            Console.WriteLine("Unsorted array is: ");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            for (int i = 1; i < arr.Length; i++)
            {
                val = arr[i];
                flag = 0;

                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }

            }
            Console.WriteLine("Sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);
            }

        }
    }
}
