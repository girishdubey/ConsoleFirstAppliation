using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    FistClass();
        //}


        public static void FistClass()
        {
            int no1, no2, total;
            no1 = 10;
            no2 = 5;
            total = 0;

            //sum of two number
            total = no1 + no2;
            Console.WriteLine(total);
            //sum of two number

            //multiplication of two number
            total = no1 * no2;
            Console.WriteLine(total);
            //multiplication of two number




            //float----------------

            float fno1, fno2, ftotal;
            fno1 = 1.9f;
            fno2 = fno1;
            ftotal = 0.0f;
            //sum of two number
            ftotal = fno1 + fno2;
            Console.WriteLine(ftotal);

            total = (int)fno1 + (int)fno2;
            Console.WriteLine(total);

            total = (int)(fno1 + fno2);
            Console.WriteLine(total);


            //////////////////////////
            ftotal = fno1 + fno2;
            Console.WriteLine(ftotal);

            total = Convert.ToInt32(fno1) + Convert.ToInt32(fno2);
            Console.WriteLine(total);

            total = Convert.ToInt32(fno1 + fno2);
            Console.WriteLine(total);
            /////////////////////////

            ftotal = no1 + no2;
            Console.WriteLine(ftotal);
            //sum of two number


            /////////bool//////////////

            bool flag;
            flag = true;
            Console.WriteLine(flag);


            /////////bit//////////////

            byte vbit;
            vbit = 0;    // value can be 0 or 1
            Console.WriteLine(vbit);


            ///////////char//////////////

            char chr = 'a';
            Console.WriteLine(chr);
            Console.WriteLine((int)chr);

            char chr2 = 'b';
            Console.WriteLine(chr2);
            Console.WriteLine((int)chr2);

            int totalchr = (int)chr + (int)chr2;
            Console.WriteLine("Sum of two char: " + Convert.ToChar(totalchr) + "(" + totalchr + ")");

            ///////////string//////////////

            string str = "microsoft";
            Console.WriteLine(str);

            Console.ReadLine();


            Console.WriteLine("////////////input from user///////////////");
            int userNum1, userNum2, userTotal = 0;

            Console.Write("Please enter a number: ");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a number: ");
            userNum2 = Convert.ToInt32(Console.ReadLine());

            userTotal = userNum1 + userNum2;

            Console.Write("Total of two numbers: " + userTotal);

            Console.ReadLine();
        }

    }
}
