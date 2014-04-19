using System;
using System.Collections.Generic;
namespace Repository.Models {
    public interface IMoviesRepository: IDisposable {
        void Create(Movie movie);
        void Delete(int id);
        void Edit(Movie movie);
        Movie Find(int id);
        IList<Movie> List();
    }
}
