define(function (require) {

    return {
        _lastId: 2,
        _movies: [
            {id: 0, title: "Star Wars", director: "Lucas"},
            {id: 1, title: "King Kong", director: "Jackson"},
            {id: 2, title: "Memento", director: "Nolan"}
        ],

        listMovies: function () {
            return this._movies;
        },

        addMovie: function (movieToAdd) {
            movieToAdd.id = ++this._lastId;
            this._movies.push(movieToAdd);
        },

        getMovie: function (id) {
            for (var i = 0; i < this._movies.length; i++) {
                if (this._movies[i].id == id) {
                    return this._movies[i];
                    break;
                }
            }
        }
    
    };
});