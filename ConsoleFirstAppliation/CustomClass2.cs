using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class CustomClass2
    {
        static void Main(string[] args)
        {


            //KINLEY kinObj2 = new KINLEY();
            //kinObj2.HIGHT = 15;
            //kinObj2.WEIGHT = 10;
            //kinObj2.CAPACITY = 1;
            //kinObj2.WATERCOLOR = "GREE";

            //kinObj2.Display();


            KINLEY[] kinArr = new KINLEY[10];

            int i = 0;

            for (; i < 5; i++)
            {
                KINLEY kinObj1 = new KINLEY();
                kinObj1.HIGHT = 15;
                kinObj1.WEIGHT = 10;
                kinObj1.CAPACITY = 1;
                kinObj1.WATERCOLOR = "RED";

                kinArr[i] = kinObj1;

            }

            for (; i < 10; i++)
            {
                KINLEY kinObj1 = new KINLEY();
                kinObj1.HIGHT = 15;
                kinObj1.WEIGHT = 10;
                kinObj1.CAPACITY = 1;
                kinObj1.WATERCOLOR = "GREEN";

                kinArr[i] = kinObj1;

            }


            for (i = 0; i < 10; i++)
            {
                kinArr[i].Display();
            }



            Console.ReadLine();
        }
    }

    class Bottel
    {

        int _Weight, _Hight, _Capacity;

        public int WEIGHT
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        public int HIGHT
        {
            get { return _Hight; }
            set { _Hight = value; }
        }
        public int CAPACITY
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public void Display()
        {
            Console.WriteLine("Weight: " + _Weight);
            Console.WriteLine("Hight: " + _Hight);
            Console.WriteLine("Capacity: " + _Capacity);
        }
    }

    class KINLEY : Bottel
    {
        string _WaterColor;

        public string WATERCOLOR
        {
            get { return _WaterColor; }
            set { _WaterColor = value; }
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("WaterColor: " + _WaterColor);
        }
    }

}
