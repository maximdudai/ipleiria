<?php

require 'vendor/autoload.php';
use Carbon\Carbon;

require_once ('functions/calcularPlano.php');

$credito = 1000;
$numPrest = 6;
$custo = 10;

$today = Carbon::today();

$planoPagamento = calcularPlano($credito, $numPrest);
$numLinhas = count($planoPagamento);
$numColunas = count($planoPagamento[0]);

require ('template/index.php');
?>