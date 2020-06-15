<?php
$servername = "localhost";
$username = "root";
$password = "usbw";
$dbname = "GIP";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
?>

<!DOCTYPE HTML>
<html>
	<head>
		<title>GIP Siebe</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
		<link rel="stylesheet" href="assets/css/main.css" />
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		<!--[if lte IE 9]><link rel="stylesheet" href="assets/css/ie9.css" /><![endif]-->
	</head>
	<body class="landing">

	<!-- Header -->
  <header id="header" class="alt">
				<h1><a href="index.html">Gip</a></h1>
				<a href="#nav">Menu</a>
			</header>

		<!-- Nav -->
			<nav id="nav">
				<ul class="links">
					<li><a href="index.html">Home</a></li>
					<li><a href="generic.html">about me</a></li>
					<li><a href="planning.html">Gip planning</a></li>
					<li><a href="elements.html">Gip werking</a></li>
					<li><a href="overzicht.php">Gip overzicht</a></li>
				</ul>
      </nav>
      <section id="banner">
				<i class="icon fa-diamond"></i>
			
			</section>
      

    <?php $keuze = $_POST['keuze'] ?>

  <form action="overzicht.php" method = 'POST'>
    <select id="keuze" name="keuze"> 
    <option value= "alles">alles</option>
    <option value= "aanwezig">aanwezig</option>
    <option value= "afwezig">afwezig</option>
  </select>
  <input type="submit" value="filter" id="submit_button"/>
    <br></br>

    

<div id="container" class="container">
  <table class="table">
    <thead class="thead-dark">
      <tr>
        <th scope="col">#</th>
        <th scope="col">voornaam</th>
        <th scope="col">naam</th>
        <th scope="col">tijd</th>
        <th scope="col">aanwezigheid</th>
      </tr>
    </thead>
    <tbody>
</div>


<?php
if ( $keuze == "aanwezig"){
  $sql = "SELECT * FROM controle WHERE aanwezigheid = 'aanwezig'";
}
if ($keuze == "afwezig"){
  $sql = "SELECT * FROM controle WHERE aanwezigheid = 'afwezig'";
}
if ($keuze == "alles"){
  $sql = "SELECT * FROM controle ";
}


$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    ?>  
    
  <tr>
        <td></td>
        <td><?php echo $row["voornaam"]?></td>
        <td><?php echo $row["naam"]?></td>
        <td><?php echo $row["tijd"]?></td>
        <td><?php echo $row["aanwezigheid"]?></td>
  </tr>
  <?php
  }
?>


<?php
} else {
  echo "0 results";
}
$conn->close();
?>

</div>
	<!-- Scripts -->
  <script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
			<script src="assets/js/main.js"></script>
</body>
</html>