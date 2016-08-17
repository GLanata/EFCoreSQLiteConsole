using EFCoreSQLiteConsole.Context;
using EFCoreSQLiteConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSQLiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a beer name");
            string beerName = Console.ReadLine();

            Beer beer = new Beer()
            {
                Name = beerName,
            };

            DataContext db = new DataContext();

            db.Beers.Add(beer);

            db.SaveChanges();
        }
    }
}
