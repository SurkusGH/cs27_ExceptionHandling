using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling
{
    public class Solution_01
    {
        //Patikrinkite System.Convert.ToDouble dokumentaciją, kokios klaidos gali įvykti konvertuojant string į double?
        //Parašykite programą, kuri pagaus tas klaidas ir atspausdins į konsolę kokia klaida tai buvo.
        public void StringToDouble(string numberInStringType)
        {
            double numberInDoubleType = 0;
            //double.TryParse(numberInStringType, out double numberInDoubleType); // Čia klaidą galima apsirašyti irgi
            try
            {
                numberInDoubleType = Convert.ToDouble(numberInStringType);
            }
            catch (FormatException)
            {
                Console.WriteLine($"String input was not in a correct format"); ;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"String input outside of bounds of double format for conversion");
            }
            catch (InvalidCastException) // <-- bet čia ne ta klaida man atrodo
            {
                Console.WriteLine($"Character conversion is not supported");
            }
            finally
            {
                Console.WriteLine("'try/catch' kodas suveikė");
                Console.WriteLine($"{numberInStringType} tipo {numberInStringType.GetType().Name}, konvertuojamas į {numberInDoubleType} tipo {numberInDoubleType.GetType().Name} ");
            }
        }
            
    }
}
