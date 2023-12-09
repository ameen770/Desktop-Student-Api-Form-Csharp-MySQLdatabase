<?php
// Check if email and password are set
if(isset($_POST['name']) && isset($_POST['password'])){
    // Include the necessary files
    require_once "conn.php";
    require_once "validate.php";
    // Call validate, pass form data as parameter and store the returned value
    $name = validate($_POST['name']);
    $password = validate($_POST['password']);
    // Create the SQL query string
    $sql = "select Name,Password from student_table where Name='$name' and Password='$password'";
    // Execute the query
    $result = $con->query($sql);
    // If number of rows returned is greater than 0 (that is, if the record is found), we'll print "success", otherwise "failure"
// ===========================================================
    // if (empty($name)) {

        // header("Location: login.php?error=User Name is required");

        // exit();

    // }else if(empty($password)){

        // header("Location: login.php?error=Password is required");

        // exit();
    // }
// ======================================================================
    if($result->num_rows > 0){
        echo "success";
    } else{
        // If no record is found, print "failure"
        echo "failure";
    }
}
?>