using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_GG
{
    public class Polindrom
    {
        public static void PolindromFunc()
        {
            
            int i = default;
            Console.WriteLine("Enter the words");
            string val = Console.ReadLine();
            string[] words = val.Split(new char[] { ' ' });
            foreach (var v in words)
            {
                if (v == new string(v.Reverse().ToArray()) && v.Length >= 2)
                {
                    i++;
                }
            }
            Console.WriteLine("Words - {0} \nWords polindrom - {1} ", words.Length, i);
        }
    }
}
