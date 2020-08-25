#include<stdio.h>

int main()
{
	char c;
	FILE  *fp;		//fp is pointer to structure popularly known as file pointer
	fp = fopen("FirstFile","w");
	printf("Please type some text below:\n");
	while(c=getchar() != EOF)
	{
		putc(c, fp);		//file
		//putchar(c);			//console
	}		
	printf("Entered information successfully saved in the file: FirstFile\n");		
	fclose(fp);
}






/*
	If FILE is a structure then why are we not writing it as struct FILE by only FILE
	FILE is created dynamically and its reference/address is returned
*/
