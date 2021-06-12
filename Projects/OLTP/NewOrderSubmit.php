<?php
try {
    include 'Connect.php';
    $item_id = $_POST['item_id'];
    $qty = $_POST['quantity'];
    $con -> setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $sql = "INSERT INTO orders(item_id, quantity) VALUES($item_id,$qty)";
    $con->exec($sql);
    echo "<script>alert('Data inserted successfully');</script>";
    echo "<script>window.location.href='NewOrder.html';</script>";
} catch (PDOException $e) {
    echo $e->getMessage();
}
$con = null;