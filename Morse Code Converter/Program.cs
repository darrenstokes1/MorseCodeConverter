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
        public static void ConvertCode()
        {
            // Obtain input from user
            Console.WriteLine("This program will convert your phrase into to morse code and display it back to you.");
            Console.WriteLine();
            Console.WriteLine("Please enter a phrase to convert and press enter");
            var userInput = Console.ReadLine().ToUpper().Replace(" ", ""); 


            var morseCode = new MorseDict();

            foreach (var letter in userInput)
            {
                morseCode.GetMorseCode(letter); // Obtaining my key
                // Convert to value here
                Console.WriteLine();


            }
        }

        static void Main(string[] args)


        {
            // Determine if user wants to continue
            var userStillPlays = true;
            while (userStillPlays)
            {
                ConvertCode();

                Console.WriteLine();
                Console.WriteLine("Would you like to continue? Y or N ");// .ToLower() needs an overide for void?

                var reply = Console.ReadLine();
                if (reply == "n" || reply == "N")
                {
                    Console.WriteLine("Thank you for playing!");
                    userStillPlays = false;
                }

            }

            Console.ReadLine();
        }
    }

}





