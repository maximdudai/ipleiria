<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>page</title>
</head>
<body>

<h1>Valor a contrair: € <?= number_format($credito,2) ?></h1>
<h4>Número de prestações: <?= $numPrest ?></h4>
<h4>Data do empréstimo: <?=  $today->toDateString() ?></h4>

<table border="1">
    <tr style="background-color: lightgrey">
        <td>Nº Prest</td>
        <td>Data</td>
        <td>Valor Prest.</td>
        <td>Valor em Dívida</td>
    </tr>

    <?php
    for ($i = 0; $i < $numLinhas; $i++) {
        echo '<tr>';
        echo '<td style="background-color: lightgrey">'.($i+1).'</td>';

        for ($j = 0; $j < $numColunas; $j++) {
            echo '<td>'.$planoPagamento[$i][$j].'</td>';
        }
        echo '</tr>';
    }
    ?>
</table>
<p><b>O valor da despesa do crédito é de <?= $custo ?>€ e encontra-se
        incluída na primeira prestação ( <?= $today->toDateString() ?>).</b></p>

</body>
</html>
