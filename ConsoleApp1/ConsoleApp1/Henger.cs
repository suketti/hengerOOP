using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Henger
    {
        double magassag, sugar;
        public static int szuletesSzamlalo = 0 ;

        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }


        public double Magassag { get => magassag; }
        public double Sugar { get => sugar; }
        public static double SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Round(sugar * sugar * Math.PI * magassag, 2);
        }

        public override string ToString()
        {
            return $"Jellemzok >> terfogat:{Terfogat()}; sugar:{sugar}; magassag:{magassag}";

        }
    }
}
