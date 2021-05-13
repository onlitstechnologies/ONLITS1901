<?php

$eid = $_GET['employee_id'];
$ename = $_GET['employee_name'];
$bcode = $_GET['branch_code'];
$gender = $_GET['gender'];
$mobile = $_GET['mobile_no'];
$state = $_GET['state'];

$con = new mysqli('localhost','john','123','Bank1901');
if($con->connect_error) {
    die($con->connect_error);
}
$sql = "INSERT INTO Employee VALUES('$eid','$ename', '$bcode', '$gender', '$mobile', '$state')";
if($con->query($sql)==true) {
    echo "Data Inserted Successfully!";
} else {
    echo $con->error;
}
