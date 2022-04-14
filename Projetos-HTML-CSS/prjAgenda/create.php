<?php
    include_once('db_conn.php');

    $sqlSelect = "SELECT * FROM compromissos";
    $result = $conn->query($sqlSelect);
?>

<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
        <title>Adicionar Compromisso</title>
    </head>
    <body>
        <div class="container">
            <div class="row d-flex col-6 d-grid mx-auto mt-5">
                <form action="saveCreate.php" method="POST">

                    <label for="input_name" class="mt-3">Nome do Compromisso</label>
                    <input type="text" class="form-control mt-2" id="input_name" name="nome">

                    <label for="input_desc" class="mt-3">Descrição do Compromisso</label>
                    <input type="text" class="form-control mt-2" id="input_desc" name="descricao">

                    <label for="input_date" class="mt-3">Data do Compromisso</label>
                    <input type="datetime-local" class="form-control mt-2" id="input_date" name="data">

                    <input type="submit" name="create" id="submit" class="mt-3">
                    
                </form>
            </div>  
        </div>    
    </body>
</html>