using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling
{
    internal class Temperature
    {
        public int temperature { get; set; }

        public void ShowTemp()
        {
            try
            {
                TemperatureIsZeroException e;
            }
            catch (TemperatureIsZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
