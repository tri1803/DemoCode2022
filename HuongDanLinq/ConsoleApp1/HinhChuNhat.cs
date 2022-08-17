using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HinhChuNhat : Hinh
    {
        public int ChieuDai { get; set; }

        public double Chuvi(double dai, double rong)
        {
            return (dai + rong) * 2;
        }
    }
}
