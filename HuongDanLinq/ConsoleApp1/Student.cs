using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public override void DemSoLuongChanTay(int chan, int tay)
        {
            Console.WriteLine("4");
        }

        public override void Speak()
        {
            Console.WriteLine("Đây là con người");
        }
    }
}
