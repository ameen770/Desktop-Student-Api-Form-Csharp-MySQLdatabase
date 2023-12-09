<?php

if(isset($_POST))
{ 
    include "conn.php";
    $studentName=$_POST['name'];
    $sql="select ID,Name,Password,Reg,Class,Section from `student_table`";
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