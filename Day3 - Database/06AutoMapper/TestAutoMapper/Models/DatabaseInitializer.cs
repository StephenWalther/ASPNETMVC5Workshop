using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAutoMapper.Models {
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext> {

        protected override void Seed(DataContext context) {
            var movies = new List<Movie> {
                new Movie { Title="Star Wars", Director="Lucas", Description="great!"},
                new Movie { Title="King Kong", Director="Jackson", Description="fantastic!"},
                new Movie { Title="Memento", Director="Nolan", Description="nice!"}
            };

            movies.ForEach(m => context.Movies.Add(m));

        }

    }
}