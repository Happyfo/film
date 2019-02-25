using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Happy.Db
{
    public class FilmContext : DbContext
    {
        public DbSet<Filmtbl> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Filmtbl
    {
        [Key]
        public int FilmId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category { get; set; }
        public double budget { get; set; }
    }

}
