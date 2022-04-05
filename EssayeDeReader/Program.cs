using LeezaalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssayeDeReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Magazine magazine = new Magazine();
            var list=magazine.ColorList;
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
             
            Console.WriteLine("Tfoooooooo 3lik "+list[magazine.Kleur]);
            var hat = Hat.Hats();
            foreach (var item in hat)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var color = MagazineColors.Colors();
            int index = random.Next(color.Length);
            foreach (var item in color)
            {
                Console.WriteLine(item);
            }
            
           
            Console.WriteLine("Essaye 1 fois"+color[index]);
            //Console.WriteLine("Essaye 2 fois" + color[index2]);

            ReadingRoom room = new ReadingRoom();
            room.Add(10);
            
            foreach (var item in room.Readers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
