using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMo1
{
    public abstract class Ca : IBoi
    {
        string tenca;
        string mausac;
        double cannang;
        bool covay;
        public Ca(string tenca, string mausac, double cannang, bool covay)
        {
            this.tenca = tenca;
            this.mausac = mausac;
            this.cannang = cannang;
            this.covay = covay;
        }

        public virtual void cachBoi()
        {
            Console.WriteLine("ca la phai biet boi");
        }

        public virtual void inThongTin()
        {
            Console.WriteLine("Ten ca: {0}", tenca);
            Console.WriteLine("mau sac: {0}",mausac );
            Console.WriteLine("Can nang: {0}",cannang );
            Console.WriteLine("la ca: {0}", 
                covay?"co vay":"da tron");
        }
    }
}
