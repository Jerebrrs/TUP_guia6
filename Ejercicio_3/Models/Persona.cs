using System;
using System.Text.RegularExpressions;

namespace Ejercicio_3.Models
{
    public class Persona : IComparable<Persona>
    {
        protected string nombre;
        public string Nombre { 
            get { return nombre; }
            set {
                Match match = Regex.Match(value, @"^\s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
                if(match.Success == false)
                {
                    throw new FormatoNombreNoValidoException();
                }
                nombre = value; 
            }
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
