using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPosteBellizzi
{
    internal class Cliente
    {
        public string Codice { get; private set; }
        
        public string TipoContratto { get; set; }
        public int Peso { get; internal set; }

        public Cliente(string codice, string tipoContratto)
        {
            Codice = codice; 
            TipoContratto = tipoContratto;
        }
        public bool HaPriorita()
        {
            return TipoContratto == "Indeterminato";
        }
    }
}
