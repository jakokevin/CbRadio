using System.Diagnostics.Tracing;

namespace CbRadio
{
    internal class Program
    {
        static List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
        }

        private static void Feladat8()
        {
            List<string> soforok = new List<string>();
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (!soforok.Contains(bejegyzesek[i].Nev))

                {
                    soforok.Add(bejegyzesek[i].Nev);
                }
            }
            Console.WriteLine($"soforok szama: {soforok.Count} fo");
        }

        private static void Feladat7()
        {
            StreamWriter sw = new StreamWriter("cb2.txt");

            sw.WriteLine("Kezdes,Nev,AdasDb");

            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                int kezdes = AtszamolPercre(bejegyzesek[i].Ora, bejegyzesek[i].Perc);
                sw.WriteLine(kezdes + ";" + bejegyzesek[i].Nev, bejegyzesek[i].AdasDb);
            }
            sw.Close();
        }

        private static void Feladat6()
        {
            
        }

        static int AtszamolPercre(int ora, int perc)
        {
            return ora * 60 + perc;
        }

        private static void Feladat5()
        {
            Console.WriteLine("irj be egy nevet: ");
            string nev = Console.ReadLine();
            int osszeg = 0;
            bool van = false;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (bejegyzesek[i].Nev == nev)
                {
                    osszeg += bejegyzesek[i].AdasDb;
                    van = true;
                }
            }
            if(van)
            {
                Console.WriteLine($"ennyiszer hasznalta {nev} a radiot: {osszeg}");
            }
            else
            {
                Console.WriteLine("ez a nev nem szerepel benne");
            }
        }

        private static void Feladat4()
        {
            bool van = false;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (bejegyzesek[i].AdasDb == 4)
                {
                    van = true;
                    break;
                }
                
            }
            Console.WriteLine("volt 4 adast indito sofor");

        }

        private static void Feladat3()
        {
            Console.WriteLine($"bejegyzesek szama: {bejegyzesek.Count()}");

          
        }

        static void Feladat2()
        {
            StreamReader sr = new StreamReader("cb.txt");
            sr.ReadLine();


            while(!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Bejegyzes b = new Bejegyzes(sor);
                bejegyzesek.Add(b);
            }
            sr.Close();
        }
    }
}

