using System;
using System.Collections.Generic;

namespace ProgettoPosteBellizzi
{
    internal class Sportello_Prestiti : Servizio
    {
        public Queue<Cliente> Indeterminati { get; set; }
        public Queue<Cliente> Determinati { get; set; }

        public Sportello_Prestiti(string nome) : base(nome)
        {
            Indeterminati = new Queue<Cliente>();
            Determinati = new Queue<Cliente>();
        }

        public override void AggiungiCliente(Cliente cliente)
        {
            if (cliente.HaPriorita())
                Indeterminati.Enqueue(cliente);
            else
                Determinati.Enqueue(cliente);
        }

        public override Cliente RimuoviCliente()
        {
            if (Indeterminati.Count > 0)
                return Indeterminati.Dequeue();
            else 
                return Determinati.Dequeue();
        }

        public override Cliente VisualizzaProssimo()
        {
            if (Indeterminati.Count > 0)
                return Indeterminati.Peek();
            else
                return Determinati.Peek();
        }

        public override void MostraCoda()
        {
            Console.WriteLine("--- Indeterminati ---");
            foreach (Cliente cliente in Indeterminati)
                Console.WriteLine(cliente.ToString());

            Console.WriteLine("--- Determinati ---");
            foreach (Cliente cliente in Determinati)
                Console.WriteLine(cliente.ToString());
        }
    }

}
