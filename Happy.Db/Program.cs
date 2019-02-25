using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy.Db
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FilmContext())
            {
                Console.WriteLine("enter film title");
                string title = Console.ReadLine();
                Console.WriteLine("enter film released year");
                string year = Console.ReadLine();
                Console.WriteLine("enter film category");
                string category = Console.ReadLine();
                Console.WriteLine("enter film budget");
                double budget = Convert.ToDouble(Console.ReadLine());
                db.Films.Add(new Filmtbl { title = title });
                db.Films.Add(new Filmtbl { year = year });
                db.Films.Add(new Filmtbl { category = category });
                db.Films.Add(new Filmtbl { budget = budget });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All films in database:");
                foreach (var Filmtbl in db.Films)
                {
                    Console.WriteLine(" - {0}{1}{2}{3}", Filmtbl.title, Filmtbl.year, Filmtbl.category,Filmtbl.budget);
                }
            }
        }
    }
}
