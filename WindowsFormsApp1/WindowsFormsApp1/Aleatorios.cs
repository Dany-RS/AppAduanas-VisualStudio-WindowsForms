using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aleatorios
    {
        public int min;
        public int max;
        private readonly Random _random = new Random();
        public void CreaAleatorio(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public int RandomNumerico()
        {
            return _random.Next(min, max);
        }
    }
}
