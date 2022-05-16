using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_heranacas
{
    internal class circulo : Centro
    {
        private double raio;

        public circulo(double x, double y,double R)
        {
            raio = R;
        }

        public void Area()
        {
            Console.WriteLine("A area é {0}", Math.PI * Math.Pow(raio,2));
        }
    }
}
