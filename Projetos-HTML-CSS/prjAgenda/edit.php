<?php

    include_once('db_conn.php');
    
    if(!empty($_GET['id_compromisso']))
    {
        echo "ENTROU AQUI";
        $id = $_GET['id_compromisso'];
        $sqlSelect = "SELECT * FROM compromissos WHERE id=$id";
        $result = $conn->query($sqlSelect);
       //if($result->num_rows != 1)
       // {
       //     while($user_data = mysqli_fetch_assoc($result))
        //    {
       //         $nome = $user_data['nome'];
        //        $descricao = $user_data['descricao'];
        //        $data_compromisso = $user_data['data_compromisso'];
         //   }
       // }
        
    }
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title>Editar Compromissos</title>
</head>
<body>
    <div class="container">
        <div class="row d-flex col-6 d-grid mx-auto mt-5">
            <form action="saveEdit.php" method="POST">
                
                <label for="input_name" class="mt-3">Nome do Compromisso</label>
                <input type="text" class="form-control mt-2" id="input_name" name="nome">
        
                <label for="input_desc" class="mt-3">Descrição do Compromisso</label>
                <input type="text" class="form-control mt-2" id="input_desc" name="descricao">
        
                <label for="input_date" class="mt-3">Data do Compromisso</label>
                <input type="datetime-local" class="form-control mt-2" id="input_date" name="data">

                <input type="hidden" name="id" value="<?php echo $id; ?>">
                <input type="submit" name="update" id="submit" class="mt-3">
            </form>
        </div>
    </div>
</body>
</html>