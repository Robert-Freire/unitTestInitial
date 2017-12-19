using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator5
{
    public class TokidokiFacturator
    {
        private readonly IBeersHour _beersHour;


        public TokidokiFacturator(IBeersHour beersHour)
        {
            this._beersHour = beersHour;
        }
        public int calcular(int horasUnicorno, int horasDonutella)
        {

            horasUnicorno = horasUnicorno < 0 ? 0 : horasUnicorno;
            horasDonutella = horasDonutella < 0 ? 0 : horasDonutella;

            var beersUnicorno = this._beersHour.BeersUnicorn();
            var beersDonatela = this._beersHour.BeersDonatella();

            return horasUnicorno * beersUnicorno + horasDonutella * beersDonatela;
        }
    }
}
