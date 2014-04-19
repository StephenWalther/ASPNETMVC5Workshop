define(['jquery'], function ($) {

    return {
        listMovies: function () {
            // return a promise (jQuery deferred)
            return $.getJSON('/api/movies');
        },

        addMovie: function (movieToAdd) {
            
            return $.ajax({
                url: '/api/movies',
                type: 'post',
                data: movieToAdd,
                contentType: "application/json",
                dataType: "json"
            });
        }
    };
});