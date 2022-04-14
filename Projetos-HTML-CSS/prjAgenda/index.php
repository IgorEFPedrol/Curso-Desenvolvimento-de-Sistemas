<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
  <title>Login</title>
  <link rel="icon" type="image/x-icon" href="assets/icone.svg">

</head>

<body style="background-image: url(assets/iMac\ -\ 3.png); background-repeat:no-repeat; background-size:cover">
  <div class="container-fluid">
    <div class="row justify-content-end d-flex" style="margin-right: 48px; margin-top: 192px">
      <div class="col-6">
        <div class="card col-10 pb-4 rounded">
          <div class="card-body">
      <div>
        <p class="text-center fs-1 fw-bold mt-4" style="color: #944ACE;">Login</p>
          <p class="text-center">Preencha os campos abaixo com seus dados cadastrados no site</p>
      
            <form action="login.php" method="post">
              <div class="row d-flex col-6 d-grid mx-auto mt-5">
                <?php if (isset($_GET['erro'])) { ?>
                  <p class="erro fw-bold bg-transparent" style="color: #bb2124;"><?php echo $_GET['erro']; ?></p>
               <?php } ?>
              <label for="Email" class="mt-2 fw-bold">E-mail</label>
                <input type="text" class="form-control mt-2" id="Email" name="email" placeholder="@dominio.com" />
              <label for="Senha" class="mt-3 fw-bold">Senha</label>
                <input type="password" class="form-control mt-2" id="Senha" name="senha" placeholder="Senha" />
              </div>
              <div class="row">
              <p class="text-center mt-5 fs-6">
              Esqueci minha senha!
              <a href="" class="link-primary fw-bold" style="color: #944ACE;"> Altere ela aqui</a>
            </p>
            <p class="text-center fs-6">
              Não tem conta? <a href="" class="link-primary fw-bold" style="color: #944ACE;"> Crie uma já</a>
            </p>
            <div class="row col-6  d-grid mx-auto">
              <button type="submit" class="btn btn-primary border-0 mt-5 col-12" id="botaoEntrar" style="background-color: #944ACE;">Entrar</button>
            </div>
          </form>
          </div>
        </div>
        </div>
        </div>
      </div>
  </div>



  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
</body>

</html>