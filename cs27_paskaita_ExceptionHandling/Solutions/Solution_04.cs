using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_paskaita_ExceptionHandling.Solutions
{
    public class Solution_04
    {
        // Sukurti failo perskaitymo klasę
        // Kokios klaidos gali kilti bandant skaityti failą?
        // Bandant surasti failą?
        // Sukurkite mechanizmus apsisaugoti nuo programos "nulūžimo"
        public List<int> FileDataInAList { get; set; }

        public Solution_04(List<int> fileDataInAList)
        {
            FileDataInAList = fileDataInAList;
        }

        public List<int> ReadData()
        {
            string path = $@"D:\GitHub\cs27_paskaita_ExceptionHandling\cs27_paskaita_ExceptionHandling\Rinkmena.csv";
            var CSVLineReader = new StreamReader(path);

            while (!CSVLineReader.EndOfStream)
            {
                var line = CSVLineReader.ReadLine();
                TryCatch_ForAddToList(line);
            }
            return FileDataInAList;
        }
        public void PrintTheList()
        {
            foreach (var item in FileDataInAList)
            {
                Console.WriteLine(item);
            }
        }
    
        public void TryCatch_ForAddToList(string line)
        {
            try
            {
                FileDataInAList.Add(Convert.ToInt32(line));
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string was not in a correct format.");
                //System.FormatException: 'Input string was not in a correct format.'
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value was either too large or too small for an Int32.");
                //System.OverflowException: 'Value was either too large or too small for an Int32.'
            }
        }
    }
}
