<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Ex 5</title>
</head>
<body>

<?php
/*              PROCESSAMENTO               */

require 'vendor/autoload.php';
use Carbon\Carbon;

$creditoInicial = 1000;
$numPrest = 6;
$custo = 10;
$valorPres = $creditoInicial/$numPrest;
$credito = $creditoInicial;
$today = Carbon::today();
$data =  $today->copy()->addMonth(-1);

for ($i = 0; $i < $numPrest; $i++) {
    $credito = $credito - $valorPres;
    $planoPagamento[$i][0] = $data->addMonth(1)->format('d-m-Y');
    if ($i == 0) {
        $planoPagamento[$i][1] = number_format($valorPres + $custo, 2);
    }else{
        $planoPagamento[$i][1] = number_format($valorPres, 2);
    }
    $planoPagamento[$i][2] = number_format($credito,2);
}

$numLinhas = count($planoPagamento);
$numColunas = count($planoPagamento[0]);
?>

<!--          Apresentação      -->

<h1>Valor a contrair: € <?= number_format($creditoInicial,2) ?></h1>
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
        incluída na pri-meira prestação ( <?= $today->toDateString() ?>).</b></p>

</body>
</html>
