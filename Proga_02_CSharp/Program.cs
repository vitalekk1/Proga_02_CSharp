using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_02_CSharp
{
    class Program
    {
        private static Int32 s = 0, x;
        static void Main(string[] args)
        {
            x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                s = s + (x % 10);
                x = x / 10;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
