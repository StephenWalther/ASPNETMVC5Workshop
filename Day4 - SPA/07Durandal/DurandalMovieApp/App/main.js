﻿require.config({
    paths: {
        'text': 'durandal/amd/text'
    }
});

define(function (require) {
    var app = require('durandal/app'),
        viewLocator = require('durandal/viewLocator'),
        system = require('durandal/system'),
        router = require('durandal/plugins/router');

    //>>excludeStart("build", true);
    system.debug(true);
    //>>excludeEnd("build");

    app.start().then(function () {
        //Replace 'viewmodels' in the moduleId with 'views' to locate the view.
        //Look for partial views in a 'views' folder in the root.
        viewLocator.useConvention();

        //configure routing
        router.useConvention();
        router.mapNav("movies/show");
        router.mapNav("movies/add");
        router.mapNav("movies/details/:id");

        app.adaptToDevice();

        //Show the app by setting the root view model for our application with a transition.
        app.setRoot('viewmodels/shell', 'entrance');
    });
});