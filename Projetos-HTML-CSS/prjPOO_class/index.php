<?php

class Pessoa {
    public $nome;
    public $nascimento;

    function set_nome($nome)
    {
        $this->nome = $nome;
    }
    function get_nome()
    {
        return $this->nome;
    }
}

$pessoa1 = new Pessoa();
$pessoa2 = new Pessoa();

$pessoa1->set_nome('Arnaldo');
$pessoa2->set_nome('Maria');

echo "<p style='text-align: center; color: red; margin-top: 50px; font-size: 42px;'>Nome da Pessoa 1: ".$pessoa1->get_nome()."</p>";
echo '<br>';
echo "<p style='text-align: center; color: blue; margin-top: 20px; font-size: 42px;'>Nome da Pessoa 2: ".$pessoa2->get_nome()."</p>";

?>