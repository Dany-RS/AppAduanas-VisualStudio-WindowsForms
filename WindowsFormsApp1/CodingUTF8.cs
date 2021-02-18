using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CodingUTF8
    {
        public string Mystring;

        public CodingUTF8(string Mystring)
        {
            this.Mystring = Mystring;
        }

        public string TransformaUTF8()
        {
            UTF8Encoding utf8 = new UTF8Encoding(true, true);

            //String s = "It was the best of times, it was the worst of times...";

            // We need to dimension the array, since we'll populate it with 2 method calls.
            Byte[] bytes = new Byte[utf8.GetByteCount(Mystring) + utf8.GetPreamble().Length];
            // Encode the string.
            Array.Copy(utf8.GetPreamble(), bytes, utf8.GetPreamble().Length);
            utf8.GetBytes(Mystring, 0, Mystring.Length, bytes, utf8.GetPreamble().Length);

            // Decode the byte array.
            String salida = utf8.GetString(bytes, 0, bytes.Length);
            return salida;
        }
    }
}
