using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1, no2;
            int total = 0;
            no1 = 5;
            no2 = 10;
            total = no1 + no2;
            Console.WriteLine(total);

            //////////////////
            int sumValue1 = Utility.Sum(9, 10);
            Console.WriteLine(sumValue1);
            int sumValue2 = Utility.Sum(25, 10);
            Console.WriteLine(sumValue2);
            int sumValue3 = Utility.Sum(50, 10);
            Console.WriteLine(sumValue3);
            /////////////////
            Console.ReadLine();
        }
    }
}
