using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface
{
    public class Smartphone:IConnectable, IRechargeable, IDisplayable
    {

        public string Brand { get; set; }
        public int Battery { get; set; }

        public Smartphone(string model)
        {
            Brand = Brand;
            Battery = 70;
        }
        public bool Connect()
        {
            Console.WriteLine($"{Brand}Smartphone Connected Successfully");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"{Brand}Smartphone charging for {minutes} minutes.");
        }

        public string Display()
        {
            return $"{Brand}Smartphone Display Information. Battery:{Battery} %";
        }
    }
}
