<?php
    class Retangulo {
        public $base;
        public $altura;
        public $area;
        public $perimetro;  
        
        function set_base($base)
        {
            $this->base = $base;
        }
        function get_base()
        {
            return $this->base;
        }

        function set_altura($altura)
        {
            $this->altura = $altura;
        }
        function get_altura()
        {
            return $this->altura;
        }
    }


?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title>Exercício de PWII</title>
</head>
<body>
<div class="container text-center">
    <div class="row my-4">
        <h1>Calculadora Geral</h1>
    </div>
    <h2 class="mb-5">Escolha o que Deseja Calcular</h2>
    <div class="row d-flex justify-content-center mx-auto col-5">
        <h4>Calculos com Retângulos</h4>
        <form action="calculo.php" method="post">
            <div class="mb-4">
                <label for="baseretangulo" class="form-label">Base do Retângulo</label>
                <input type="number" class="form-control" id="baseretangulo" name="baseRetangulo">

                <label for="alturaretangulo" class="form-label">Altura do Retângulo</label>
                <input type="number" class="form-control" id="alturaretangulo" name="alturaRetangulo">
                
                <input type="submit" name="retangulo" class="mt-3 btn btn-success">
            </div>
        <form>

            <hr>  

            <form action="calculo.php" method="post">
            <h4>Calculos com Quadrados</h4>
                <div class="mb-4">
                    <label for="ladoQuadrado" class="form-label">Lado do Quadrado</label>
                    <input type="number" class="form-control" id="ladoQuadrado" name="ladoQuadrado">
                    <input type="submit" name="quadrado" class="mt-3">
            </div>  
            </form>
            <hr>
            <h4>Calculos de Circunferência</h4>
            <h4></h4>
            <h4></h4>
            <h4></h4>
    </div>
    

       
</div>
    
</body>
</html>