<?php
    include_once('ManageData.php');
    $md = new CodeAddict\ManageData();

    $code = $_POST['code'];
    $name = $_POST['name'];
//    $postdata = file_get_contents("php://input");
//    $request = json_decode($postdata);

//    $post = $md->getPost();
//
//    $code = $post->code;
//    $name = $post->name;

    $md->addData($code, $name);

    echo 'SUCCESS';
?>