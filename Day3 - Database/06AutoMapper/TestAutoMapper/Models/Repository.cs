using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;


// See http://stackoverflow.com/questions/2212126/does-automapper-support-linq

namespace TestAutoMapper.Models {
    public class Repository {

        private DataContext _db = new DataContext();


        //// Don't do this!
        //public IList<BriefMovie> ListMovies() {
        //    var movies = _db.Movies;
        //    var briefMovies = Mapper.Map<List<BriefMovie>>(movies);
        //    return briefMovies.ToList();
        //}





        public IList<BriefMovie> ListMovies() {
            var briefMovies = _db.Movies.Project().To<BriefMovie>();
            return briefMovies.ToList();
        }




    }
}