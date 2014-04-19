using ResponseMessage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponseMessage.Infrastructure {
    public class MoviesRepository {

        public IList<Movie> GetMovies() {
            throw new Exception("Yikes!");
        }


        public Movie GetMovie(int id) {
            return null;
        }


        public void AddMovie(Movie movieToAdd) {
            movieToAdd.Id = 27;
        }


        public bool UpdateMovie(Movie movieToUpdate) {
            return false;
        }

        public bool DeleteMovie(int id) {
            return true;
        }

    }
}