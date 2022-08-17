using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public int Tay { get; set; }
        public int Chan { get; set; }
        public abstract void Speak();

        public abstract void DemSoLuongChanTay(int chan, int tay);

    }
}
