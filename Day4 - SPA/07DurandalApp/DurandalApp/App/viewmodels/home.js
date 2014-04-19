define(['durandal/app', 'knockout', 'services/movieService'], function (app, ko, movieService) {

    return {
        movies: ko.observableArray([]),

        // get the movies
        activate: function () {
            var self = this;

            var movies = movieService.listMovies()
                .done(function (movies) {
                    self.movies(movies);
                });
        }
    };
});