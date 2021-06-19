/*
	Program to find the length of a string with library function
*/

#include<stdio.h>
#include<string.h>

int main()
{
	char str[30];		//'\0' -null character
	int len;
	
	printf("Please enter a string: ");
	scanf("%s",str);
	
	len = strlen(str);
	
	printf("The string %s has %d characters.\n",str,len);
	
	return 0;
}


/*Re-write this program in c++ using ADT string*/



