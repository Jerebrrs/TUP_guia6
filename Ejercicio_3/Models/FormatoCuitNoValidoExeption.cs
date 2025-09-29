using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class FormatoCuitNoValidoExeption : ApplicationException
    {
        public FormatoCuitNoValidoExeption() : base("El Cuit debe tener 11 digitos numericos."){}

        public FormatoCuitNoValidoExeption(string message) { }
       

        public FormatoCuitNoValidoExeption(string message, Exception inner) { }
    }
}
