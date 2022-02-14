using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling
{
    internal class TemperatureIsZeroException : Exception
    {
        public TemperatureIsZeroException(string message) : base(message) { }
    }
}
