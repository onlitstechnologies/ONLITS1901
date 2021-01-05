#include<stdio.h>

int main()
{
	char name[30];
	int i=0;
	
	printf("Please enter your name: ");
	scanf("%[^\n]", name);
	//gets(name);	//Dangerous as per GCC
	
	while(name[i] != '\0')
	{
		i++;
	}
	
	printf("Your name contains %d characters.\n", i);
	
	printf("You are not utilizing %d bytes of memory.\n", 30-i-1);
	
	return 0;
}


/*
	Why gets() is dangerous according to GCC documentation?
	In which languages array size may be modified?
	
	Quality = K, P, T
*/
