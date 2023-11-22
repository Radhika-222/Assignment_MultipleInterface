using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Samsung");
            Laptop laptop = new Laptop("Lenovo");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine("___________________\n");

            
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
