<?php
// Create 4 variables to store these information
$server="localhost";
$username="root";
$password="";
$database = "student";
// Create connection
$con = new mysqli($server, $username, $password, $database);
// Check connection
if ($con->connect_error) {
  die("Connection failed: " . $con->connect_error);
}
?>
