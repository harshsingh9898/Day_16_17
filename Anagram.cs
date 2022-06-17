namespace Anagram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the 1st word: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the 2nd word: ");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine(val1);
                Console.WriteLine("Both strings are Anagram");
            }

        }
    }
}