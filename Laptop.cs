using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface
{
    public class Laptop: IConnectable, IRechargeable, IDisplayable
    {

        public string Model{ get; set; }
        public int Battery { get; set; }

        public Laptop(string brand)
        {
            Model = Model;
            Battery = 80;
        }
        public bool Connect()
        {
            Console.WriteLine($"{Model}Laptop Connected Successfully");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"{Model}Laptop Charging for {minutes} minutes.");
        }

        public string Display()
        {
            return $"{Model}Laptop Display Information. Battery: {Battery} %";
        }
    }
}
