using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1.Core;
using Formula1.Persistence;

namespace Formula1.ImportConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Import der Rennen und Ergebnisse in die Datenbank");
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                dbContext.Database.Delete();
                Console.WriteLine("Daten werden von results.xml eingelesen");

                var results = ImportController.LoadResultsFromXmlIntoCollections().ToArray();
                if (results.Length == 0)
                {
                    Console.WriteLine("!!! Es wurden keine Rennergebnisse eingelesen");
                    return;
                }
                Console.WriteLine($"  Es wurden {results.Count()} Rennergebnisse eingelesen!");
                dbContext.Results.AddRange(results);
                Console.WriteLine("Ergebnisse werden in Datenbank gespeichert (persistiert)");
                dbContext.SaveChanges();
                Console.Write("Beenden mit Eingabetaste ...");
                Console.ReadLine();

            }
        }
    }
}
