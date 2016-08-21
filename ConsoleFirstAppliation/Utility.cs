using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class Utility
    {
        public int Sum(int number1, int number2)
        {
            return (number1 + number2);
        }

        public int Sum(int number1, int number2, int number3)
        {
            return (number1 + number2 + number3);
        }

        public float Sum(float number1, float number2)
        {
            return (number1 + number2);
        }

        public string Sum(string fname, string lname)
        {
            return (fname + " " + lname);
        }

        public int Minus(int number1, int number2)
        {
            return Math.Abs(number1 - number2);
        }

        public int Div(int number1, int number2)
        {
            if (number2 == 0)
                return 0;
            else
                return (number1 / number2);
        }

        public int Mult(int number1, int number2)
        {
            return (number1 * number2);
        }


        public void DispayName(string Name)
        {
            Console.WriteLine(Name);
        }

        public void DispayName(int[] NameList)
        {
            for (int i = 0; i < NameList.Length; i++)
            {
                Console.WriteLine(NameList[i]);
            }
        }

        public void DispayName(int[,] NameList, int rowcount, int colcount)
        {
            Console.WriteLine("display data of array");
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < colcount; j++)
                {
                    Console.WriteLine(NameList[i, j]);
                }
            }
        }

    }
}
