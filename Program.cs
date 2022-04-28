using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA220324
{
    internal class Tanulo
    {
        public string nev;
        public int[] magyarJegyek = new int[100];
        public int jegyekSzam = 0;
    }
    internal class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            //Feladat_1_00();
            //Feladat_1_01();
            //Feladat_1_03();
            //Feladat_1_04();
            //Feladat_1_05();
            //Feladat_1_06();
            //Feladat_1_07();
            //Feladat_1_08();
            //Feladat_1_13();

            //HF: 9, 10, 11, 12, 14, 15

            //Feladat_1_16();
            //Feladat_1_17();
            //Feladat_1_18();
            //Feladat_1_20();
            //Feladat_1_2x();
            //Feladat_1_26();

            //HF: 19, 21, 22, 23, 24, 25, 27, 28, 

            //Feladat_1_29();
            //Feladat_1_30();

            //Feladat_1_31();
            //Feladat_1_32();
            //Feladat_1_33();
            //Feladat_1_34();

            //HF: 35, 37, 38, 39, 40

            //Feladat_1_36();

            //--------------------

            //Feladat_2_01();
            //Feladat_2_02();
            //Feladat_2_03();
            //Feladat_bonusz();
            //Feladat_2_04();

            //HF: mind

            //Feladat_2_szinek();

            //Feladat_2_05();
            //Feladat_2_06();
            //Feladat_2_07();
            //Feladat_2_08();
            //Feladat_2_09();
            //Feladat_2_10();

            //Feladat_2_11();
            //Feladat_2_12();
            //Feladat_2_13();
            //Feladat_2_14();
            //HF: 15-20
            //Feladat_2_21();
            //Feladat_2_char();
            //Feladat_2_22();
            //Felada_2_22_b();
            //Feladat_2_23();

            //Feladat_2_24();
            //Feladat_2_25();
            //Feladat_2_26();
            //Feladat_2_27();
            //Feladat_2_28();

            //Feladat_2_32_a();
            //Feladat_2_32_b();
            //Feladat_2_33();

            //--------------------

            //Feladat_3_00_1();
            //Feladat_3_00_2();

            //Feladat_3_01();
            //Feladat_3_matrix();
            //Feladat_3_2();

            //HF: 3, 

            //Feladat_3_4_a();
            //Feladat_3_4_b();
            //Feladat_3_4_c();
            //Feladat_3_5();
            //Feladat_3_6();

            //OM: 7

            Feladat_lotto();

            //HF 8, 9, 10, 11, 12

            Console.ReadKey();
        }

        private static void Feladat_lotto()
        {
            int[] tippek = new int[5];

            Console.WriteLine("=== 5ös lottó emu ===");
            Console.WriteLine("add meg a tippjeidet!");
            for (int i = 0; i < tippek.Length; )
            {
                Console.Write($"{i + 1}. tipp: ");
                int tipp = int.Parse(Console.ReadLine());

                if (tipp < 1 || tipp > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("csak 1 és 90 közötti lehet a tipped!");
                    Console.ResetColor();
                }
                else if (tippek.Contains(tipp))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ez a szám már volt!");
                    Console.ResetColor();
                }
                else
                {
                    tippek[i] = tipp;
                    i++;
                }
            }

            int[] nyeroszamok = new int[5];
            for (int i = 0; i < nyeroszamok.Length; )
            {
                int nyeroszam = rnd.Next(1, 91);
                if (!nyeroszamok.Contains(nyeroszam))
                {
                    nyeroszamok[i] = nyeroszam;
                    i++;
                }
            }

            Array.Sort(tippek);
            Console.Write("tippjeid: ");
            for (int i = 0; i < tippek.Length; i++)
                Console.Write($"{tippek[i]} ");
            Console.Write('\n');

            Array.Sort(nyeroszamok);
            Console.Write("nyerőszámok: ");
            for (int i = 0; i < nyeroszamok.Length; i++)
                Console.Write($"{nyeroszamok[i]} ");
            Console.Write('\n');

            int talalatokSzama = 0;
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroszamok.Contains(tippek[i]))
                    talalatokSzama++;
            }
            Console.WriteLine($"Összesen {talalatokSzama} találatod volt!");
            if (talalatokSzama > 0)
                Console.WriteLine("grat!");
            else Console.WriteLine(":(");
        }

        private static void Feladat_3_6()
        {
            int[] t = new int[50];
            int lefutas = 0;
            for (int i = 0; i < t.Length; )
            {
                int szam = rnd.Next(10, 100);
                if (!t.Contains(szam))
                {
                    t[i] = szam;
                    Console.Write($"{t[i]} ");
                    if ((i + 1) % 10 == 0) Console.Write('\n');
                    i++;
                }
                lefutas++;
            }
            Console.WriteLine($"\nlefutások száma: x{lefutas}");
        }
        private static void Feladat_3_5()
        {
            int[] t = new int[50];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(5, 50) * 2 + 1;

                if(t[i] == 13) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{t[i]} ");
                Console.ResetColor();
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }

            if (t.Contains(13))
            {
                Console.WriteLine("benne van a 13");
            }
            else
            {
                Console.WriteLine("nincs benne a 13");
            }
        }
        private static void Feladat_3_4_c()
        {
            List<string> nevek = new List<string>();
            string nev = null;
            do
            {
                Console.Write($"{nevek.Count + 1,2}. név: ");
                nev = Console.ReadLine();
                if (!string.IsNullOrEmpty(nev))
                    nevek.Add(nev);
            } while (!string.IsNullOrEmpty(nev) && nevek.Count < 10);
            
            Console.WriteLine("vége a bekérésnek");
            
            nevek.Sort();

            foreach (string n in nevek)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("vége a feladatnak");
        }
        private static void Feladat_3_4_b()
        {
            string[] nevek = new string[10];
            int hossz = 0;

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write($"{i + 1,2}. név: ");
                string aktNev = Console.ReadLine();

                if (aktNev != "")
                {
                    nevek[i] = aktNev;
                    hossz++;
                }
                else
                {
                    Console.WriteLine("vége az adatbekérésnek!");
                    i = nevek.Length;
                }
            }

            Array.Resize(ref nevek, hossz);
            Array.Sort(nevek);
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }
            Console.WriteLine("itt a vége");
        }
        private static void Feladat_3_4_a()
        {
            //számolom a 'valódi' hosszt:
            string[] nevek = new string[10];
            int hossz = 0;

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write($"{i + 1, 2}. név: ");
                string aktNev = Console.ReadLine();

                if (aktNev != "")
                {
                    nevek[i] = aktNev;
                    hossz++;
                }
                else
                {
                    Console.WriteLine("vége az adatbekérésnek!");
                    i = nevek.Length;
                }
            }

            Array.Sort(nevek);
            for (int i = nevek.Length - hossz; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }
            Console.WriteLine("itt a vége");
        }
        private static void Feladat_3_2()
        {
            int[] t = new int[20];

            for (int i = 0; i < t.Length; i++)
                Console.Write($"{t[i]} ");
            Console.Write('\n');


            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(50, 151);
            }

            for (int i = 0; i < t.Length; i++)
                Console.Write($"{t[i]} ");
            Console.Write('\n');

            Array.Sort(t);

            for (int i = 0; i < t.Length; i++)
                Console.Write($"{t[i]} ");
            Console.Write('\n');

            int sum = t.Sum();
            Console.WriteLine($"sum: {sum}");

            double avg = t.Average();
            Console.WriteLine($"avg: {avg, 0:0.00}");

            int c = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 10 == 0) c++;
            }
            Console.WriteLine($"0ra végződő: {c} db");

        }
        private static void Feladat_3_matrix()
        {
            int[,] matrix = new int[3, 4];

            matrix[0, 0] = 17;
            matrix[1, 0] = 12;
            matrix[2, 0] = 42;

            matrix[1, 3] = 99;

            //Console.WriteLine(matrix.Length);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write('\n');
            }

            Console.SetCursorPosition(left: 11, top: 3);


            int[,,] ter = new int[10, 20, 30];
        }
        private static void Feladat_3_01()
        {
            string[] nevek = 
            {
                /* 0: */ "Peti",
                /* 1: */ "Jani",
                /* 2: */ "Feri",
                /* 3: */ "Lajos",
                /* 4: */ "Kálmán",
            };

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            int[] magassagok = new int[5];

            for (int i = 0; i < magassagok.Length; i++)
            {
                Console.Write($"{nevek[i]} magassága: ");
                magassagok[i] = int.Parse(Console.ReadLine());
            }

            //int magassagokOsszege = 0;
            //for (int i = 0; i < magassagok.Length; i++)
            //{
            //    magassagokOsszege += magassagok[i];
            //}
            //Console.WriteLine($"átlagmagasság: {magassagokOsszege / (float)magassagok.Length}");

            double atlagMagassag = magassagok.Average();
            Console.WriteLine($"átlagmagasság: {atlagMagassag} cm");

            Array.Sort(nevek, magassagok);

            Console.WriteLine("nevek rendezve:");
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            int legnagyobbMagassag = magassagok.Max();
            int legnagyobbMagassagIndex = Array.IndexOf(magassagok, legnagyobbMagassag);
            string legmagasabbNeve = nevek[legnagyobbMagassagIndex];

            Console.WriteLine($"a legmagasabb {legmagasabbNeve} ({legnagyobbMagassag} cm)");

            Array.Sort(magassagok, nevek);

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine($"{nevek[i]}: {magassagok[i]}");
            }
        }
        private static void Feladat_3_00_2()
        {
            int[] t = new int[5];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
            }

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            Console.Write("\n");

            Array.Sort(t);

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            Console.Write("\n");

            Array.Reverse(t);

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            Console.Write("\n");

            Array.Resize(ref t, 7);

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            Console.Write("\n");

            Array.Resize(ref t, 3);

            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            Console.Write("\n");

            Tanulo legjobbDiak = new Tanulo();
            legjobbDiak.nev = "Imola";
            legjobbDiak.magyarJegyek[legjobbDiak.jegyekSzam] = 5;
            legjobbDiak.jegyekSzam++;
            legjobbDiak.magyarJegyek[legjobbDiak.jegyekSzam] = 4;
            legjobbDiak.jegyekSzam++;

            Console.WriteLine($"{legjobbDiak.nev} első jegye magyarból {legjobbDiak.magyarJegyek[0]}");

            int sum = 0;
            for (int i = 0; i < legjobbDiak.jegyekSzam; i++)
            {
                sum += legjobbDiak.magyarJegyek[i];
            }
            Console.WriteLine($"átlaga: {sum / (float)legjobbDiak.jegyekSzam}");

            bool vanE5ose = legjobbDiak.magyarJegyek.Contains(5);
            if (vanE5ose)
            {
                Console.WriteLine($"{legjobbDiak.nev}nak van 5öse!!");
            }
            else
            {
                Console.WriteLine($"{legjobbDiak.nev}nak nincs 5öse :(((((");
            }

            int elemekOsszege = t.Sum();
            Console.WriteLine($" t tömb elemeinek össszege: {elemekOsszege}");

            Console.WriteLine($"elemek átlaga: {t.Average()}");

            Console.WriteLine($"elemek átlaga: {t.Min()}");

            Console.Write("írd be a keresett számot: ");
            int keresettSzam = int.Parse(Console.ReadLine());

            int szamIndexe = Array.IndexOf(t, keresettSzam);

            Console.WriteLine($"keresett szám indexe: {szamIndexe}");
        }
        private static void Feladat_3_00_1()
        {
            //tömb || vektor || array

            //tömbök deklarálása és inicializálása
            int[] egeszSzamok = new int[10];
            string[] nevek = new string[] { "András", "Béla", "Cecil" };
            double[] lebegopontosSzamok = { 3.14, 1.22, 42.5, 100.0 };

            string[] ures = new string[3];

            //a tömb 0ás indexű elemének felülírása

            egeszSzamok[5] = 42;
            for (int i = 0; i < egeszSzamok.Length; i++)
            {
                Console.WriteLine(egeszSzamok[i]);
            }

            for (int i = 0; i < ures.Length; i++)
            {
                Console.WriteLine($"ures {i}. eleme:{ures[i]}");
            }

            ures[1] = "bableves";

            for (int i = 0; i < ures.Length; i++)
            {
                Console.WriteLine(ures[i]);
            }
                
        }
        private static void Feladat_2_33()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i * j % 10 == 0)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    if (i == j)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (j == 1 || i == 1)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write($"{i * j, 3} ");
                    Console.ResetColor();
                }
                Console.Write('\n');
            }
        }
        private static void Feladat_2_32_b()
        {
            string s = "VAKÁCIÓ";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = s.Length - 1 - i; j <= s.Length - 1; j++)
                {
                    Console.Write(s[j]);
                }
                Console.Write("\n");
            }
        }
        private static void Feladat_2_32_a()
        {
            string s = "VAKÁCIÓ";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    Console.Write(s[j]);
                }
                Console.Write("\n");
            }
        }
        private static void Feladat_2_28()
        {
            string nev = "Juhasz Zoltan";

            for (int i = 0; i < nev.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(nev[i]);
            }
        }
        private static void Feladat_2_27()
        {
            Console.Write("írj be valamit: ");
            string szoveg = Console.ReadLine();

            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                Console.Write(szoveg[i]);
            }
        }
        private static void Feladat_2_26()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += rnd.Next(1, 7);
            }
            Console.WriteLine($"100 db dobókocka dubásainak összege: {sum}");
        }
        private static void Feladat_2_25()
        {
            int sum = 0;
            for (int szam = 0; szam < 100; szam++)
            {
                sum += szam;
            }
            Console.WriteLine($"első 100 természetes sám összege: {sum}");
        }
        private static void Feladat_2_24()
        {
            //int tizenKettoOsszegDB = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    int d1 = rnd.Next(1, 7);
            //    int d2 = rnd.Next(1, 7);
            //    int sum = d1 + d2;
            //    if (sum == 12)
            //    {
            //        tizenKettoOsszegDB++;
            //    }
            //}
            //Console.WriteLine($"{tizenKettoOsszegDB} alkalommal lett a dobások összege 12");

            int c = 0;
            for (int i = 0; i < 20; i++)
            {
                if (rnd.Next(1, 7) + rnd.Next(1, 7) == 12) c++;
            }
            Console.WriteLine($"{c} alkalommal lett a két dobás összege 12");
        }
        private static void Feladat_2_23()
        {
            int hatosDobasokSzama = 0;

            for (int i = 0; i < 100; i++)
            {
                int dobas = rnd.Next(1, 7);
                if (dobas == 6) hatosDobasokSzama++;
            }

            Console.WriteLine($"6os dobások száma: {hatosDobasokSzama}");
        }
        private static void Felada_2_22_b()
        {
            Console.Write("írj be egy számot: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}! = {Faktorialis(n)}");
        }
        private static int Faktorialis(int n)
        {
            if (n == 1) return 1;
            else return n * Faktorialis(n - 1);
        }
        private static void Feladat_2_22()
        {
            Console.Write("írj be egy számot: ");
            int n = int.Parse(Console.ReadLine());

            int nFakt = 1;
            for (int i = 2; i <= n; i++)
            {
                //nFakt = nFakt * i;
                nFakt *= i;
            }

            Console.WriteLine($"{n}! = {nFakt}");
        }
        private static void Feladat_2_char()
        {
            int szam = 1234;

            string szamAlak = szam.ToString();

            Console.WriteLine(szam);
            Console.WriteLine(szamAlak);

            char szamAlakElsoJegye = szamAlak[0];
            Console.WriteLine(szamAlakElsoJegye);

            Console.WriteLine(szamAlakElsoJegye * 10);

            string szamAlakElsoJegyeString = szamAlakElsoJegye.ToString();

            int visszaAlakitvaAzElsoJegy = int.Parse(szamAlakElsoJegyeString);

            Console.WriteLine(visszaAlakitvaAzElsoJegy * 10);
        }
        private static void Feladat_2_21()
        {
            //for (int i = 100; i < 1000; i++)
            //{
            //    int e = i % 10;
            //    int t = i % 100 / 10;
            //    int s = i / 100;

            //    if (i == Math.Pow(s, 3) + Math.Pow(t, 3) + Math.Pow(e, 3))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for (int i = 100; i < 1000; i++)
            {
                string szam = $"{i}";

                if (i == 
                    Math.Pow(int.Parse(szam[0].ToString()), 3) + 
                    Math.Pow(int.Parse(szam[1].ToString()), 3) + 
                    Math.Pow(int.Parse(szam[2].ToString()), 3))
                {
                    Console.WriteLine(szam);
                }
            }
        }
        private static void Feladat_2_14()
        {
            for (int i = -30; i <= 30; i++)
            {
                Console.WriteLine($"{i}°C = {i*1.8 + 32}°F");
            }
        }
        private static void Feladat_2_13()
        {
            Console.Write("sorozat n. tagja: ");
            int n11 = int.Parse(Console.ReadLine());
            Console.Write("sorozat n + 1. tagja: ");
            int n12 = int.Parse(Console.ReadLine());

            int d = n12 - n11;

            Console.WriteLine("előző 10 tag:");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write($"{n11 - d * i}, ");
            }

            Console.WriteLine("\nkövetkező 10 tag:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{n12 + d * i}, ");
            }
        }
        private static void Feladat_2_12()
        {
            Console.Write("számtani sorozat első tagja: ");
            int elsoTag = int.Parse(Console.ReadLine());

            Console.Write("számtani sorozat diferenciálja: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("első 20 tag:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{elsoTag + i * d}, ");
            }
        }
        private static void Feladat_2_11()
        {
            //for (int i = 10; i <= 10+50*7;i += 7)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(10 + i * 7);
            }
        }

        private static void Feladat_2_10()
        {
            for (int i = 99; i >= 1; i -= 2)
            {
                Console.WriteLine(i);
            }

            //for (int i = 1; i <= 99; i += 2)
            //{
            //    Console.WriteLine(100 - i);
            //}
        }

        private static void Feladat_2_09()
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 1) Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(2 * i + 1);
            }
        }

        private static void Feladat_2_08()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"2^{i, 2} = {Math.Pow(2, i), 9}");
            }
        }

        private static void Feladat_2_07()
        {
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        private static void Feladat_2_06()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);

                Console.SetCursorPosition(
                    left: rnd.Next(Console.WindowWidth),
                    top: rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
        }

        private static void Feladat_2_05()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.SetCursorPosition(
                    left: rnd.Next(Console.WindowWidth),
                    top: rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
        }

        private static void Feladat_2_szinek()
        {
            //ConsoleColor szin = (ConsoleColor)13;

            ConsoleColor szin = ConsoleColor.Magenta;

            Console.ForegroundColor = szin;

            Console.WriteLine("ROZSASZÍÍÍÍÍN <3 ^^");
        }

        private static void Feladat_2_04()
        {
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Green;

            string nev = "Juhasz Zoltan";
            int szelesseg = Console.WindowWidth - nev.Length;
            int magassag = Console.WindowHeight;

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(
                    left: rnd.Next(szelesseg),
                    top: rnd.Next(magassag));
                Console.Write(nev);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void Feladat_bonusz()
        {
            for (int i = 0; i < 10000; i++)
            {
                int x = rnd.Next(Console.WindowWidth);
                int y = rnd.Next(Console.WindowHeight);

                Console.SetCursorPosition(x, y);

                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
                Console.BackgroundColor = (ConsoleColor)rnd.Next(16);
                Console.Write("X");
                //Thread.Sleep(100);
            }
        }

        private static void Feladat_2_03()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{i}...");
                Thread.Sleep(300);
                Console.Clear();
            }
            Console.WriteLine("viszont látásra!");
            Thread.Sleep(3000);
        }

        private static void Feladat_2_02()
        {
            Console.Write("írj be egy számot: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("írj be egy szöveget: ");
            string s = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{s} ");
            }
            Console.Write("\n");
        }

        private static void Feladat_2_01()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1, 2}. Zoli");
            }
        }

        private static void Feladat_1_36()
        {
            int szam = rnd.Next(1000001);
            if (szam / 1000000 >= 1)
                Console.WriteLine("7 számjegyű");
            else if (szam / 100000 >= 1)
                Console.WriteLine("6 számjegyű");
            else if (szam / 10000 >= 1)
                Console.WriteLine("5 számjegyű");
            else if (szam / 1000 >= 1)
                Console.WriteLine("4 számjegyű");
            else if (szam / 100 >= 1)
                Console.WriteLine("3 számjegyű");
            else if (szam / 10 >= 1)
                Console.WriteLine("2 számjegyű");
            else
                Console.WriteLine("1 számjegyű");

        }

        private static void Feladat_1_34()
        {
            int paros = rnd.Next(0, 50) * 2;
            Console.WriteLine(paros);
        }

        private static void Feladat_1_33()
        {
            int e = rnd.Next(15, 26);
            double t = 15 + rnd.NextDouble() * 10;

            Console.WriteLine(e);
            Console.WriteLine(t);

            double t2 = rnd.Next(150, 251) / 10d;

            Console.WriteLine(t2);
        }

        private static void Feladat_1_32()
        {
            int randomEgesz = rnd.Next(26);
            Console.WriteLine(randomEgesz);

            double randomTort = rnd.NextDouble() * 25;
            Console.WriteLine(randomTort);
        }

        private static void Feladat_1_31()
        {
            int veletlen_1 = rnd.Next(100, 1000);
            //int veletlen_2 = rnd.Next(2, 768);
            Console.WriteLine(veletlen_1);
            //Console.WriteLine(veletlen_2);

            int veletlen_3 = rnd.Next();
            int veletlen_4 = rnd.Next(100);
            int veletlen_5 = rnd.Next(-40, 41);

        }

        private static void Feladat_1_30()
        {
            Console.Write("írj be egy évszámot: ");
            int ev = int.Parse(Console.ReadLine());

            //v1
            if (ev % 400 == 0)
            {
                Console.WriteLine("szökőév");
            }
            else if (ev % 100 == 0)
            {
                Console.WriteLine("NEM szökőév");
            }
            else if (ev % 4 == 0)
            {
                Console.WriteLine("szökőév");
            }
            else
            {
                Console.WriteLine("NEM szökőév");
            }

            //v2
            if (ev % 400 == 0 || (ev % 100 != 0 && ev % 4 == 0))
            {
                Console.WriteLine("szökőév");
            }
            else
            {
                Console.WriteLine("NEM szökőév");
            }

            //v3
            Console.WriteLine(ev % 400 == 0 || (ev % 100 != 0 && ev % 4 == 0) ? "szökőév" : "NEM szökőév");

            //v4
            Console.WriteLine(DateTime.IsLeapYear(ev) ? "szökőév" : "NEM szökőév");

        }

        private static void Feladat_1_29()
        {
            Console.Write("mennyibe kerül egy ilyen biszbasz?: ");
            int ar = int.Parse(Console.ReadLine());
            Console.Write("menni biszbaszt szeretnél venni?: ");
            int db = int.Parse(Console.ReadLine());
            Console.Write("mennyi pénz van nálad?: ");
            int penz = int.Parse(Console.ReadLine());

            if (ar * db <= penz)
            {
                Console.WriteLine($"meg tudsz venni {db} a biszbaszt");
                Console.WriteLine($"{penz - ar * db} Ft marad majd nálad");
            }
            else
            {
                Console.WriteLine("ennyi biszbaszra nincs pénzed");
                Console.WriteLine($"össz max {penz / ar} biszbaszt tudsz venni");
            }
        }

        private static void Feladat_1_26()
        {
            //switch: az if + else if + else if + ... + else elágazásos vezérlő alternatívása,
            //case-enként a "kapcsolóra" ekvivalencia relációt végez
            //javaslom használatát igen indokolt eseteken kíbül kerüljük

            Console.Write("írd be a jegyet numerikusan: ");
            int j = int.Parse(Console.ReadLine());

            switch (j)
            {
                case 1:
                    Console.WriteLine("elégtelen");
                    break;
                case 2:
                    Console.WriteLine("elégséges");
                    break;
                case 3:
                    Console.WriteLine("közepes");
                    break;
                case 4:
                    Console.WriteLine("jó");
                    break;
                case 5:
                    Console.WriteLine("jeles");
                    break;
                default:
                    Console.WriteLine("nem megfelelő számot írtál be!");
                    break;
            }


        }

        private static void Feladat_1_2x()
        {
            Console.Write("add meg X értékét: ");
            int x = int.Parse(Console.ReadLine());

            //adott szám [-10; +10] intervallumon KÍVÜL esik:
            if (x < -10 || x > 10)
            {
                Console.WriteLine("iv.-n kívül van");
            }
            else
            {
                Console.WriteLine("iv.-n belül van");
            }

            //adott szám [-10; +10] intervallumon BELÜL van:
            if (x >= -10 && x <= 10)
            {
                Console.WriteLine("iv.-n belül van");
            }
            else
            {
                Console.WriteLine("iv.-n kívül van");
            }
        }

        private static void Feladat_1_20()
        {
            Console.Write("írj be egy számot: ");
            int n = int.Parse(Console.ReadLine());

            //v1
            if (n < 0)
            {
                Console.WriteLine($"{n} negatív");
            }
            else
            {
                if (n > 0)
                {
                    Console.WriteLine($"{n} pozitív");
                }
                else
                {
                    Console.WriteLine($"{n} se nem negatív, se nem pozitív");
                }
            }

            //v2
            if (n < 0)
                Console.WriteLine($"{n} negatív");
            else if (n > 0)
                Console.WriteLine($"{n} pozitív");
            else
                Console.WriteLine($"{n} se nem negatív, se nem pozitív");

            //v2
            if (n < 0) Console.WriteLine($"{n} negatív");
            else if (n > 0) Console.WriteLine($"{n} pozitív");
            else Console.WriteLine($"{n} se nem negatív, se nem pozitív");
        }

        private static void Feladat_1_18()
        {
            Console.Write("írj be egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("páratlan");
            }
        }

        private static void Feladat_1_17()
        {
            Console.Write("szeretsz programozni? ");
            string valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                Console.WriteLine("még sokra viszed az életben!");
            }
            Console.WriteLine("viszontlátásra!");
        }

        private static void Feladat_1_16()
        {
            Console.Write("Írd be, hogy hány °C van: ");
            int h = int.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("odakint fagy van!\nvegyél kabátot!");
            }
        }

        private static void Feladat_1_13()
        {
            Console.WriteLine("Bankjegyautomata");

            Console.WriteLine(
                "legkisebb felvehető összeg 1 000 Ft\n" +
                "legnagyobb felvehető összeg 300 000 Ft");

            Console.Write("adja meg mekkora összeget kíván felvenni?: ");
            int ft = int.Parse(Console.ReadLine());

            if (ft < 1000)
            {
                Console.WriteLine("legalább 1.000 Ft-ot kell felvenned!");
            }
            else if (ft > 300000)
            {
                Console.WriteLine("legfeljebb 300.000 Ft-ot vehetsz fel!");
            }
            else if (ft % 1000 != 0)
            {
                Console.WriteLine("kerek ezres összeget tudunk csak a rendelkezésedre bocsátani!");
            }
            else
            {
                int tesz = ft / 10000;
                ft %= 10000;
                int oesz = ft / 5000;
                ft %= 5000;
                int esz = ft / 1000;

                Console.WriteLine("kiadott bankjegyek: ");

                Console.WriteLine($"{tesz ,2} * 10000 = {tesz * 10000, 7:N0}");
                Console.WriteLine($"{oesz ,2} *  5000 = {oesz *  5000, 7:N0}");
                Console.WriteLine($"{ esz ,2} *  1000 = { esz *  1000, 7:N0}");
                Console.WriteLine("____________________");
                Console.WriteLine($"{(10*tesz + 5*oesz + esz)*1000 ,20:N0} Ft");

            }



        }

        private static void Feladat_1_08()
        {
            Console.Write("megtett út hossza (km): ");
            float s = float.Parse(Console.ReadLine());
            Console.Write("eltelt idő (h): ");
            float t = float.Parse(Console.ReadLine());
            Console.WriteLine($"átlagsebesség: {s / t} kmph");
        }

        private static void Feladat_1_07()
        {
            Console.Write("derékszögű háromszög egyik befogójának hossza: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("derékszögű háromszög másik befogójának hossza: ");
            float b = float.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"a befogó hossza: {c}");
        }

        private static void Feladat_1_06()
        {
            Console.Write("írd be a kör sugarát: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------");
            double k = 2 * r * Math.PI;
            //kiírom úgy, ahogy van:
            Console.WriteLine($"kör kerülete: {k} cm");
            //kiírom a tizedesjegyek levágásával
            double levagottK = Math.Floor(k);
            Console.WriteLine($"\t'k' egész része: {levagottK}");
            //kiírom matematikai kerekítéssel
            double kerekitettK = Math.Round(k);
            Console.WriteLine($"\t'k' kerekítéssel kapott értéke: {kerekitettK}");
            //kiírom math. kerekítéssel, adott tizedes jegyig:
            double kerekitettK2 = Math.Round(k, 2);
            Console.WriteLine($"\t'k' adott pontosságúra kerekített értéke: {kerekitettK2}");
            //nem módosítom a számot, de a kiírásban a szám más formában (kerekítve) szerepel.
            Console.WriteLine("\t'k' értékének alternatív kiírása: {0:0.00}", k);
            double t = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine($"kör területe: {t} cm^2");
        }
        
        private static void Feladat_1_05()
        {
            Console.Write("téglalap 'a' oldala (cm): ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("téglalap 'b' oldala (cm): ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------");
            Console.WriteLine($"téglalap kerülete: {2 * (a + b)} cm");
            Console.WriteLine($"téglalap területe: {a * b} cm^2");
        }
        
        private static void Feladat_1_04()
        {
            Console.Write("írd be az euro árfolyamát: ");
            float arfolyam = float.Parse(Console.ReadLine());
            Console.Write("ennyi eurot szeretnénk átváltani: ");
            int euro = int.Parse(Console.ReadLine());

            Console.WriteLine($"ennyi forintot ér: {arfolyam * euro}");

            Console.WriteLine();
        }
        
        private static void Feladat_1_03()
        {
            Console.Write("írd be a havi fizetésed: ");
            int haviFizetes = int.Parse(Console.ReadLine());
            Console.WriteLine($"éves fizet: {haviFizetes * 12} Ft");
        }
        
        private static void Feladat_1_01()
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
        
        private static void Feladat_1_00()
        {
            Console.Write("Írd be a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}! Sok sikeret a C#-hoz!");
        }

    }
}
