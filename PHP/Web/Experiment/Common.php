<?php
function fetch_state()
{
    include 'Connect.php';
    $sql = "SELECT State FROM State";
    $result = $con->query($sql);
    echo '<select name="state" id="state">';
    while ($row = $result->fetch_array()) {
        $state = $row[0];
        echo  '<option value="' . $state . '">' . $state . '</option>';
    }
    echo '</select>';
    $con->close();
}

function fetch_existing_state($p_state)
{
    include 'Connect.php';
    $sql = "SELECT State FROM State";
    $result = $con->query($sql);
    echo '<select name="state" id="state">';
    while ($row = $result->fetch_array()) {
        $state = $row[0];
        //echo "<script>alert('$state')</script>";
        //echo "<script>alert('$p_state')</script>";
        if ($state == $p_state)
            echo  '<option value="' . $state . '" selected>' . $state . '</option>';
        else
            echo  '<option value="' . $state . '">' . $state . '</option>';
    }
    echo '</select>';
    $con->close();
}
