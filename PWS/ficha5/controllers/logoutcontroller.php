<?php

    if($_SERVER['REQUEST_METHOD'] == 'GET') {
        require_once ('../models/authenticator.php');

        logout();

        require_once ('../views/login.php');
    }
?>