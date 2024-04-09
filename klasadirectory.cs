using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unos putanje mape
            Console.WriteLine("Unesi putanju mape: ");
            string putanja = Console.ReadLine();
            // provjera da li mapa postoji
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Mapa postoji! ");
                // ako postoji ispisuje sve datoteke u mapi
                Console.WriteLine("Ispis podataka:");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
                string putanjaPodmape = putanja + "\\bla";

                // provjera da li podmapa postoji, ako ne postoji, kreiramo je
                if (!Directory.Exists(putanjaPodmape))
                {
                    Directory.CreateDirectory(putanjaPodmape);
                    Console.WriteLine("Mapa " + putanjaPodmape + " je napravljena.");
                }
                // ispis podmapa
                Console.WriteLine("Ispis podmapa:");
                foreach(string podmapa in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(podmapa);
                }
                // brisanje podmape
                Directory.Delete(putanjaPodmape);
                Console.WriteLine("Ispis podmapa nakon brisanja:");
                foreach (string podmapa in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(podmapa);
                }
            }
            // ako ne postoji, kreiramo mapu
            else
            {
                Directory.CreateDirectory(putanja);
                Console.WriteLine("Mapa " + putanja + " je napravljena!");
            }
            Console.ReadKey();
        }
    }
}
