define(['durandal/app', 'knockout', 'services/movieService', 'plugins/router'], function (app, ko, movieService,router) {

    return {
        movieToAdd: {
            title: ko.observable(''),
            director: ko.observable('')
        },

        movieToAddErrors: ko.observableArray([]),

        save: function () {
            var self = this;
            
            var movie = ko.toJSON(this.movieToAdd);
            movieService.addMovie(movie)
                .done(function (result) {
                    // reset the form
                    self.movieToAddErrors([]);
                    self.movieToAdd.title('');
                    self.movieToAdd.director('');

                    // navigate home to show the new movie
                    router.navigate('/');
                })
                .fail(function (xhr) {
                    // build errors to display
                    var response = JSON.parse(xhr.responseText);
                    var errors = [];
                    for (var prop in response.modelState) {
                        var valErrors = response.modelState[prop];
                        for (var e = 0; e < valErrors.length; e++) {
                            errors.push(valErrors[e]);
                        }
                    }
                    self.movieToAddErrors(errors);
                });
        }
    };
});