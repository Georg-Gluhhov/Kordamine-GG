using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_GG.Polindrom;
namespace Kordamine_GG
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("\n----------------------------------\nChoose Function\n1-Polidrom \n2- \n3-");
                int chs = int.Parse(Console.ReadLine());
                if (chs == 1)
                {
                    PolindromFunc();
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
