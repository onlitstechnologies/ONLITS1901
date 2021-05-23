<?php
include 'Employee.php';
$gender = $_GET['gender'];
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee List</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <header>
        <?php
        include 'Header.html';
        ?>
    </header>

    <div>
        <form action="">
            <select name="gender" id="gender" onchange="form.submit();">
                <option value="M" <?php if ($gender == 'M') {
                                        echo 'selected';
                                    } ?>>Male</option>
                <option value="F" <?php if ($gender == 'F') {
                                        echo 'selected';
                                    } ?>>Female</option>
            </select>
            <?php
            fetch_branch();
            ?>
            <?php
            include 'Connect.php';
            if (isset($_GET['gender']) == true) {
                $sql = "SELECT * FROM Employee WHERE Gender='" . $_GET['gender'] . "'";
            } elseif (isset($_GET['branch_code']) == true) {
                $sql = "SELECT * FROM Employee WHERE BranchCode='" . $_GET['branch_code'] . "'";
            } else {
                $sql = "SELECT * FROM Employee";
            }
            $result = $con->query($sql);
            if ($result->num_rows > 0) {
                echo '<table class="list">';
                echo "<tr>";
                echo "    <th>Employee Id</th>";
                echo "    <th>Employee Name</th>";
                echo "    <th>Branch Code</th>";
                echo "    <th>Gender</th>";
                echo "    <th>Mobile</th>";
                echo "    <th>State</th>";
                echo "</tr>";
                while ($row = $result->fetch_assoc()) {
                    $eid = $row["Eid"];
                    echo "<tr>";
                    echo '    <td><a href="EditEmployeeEmployeeList.php?employee_id=' . $eid . '">' . $row["Eid"] . '</a></td>';
                    echo '    <td>' . $row["EmployeeName"] . '</td>';
                    echo '    <td>' . $row["BranchCode"] . '</td>';
                    echo '    <td>' . $row["Gender"] . '</td>';
                    echo '    <td>' . $row["Mobile"] . '</td>';
                    echo '    <td>' . $row["State"] . '</td>';
                    echo "</tr>";
                }
                echo "</table>";
            } else {
                echo "No data found";
            }
            $con->close();
            ?>
        </form>
    </div>
    <script>
        let bcode = document.getElementById('branch_code');
        bcode.onchange = function() {
            form.submit();
        }
    </script>
</body>

</html>