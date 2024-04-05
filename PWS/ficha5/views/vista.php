<?php
    $credito = $_POST['valorCredito'];
    $numPrest = $_POST['numeroPrestacoes'];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Ex 5</title>
</head>
<body>


<h1>Valor a Contrair: € <?= number_format($credito,2) ?></h1>
<h4>Número de prestações: <?= $numPrest ?></h4>

<table border="1">
    <tr style="background-color: lightgrey">
        <td>Nº Prest</td>
        <td>Data</td>
        <td>Valor Prest.</td>
        <td>Valor em Dívida</td>
    </tr>

<?php
for ($i = 0; $i < $planoPagamento['numLinhas']; $i++) {
    echo '<tr>';
    echo '<td style="background-color: lightgrey">'.($i+1).'</td>';

    for ($j = 0; $j < $planoPagamento['numColunas']; $j++) {
        echo '<td>'.$planoPagamento['dados'][$i][$j].'</td>';
    }
    echo '</tr>';
}
?>
</table>
<p><b>O valor da despesa do crédito é de <?= $planoPagamento['custo'] ?>€ e encontra-se
        incluída na primeira prestação ( <?= $planoPagamento['today'] ?>).</b></p>

<a href="../controllers/logoutcontroller.php">Log out</a>

</body>
</html>