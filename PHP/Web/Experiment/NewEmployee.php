<?php
include 'Employee.php';
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
    <form action="NewEmployeeSubmit.php">
        <label for="employee_id">Employee Id</label>
        <input type="text" name="employee_id" id="employee_id" readonly value="<?= generate_employee_id()?>"> <br>
        <label for="employee_name">Employee Name</label>
        <input type="text" name="employee_name" id="employee_name"> <br>
        <label for="branch_code">Branch Code</label> <br>
        <?php fetch_branch();?> <br> <br>
        <input type="radio" name="gender" id="gender" checked>Male
        <input type="radio" name="gender" id="gender">Female <br> <br>
        <button>Submit</button>
        <button type="reset">Reset</button>
    </form>
</body>
</html>