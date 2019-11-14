using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat_server
{
    public class Record_transazione
    {
        public long numero_carta { get; set; }
        public DateTime data_prelievo { get; set; }
        public long importo_prelievo { get; set; }
        public bool esito { get; set; }
        

        public Record_transazione()
        {

        }

        public Record_transazione(long a,DateTime b, int c,bool d)
        {
            numero_carta = a;
            data_prelievo = b.Date;
            importo_prelievo = c;
            esito = d;
        }
    }
}
