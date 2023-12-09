<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','student');
    $studentID=$_POST['id'];
    $studentName=$_POST['name'];
    $studentReg=$_POST['reg'];
    $studentClass=$_POST['iclass'];
    $studentSection=$_POST['section'];

    $sql="UPDATE student_table SET Name = '$studentName', Reg = '$studentReg', Class = '$studentClass', Section = '$studentSection' WHERE ID = '$studentID'";
    
    if(mysqli_query($con,$sql))
    {
        echo "Updated successfuly";
    }
    else
    {
        echo  "An error Accured";
    }
}
?>