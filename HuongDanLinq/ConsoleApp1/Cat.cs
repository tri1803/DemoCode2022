using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Animal, ISpeak
    {
        public override void showAge()
        {
            base.showAge();
            Console.WriteLine("meo co 4 chan");
        }

        public void Speak()
        {
            Console.WriteLine("Meo keu meo meo");
        }

        public int TinhTong(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
