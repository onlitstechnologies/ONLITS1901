<?php
$n = readline("Enter a number: ");	//Console Input
$f=1;
for($i=$n; $i>1; $i--) {
	$f = $f * $i;
}

echo "The factorial of $n is $f.\n";

/*
	We do not have to declare variables. (dynamic typing)
	We cannot use variables without initializing.
	We do not have main function here.
*/
