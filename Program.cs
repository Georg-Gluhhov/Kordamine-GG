using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_GG.Polindrom;
using static Kordamine_GG.LongLine;
namespace Kordamine_GG
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("\n----------------------------------\nChoose Function\n1-Polidrom \n2-LongLineFunc");
                int chs = int.Parse(Console.ReadLine());
                if (chs == 1)
                {
                    PolindromFunc();
                }
                else if (chs == 2)
                {
                    LongLineFunc();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
