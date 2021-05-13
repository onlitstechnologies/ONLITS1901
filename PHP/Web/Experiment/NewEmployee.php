<?php
include 'Employee.php';
include 'Common.php';
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
    <form action="NewEmployeeSubmit.php">
        <label for="employee_id">Employee Id</label>
        <input type="text" name="employee_id" id="employee_id" readonly value="<?= generate_employee_id() ?>"> <br>
        <label for="employee_name">Employee Name</label>
        <input type="text" name="employee_name" id="employee_name" required> <br>
        <label for="branch_code">Branch Code</label>
        <?php fetch_branch(); ?> <br> <br>
        <label for="gender">Gender</label>
        <input type="radio" name="gender" id="gender" checked value='M'>Male
        <input type="radio" name="gender" id="gender" value='F'>Female <br> <br>
        <label for="mobile_no">Mobile No</label>
        <input type="text" name="mobile_no" id="mobile_no"> <br>
        <label for="state">State</label>
        <?php fetch_state(); ?> <br> <br>
        <button>Submit</button>
        <button type="reset">Reset</button>
    </form>
</body>

</html>