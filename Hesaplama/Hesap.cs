using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class Hesap
    {
      public decimal Toplama(decimal sayi1,decimal sayi2)
        {
            return (sayi1 + sayi2);
        }

        public decimal Cikarma(decimal sayi1, decimal sayi2)
        {
            return (sayi1 - sayi2);
        }

        public decimal Carpma(decimal sayi1, decimal sayi2)
        {
            return (sayi1 * sayi2);
        }

        public decimal Bolme(decimal sayi1, decimal sayi2)
        {
            return (sayi1 / sayi2);
        }

        public double Karekok(double sayi)
        {
            return Math.Sqrt(sayi);
        }

        public MethodInfo[] GetMethodInfo()
        {
            MethodInfo[] methods = typeof(Hesap).GetMethods();
            return methods;
        }
    }
    
}
