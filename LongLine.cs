using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kordamine_GG
{
    public class LongLine
    {
        public static void LongLineFunc()
        {
            Console.WriteLine("Enter the words2");
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            Console.WriteLine(charArray);
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

        }
    }
}
