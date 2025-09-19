using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class Persona : IComparable<Persona>
    {
        protected string nombre;
        public string Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public virtual string Describir()
        {
            return $"Nombre: {nombre}";
        }
        public int CompareTo(Persona other)
        {
            if (other != null)
            {
                this.nombre.CompareTo(other.nombre);
            }
            return -1;
        }
    }
}
