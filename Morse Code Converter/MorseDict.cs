using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Converter
{
    class MorseDict
    {
        // Create Dictionary

        public Dictionary<char, string> lookupDictionary = new Dictionary<char, string>();

        string fileName = "morse.csv";

        public MorseDict()
        {
            using (var sr = new StreamReader(fileName))
            {
                while (sr.Peek() > 0)
                {
                    var line = sr.ReadLine().Split(',');
                    var toLetter = Convert.ToChar(line[0]);
                    var toMorse = line[1];
                    lookupDictionary.Add(toLetter, toMorse);
                    Console.WriteLine(line);
                }

            }


        }

        public string GetMorseCode(char letter )
        {
            Console.WriteLine($"getting morse code for {letter}"); // obtaining key for dictionary
            return string.Empty;
        }

    }
}
