define(function (require) {
    var app = require('durandal/app');
    var router = require('durandal/plugins/router');
    var moviesRepository = require("repositories/moviesRepository");

    return {
        movieToAdd: {
            title: ko.observable(),
            director: ko.observable()
        },
 
        activate: function () {
            this.movieToAdd.title("");
            this.movieToAdd.director("");
            this._movieAdded = false;
        },

        canDeactivate: function () {
            if (this._movieAdded == false) {
                return app.showMessage('Are you sure you want to leave this page?', 'Navigate', ['Yes', 'No']);
            } else {
                return true;
            }
        },

        addMovie: function () {
            // Add movie to db
            moviesRepository.addMovie(ko.toJS(this.movieToAdd));

            // flag new movie
            this._movieAdded = true;

            // return to list of movies
            router.navigateTo("#/movies/show");
        }
    };

});