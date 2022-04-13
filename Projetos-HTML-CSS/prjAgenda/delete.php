<?php

    include_once('db_conn.php');
    if(!empty($_GET['id_compromisso']))
    {      
        $id = $_GET['id_compromisso'];

        $sqlSelect = "SELECT *  FROM compromissos WHERE id_compromisso=$id";

        $result = $conn->query($sqlSelect);

        if($result->num_rows != 0)
        {
            $sqlDelete = "DELETE FROM compromissos WHERE id_compromisso=$id";
            $resultDelete = $conn->query($sqlDelete);
            header('Location: telaPrincipal.php');
        }
    }
   
?>