<?php
$con = new mysqli('localhost', 'john', '123', 'Bank1901');
if ($con->connect_error) {
    die($con->connect_error);
}
