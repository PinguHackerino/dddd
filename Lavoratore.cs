using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPosteBellizzi
{
    internal class Lavoratore
    {
        public string Mansione { get; set; }
        private List<Cliente> Lavorati { get; set; }

        public Lavoratore( string mansione)
        {
            Mansione = mansione;
            Lavorati = new List<Cliente>();
        }

        public void ServiProssimo(Servizio servizio)
        {
            Lavorati.Add(servizio.RimuoviCliente());
        }

        public List<Cliente> MostraLavorati()
        {
            return Lavorati;
        }
    }
}
