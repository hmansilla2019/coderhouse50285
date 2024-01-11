using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Rectangulo : I2DmedidasCalculable
    {
        double base_r, altura_r;

        public Rectangulo(double base_r, double altura_r)
        {
            this.base_r = base_r;
            this.altura_r = altura_r;
        }

        public double Area()
        {
            return this.base_r * this.altura_r;
        }

        public double Perimetro()
        {
            return 2 * this.base_r + 2 * this.altura_r;
        }
    }
}
