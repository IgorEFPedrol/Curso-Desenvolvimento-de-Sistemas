<?php

$valor = $_POST["nome"];
echo "<h1>", $valor, "</h1>";

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "agenda_pessoal";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error)
{
    die("Falha na conexão!" . $conn->connect_error);
}
echo "<h2>Conectado com Sucesso!</h2>";

$sql = "INSERT INTO compromissos (, lastname, email)
VALUES ()";

if ($conn->query($sql) === TRUE) {
  echo "New record created successfully";
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();

?>