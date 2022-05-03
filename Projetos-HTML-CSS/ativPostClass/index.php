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

    <hr>

    <h3 class="mb-5">Escolha o que Deseja Calcular</h3>
    <div class="row">
        <div class="col">
        <h4>Área e Perímetro do Retângulo</h4>
            <form action="calculo.php" method="post">
                <div class="mb-4 mx-2">
                    <label for="baseretangulo" class="form-label">Base do Retângulo</label>
                    <input type="number" class="form-control" id="baseretangulo" name="baseRetangulo">

                    <label for="alturaretangulo" class="form-label">Altura do Retângulo</label>
                    <input type="number" class="form-control" id="alturaretangulo" name="alturaRetangulo">
                    
                    <input type="submit" name="retangulo" class="mt-3 btn btn-success" value="Calcular">
                </div>
            <form>
        </div>

        <div class="col">
            <h4>Área do Quadrado</h4>
            <form action="calculo.php" method="post">
                <div class="mb-4 mx-2">
                        <label for="ladoQuadrado" class="form-label">Lado do Quadrado</label>
                        <input type="number" class="form-control" id="ladoQuadrado" name="ladoQuadrado">
                        <input type="submit" name="quadrado" class="mt-3 btn btn-success" value="Calcular">
                </div>  
            </form>
        </div>
    </div>

    <hr>

    <div class="row">
        <div class="col">
            <h4>Área e Perímetro da Circunferência</h4>
            <form action="calculo.php" method="post">
                <div class="mb-4 mx-2">
                    <label for="raiocircunferencia" class="form-label">Raio da circunferência</label>
                    <input type="number" class="form-control" id="raiocircunferencia" name="raioCircunferencia" min="0">
                    <input type="submit" name="circunferencia" class="mt-3 btn btn-success" value="Calcular">
                </div>
            </form>
        </div>

        <div class="col">
            <h4>Perímetro do Triângulo</h4>
            <form action="calculo.php" method="post">
                <div class="mb-4 mx-2">
                    <label for="ladotriangulo1" class="form-label">Primeiro Lado</label>
                    <input type="number" class="form-control" id="ladotriangulo1" name="ladoTriangulo1">

                    <label for="ladotriangulo2" class="form-label">Segundo Lado</label>
                    <input type="number" class="form-control" id="ladotriangulo2" name="ladoTriangulo2">

                    <label for="ladotriangulo3" class="form-label">Terceiro Lado</label>
                    <input type="number" class="form-control" id="ladotriangulo3" name="ladoTriangulo3">

                    <input type="submit" name="triangulo" class="mt-3 btn btn-success" value="Calcular">
                </div>
            </form>
        </div>
    </div>

    <hr>

    <div class="row">
        <div class="col">
        
        </div>
        <div class="col">
        
        </div>
    </div>  
</div>
    
</body>
</html>