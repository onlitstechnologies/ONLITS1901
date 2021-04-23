<?php
$output = shell_exec('ls');
echo $output;
$output = shell_exec('sudo gcc Address.c -o Address.out');
echo $output;

echo "Aal is Well!";
