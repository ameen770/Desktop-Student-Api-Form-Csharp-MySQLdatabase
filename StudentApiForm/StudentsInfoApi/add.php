<?php
include 'conn.php';

$studentName=$_POST['name'];
$studentPassword=$_POST['password'];
$studentReg=$_POST['reg'];
$studentClass=$_POST['iClass'];
$studentSection=$_POST['section'];
$response = array();

$query = mysqli_query($con, "INSERT INTO student_table(Name,Password,Reg,Class,Section) VALUES ('$studentName','$studentPassword','$studentReg','$studentClass','$studentSection')");

if($query){
  // $response['success'] = 'true';
  $response['Done'] = 'Data Inserted Successfully';
}else{
  $response['success'] = 'false';
  $response['message'] = 'Data Insertion Failed';
}

echo json_encode($response);
?>
