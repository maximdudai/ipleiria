<?php

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Web Title</title>
</head>
<body>

    <?php
        $protocolo = 'https://';
        $dominio = "www.ipleiria.pt";
        $caminho = "/estudar/cursos/test";

        $url = $protocolo.$dominio.$caminho;
    ?>

    <a href="<?= $url; ?>">IP Leiria</a>

    <?php
        $num1 = 2;
        $num2 = 3;
    ?>

</body>
</html>