using System;
using System.Collections.Generic;

namespace ProgettoPosteBellizzi
{
    internal class Postino
    {
        public void SvuotaPila(Sportello_Pacchi sportello)
        {
            Stack<Cliente> leggeri = new Stack<Cliente>();

            while (sportello.Clienti.Count > 0)
            {
                Cliente cliente = sportello.Clienti.Pop();
                if (cliente.Peso < 3)
                    Console.WriteLine($"{cliente.Codice} consegnato (peso: {cliente.Peso}kg)");
                else
                    leggeri.Push(cliente);
            }
            sportello.Clienti = leggeri;
        }
    }

}
