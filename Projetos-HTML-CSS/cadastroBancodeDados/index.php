<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <title>Cadastro Banco de Dados</title>
</head>
<body>
    <div class="container mt-4">
        <div class="text-center">
            <h1>Cadastro no Banco de Dados</h1>
        </div>
        <div class="row mt-4 mx-auto">
            <form action="" method="GET">
                <div class="col-7 mt-4 mx-auto">
                    <label for="inpNome" class="form-label">Nome</label>
                    <input type="text" name="nome" id="inpNome" class="form-control">
                </div>
                <div class="col-7 mt-4 mx-auto">
                    <label for="inpIdade" class="form-label">Idade</label>
                    <input type="number" name="idade" id="inpIdade" class="form-control">
                </div>
                <div class="col-7 mt-4 mx-auto">
                    <label for="inpEmail" class="form-label">Email</label>
                    <input type="email" name="email" id="inpEmail" class="form-control" placeholder="exemplo@gmail.com">
                </div>
                <input type="submit" value="Cadastrar" class="btn btn-primary my-4 d-flex mx-auto" name="cadastrar">                                                        
            </form>
        </div>
       
    </div>
</body>
</html>

<?php
        $nome;
        $idade;
        $email;

        if(!empty($nome) && !empty($idade) && !empty($email))
        {
            $nome = $_GET['nome'];
            $idade = $_GET['idade'];
            $email = $_GET['email'];
            require __DIR__ . '/cadastro.php';

            $retorno = conexaoDB();
            echo $retorno;
        }
        else {
            echo "<h1 style='text-align: center; color: red;'>Preencha os Campos!</h1>";
        }
?>