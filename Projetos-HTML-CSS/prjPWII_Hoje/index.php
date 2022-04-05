
<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
    <link rel="stylesheet" href="css/custom.css" />
    <title>Agenda Pessoal</title>
  </head>
  <body>
    <div class="row d-flex justify-content-center">
      <div class="col-4">
        <h1 class="text-center">Login</h1>
        <form class="form-group mt-4" action="config.php" method="post">
          <label for="nome">Usuário</label>
          <input class="form-control mt-1" type="text" name="nome" placeholder="Nome de usuário"><br>
          <label for="senha">Senha</label>
          <input class="form-control mt-3" type="password" name="senha" placeholder="Senha"><br>
          <div class="bg-info">
            <input class="btn btn-primary mt-1" type="submit">
          </div>
      </form>
      </div>
    </div>

  </body>