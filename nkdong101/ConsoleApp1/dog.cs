using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class dog : Animal
    {
        public string leg_staus { get; set; }

        public void show_leg()
        {
            Console.WriteLine("Tinh trang chan: " + leg_staus); 
        }
    }
}
