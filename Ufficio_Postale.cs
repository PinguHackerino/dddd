using System.Collections.Generic;

namespace ProgettoPosteBellizzi
{
    internal class Ufficio_Postale
    {
        public Sportello_Pacchi Pacchi { get; set; }
        public Sportello_Ordinario Ordinario { get; set; }
        public Sportello_Pagamento Pagamento { get; set; }
        public Sportello_Prestiti Prestiti { get; set; }
        public List<Lavoratore> Lavoratori { get; set; }

        public void AggiungiCliente(Cliente cliente, string tipoServizio)
        {
            switch (tipoServizio.ToLower())
            {
                case "ordinario":
                    Ordinario.AggiungiCliente(cliente); break;
                case "pagamento":
                    Pagamento.AggiungiCliente(cliente); break;
                case "pacchi":
                    Pacchi.AggiungiCliente(cliente); break;
                case "prestiti":
                    Prestiti.AggiungiCliente(cliente); break;
                default: break;
            }
        }

        public void ServiCliente(string tipoServizio, Lavoratore lavoratore)
        {
            switch (tipoServizio.ToLower())
            {
                case "Ordinario":
                    lavoratore.ServiProssimo(Ordinario); break;
                case "Pagamento":
                    lavoratore.ServiProssimo(Pagamento); break;
                case "Pacchi":
                    lavoratore.ServiProssimo(Pacchi); break;
                case "Prestiti":
                    lavoratore.ServiProssimo(Prestiti); break;
                default: break;
            }
        }

        public void InterventoPostino(Postino postino)
        {
            postino.SvuotaPila(Pacchi);
        }
    }

}
