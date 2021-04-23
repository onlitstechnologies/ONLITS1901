#include<stdio.h>
#include<stdlib.h>
int main()
{
	printf("Running ls command:\n");
	system("ls -l");
	printf("Running date command:\n");
	system("date");
	printf("Compiling Address.c:\n");
	int err = system("gcc Address.c -o Address.out");
	printf("\n%d\n\n", err);

	if(err==0)
	{
		printf("Running Address.out:\n");
		system("./Address.out");
	}
	return 0;
}
