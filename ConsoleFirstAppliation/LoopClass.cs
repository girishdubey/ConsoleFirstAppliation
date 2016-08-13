using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class LoopClass
    {
        static void Main(string[] args)
        {
            WhileLoopExample1();
            WhileLoopExample2();
            DoWhileLoopExample1();
        }

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
            Console.WriteLine("Extra Amout: " + (PaidAmout-TotalPendingAmount));
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


    }
} 
