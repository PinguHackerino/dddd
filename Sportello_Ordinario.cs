using System;
using System.Collections.Generic;

namespace ProgettoPosteBellizzi
{
    internal class Sportello_Ordinario : Servizio
    {
        public Queue<Cliente> Clienti { get; set; }
        public static List<Cliente> Temp { get; set; }
        public static Queue<Cliente> CodaO {  get; set; }
        public Sportello_Ordinario(string nome) : base(nome)
        {
            Clienti = new Queue<Cliente>();
        }

        public override void AggiungiCliente(Cliente cliente)
        {
            Clienti.Enqueue(cliente);
        }

        public override Cliente RimuoviCliente()
        {
            return Clienti.Dequeue();
        }

        public override Cliente VisualizzaProssimo()
        {
            if (Clienti.Count > 0)
                return Clienti.Peek();
            else
                return null;
        }

        public override void MostraCoda()
        {
            foreach (Cliente cliente in Clienti)
                Console.WriteLine(cliente.ToString());
        }
    }
}
