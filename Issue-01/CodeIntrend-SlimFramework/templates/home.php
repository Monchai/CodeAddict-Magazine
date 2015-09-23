<html>
<head>
    <style>
        #div-result{
            margin: 10px;   background-color: lightgray;
            padding: 10px;  heigth: 30px;
        }
    </style>
</head>
<body>
    <h1><?php echo $hello; ?></h1>
    <button id="cmdCalc" onclick="calc(10, 5)">Calc 10+5</button>
    <div id="div-result">&nbsp;</div>        
</body>
</html>
<script src="/scripts/jquery.js"></script>
<script>
    function calc(x, y){    
        var url = "/calc/"+x+"/"+y;    
        $.get(url).done(function(result){
            document.getElementById("div-result").innerHTML = result;
        });
    }
</script>


