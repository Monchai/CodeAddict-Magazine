var app = angular.module("Issue-03-App", []);

app.config(function($httpProvider) {
    $httpProvider.defaults.headers.post['Content-Type'] 
        = 'application/x-www-form-urlencoded; charset=UTF-8';
});

