using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMo1
{
    public class CaTre :Ca, IBo
    {
        private double tocdobo;

        public CaTre(string tenca, string mausac, 
            double cannang, bool covay, double tocdobo) 
            : base(tenca, mausac, cannang, covay)
        {
            this.tocdobo = tocdobo;
        }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("bo xoa voi toc do {0:0.00}", tocdobo);
        }

        public override void cachBoi()
        {
            base.cachBoi();
            Console.WriteLine("boi nhu nguoi nhai");
        }

        public void cachBo()
        {
            Console.WriteLine("bo nhu con bo");
        }
    }
}
