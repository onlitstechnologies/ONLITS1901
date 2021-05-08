<?php
function generate_employee_id()
{
    include 'Connect.php';
    $sql = "SELECT Eid FROM Employee ORDER BY Eid DESC LIMIT 1";
    $result = $con->query($sql);
    if ($result->num_rows > 0) {
        $row = $result->fetch_array();
        $cur_id = $row[0];
        $cur_id = substr($cur_id, 1);
        $next_id = $cur_id + 1;
        $next_id = 'E00' . $next_id;
        return $next_id;
    }
    $con->close();
}

function fetch_branch()
{
    include 'Connect.php';
    $sql = "SELECT BranchCode FROM Branch";
    $result = $con->query($sql);
    echo '<select name="branch_code" id="branch_code">';
    while ($row = $result->fetch_array()) {
        $bcode = $row[0];
        echo  '<option value="' . $bcode . '">' . $bcode . '</option>';
    }
    echo '</select>';
    $con->close();
}
