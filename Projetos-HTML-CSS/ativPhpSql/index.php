<?php
    $nomeServidor = 'localhost';
    $nomeUsuario = 'root';
    $senhaUsuario = 'minas';

    //conexão com o banco de dados
    $conexao = new mysqli($nomeServidor, $nomeUsuario, $senhaUsuario);

    if($conexao->connect_error) {
        echo "Erro na conexão com o banco de dados" . $conexao->connect_error;
    }
    else {
        echo "Conexão Bem Sucedida";
    }
?>