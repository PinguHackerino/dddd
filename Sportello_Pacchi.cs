using System;
using System.Collections.Generic;

namespace ProgettoPosteBellizzi
{
    internal class Sportello_Pacchi : Servizio
    {
        public Stack<Cliente> Clienti { get; set; }

        public Sportello_Pacchi(string nome) : base(nome)
        {
            Clienti = new Stack<Cliente>();
        }

        public List<Cliente> GetPacchiPesanti()
        {
            List<Cliente> pesanti = new List<Cliente>();
            foreach (Cliente cliente in Clienti)
                if (cliente.Peso >= 3)
                    pesanti.Add(cliente);
            return pesanti;
        }

        public override void AggiungiCliente(Cliente cliente)
        {
            Clienti.Push(cliente);
        }

        public override Cliente RimuoviCliente()
        {
            return Clienti.Pop();
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
            foreach (Cliente c in Clienti)
                Console.WriteLine(c.ToString()); ;
        }
    }
}
