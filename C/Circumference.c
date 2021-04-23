#include<stdio.h>
#include "MyLib.c"
int main()
{
	float r, c;
	printf("Enter radius: ");
	scanf("%f", &r);
	c = 2 * pi() * r;
	printf("The circumference is %1.2f.\n", c);
	return 0;
}
