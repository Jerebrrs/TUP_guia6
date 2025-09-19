using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class FormatoCuitNoValidoExeption : ApplicationException
    {
        public FormatoCuitNoValidoExeption()
        {
            
        }

        public FormatoCuitNoValidoExeption(string message)
        {
            
        }

        public FormatoCuitNoValidoExeption(string message, Exception inner)
        {
            
        }
    }
}
