using System;

namespace Ficha_heranacas
{
    class main
    {
        static void Main(string[] args)
        {
            int n = 4;
            circulo[] c = new circulo[n];
            float x = 0; float y = 0;
            double R = 0.5;

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = new circulo(x, y, R);
                c[i].CoodCentro();
                c[i].Area();
            }
        }
    }
}