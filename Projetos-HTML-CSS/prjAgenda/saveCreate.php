<?php
    include_once('db_conn.php');
    if (isset($_POST['create']))
    {
        $nome = $_POST['nome'];
        $descricao = $_POST['descricao'];
        $data = $_POST['data'];

        $sqlInsert = "INSERT INTO compromissos (id_compromisso, nome, descricao, data_compromisso) VALUES (NULL, '$nome', '$descricao', '$data')";

        $result = $conn->query($sqlInsert);
    }
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
    <title>Criado com Sucesso</title>
</head>
<body>
    <div class="text-center d-flex mx-auto">
        <?php
             echo  "<h1>Compromisso Criado com Sucesso!</h1>";
        ?>
    </div>
    <form class="d-flex" method="POST" action="telaPrincipal.php"> 
        <button class="btn btn-primary me-5 my-2 my-sm-0" type="submit">
            Voltar
        </button>
    </form>
</body>
</html>