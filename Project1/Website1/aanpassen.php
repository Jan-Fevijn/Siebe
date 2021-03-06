<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>aanpassen</title>
</head>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    
<link rel="stylesheet" href=databankconnectie.php>

<body>
        <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
      <a class="navbar-brand" href="#">Project2</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
    
      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="index.php">Home <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="Aanpassen.php">Aanpassen <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="nieuw gerecht.php">nieuw gerecht <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="overzicht.php">overzicht <span class="sr-only">(current)</span></a>
          </li>
        
        </ul>
        <form class="form-inline my-2 my-lg-0">
          <input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search">
          <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
        </form>
      </div>
    </nav>
    
    <main role="main" class="container">
    
      
    

  
      <div class="starter-template">
      <?php include 'overzicht.php';?>
<br>
<!-- inhoud -->
<!-- overzicht -->
<div id="container" class="container">
    <form action="Aanpassen.php" method="POST">
        <?php if (!isset($_SESSION["keuzetype"])) {?>
        <select name="kuezininkomst" onchange="this.form.submit()">
            <option value="0"><-maak uw keuze -></option>
            <option value="1">Inkomsten</option>
            <option value="2">Uitgaves</option>
        </select>
        <?php 
        } else {

// hier komt je enkel als je een type hebt gekozen            

            switch ($_SESSION["keuzetype"]) {
                case 1:
                    echo "<p>inkomst <a class='btn btn-outline-primary' href='?typeClear=1'>CLEAR</a></p>";
                    break;
                case 2:
                    echo "<p>uitgave <a class='btn btn-outline-primary' href='?typeClear=1'>CLEAR</a></p>";
                    break;
            }
?>
            <select name="typeIO" onchange="this.form.submit()">
            <option ><- maak uw keuze -></option>
<?php

            $sql = "SELECT * FROM typeinkomsten;";

            $result = $conn->query($sql);

            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {     
                    echo "<option value='".$row["idtypeVerrichting"]."'>" .$row["omschrijving"]. "</option>";
                }
            }
?>
            </select>
<?php
         }
?>
      </div>


    </main><!-- /.container -->
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
          <script>window.jQuery || document.write('<script src="/docs/4.4/assets/js/vendor/jquery.slim.min.js"><\/script>')</script><script src="/docs/4.4/dist/js/bootstrap.bundle.min.js" integrity="sha384-6khuMg9gaYr5AxOqhkVIODVIvm9ynTT5J4V1cfthmT+emCG6yVmEZsRHdxlotUnm" crossorigin="anonymous"></script>
    
    </body>

</html>