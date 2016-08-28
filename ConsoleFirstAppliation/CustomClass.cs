using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class CustomClass
    {
        //static void Main(string[] args)
        //{
        //    //A obja = new A();
        //    //Console.WriteLine(obja.address);
        //    //obja.Display();
        //    B objb = new B();
        //    Console.WriteLine(objb.id);
        //    objb.Display();
        //    int a, b = 100, c = 0;
        //    a = b / c;
        //    Console.ReadLine();
        //}
    }

    class A
    {
        private string name = "MTI";
        protected string email = "mti@gmail.com";
        public string address = "Saket";

        public void Display()
        {
            Console.WriteLine("Current class is 'A'");
        }
    }

    class B : A
    {
        public int id = 22;
        string email_temp;
        string name_temp;
        public void setBEmail()
        {
            email_temp = email;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Current class is 'B'");
        }
    }

    class C : B
    {
        public int id = 22;
        string email_temp;
        string name_temp;
        public void setCEmail()
        {
            email_temp = email;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Current class is 'C'");
        }
    }


}
