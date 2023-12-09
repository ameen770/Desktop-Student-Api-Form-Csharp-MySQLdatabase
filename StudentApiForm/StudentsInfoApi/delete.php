<?php
include 'conn.php';

$studentID=$_POST['id'];

$query = mysqli_query($con, "DELETE FROM student_table WHERE ID = '$studentID'");

if($query){
  // $response['success'] = 'true';
  $response['Done'] = 'Data Deleted Successfully';
}else{
  $response['success'] = 'false';
  $response['message'] = 'Data Deletion Failed';
}

echo json_encode($response);
?>
