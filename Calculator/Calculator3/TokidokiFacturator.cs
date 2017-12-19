using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    public class TokidokiFacturator
    {
        public int calcular(int horasUnicorno, int horasDonutella)
        {
            var beersHourCalculator = new BeersHour();

            horasUnicorno = horasUnicorno < 0 ? 0 : horasUnicorno;
            horasDonutella = horasDonutella < 0 ? 0 : horasDonutella;

            var beersUnicorno = beersHourCalculator.BeersUnicorn();
            var beersDonatela  = beersHourCalculator.BeersDonatella();

            return horasUnicorno * beersUnicorno + horasDonutella * beersDonatela;
        }
    }
}
