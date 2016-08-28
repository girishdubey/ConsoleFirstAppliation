using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstAppliation
{
    class Property
    {
        //static void Main(string[] args)
        //{
        //    MobileData obj = new MobileData();
        //    obj.SetFeature(1, "ABC", "XYZ", "2.256", 16.0f, 20000, 5.2f);
        //    obj.DisplayFeature();
        //    //obj.ID = 15;//cannot be assigned.
        //    Console.WriteLine("==============================");
        //    Console.WriteLine("ID: " + obj.ID);
        //    Console.WriteLine("Name: " + obj.NAME);
        //    Console.WriteLine("==============================");
        //    obj.TAX = 4f;
        //    obj.DisplayFeature();
        //}
    }


    class MobileData
    {
        int _id;
        string _name;
        string _version;
        string _brand;
        int _amount;
        float _txt;
        int _TotalAmount;
        float _capacity;



        public int ID {
            get { return _id; }
            //set { _id = value; }
        }

        public string NAME
        {
            get { return _name; }
            //set { _name = value; }
        }

        public float TAX
        {
            get { 
                return _txt; 
            }
            set { 
                _txt = value;
                _TotalAmount = Convert.ToInt32(Math.Round((_amount * _txt)/100, 0)) + _amount;
            }
        }


        public void DisplayFeature()
        {
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Version: " + _version);
            Console.WriteLine("Capacity: " + _capacity);
            Console.WriteLine("Price: " + _amount);
            Console.WriteLine("TAX: " + _txt);
            Console.WriteLine("Total Amount: " + _TotalAmount);
            Console.ReadLine();
        }

        public void SetFeature(int id, string name, string brand, string version, float capacity, int amount, float txt)
        {
            _id = id;
            _name = name;
            _brand = brand;
            _version = version;
            _capacity = capacity;
            _amount = amount;
            _txt = txt;
            _TotalAmount = Convert.ToInt32(Math.Round((_amount * _txt) / 100, 0)) + _amount;
        }
    }


}
