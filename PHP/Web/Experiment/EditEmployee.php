<?php
include 'Employee.php';
include 'Common.php';

$eid = $_GET['employee_id'];

$con = new mysqli('localhost', 'john', '123', 'Bank1901');
if ($con->connect_error) {
    die($con->connect_error);
}
$sql = "SELECT * FROM Employee WHERE Eid='$eid'";
$result = $con->query($sql);

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $ename = $row['EmployeeName'];
    $bcode = $row['BranchCode'];
    $gender = $row['Gender'];
    $mobile = $row['Mobile'];
    $state = $row['State'];
    echo "<script>alert('$state')</script>";
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>New Employee</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <header>
        <?php
        include 'Header.html';
        ?>
    </header>
    <form>
        <label for="employee_id">Employee Id</label>
        <input type="text" name="employee_id" id="employee_id" value="<?= $eid ?>">
        <button id="search">Search</button><br>
    </form>
    <form action="EditEmployeeSubmit.php">
        <input type="hidden" name="eid" value="<?= $eid ?>">
        <label for="employee_name">Employee Name</label>
        <input type="text" name="employee_name" id="employee_name" value="<?= $ename ?>"> <br>
        <label for="branch_code">Branch Code</label>
        <?php fetch_existing_branch($bcode); ?> <br> <br>
        <label for="gender">Gender</label>
        <input type="radio" name="gender" id="gender" <?php if($gender == 'M') {echo 'checked';}?> value='M'>Male
        <input type="radio" name="gender" id="gender" <?php if($gender == 'F') {echo 'checked';}?> value='F'>Female <br> <br>
        <label for="mobile_no">Mobile No</label>
        <input type="text" name="mobile_no" id="mobile_no" value="<?= $mobile?>"> <br>
        <label for="state">State</label>
        <?php fetch_existing_state($state); ?> <br> <br>
        <button id="submit">Submit</button>
        <button type="reset">Reset</button>
    </form>
</body>

</html>