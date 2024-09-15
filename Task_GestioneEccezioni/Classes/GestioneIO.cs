using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_GestioneEccezioni.Classes
{
    internal class GestioneIO
    {
        public string[]? fileTxt { get; set; }

        //costruttore di default

        //methods

        public void InserimentoFile(string? path)
        {
            try
            {
                fileTxt = File.ReadAllLines(path);
                Console.WriteLine("File caricato");
                Console.WriteLine("---------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LetturaFile()
        {
            try
            {
                if (fileTxt?.Length != 0)
                {
                    for (int i = 0; i < fileTxt?.Length; i++)
                    {
                        Console.WriteLine(fileTxt[i]);
                    }
                }
                else
                {
                    Console.WriteLine("ERRORE: il file è vuoto");
                    Console.WriteLine("--------------------");
                }
                Console.WriteLine("---------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SommaNumeri()
        {
            double ris = 0;
            try
            {
                for (int i = 0; i < fileTxt?.Length; i++)
                {
                    ris = ris + Convert.ToDouble(fileTxt[i]);
                }
                Console.WriteLine($"Risultato: {ris}");
                Console.WriteLine("------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

