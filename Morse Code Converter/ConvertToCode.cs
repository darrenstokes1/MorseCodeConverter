using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Converter
{
    class ConvertToCode
    {
        // 
        public string Phrase { get; set; }
        public string Code { get; set; }

        public ConvertToCode()
        {
            this.Phrase = Phrase;
            this.Code = Code;
        }
        public string GetPhrase()
        {
            return Phrase;
        }
        //public string GetMorseCode(char letter)
        //{
        //    var morse = lookupDictionary[letter];

        //    Console.WriteLine($"You entered the letter {letter} which converts to {morse} in morse code"); // obtaining key for dictionary and returning code
        //    return string.Empty;
        //}
    }

   
}
