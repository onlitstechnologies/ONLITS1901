<?php
$eid = $_GET['employee_id'];
$ename = null;
$con = new mysqli('localhost', 'john', '123', 'Bank1901');
if ($con->connect_error) {
    die($con->connect_error);
}
$sql = "SELECT * FROM Employee WHERE Eid='$eid'";
$result = $con->query($sql);

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $ename = $row['EmployeeName'];
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
    <form>
        <label for="employee_id">Employee Id</label>
        <input type="text" name="employee_id" id="employee_id" value="<?= $eid?>">
        <button id="search">Search</button><br>
    </form>
    <form action="EditEmployeeSubmit.php">
        <input type="hidden" name="eid" value="<?= $eid?>">
        <label for="employee_name">Employee Name</label>
        <input type="text" name="employee_name" id="employee_name" value="<?= $ename?>"> <br>
        <label for="branch_code">Branch Code</label>
        <input type="text" name="branch_code" id="branch_code">
        <button id="submit">Submit</button>
        <button type="reset">Reset</button>
    </form>
</body>

</html>