<?php 
session_start(); 
include "db_conn.php";

if (isset($_POST['email']) && isset($_POST['senha'])) {

	function validar($data){
       $data = trim($data);
	   $data = stripslashes($data);
	   $data = htmlspecialchars($data);
	   return $data;
	}

	$email = validar($_POST['email']);
	$senha = validar($_POST['senha']);

	if (empty($email)) {
		header("Location: index.php?erro=Preencha o campo Email");
	    exit();
	}else if(empty($senha)){
        header("Location: index.php?erro=Preencha o campo Senha");
	    exit();
	}else{
		$sql = "SELECT * FROM usuarios WHERE login_usuario='$email' AND senha_usuario='$senha'";

		$result = mysqli_query($conn, $sql);

		if (mysqli_num_rows($result) === 1) {
			$row = mysqli_fetch_assoc($result);
            if ($row['login_usuario'] === $email && $row['senha_usuario'] === $senha) {
            	$_SESSION['login_usuario'] = $row['login_usuario'];
            	$_SESSION['id_usuario'] = $row['id_usuario'];
            	header("Location: telaPrincipal.php");
		        exit();
            }else{
				header("Location: index.php?erro=Email ou Senha Incorretos");
		        exit();
			}
		}else{
			header("Location: index.php?erro=Email ou Senha Incorretos");
	        exit();
		}
	}
	
}else{
	header("Location: index.php");
	exit();
}