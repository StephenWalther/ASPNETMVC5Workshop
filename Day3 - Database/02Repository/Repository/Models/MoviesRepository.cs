using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models {
    public class MoviesRepository : IMoviesRepository {

        private RepositoryContext db = new RepositoryContext();


        public Movie Find(int id) {
            return db.Movies.Find(id);
        }


        public IList<Movie> List() {
            return db.Movies.ToList();
        }


        public void Create(Movie movie) {
            db.Movies.Add(movie);
            db.SaveChanges();
        }


        public void Edit(Movie movie) {
            var originalMovie = this.Find(movie.Id);
            originalMovie.Title = movie.Title;
            originalMovie.Director = movie.Director;
            db.SaveChanges();
        }


        public void Delete(int id) {
            var movie = this.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }


        public void Dispose() {
            db.Dispose();
        }

    }
}