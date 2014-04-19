define(function (require) {
    var router = require('durandal/plugins/router');
    var moviesRepository = require("repositories/moviesRepository");

    return {
        movieToShow: {
            title: ko.observable(),
            director: ko.observable()
        },

        activate: function (context) {
            // Grab movie from repository
            var movie = moviesRepository.getMovie(context.id);

            // Add to view model
            this.movieToShow.title(movie.title);
            this.movieToShow.director(movie.director);
        }
    };

});