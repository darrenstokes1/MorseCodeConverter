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

        string fileName = "morse.csv"; // Access csv

        public MorseDict()
        {
            using (var sr = new StreamReader(fileName))
            {
                while (sr.Peek() > 0)
                {
                    var line = sr.ReadLine().Split(',');
                    var toLetter = Convert.ToChar(line[0]); // this is dictionary key
                    var toMorse = line[1]; // this value is returned to user 
                    lookupDictionary.Add(toLetter, toMorse); // Building dictionary
                    
                }

            }



        }
        

        public string GetMorseCode(char letter)
        {
            var morse = lookupDictionary[letter]; // Gavin 
            

            Console.Write($"Your phrase was {letter} which conerts to {morse} in code"); // obtaining key for dictionary and returning code
            return string.Empty;

        }

    }
}
