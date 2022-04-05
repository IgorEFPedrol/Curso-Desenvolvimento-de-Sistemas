<?php

require_once('../config.php');
require_once(DBAPI);

$customers = null;
$customer = null;

function index() {
	global $customers;
	$customers = find_all('clientes');
}

function add() {

	if (!empty($_POST['clientes'])) {
	  
	  $today = 
		date_create('now', new DateTimeZone('America/Sao_Paulo'));
  
	  $customer = $_POST['clientes'];
	  $customer['data_atualizacao'] = $customer['data_cadastro'] = $today->format("Y-m-d H:i:s");
	  
	  save('clientes', $customer);
	  header('location: index.php');
	}
  }
?>