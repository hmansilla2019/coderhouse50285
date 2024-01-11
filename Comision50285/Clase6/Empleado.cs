using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Empleado : Persona
    {
        protected string legajo;

        public Empleado(string legajo, long dni , string nombre,string domicilioParticular) 
            : base(dni,nombre, domicilioParticular)
        {
            this.legajo = legajo;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("LEGAJO:" + this.legajo);
        }

    }
}
