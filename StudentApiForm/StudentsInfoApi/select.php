<?php
include 'conn.php';
$query = mysqli_query($con, "SELECT ID,Name,Password,Reg,Class,Section FROM `student_table`");
$data = array();
$qry_array = array();
$i = 0;
$total = mysqli_num_rows($query);
while ($row = mysqli_fetch_array($query)) {
  $data['id'] = $row['ID'];
  $data['name'] = $row['Name'];
  $data['password'] = $row['Password'];
  $data['reg'] = $row['Reg'];
  $data['iClass'] = $row['Class'];
  $data['section'] = $row['Section'];
  $qry_array[$i] = $data;
  $i++;
}

if($query){
  // $response['success'] = 'true';
  $response['Good'] = 'Data Loaded Successfully';
  $response['total'] = $total;
  $response['data'] = $qry_array;
}else{
  $response['success'] = 'false';
  $response['message'] = 'Data Loading Failed';
}

echo json_encode($response);
?>
