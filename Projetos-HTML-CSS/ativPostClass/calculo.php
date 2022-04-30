<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title>Calculo do Quadrado</title>
</head>
<body>
    <div class="container text-center mt-5 display-4">
        <h1>Resultados</h1>
            <?php
               class Quadrado {
                public $lado;
                public $area;
                public $perimetro;

                function set_lado($lado)
                {
                    $this->lado = $lado;
                }
                function get_lado()
                {
                    return $this->lado;
                }

                function set_area($area)
                {
                    $this->area = $area;
                }
                function get_area()
                {
                    return $this->area;
                }

                function set_perimetro($perimetro)
                {
                    $this->perimetro = $perimetro;
                }
                function get_perimetro()
                {
                    return $this->perimetro;
                }
               }

               class Retangulo {
                   public $area;
                   public $perimetro;

                   function set_area($area)
                   {
                       $this->area = $area;
                   }
                   function get_area()
                   {
                       return $this->area;
                   }
   
                   function set_perimetro($perimetro)
                   {
                       $this->perimetro = $perimetro;
                   }
                   function get_perimetro()
                   {
                       return $this->perimetro;
                   }
               }

                if (isset($_POST['quadrado']))
                {
                    $quadrado1 = new Quadrado();
                    $quadrado1->set_lado($_POST['ladoQuadrado']);
                    $quadrado1->set_area($_POST['ladoQuadrado'] * $_POST['ladoQuadrado']);
                    $quadrado1->set_perimetro($_POST['ladoQuadrado'] * 4);
                    
                    echo "<p>A Área do <strong>Quadrado</strong> é: ".$quadrado1->get_area()."</p>";
                    echo "<p>E o seu perímetro é: ".$quadrado1->get_perimetro()."</p>";
                }

                if (isset($_POST['retangulo']))
                {
                    $retangulo1 = new Retangulo();
                    $retangulo1->set_area($_POST['baseRetangulo'] * $_POST['alturaRetangulo']);
                    $retangulo1->set_perimetro( 2 * ($_POST['baseRetangulo'] + $_POST['alturaRetangulo']));
                    
                    echo "<p>A Área do <strong>Retângulo</strong> é: ".$retangulo1->get_area()."</p>";
                    echo "<p>E o seu perímetro é: ".$retangulo1->get_perimetro()."</p>";
                }
            ?>
            <form action="index.php" method="post">
                <input type="submit" class="btn btn-primary">
            </form>
    </div>

   
</body>
</html>
