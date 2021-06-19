/*
	Program to find whether an array occupies adjacent physical
	address in memory
*/

#include<stdio.h>

int main()
{
	char a[10], i;
	printf("Following are the address of each array element:\n");
	
	for(i=0; i<10; i++)
		printf("a[%d] = %p\n", i, &a[i]);
		
	return 0;
}
