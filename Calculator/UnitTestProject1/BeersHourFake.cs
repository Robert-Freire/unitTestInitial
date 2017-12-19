using Calculator5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class BeersHourFake : IBeersHour
    {
        public int BeersDonatella()
        {
            return 1;
        }

        public int BeersUnicorn()
        {
            return 3;
        }
    }
}
