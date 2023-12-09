<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','student');
    $studentName=$_POST['search'];
    
    $sql="select ID,Name,Password,Reg,Class,Section from `student_table` where Name like '%$studentName%' ";
    $query=mysqli_query($con,$sql);
    $menuarray = array();

    if (mysqli_num_rows($query)>0)
    {
            while($row = mysqli_fetch_assoc($query)){
                $menuarray[] = $row;
        }
        echo json_encode($menuarray);
    }
    else
    {
        echo "Sorry, No student in this menu";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>