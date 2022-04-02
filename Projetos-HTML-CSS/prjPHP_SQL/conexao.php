<?php

$valor = $_POST["nome"];
echo "<h1>", $valor, "</h1>";

$servername = "localhost";
$username = "root";
$password = "minas";
$conn = new mysqli($servername, $username, $password);

if ($conn->connect_error)
{
    die("Falha na conexão!" . $con->connect_error);
}
echo "<h2>Conectado com Sucesso!</h2>";

?>