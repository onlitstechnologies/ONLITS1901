<?php
include 'Header.html';
$eid = $_GET['eid'];
echo $eid;
$ename = $_GET['employee_name'];
$bcode = $_GET['branch_code'];
$gender = $_GET['gender'];
$mobile = $_GET['mobile_no'];
$state = $_GET['state'];

$con = new mysqli('localhost','john','123','Bank1901');
if($con->connect_error) {
    die($con->connect_error);
}
$sql = "UPDATE Employee SET EmployeeName='$ename', BranchCode='$bcode', Gender='$gender', Mobile='$mobile', State='$state' WHERE Eid='$eid'";
if($con->query($sql)==true) {
    echo "Data Updated Successfully!";
} else {
    echo $con->error;
}