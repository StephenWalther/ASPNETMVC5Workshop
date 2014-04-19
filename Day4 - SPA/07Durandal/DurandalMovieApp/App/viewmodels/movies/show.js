define(function (require) {

    var moviesRepository = require("repositories/moviesRepository");

    return {
        movies: ko.observable(),

        activate: function() {
            this.movies(moviesRepository.listMovies());
        }
    };
});