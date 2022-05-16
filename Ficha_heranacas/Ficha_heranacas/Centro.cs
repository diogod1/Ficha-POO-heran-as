using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_heranacas
{
    internal class Centro
    {
        private float x, y;
        
        public Centro()
        {
            x = 0;
            y = 0;
        }
        public Centro(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void CoodCentro()
        {
            Console.WriteLine("As cordenadas do centro são: x={0} , y={1}",x,y);
        }
    }
}
