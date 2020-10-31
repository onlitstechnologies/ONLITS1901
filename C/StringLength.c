//Program to find the length of a string without using library function

#include<stdio.h>

int main()
{
	char name[10];
	int i=0;
	
	printf("Please enter your first name: ");
	scanf("%s", name);
	
	while(name[i]!='\0')
	{
		i++;
	}
	
	printf("Your first name has %d characters.\n",i);
	
	return 0;
}
