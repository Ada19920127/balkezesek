using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class Program
    {
        static List<jatekosok>jatekos = new List<jatekosok>();
        static void Main(string[] args)
        {
            System.IO.File.ReadAllLines("balkezesek.csv").Skip(1).ToList().ForEach(item => jatekos.Add(new jatekosok(item)));

            Console.WriteLine($"3. feladat: Adatsorok száma: {jatekos.Count} db");
            Console.WriteLine( "4. feladat: 1999 októberében utoljára pályára lépett játékosok:");
            jatekos.Where(x => x.utolso.ToString("yyyy-MM").Contains("1999-10")).ToList().ForEach(x => Console.WriteLine($"\t{x.nev} {Math.Round(x.magassag * 2.54, 1)} cm"));
        
            bool helyesSzam = false;
            int evszam = 0;
            Console.WriteLine("5. feladat:");
            Console.Write("Kérek egy év számot 1990 és 1999 között: ");
            while(helyesSzam == false)
                {
                    evszam = Convert.ToInt32(Console.ReadLine());
                    if (evszam >= 1990 && evszam <= 1999)
                    {
                        helyesSzam = true;
                        Console.WriteLine("Köszönöm");
                    }
                    else
                    {
                        Console.WriteLine("Hibás adat, kérek egy 1990 és 1999 közötti évszámot!");
                    }
                }
            Console.WriteLine("6. feladat:");
            double osszSuly = 0;
            double db = 0;
            for (int i = 0; i < jatekos.Count; i++)
            {
                if (evszam >= jatekos[i].elso.Year && evszam <= jatekos[i].utolso.Year)
                {
                    osszSuly += jatekos[i].suly;
                    db++;
                }
            }
            double atlag = osszSuly / db;
            Console.WriteLine($"Az adott évben a játékosok átlag súlya:{Math.Round(atlag, 2)} font ");


            Console.ReadKey();
        }
    }
}
