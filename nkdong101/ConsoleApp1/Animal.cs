using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public int wieght { get; set; }
        public int age { get; set; }
        public int hieght { get; set; }

        public void show_w()
        {
            Console.WriteLine("Can nang: " + wieght);
        }

        public void show_a()
        {
            Console.WriteLine("Tuoi: " + age);
        }
        public void show_h()
        {
            Console.WriteLine("Chieu cao " + hieght);
        }
    }
}
