<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <title>Formulario Cadastro BD</title>
</head>
<body>
    <div class="container">
        <div class="row text-center my-4">
            <h1>Formulario para inserir no BD</h1>
            <hr>
        </div>
        <div class="row">
            <div class="col-6">
                <form action="" method="POST">
                    <input type="text" name="nome" class="form-control mb-4" placeholder="Nome">
                    <input type="text" name="email" class="form-control mb-4" placeholder="Email">
            </div>
            <div class="col-6">
                <input type="password" name="senha" class="form-control mb-4" placeholder="Senha">
                <select name="sexo" id="sexo" class="form-select ">
                    <option value="Masculino">Masculino</option>
                    <option value="Feminino">Feminino</option>
                    <option value="Outros">Outros</option>
                </select>
            </div>                                    
        </div>
        <div class="row">
            <div class="col-3">
                <label for="data" class="form-label">Data de Nascimento</label>
                <input type="date" name="data" id="data" class="form-control">
            </div>
            <div class="col-3">
                <label for="telefone" class="form-label">Telefone</label>       
                <input type="tel" name="telefone" id="telefone" class="form-control" placeholder="99xxx-xxxx" pattern="[0-9]{5}-[0-9]{4}" >
            </div>
            <div class="col-3">
                <input type="text" name="cidade" id="cidade" class="form-control" placeholder="Cidade">
            </div>
            <div class="col-3">
                <input type="text" name="estado" id="estado" class="form-control" placeholder="Estado">
            </div>
        </div>
        <div class="row">
            <input type="submit" class="btn btn-primary mt-5" value="Cadastrar">
            </form> 
        </div>     
    </div>
</body>
</html>

<?php



if(!empty($_POST["nome"]) && !empty($_POST["email"]) && !empty($_POST["senha"])){

    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $senha = $_POST["senha"];
    $sexo = $_POST["sexo"];
    $dataNasc = $_POST["data"];
    $telefone = $_POST["telefone"];
    $cidade = $_POST["cidade"];
    $estado = $_POST["estado"];

    include 'insertBanco_Dados.php';
}
else{
    echo "<h2 style='text-align: center; margin-top: 28px; color: red;'>Preencher os campos!</h2>";
}




?>