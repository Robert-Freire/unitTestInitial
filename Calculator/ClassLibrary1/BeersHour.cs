using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator5
{
    public class BeersHour : IBeersHour
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
