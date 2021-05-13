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