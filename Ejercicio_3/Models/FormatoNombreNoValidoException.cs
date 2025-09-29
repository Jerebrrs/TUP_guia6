using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class FormatoNombreNoValidoException : ApplicationException
    {
        public FormatoNombreNoValidoException() : base("El nombre ingresado no cumple con el formato 'Apellido, Nombre.") { }
        public FormatoNombreNoValidoException(string message) { }
        public FormatoNombreNoValidoException(string message,Exception inner ) { }
    }
}
