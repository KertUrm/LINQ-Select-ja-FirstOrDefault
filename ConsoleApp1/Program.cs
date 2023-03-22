using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectLINQ();
            FirstOrDefault();
        }
        public static void SelectLINQ()
        {
            // teeb muutjua milles on ainult nimed listist ja paneb selle järjekorra nime ette. Projekteerib järjestuse iga elemendi uude vormi.
            var selected = PeopleList.People.Select(x => PeopleList.People.IndexOf(x) + " " + x.Name);
            
            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }
        }
        public static void FirstOrDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;

             // muutjua mille väärtus on esimene elemendi listist. kui elemente ei ole siis annab default väärtuse. 
            var firstOrDefault = PeopleList.People.FirstOrDefault();

            Console.WriteLine(firstOrDefault.Name);
            Console.WriteLine(firstOrDefault.Age);
        }
    }
}
