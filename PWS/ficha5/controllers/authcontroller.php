<?php
if($_SERVER['REQUEST_METHOD']=== 'GET'){
    require_once '../views/login.php';
}else{
    //Fazer Login
    require_once '../models/authenticator.php'; //chamando o authenticator para dentro dessa função
    $username = $_POST['username'];
    $password = $_POST['password'];


    if(checkAuth($username,$password)){
        header('Location: controlador.php');
    }else{
        require_once '../views/login.php';
    }
}