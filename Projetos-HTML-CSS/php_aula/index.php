<!DOCTYPE html>
<html>

<body>
    <h1>Exemplos de Arrays:</h1><br>


    <?php
        $br = "<br>";
        $tipo = "<h2>Tipo ";

        echo $tipo."string</h2>";
        $array_string =  array("hello world", "olá mundo", "boa noite");
        var_dump($array_string);
        echo $br;

        echo $tipo."inteiro</h2>";
        $array_int =  array(1, 2, 3);
        var_dump($array_int);      
        echo $br;

        echo $tipo."decimal</h2>";
        $array_decimal = array(1.5, 2.4, 3.6);
        var_dump($array_decimal);
    ?>

</body>
</html>