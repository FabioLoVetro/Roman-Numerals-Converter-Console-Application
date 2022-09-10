using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Converter_Console_Application
{
    /// <summary>
    /// Class <c>RomanNumeralsConverter</c>
    /// manage the logic of the application.
    /// </summary>
    public class RomanNumeralsConverterConsoleApplication
    {
        private string romanNumerals = "";
        private int numero;

        /// <summary>
        /// Method <c>Start</c>
        /// start the application.
        /// contains the logic of the application
        /// </summary>
        public void Start()
        {
            //print to video a message
            Console.WriteLine("Insert the roman numeral to convert");
            //convert the roman numeral
            Converter converter = new Converter();
            numero = converter.transform_roman_numeral_to_number(romanNumerals);
            //clear the video
            Console.Clear();
            //print to video a message with the result
            if (numero == -1)
            {
                Console.WriteLine("This is not a roman numeral [" + romanNumerals + "]");
            }
            else
            {
                Console.WriteLine("The roman numerals " + romanNumerals + " is equal to " + numero);
            }
        }
    }
}
