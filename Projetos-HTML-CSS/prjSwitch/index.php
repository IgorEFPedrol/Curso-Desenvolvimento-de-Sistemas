<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <link rel="icon" type="image/x-icon" href="assets/favicon.png">
    <title>Operações Com Switch</title>
</head>
<body>
    <div class="container mt-5">
        <div class="row text-center mb-4">
            <h1>Operações Matemáticas</h1>
        </div>
        <form action="index.php" method="post">  
            <div class="row d-flex mx-auto col-7">
                <div class="col">
                    <label for="input1" class="form-label">Insira o Primeiro número</label>
                    <input type="number" class="form-control" name="num1" min="0">
                </div>
                <div class="col">
                    <label for="input2" class="form-label">Insira o Segundo número</label>
                    <input type="number" class="form-control" name="num2" min="0">
                </div>  
            </div>
            <div class="row d-flex mx-auto col-8 mt-4">
                <div class="col">
                    <input type="submit" value="Somar" name="somar" class="btn btn-info mx-5">
                </div> 
                <div class="col">      
                    <input type="submit" value="Subtrair" name="subtrair" class="btn btn-info mx-5">
                </div>
                <div class="col">
                    <input type="submit" value="Dividir" name="dividir" class="btn btn-info mx-5">
                </div>            
                <div class="col">
                    <input type="submit" value="Multiplicar" name="multiplicar" class="btn btn-info mx-5">  
                </div>
                
        </form>
        </div>
        <div class="row text-center mt-5">
            <h2>Resultado</h2>
            <?php
                $operacao = "";
                $resultado = 0;

                if (empty($_POST['num1']) || empty($_POST['num2']))
                    return;
                else {  
                    $num1 = $_POST['num1'];
                    $num2 = $_POST['num2'];
                }
                

                if (isset($_POST['somar']))
                {
                    $operacao = "somar";
                }
                if (isset($_POST['subtrair']))
                {
                    $operacao = "subtrair";
                }
                if (isset($_POST['dividir']))
                {
                    $operacao = "dividir";
                }
                if (isset($_POST['multiplicar']))
                {
                    $operacao = "multiplicar";
                }

                switch ($operacao) {
                    case "somar":
                        $resultado = $num1 + $num2;
                        echo "<h1 style='text-align: center;'>$resultado</h1>";
                        break;

                    case "subtrair":
                        $resultado = $num1 - $num2;
                        echo "<h1 style='text-align: center;'>$resultado</h1>";
                        break;
                        
                    case "dividir":
                        $resultado = $num1 / $num2;
                        echo "<h1 style='text-align: center;'>".round($resultado, 2)."</h1>";
                        break;

                    case "multiplicar":
                        $resultado = $num1 * $num2;
                        echo "<h1 style='text-align: center;'>$resultado</h1>";
                        break;
                    
                    default:
                    echo "<p style='color:red;'>PREENCHA OS CAMPOS!</p>";
                    break;
                }

            ?>
        </div>
    </div>
</body>
</html>

