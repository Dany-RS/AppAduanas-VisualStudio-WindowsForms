using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GeneraMatriculas
    {
        public int min;
        public int max;
        //public char charMin;
        //public char charMax;
        public bool lowerCase;
        public int size;
        private readonly Random numeros = new Random();

        public GeneraMatriculas(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public GeneraMatriculas(int size, bool lowerCase = false)
        {
            this.size = size;
            this.lowerCase = lowerCase;
            //this.charMin = charMin;
            //this.charMax = charMax;
        }

        public string RandomNumeros()
        {
            //return numeros.Next(min, max);
            string valor = "";
            /*for (int i=0; i < valor.Length; i++)
            {
                int num = numeros.Next(min, max);
                valor = num.ToString();
            }*/

            do {int num = numeros.Next(min, max); valor = num.ToString(); }while (valor.Length < 4) ;
            return valor;

        }

        public string RandomLetras()
        {
            char offset;
            var constructor = new StringBuilder(size);
            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):   
            // The first group containing the uppercase letters and
            // the second group containing the lowercase. 
            // char is a single Unicode character  
            offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)numeros.Next(offset, offset + lettersOffset);
                constructor.Append(@char);
            }

            return lowerCase ? constructor.ToString().ToLower() : constructor.ToString();
        }

        public string RandomLetters()
        {
            var list = new List<string> { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
            var constructor = new StringBuilder(size);

            for (var i = 0; i < size; i++)
            {
                var index = numeros.Next(list.Count);
                var @char = list[index];
                constructor.Append(@char);
            }

            return constructor.ToString();

        }


    }
}
