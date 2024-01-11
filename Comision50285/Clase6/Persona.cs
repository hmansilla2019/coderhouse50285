using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;

        public Persona()
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.domicilioParticular = String.Empty;
        }

        public Persona(long dni, string nombre, string domicilioParticular)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilioParticular;
        }

        // lo puedo sobreescribir en una clase derivada
        public virtual void MostrarDatos()
        {
            Console.WriteLine("DNI:" + this.dni);
            Console.WriteLine("NOMBRE:" + this.nombre);
            Console.WriteLine("DOMICILIO PARTICULAR:" + this.domicilioParticular);
        }

        public static string TelefonoEmergencia()
        {
            return "101, 103";
        }

    }
}
