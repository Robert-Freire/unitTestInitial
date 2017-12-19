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
            horasUnicorno = horasUnicorno < 0 ? 0 : horasUnicorno;
            horasDonutella = horasDonutella < 0 ? 0 : horasDonutella;
            return horasUnicorno * 3 + horasDonutella * 1;
        }
    }
}
