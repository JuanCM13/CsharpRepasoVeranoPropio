using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni , string nombre) : this(nombre)
        {
            this.Dni = dni;
        }

        internal string MostrarDatos()
        {
            StringBuilder auxS = new StringBuilder();

            auxS.Append($"Nombre: {this.Nombre}\nDNI: {this.Dni}");

            return auxS.ToString();
        }

    }
}
