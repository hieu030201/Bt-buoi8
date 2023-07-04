using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BT bt = new BT();
            //bt.Bai1();
            //bt.Bai2();

            SV sv = new SV();
            sv.MainB1();

            Console.ReadKey();
        }
    }
}
