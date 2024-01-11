using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Estudiante : Persona
    {
        protected string carrera;
        public Estudiante(string carrera, long dni, string nombre, string domicilioParticular)
            : base(dni, nombre, domicilioParticular)
        {
            this.carrera = carrera;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("CARRERA:" + this.carrera);
        }

    }
}
