using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Obtain input from user
            Console.WriteLine("This program will convert your sentence to morse code and display it back to you.");
            Console.WriteLine();
            Console.WriteLine("Please enter one sentence.");
            var userInput = Console.ReadLine().ToUpper().Replace(" ", "");
            
            var morseCode = new MorseDict();

            foreach (var letter in userInput)
            {
                morseCode.GetMorseCode(letter); // Obtaining my key
                

            }
            Console.ReadLine();
        }
    }

}





