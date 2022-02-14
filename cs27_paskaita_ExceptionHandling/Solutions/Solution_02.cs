using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling
{
    public class Solution_02
    {
        // Sutvarkyti kodą su try/catch mechanizmu
        public void Array(int index)
        {
            // Declare ana array of max index 4;
            int[] arr = { 1, 2, 3, 4, 5 };

            //Display values of array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Try to access invalid index of array
            try
            {
                Console.WriteLine(arr[index]);
                // An exception is thrownn upon executing
                // the above line
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array");
                //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            }
        }
    }
}
