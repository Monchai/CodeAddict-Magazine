<?php
require 'Slim/Slim.php';

\Slim\Slim::registerAutoloader();

$app = new \Slim\Slim();
//-------------------------------------------------------------------------
$app->get('/',function () use ($app) {
    $app->render('home.php', array(
        'hello' => 'Hello Code Addict'
    ));
});
//-------------------------------------------------------------------------
$app->get('/calc/:x/:y', function($x, $y){
    echo $x + $y;
});
//-------------------------------------------------------------------------
$app->run();
