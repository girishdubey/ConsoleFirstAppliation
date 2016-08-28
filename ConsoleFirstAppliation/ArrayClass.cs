using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class ArrayClass
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("********1D Array********");
        //    Array1D();
        //    Console.WriteLine("********2D Array********");
        //    Array2D();

        //    Utility util = new Utility();
        //    util.DispayName("Girish");

        //    const int no = 20;
        //    int[] numberList = new int[no]; 
        //    for (int i = 0; i < no; i++)
        //    {
        //        numberList[i] = i * 10;
        //    }
        //    util.DispayName(numberList);




        //    const int colno = 3;
        //    const int rowno = 4;
        //    int[,] numberList2 = new int[rowno, colno];
        //    Console.WriteLine("insert data in array");
        //    for (int i = 0; i < rowno; i++)
        //    {
        //        for (int j = 0; j < colno; j++)
        //        {
        //            numberList2[i, j] = i * j * 10;
        //        }
        //    }
        //    util.DispayName(numberList2, rowno, colno);
        //}

        public static void Array1D()
        {
            const int no = 20;
            int[] numberList = new int[no];
            Console.WriteLine("insert data in array");
            for (int i = 0; i < no; i++)
            {
                numberList[i] = i * 10;
            }
            //Console.WriteLine("display data of array");
            //for (int i = 0; i < no; i++)
            //{
            //    Console.WriteLine(numberList[i]);
            //}

            Console.WriteLine(numberList[10]);

            Console.ReadLine();
        }

        public static void Array2D()
        {
            const int colno = 3;
            const int rowno = 4;
            int[,] numberList = new int[rowno, colno];
            Console.WriteLine("insert data in array");
            for (int i = 0; i < rowno; i++)
            {
                for (int j = 0; j < colno; j++)
                {
                    numberList[i, j] = i * j * 10;
                }
            }
            Console.WriteLine("display data of array");
            for (int i = 0; i < rowno; i++)
            {
                for (int j = 0; j < colno; j++)
                {
                    Console.WriteLine(numberList[i, j]);
                }
            }

            //Console.WriteLine(numberList[2,3]);

            Console.ReadLine();
        }
    }
}
