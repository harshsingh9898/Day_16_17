using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Permutation_Strings
    {


        static void permute(String s, String answer)
        {
            if (s.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String rest = left_substr + right_substr;
                permute(rest, answer + ch);
            }
        }

    }
}
