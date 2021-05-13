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
        <?php
        include 'Connect.php';
        $sql = "SELECT * FROM Employee";
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
                echo "<tr>";
                echo '    <td>' . $row["Eid"] . '</td>';
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
    </div>
</body>

</html>