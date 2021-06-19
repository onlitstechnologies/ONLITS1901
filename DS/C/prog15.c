/*
	Program to find the length of a string with library function
*/
#include<stdio.h>

int slen(char[]);

int main()
{
	char str[30];		//'\0' -null character
	int len;
	
	printf("Please enter a string: ");
	scanf("%s",str);
	
	printf("The size of str is %ld bytes.\n",sizeof(str));
	
	len = slen(str);
	
	printf("The string %s has %d characters.\n",str,len);
	
	return 0;
}


int slen(char s[])
{
	int i=0;
	
	printf("The size of s is %ld bytes.\n",sizeof(s));
	
	while(s[i]!='\0')
	{
		i++;	
	}
	
	return i;
}
