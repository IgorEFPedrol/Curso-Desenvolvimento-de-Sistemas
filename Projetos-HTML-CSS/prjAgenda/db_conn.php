<?php

$server= "localhost";
$user= "root";
$password = "minas";
$db_name = "agenda";

$conn = mysqli_connect($server, $user, $password, $db_name);

if (!$conn) {
	echo "Connection failed!";
}