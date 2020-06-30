//How to display the address of a variable in C

#include<stdio.h>

int main()
{
	int a=10;
	
	printf("The value of a is %d.\n",a);
	printf("The address of a is %p.\n",&a);
	
	return 0;
}




/*
	- Pointer is a special variable which stores the address of another variable.
	- %d is known as control string or format string.
	- Memory addresses are hexadecimal numbers
	
	- Hexadecimal numbers are represented by prefixing 0x (eg. 0x7fffb8eb8b24)
	- Octal number are represented by prefixing 0.	07865
	- C and Java are very important from interview point of view.
*/
