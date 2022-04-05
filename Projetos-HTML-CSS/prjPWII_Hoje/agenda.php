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
    <title>Agenda de compromissos</title>
  </head>
  <body>
    <!--Header da página-->

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <div class="container-fluid">
        <a class="navbar-brand ms-5 fs-3 fw-bold" href="#"
          >Agenda de compromissos</a
        >
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarColor03"
          aria-controls="navbarColor03"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>

        <form class="d-flex">
          <button class="btn btn-outline-dark me-4 my-2 my-sm-0" type="submit">
            Entrar
          </button>

          <button class="btn btn-dark me-5 my-2 my-sm-0" type="submit">
            Cadastrar-se
          </button>
        </form>
      </div>
    </nav>

    <!--Navbar vertical da páagina-->
    <div class="bg-danger h-100 ">
    <form class="form-group bg-light shadow-sm p-3 col-2">
      <input
        class="form-control me-sm-2"
        type="text"
        placeholder="Procure pelo nome "
      />

      <div
        class="btn-group-vertical rounded mx-5 mt-3"
        role="group"
        aria-label="Button group with nested dropdown"
      >
        <button
          type="button"
          class="btn btn-outline-light text-dark border-0 mt-3"
        >
          Meu perfil
        </button>
        <button
          type="button"
          class="btn btn-outline-light text-dark border-0 mt-3"
        >
          Compromissos pendentes
        </button>

        <div class="btn-group mt-3" role="group">
          <button
            id="btnGroupDrop1"
            type="button"
            class="btn btn-outline-ligth border-0 dropdown-toggle"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Dropdown
          </button>
          <ul class="dropdown-menu" aria-labelledby="btnGroupDrop1">
            <li><a class="dropdown-item" href="#">Dropdown link</a></li>
            <li><a class="dropdown-item" href="#">Dropdown link</a></li>
          </ul>
        </div>
      </div>
    </form>
  </div>

    <!--Js ja linkado na página-->
    <script
      src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"
      integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"
      crossorigin="anonymous"
    ></script>
  </body>
</html>