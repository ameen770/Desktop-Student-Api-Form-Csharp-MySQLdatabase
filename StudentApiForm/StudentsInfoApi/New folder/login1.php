<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','studentapi');
    $username=$_POST['name'];
    $password=$_POST['password'];
    
    $sql="select Name,Password from users where Name='$username' and Password='$password' ";
    $query=mysqli_query($con,$sql);

    if (mysqli_num_rows($query)>0)
    {
        echo "1"; 
    }
    else
    {
        echo "Sorry, you are not registered yet";
    }
}
else 
{
    echo "No data enterd :(";
}

?>