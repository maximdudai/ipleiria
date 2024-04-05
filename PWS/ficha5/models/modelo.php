<?php
use Carbon\Carbon;

function calculaPlano($credito, $numPrest){
    $valorPres = $credito/$numPrest;
    $custo = 10;
    $data = Carbon::today()->addMonth(-1);

    for ($i = 0; $i < $numPrest; $i++) {
        $credito = $credito - $valorPres;
        $res['dados'][$i][0] = $data->addMonth(1)->format('d-m-Y');
        if ($i == 0) {
            $res['dados'][$i][1] = number_format($valorPres + $custo, 2);
        }else{
            $res['dados'][$i][1] = number_format($valorPres, 2);
        }
        $res['dados'][$i][2] = number_format($credito,2);
    }
    $res['custo'] = $custo;
    $res['today'] = Carbon::today()->toDateString();
    $res['numLinhas'] = count($res['dados']);
    $res['numColunas'] = count($res['dados'][0]);


    return $res;
}

?>
