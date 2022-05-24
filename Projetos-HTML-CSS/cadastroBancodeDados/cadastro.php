<?php
$conexao = "";

    function conexaoDB()
    {
        $nome_servidor = "localhost";
        $usuario = "root";
        $senha = "minas";
        $nomeDataBase = "banco_dados_php";
        
        $conexao = new mysqli($nome_servidor, $usuario, $senha, $nomeDataBase);

        if($conexao -> connect_error) 
        {
            die("Falha na conexão: ". $conexao->connect_error);
            return "Erro na Conexão!";
        }
        else {
            $sql = "INSERT INTO clientes (nome_cliente, idade_cliente, email_cliente) VALUES('Igor', 16, 'admin@gmail.com')";
            if($conexao->query($sql) === true)
            {
                return "Cadastrado com sucesso!";
            }
            else {
                return "Erro: ".$sql." ".$conexao->error;
            }
        }
    }

?>
