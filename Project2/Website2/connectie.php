<?php
session_start();

    $_SESSION["actief"];

    $servername = "localhost";
    $username = "root";
    $password = "usbw";
    $dbname = "project2";
    $port = "3307";

    $debug = false;

    $conn = new mysqli($servername, $username, $password, $dbname, $port);

    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    } 
?>