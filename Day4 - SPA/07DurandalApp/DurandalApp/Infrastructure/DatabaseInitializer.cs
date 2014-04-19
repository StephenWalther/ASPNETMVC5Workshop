using DurandalApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DurandalApp.Infrastructure
{
    public class DatabaseInitializer:DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="King Kong", Director="Jackson"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}