<?php
include 'conn.php';

$studentID=$_POST['id'];
$studentName=$_POST['name'];
$studentPassword=$_POST['password'];
$studentReg=$_POST['reg'];
$studentClass=$_POST['iClass'];
$studentSection=$_POST['section'];

$query = mysqli_query($con, "UPDATE student_table SET Name = '$studentName', Password = '$studentPassword', Reg = '$studentReg', Class = '$studentClass', Section = '$studentSection' WHERE ID = '$studentID'");

if($query){
  // $response['success'] = 'true';
  $response['Done'] = ' Data Updated Successfully ';
}else{
  $response['success'] = 'false';
  $response['message'] = 'Data Updation Failed';
}

echo json_encode($response);
?>
