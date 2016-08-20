using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class LoopClass
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("************While Loop******************");
        //    WhileLoopExample1();
        //    Console.WriteLine("************While Loop******************");
        //    WhileLoopExample2();
        //    Console.WriteLine("************Do While Loop******************");
        //    DoWhileLoopExample1();
        //    Console.WriteLine("************For Loop******************");
        //    ForWhileLoopExample1();
        //    ForWhileLoopExample3();
        //    Console.WriteLine("************Print Odd Number******************");
        //    PrintOddNumber();
        //}

        public static void WhileLoopExample1()
        {

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();

        }


        public static void WhileLoopExample2()
        {

            int PayAmout, TotalPendingAmount = 10000, PaidAmout = 0;
            int CurrPendingAmount = TotalPendingAmount;


            while (PaidAmout < TotalPendingAmount)
            {
                Console.Write("Enter pay amount (" + CurrPendingAmount + "): ");
                PayAmout = Convert.ToInt32(Console.ReadLine());
                PaidAmout += PayAmout;      //PaidAmout = PaidAmout + PayAmout
                CurrPendingAmount = TotalPendingAmount - PaidAmout;
            }

            Console.WriteLine("******************************");
            Console.WriteLine("Pending Amout: " + TotalPendingAmount);
            Console.WriteLine("Paid Amout: " + PaidAmout);
            Console.WriteLine("Extra Amout: " + (PaidAmout - TotalPendingAmount));
            Console.WriteLine("******************************");

            Console.ReadLine();

        }


        public static void DoWhileLoopExample1()
        {

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            Console.ReadLine();

        }


        public static void ForWhileLoopExample1()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }


        public static void ForWhileLoopExample2()
        {

            int i = 0;

            for (; ; )
            {
                Console.WriteLine(i);
                if (i < 10)
                    break;
                i++;
            }

            Console.ReadLine();

        }


        public static void ForWhileLoopExample3()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            Console.ReadLine();
        }


        ///////

        public static void PrintOddNumber()
        {
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }



    }
}
