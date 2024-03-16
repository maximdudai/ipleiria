<?php
    use Carbon\Carbon;
    function calcularPlano($credito, $numPrest) {

        $valorPres = $credito/$numPrest;
        $custo = 10;
        $data =  Carbon::today()->addMonth(-1);

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
        return $planoPagamento;
    }
?>