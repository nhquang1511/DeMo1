using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMo1
{
    internal class TestCa
    {
        static void Main(string[] args)
        {
            CaTre ca1 = new CaTre("nam", "blue", 5.3, true, 10);
            ca1.inThongTin();
            ca1.cachBoi();
            ca1.cachBo();
            Console.ReadKey();
        }
    }
}
