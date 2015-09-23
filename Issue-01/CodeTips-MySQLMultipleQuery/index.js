var express = require("express");
var app = express();
//-----------------------------------------------------------------
var MySQLConnectionSet = {
    host : "127.0.0.1"
    , database : "codeaddict_db"
    , user : "root"
    , password : ""
    , multipleStatements : true  
}
var mysql = require("mysql");
var db = mysql.createConnection(MySQLConnectionSet);
db.connect(function(err){
    if(err){
        console.log("Cannot Connect Database");
    }else{
        console.log("Connect DB OK.");    
    }    
});
//-----------------------------------------------------------------
app.get("/", function(req, res, next){
    res.send("Hello : Code Tips");
});
//-----------------------------------------------------------------
app.get("/article/:id", function(req, res, next){
    var id = req.params.id;
    // sql query set 1
    var sql = "select id, title, content, null as 'details'";
    sql+=     " from codetips_01_header where id = "+id+";";
    // sql query set 2
    sql+=     " select id, content from codetips_01_detail";
    sql+=     " where header_id = "+id+";";

    db.query(sql, function(err, results){
        
        var header = results[0][0];
        var details = results[1];
        header.details = details;
        res.json(header);
    });
});
//-----------------------------------------------------------------
app.listen(3000);



//{
//    id              : 1
//    , title         : "รายละเอียดหัวข้อ (header)"
//    , content       : "รายละเอียดทั้งหมด"
//    , details       : [
//        {
//            id          : 1
//            , content   : "detail ที่ 1"
//        }
//        , {
//            id          : 2
//            , content   : "detail ที่ 1"
//        }
//        , {
//            id          : n
//            , content   : "detail ที่ n"
//        }        
//    ]
//
//}


