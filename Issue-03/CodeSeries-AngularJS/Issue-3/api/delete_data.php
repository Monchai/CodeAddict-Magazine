<?php
    include_once('ManageData.php');
    $md = new CodeAddict\ManageData();


    $post = $md->getPost();

    $code = $post->code;
    echo 'Code : '.$code."\n";
    $result = $md->deleteData($code);

    echo $result;

?>