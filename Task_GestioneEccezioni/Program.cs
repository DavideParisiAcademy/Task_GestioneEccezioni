using Task_GestioneEccezioni.Classes;

namespace Task_GestioneEccezioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIONE FILE DI TESTO");

            bool ciclo = true;
            GestioneIO gs = new GestioneIO();

            while (ciclo)
            {
                
                string? path;
                Console.WriteLine("Inserisci un comando\n1-Carica file\n2-Leggi file\n3-Somma numeri\n4- Esci");
                string? inputUtente = Console.ReadLine();
                

                switch (inputUtente)
                {
                    case "1":
                        Console.WriteLine("Inserisci il path del file da caricare");
                        path = Console.ReadLine();
                        gs.InserimentoFile(path);
                        break;
                    case "2":
                        Console.WriteLine("[Contenuto del file]:");
                        gs.LetturaFile();
                        break;
                    case "3":
                        gs.SommaNumeri();
                        break;
                    case "4":
                        ciclo = false;
                        break;
                    default: Console.WriteLine("ERRORE DI INSERIMENTO");
                        break;
                }
            }            
        }
    }
}
