<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Title</title>
</head>
<body>
    <form method="post" action="<?=$_SERVER['SCRIPT_NAME'] ?>">
        <p>Credito: <input name="valorCredito" type="number"></p>
        <p>Numero de prestações: <input name="numeroPrestacoes" type="number"></p>
        <button type="submit">Criar plano</button>
    </form>

</body>
</html>