<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
    integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
  <title>Login</title>
  <link rel="icon" type="image/x-icon" href="assets/icone.svg">

</head>

<body>
  <div class="container">
    <div>
      <p class="text-center fs-1 mt-5 fw-bold">Login</p>
    </div>
    <div>
      <p class="text-center col-12 fs-6 fw-normal">Preencha os campos abaixo com seus dados cadastrados no site</p>
    </div>

    <form action="login.php" method="post">
      <div class="row d-flex col-6 d-grid mx-auto mt-5">
      <?php if (isset($_GET['erro'])) { ?>
     		<p class="erro bg-danger"><?php echo $_GET['erro']; ?></p>
        <?php } ?>
        <label for="Email" class="fw-bold">E-mail</label>
        <input type="text" class="form-control my-1" id="Email" name="email" placeholder="@dominio.com" />

        <label for="Senha" class="fw-bold mt-3">Senha</label>
        <input type="password" class="form-control my-1" id="Senha" name="senha" placeholder="Senha" />
      </div>
      <div class="row">
        <p class="text-center mt-5">Esqueci minha senha! <a href="#" class="link-primary fw-bold">Altere aqui</a></p>
        <p class="text-center mb-4 ">Não tem uma conta? <a href="#" class="link-primary fw-bold">Criar uma já</a></p>
      </div>

      <div class="row col-6 mt-3 d-grid mx-auto">
        <button type="submit" class="btn btn-primary" id="botaoEntrar" style="background-color: black;">Entrar</button>
      </div>
    </form>

  </div>



  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"
    integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"
    crossorigin="anonymous"></script>
</body>

</html>