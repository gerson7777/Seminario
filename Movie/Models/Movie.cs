using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Movie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime REleaseDate { get; set; }
        public decimal price { get; set; }

    }
    public class MovieDBcontext : DbContext
    {
        public DbSet<Movie> Movies { get; set;}
    }
}
