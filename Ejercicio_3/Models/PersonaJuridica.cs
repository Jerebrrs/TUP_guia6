using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class PersonaJuridica : Persona
    {
        private string cuit;
        public PersonaJuridica(string nombre, string cuit):base(nombre)
        {
            this.cuit = cuit;
        }

        public override string Describir()
        {
            return $"{base.Describir()}Cuit: {cuit}"; 
        }
    }
}
