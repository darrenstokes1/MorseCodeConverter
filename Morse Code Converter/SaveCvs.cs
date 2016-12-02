using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Converter
{
    class SaveCvs : MorseDict
    {
        public SaveCvs()
        {
            var saveFile = "saveCvs.csv";
            var line = string.Empty;
           

            using ( var sw = File.AppendText(line) )
            {
                    
            }



        }




    }
            
               

    
}
