using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozokConsole
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Dolgozok> dolgozoks;
        static void Main(string[] args)
        {
            dolgozoks = db.getAllDolgozo();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }
    }
}
