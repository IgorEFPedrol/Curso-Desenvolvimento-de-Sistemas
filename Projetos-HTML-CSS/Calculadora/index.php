<?php
    $resultado = 0;


?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" type="image/x-icon" href="assets/favicon.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Calculadora</title>
</head>
<body>
    <div class="container bg-primary ">
        <div class="row">
            <div class="col-7">
                <label for="numero" class="form-label">
                    <?php
                        echo "<p style='font-size: 24px;'>$resultado</p>";
                    ?>
                </label>
                <input type="number" class="form-control" name="numero" id="numero">
            </div>
        </div>

        <div class="row">
            <div class="col-2">
                <form action="index.php" method="post"> 
                   <input type="submit" class="btn btn-success" value="adicionar">
                </form>
            </div>
            <div class="col-2">
                <form action="index.php" method="post">
                    <input type="submit" class="btn btn-success" value="subtrair">
                </form>
            </div>
            <div class="col-2">
                <form action="index.php" method="post">
                    <input type="submit" class="btn btn-success" value="multiplicar">
                </form>
                
            </div>
            <div class="col-2">
                <form action="index.php" method="post">
                    <input type="submit" class="btn btn-success" value="dividir">
                </form>
            </div>
        </div>
       
    </div>
</body>
</html>