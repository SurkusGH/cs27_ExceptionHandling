using cs27_paskaita_ExceptionHandling.Solutions;
using System;

namespace cs27_paskaita_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs27_PASKAITA_ExceptionHandling!");

            #region TEORIJA TRY/CATCH/FINALLY

            // Try - kodo blokas kuriame tikimasi gauti tam tikrą klaidą
            // Catch - koto blokas, kuris paleidžiamas pagavus klaid1
            // Finally - Kodo blokas, kuris leidžiamas pabaighoje try/catch nesvarbu ar klaida buvo pagauta ar ne.

            // Tam tikrai prasme tai yra klaidų ignoravimas

            //try
            //{
            //    string s = null;
            //    s.ToString();
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message); // <-- jeigu šitos eilutės nebūtų, tai būtų vadinama error swallowing
            //}
            //catch (Exception e2) // <-- pagauna visas klaidas
            //{ 
            
            //}

            // Exceptions klasės paveldi iš klasės systemException klasės.
            // System.Exception yra tėvinė visų exception'ų klasė.

            // what is stack overflow?

            var temperature = new Temperature();
            temperature.temperature = 0;

            try
            {
                temperature.ShowTemp();
            }
            catch (TemperatureIsZeroException e)
            {

                Console.WriteLine($"TemperatureIsZeroException: {e.Message}");
            }
            #endregion

            Solution_01("100.99");
            Console.WriteLine();
            Solution_01("100.99a");
            Console.WriteLine();
            Solution_01("1.29e325999999");
            Console.WriteLine();
            Solution_01("a");
            Console.WriteLine();

            Solution_02(7);

            Solution_03();

            Solution_04();





        }

        public static void Solution_01(string numberInStringType)
        {
            Console.WriteLine("Solution_01_Instance!");
            var solution_01 = new Solution_01();
            solution_01.StringToDouble(numberInStringType);
        }

        public static void Solution_02(int index)
        {
            Console.WriteLine("Solution_02!");
            var solution_02 = new Solution_02();
            solution_02.Array(index);
        }

        public static void Solution_03()
        {
            Console.WriteLine("Solution_03!");
            var solution_03 = new Solution_03();
            solution_03.ArrayAndCalculations();
        }

        public static void Solution_04()
        {
            Console.WriteLine("Solution_04!");
            var solution_04 = new Solution_04(new System.Collections.Generic.List<int>());
            solution_04.ReadData();
            solution_04.PrintTheList();
        }
    }
}
