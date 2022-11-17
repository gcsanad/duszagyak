using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Commit(string path)
        {
            Console.WriteLine("Gimme ur name:");
            string szerzo = Console.ReadLine();
            Console.WriteLine("Adoljál üzenet-t");
            string uzenet = Console.ReadLine();

            int utolso = 0;
            string elso = "";
            for (int seged = 0; seged < path.Length; seged++)
            {
                if (path[seged]=='\\')
                {
                    utolso = seged;
                }
            }
            int segedCucc = 2;
            for (int hossz = path.Length-1; path[hossz] == '\\'; hossz--)
            {
                if (path[hossz]=='\\')
                {
                    if (segedCucc != 0)
                    {
                        segedCucc--;
                    }
                    else
                    {
                        utolso = hossz;
                    }
                }
            }
            foreach (var karakter in path)
            {
                if (utolso > 0)
                {
                    elso += karakter;
                    utolso--;
                }
            }
            elso += "\\mentes\\commit";
            Directory.CreateDirectory(elso);
            File.Create($"{elso}\\pleasemukodj.txt");

            int mentesSzam = 0;
            do
            {
                mentesSzam++;
                if (Directory.Exists(elso + mentesSzam) == false)
                {
                    Console.WriteLine(mentesSzam);
                    elso += mentesSzam;
                    Directory.CreateDirectory(elso);
                    File.WriteAllText(elso + "\\pleasemukodj.txt", "Helloszia");
                }
            } while (Directory.Exists(elso + mentesSzam) == true);
            Console.WriteLine(elso);

            if (Directory.Exists(elso + "\\mentes\\commit1")==false)
            {

            }











        }
        static void Main(string[] args)
        {



            Commit(@"D:\Gajdos Csanád\dusza");


















            /*
            string path = @"D:\Gajdos Csanád\dusza gyak\jegyzet.txt" ;
            File.Create(path);

            string valtozas = "Ez egy jegyzet";
            File.WriteAllText("jegyzet.txt", valtozas);

            string olvas = File.ReadAllText("jegyzet.txt");

            
            using (StreamWriter w = File.AppendText("jegyzet.txt"))
            {
                w.WriteLine("Csá");
            }
            
            Console.WriteLine(olvas);
            */

        }
    }
}
