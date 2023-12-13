<?php 

  $linguagens = array("HTML", "CSS", "JavaScript", "jQuery", "PHP");



?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <link rel="stylesheet" href="style/style.css">

  <title>PHP - Ficha</title>
</head>
<body>

  
  <form action="index.php" method="post">
    <label for="linguagem">Linguagem:</label>
    <select name="linguagem" id="linguagem">
      <?php 
        foreach($linguagens as $linguagem) {
          echo "<option value='$linguagem'>$linguagem</option>";
        }
      ?>
    </select>

    <input type="submit" value="Enviar">
  </form>


  <script src="script/script.js"></script>
</body>
</html>