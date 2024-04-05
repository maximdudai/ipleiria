
<?php
/*              PROCESSAMENTO               */

require '../vendor/autoload.php';
require_once ('../models/authenticator.php');

if(isLoggedIn()) {

    if($_SERVER['REQUEST_METHOD'] === 'GET'){
        require '../views/vistaFormulario.php';
    } else {

        require_once '../models/modelo.php';

        $credito = $_POST['valorCredito'];
        $numPrest = $_POST['numeroPrestacoes'];

        $planoPagamento = calculaPlano($credito, $numPrest);
       // var_dump($planoPagamento);   // aqui eu vejo o que está dentro , todas as informações

        require_once '../views/vista.php';
    }
} else {
    header('Location: authcontroller.php');
}

?>
