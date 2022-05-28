<?php

$nome_cliente = $_POST["nome"];
$email_cliente = $_POST["email"];
$senha_cliente = $_POST["senha"];
$sexo_cliente = $_POST["sexo"];
$dataNasc_cliente = $_POST["data"];
$telefone_cliente = $_POST["telefone"];
$cidade_cliente = $_POST["cidade"];
$estado_cliente = $_POST["estado"];



$nome_servidor = "localhost";
$nome_usuario = "root";
$senha_usuario = "minas";
$nome_data_base = "base_dados_php";


$conexao = new mysqli($nome_servidor, $nome_usuario, $senha_usuario, $nome_data_base);

if ($conexao->connect_error) {
  die("Falha na conexão: " . $conexao->connect_error);
}
else{

  $sql = "INSERT INTO clientes (nome, email, senha, sexo, data_Nascimento,
    telefone, cidade, estado)
  VALUES ('$nome_cliente', '$email_cliente', '$senha_cliente', '$sexo_cliente',
    '$dataNasc_cliente', '$telefone_cliente', '$cidade_cliente', '$estado_cliente')";

  if($conexao->query($sql) === true){
    echo "<h2 style='text-align: center; margin-top: 25px; color: red;'>Dados Inseridos com Sucesso!<h2>";
  } 
  else {
    echo "Erro na Inserção dos Dados!" + $sql . "<br>" . $conexao->error;
  }

  $conexao->close();
}









?>