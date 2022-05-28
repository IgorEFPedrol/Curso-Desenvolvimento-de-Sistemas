<?php



if (!empty($_POST["input1"]) && !empty($_POST["input2"])) {

  $valor1 = $_POST["input1"];
  $valor2 = $_POST["input2"];

  $resultado = calculoSoma($valor1, $valor2);
  echo $resultado;
} else {

  echo "Preencher os campos!";
}

function calculoSoma($valor1, $valor2)
{

  $resultado = $valor1 + $valor2;
  return $resultado;
}

/*
// VARIAVEIS
$valor1 = 10; // variavel GLOBAL
$valor;
$stringValor = "Texto";
$inteiroValor = 10;
$realValor = 10.0;
$boolValor = true;

calcSoma();// está chamando o metodo

// uma função
function calcSoma(){
  //um metodo só é executado quando é chamado
}

$resultado = calcularSoma(20 , 10);

echo $resultado;

//função com argumentos ($valor1, $valor2)

function calcularSoma($valor1 , $valor2){

  $resultadoSoma = $valor1 + $valor2;

  return $resultadoSoma;
}

echo "<br>";

$resultadoMultiplica = calcularMulti(10, 10);
echo $resultadoMultiplica;

function calcularMulti($valor1 , $valor2){

  $resultadoMulti = $valor1 * $valor2;
  return $resultadoMulti;
}

*/




?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <!-- CSS only -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">

  <!-- JavaScript Bundle with Popper -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
  <title>Document</title>
</head>

<body>
  <div class="container">
    <div class="mb-3">
      <form action="" method="post">
        <label for="input1" class="form-label">Valor 1</label>
        <input class="form-control" id="input1" name="input1" type="text">
        <label for="input2" class="form-label">Valor 2</label>
        <input class="form-control" id="input2" name="input2" type="text">
        <input type="submit" class="btn btn-primary mt-3" value="Calcular">
      </form>
    </div>

  </div>


</body>

</html>