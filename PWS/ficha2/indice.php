<?php
    $cap1 = "Capitulo 1";
    $cap2 = "Capitulo 2";
    $cap3 = "Capitulo 3";

    $titulo = "Indice";
    $versao = "1.0";
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Web Title</title>
</head>
<body>

    <h1><?= $titulo; ?></h1>
    <span> Versao <?= $versao; ?></span>

    <ul>
        <li><a href="capitulos/capitulo1.php"><?= $cap1; ?></a></li>
        <li><a href="capitulos/capitulo2.php"><?= $cap2; ?></a></li>
        <li><a href="capitulos/capitulo3.php"><?= $cap3; ?></a></li>
    </ul>

</body>
</html>