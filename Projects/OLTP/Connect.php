<?php
$con = new PDO("sqlite:OLTP.900");
echo "Connected successfully";
$sql = "INSERT INTO orders(item_id, quantity) VALUES(1,10)";
$con->query($sql);
echo "Data inserted successfully";