using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220324
{
    internal class Program
    {
        static void Main()
        {
            //Feladat00();
            //Feladat01();
            //Feladat03();
            Feladat04();
            Console.ReadKey();
        }
        static void Feladat04()
        {
            Console.Write("írd be az euro árfolyamát: ");
            float arfolyam = float.Parse(Console.ReadLine());
            Console.Write("ennyi eurot szeretnénk átváltani: ");
            int euro = int.Parse(Console.ReadLine());

            Console.WriteLine($"ennyi forintot ér: {arfolyam * euro}");

            Console.WriteLine();
        }
        static void Feladat03()
        {
            Console.Write("írd be a havi fizetésed: ");
            int haviFizetes = int.Parse(Console.ReadLine());
            Console.WriteLine($"éves fizet: {haviFizetes * 12} Ft");
        }
        static void Feladat00()
        {
            Console.Write("Írd be a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}! Sok sikeret a C#-hoz!");
        }
        static void Feladat01()
        {
            Console.Write("Írbe be az irányítószámod: ");
            string iranyitoSzam = Console.ReadLine();
            Console.Write("Írbe be a teleülés nevét: ");
            string telepules = Console.ReadLine();
            Console.Write("Írbe be aközterület nevét: ");
            string kozteruletNeve = Console.ReadLine();
            Console.Write("Írbe be a közterület jellegét: ");
            string kozteruletJellege = Console.ReadLine();
            Console.Write("Írbe be aházszámot: ");
            string hazszam = Console.ReadLine();

            Console.Clear();
            
            // v1:
            Console.WriteLine(iranyitoSzam + ' ' + telepules + ' ' + kozteruletNeve + ' ' + kozteruletJellege + ' ' + hazszam + '.');
            Console.WriteLine(
                "{0} {1} {2} {3} {4}.", 
                iranyitoSzam,
                telepules,
                kozteruletNeve,
                kozteruletJellege,
                hazszam);
            Console.WriteLine($"{iranyitoSzam} {telepules} {kozteruletNeve} {kozteruletJellege} {hazszam}.");
        }
    }
}
