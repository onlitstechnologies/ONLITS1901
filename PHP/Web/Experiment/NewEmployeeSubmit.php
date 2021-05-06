<?php
$eid = $_GET['employee_id'];
$ename = $_GET['employee_name'];
$con = new mysqli('localhost','john','123','Bank1901');
if($con->connect_error) {
    die($con->connect_error);
}
$sql = "INSERT INTO Employee(Eid, EmployeeName) VALUES('$eid','$ename')";
if($con->query($sql)==true) {
    echo "Data Inserted Successfully!";
} else {
    echo $con->error;
}
