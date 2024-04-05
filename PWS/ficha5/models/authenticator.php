<?php
session_start();

//função de autenticação e set da Session
function checkAuth($user, $secret){
    // verificação "hard-code"
    if($user ==='Maxim' && $secret === '123'){
        $_SESSION['username'] = 'Maxim';
        return true;
    }else{ //uma forma do else
        return false;
    }
}
//++++++++++++++++++++++++++++++++++++++//++++++++++++++++++++++++++++++++++++++
//funçao de verificação de log do utiliador. Retorna um booleano
function isLoggedIn(){
    return isset($_SESSION['username']);
}
//++++++++++++++++++++++++++++++++++++++//++++++++++++++++++++++++++++++++++++++
//função de logout
function logout(){
    session_destroy();
}
?>
