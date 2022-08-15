using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.age = 5;
            d.wieght = 12;
            d.hieght = 50;

            d.show_a();
            d.show_w();
            d.show_h();

            d.leg_staus = "GOOD";
            d.show_leg();
            Console.ReadLine();
        }
    }
}
