using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling.Solutions
{
    public class Solution_03
    {
        // Numatyti galimas kodo klaidas ir išspausdinkite įvykusias klaidas su try catch
        public void ArrayAndCalculations()
        {
            int[] arr = { 19, 0, 75, 52 };
            //try to generate an exception
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                    // (!) System.DivideByZeroException: 'Attempted to divide by zero.'
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("(!) Attempted to divide by zero");
                    // (!) System.DivideByZeroException: 'Attempted to divide by zero.'
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("(!) Index was outside the bounds");
                    //System.IndexOutOfRangeException: 'Index was outside the bounds'
                }
            }
        }
    }
}
