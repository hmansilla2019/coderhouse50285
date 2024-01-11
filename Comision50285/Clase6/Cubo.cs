using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Cubo : I2DmedidasCalculable, I3DmedidaCalculable
    {
        double lado;
        public Cubo(double lado)
        {
            this.lado = lado;
        }

        public double Area()
        {
            return 6*Math.Pow(lado,2);
        }

        public double Perimetro()
        {
            return 12 * lado;
        }

        public double Volumen()
        {
            return Math.Pow(lado, 3);
        }
    }
}
