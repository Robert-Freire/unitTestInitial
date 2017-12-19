using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    public class BeersHour
    {
        private readonly Random rnd = new Random();
        public int BeersUnicorn()
        {
            
            return rnd.Next(0, 4);
        }

        public int BeersDonatella()
        {
            return rnd.Next(0, 4);
        }
    }
}
