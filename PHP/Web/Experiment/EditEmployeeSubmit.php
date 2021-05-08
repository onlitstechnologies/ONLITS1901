<?php
$eid = $_GET['eid'];
echo $eid;
$ename = $_GET['employee_name'];
$con = new mysqli('localhost','john','123','Bank1901');
if($con->connect_error) {
    die($con->connect_error);
}
$sql = "UPDATE Employee SET EmployeeName='$ename' WHERE Eid='$eid'";
if($con->query($sql)==true) {
    echo "Data Updated Successfully!";
} else {
    echo $con->error;
}