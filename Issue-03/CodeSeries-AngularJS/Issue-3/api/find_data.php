<?php
    include_once('ManageData.php');
    $md = new CodeAddict\ManageData();

    $code = $_GET['code'];

    
    $result = $md->filterData($code);

    echo json_encode($result);

?>