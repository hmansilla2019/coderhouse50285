using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Administrativo : Empleado
    {
        public Administrativo(string legajo, long dni, string nombre, string domicilioParticular) 
            : base(legajo, dni, nombre, domicilioParticular)
        {
        }
    }
}
