<?php 
  require_once('functions.php'); 
  edit();
?>

<?php include(HEADER_TEMPLATE); ?>

<h2>Atualizar Cliente</h2>

<form action="edit.php?id=<?php echo $customer['id_cliente']; ?>" method="post">
  <hr />
  <div class="row">
        <div class="form-group col-md-7">
        <label for="name">Nome</label>
        <input type="text" class="form-control" name="customer['nome']" value="<?php echo $customer['nome']; ?>">
        </div>

    
        <div class="form-group col-md-2">
        <label for="campo3">Data de Cadastro</label>
        <input type="text" class="form-control" name="customer['data_cadastro']" disabled value="<?php echo $customer['data_cadastro']; ?>">
        </div>
  </div>

  <div id="actions" class="row">
    <div class="col-md-12">
      <button type="submit" class="btn btn-primary">Salvar</button>
      <a href="index.php" class="btn btn-default">Cancelar</a>
    </div>
  </div>
</form>

<?php include(FOOTER_TEMPLATE); ?>