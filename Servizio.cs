
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPosteBellizzi
{
    internal abstract class Servizio
    {
            public string Nome { get; set; }
            public List<Lavoratore> Operatori { get; set; }

            public Servizio(string nome)
            {
                Nome = nome;
                Operatori = new List<Lavoratore>();
            }

            public abstract void AggiungiCliente(Cliente cliente);

            public abstract Cliente RimuoviCliente();

            public abstract Cliente VisualizzaProssimo();

            public abstract void MostraCoda();
        
    }
}
