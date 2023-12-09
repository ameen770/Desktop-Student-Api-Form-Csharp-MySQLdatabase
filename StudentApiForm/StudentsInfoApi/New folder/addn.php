<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','student');
    $studentName=$_POST['name'];
    $studentPassword=$_POST['password'];
    $studentReg=$_POST['reg'];
    $studentClass=$_POST['iClass'];
    $studentSection=$_POST['section'];

    $sql="insert into student_table(Name,Password,Reg,Class,Section) values('$studentName','$studentPassword','$studentReg','$studentClass','$studentSection')";
    
    if(mysqli_query($con,$sql))
    {
        echo "Added successfuly";
    }
    else
    {
        echo  "An error Accured";
    }
}
?>