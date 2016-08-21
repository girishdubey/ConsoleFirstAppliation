using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class ConditionalStatment
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("************If Condition******************");
        //    IfCondition();
        //    Console.WriteLine("************If else Condition******************");
        //    IfElseCondition();
        //    Console.WriteLine("************nested If else Condition******************");
        //    IfNestedCondition();
        //    Console.WriteLine("************Multi If else Condition******************");
        //    MultiIfElseCondition();

        //    Console.WriteLine("************Switch Case******************");
        //    SwitchCaseStatment();

        //}


        //if condition
        public static void IfCondition()
        {
            int i, j;
            i = 10;
            j = 20;

            if (i < j)
            {
                Console.WriteLine("{0} is less then {1}", i, j);
            }
            Console.ReadLine();
        }


        //if else condition
        public static void IfElseCondition()
        {
            int i, j;
            i = 10;
            j = 10;

            if (i < j)
            {
                Console.WriteLine("{0} is less then {1}", i, j);
            }
            else
            {
                Console.WriteLine("{0} is not less then {1}", i, j);
            }
            Console.ReadLine();
        }

        //Nested if else condition 
        public static void IfNestedCondition()
        {
            int i, j, k, l;
            i = 13;
            j = 12;
            k = 13;
            l = 14;

            if (i > j)
            {
                if (i > k)
                {
                    if (i > l)
                    {
                        Console.WriteLine("{0} > {1}", i, l);
                    }
                    else
                    {
                        Console.WriteLine("{0} < {1}", i, l);
                    }
                }
                else
                {
                    Console.WriteLine("{0} < {1}", i, k);
                }
            }
            else
            {
                Console.WriteLine("{0} < {1}", i, j);
            }
            Console.ReadLine();
        }


        //multi if else condition
        public static void MultiIfElseCondition()
        {
            int no;

            Console.Write("Please enter no: ");
            no = Convert.ToInt32(Console.ReadLine());

            if (no % 2 == 0)
            {
                Console.WriteLine("{0} can divid by 2", no);
            }
            else if (no % 3 == 0)
            {
                Console.WriteLine("{0} can divid by 3", no);
            }
            else if (no % 5 == 0)
            {
                Console.WriteLine("{0} can divid by 5", no);
            }
            else if (no % 7 == 0)
            {
                Console.WriteLine("{0} can divid by 7", no);
            }
            else if (no % 11 == 0)
            {
                Console.WriteLine("{0} can divid by 11", no);
            }
            else if (no % 13 == 0)
            {
                Console.WriteLine("{0} can divid by 13", no);
            }
            else if (no % 17 == 0)
            {
                Console.WriteLine("{0} can divid by 17", no);
            }
            else if (no % 19 == 0)
            {
                Console.WriteLine("{0} can divid by 19", no);
            }
            else if (no % 23 == 0)
            {
                Console.WriteLine("{0} can divid by 23", no);
            }

            Console.ReadLine();
        }

        public static void SwitchCaseStatment()
        {
            string name = "MTI";

            switch (name) {
                case "MTI":
                    Console.WriteLine("Microsoft Training Institute");
                    Console.WriteLine("----");
                    break;
                case "ABC":
                    Console.WriteLine("ABC");
                    Console.WriteLine("====");
                    break;
                case "XYZ":
                    Console.WriteLine("XYZ");
                    Console.WriteLine("+++++");
                    break;
            }
            Console.ReadLine();
        }

    }
}
