<?php
$servername = "localhost";
$username = "root";
$password = "";
$database = "assignment04";
$connection = mysqli_connect($servername, $username, $password, $database);
if(!$connection) 
{die("Failed to Setup the Connection: " . mysqli_connect_error());}
?>	
