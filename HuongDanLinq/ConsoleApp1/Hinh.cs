using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hinh
    {
        public int canh { get; set; }
        public int goc { get; set; }

        public int Chuvi(int canh)
        {
            return canh;
        }

        //public int DienTich(int canh)
        //{
        //    return canh * 4;
        //}

        public int Chuvi(int canh, int goc)
        {
            return canh + goc;
        }
    }
}
