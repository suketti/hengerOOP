using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cso : Henger
    {
        double falVastagsag;

        public Cso(double magassag, double sugar, double falVastagsag) : base(magassag, sugar)
        {
            this.falVastagsag = falVastagsag;
        }
        public Cso(double magassag, double sugar) : base(magassag, sugar)
        {
            this.falVastagsag = 1;
        }

        public  override double Terfogat()
        {
            double t1 = Math.Round(Math.PI * base.Sugar * base.Sugar * base.Magassag, 2);
            double t2 = Math.Round(Math.PI * Math.Pow(base.Sugar - this.falVastagsag, 2) * base.Magassag, 2);
            return Math.Round(t1 - t2, 2);
        }

        public override string ToString()
        {
            return $"Jellemzok >> terfogat: {this.Terfogat()}; sugar: {base.Sugar}; magassag: {this.Magassag}; falvastagsag: {this.falVastagsag};";
        }
    }
}
