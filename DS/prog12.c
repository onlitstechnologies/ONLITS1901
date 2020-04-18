#include<stdio.h>
#include "prog11.c"

int main()
{
	struct date d;

	d.dd = 11;
	d.mm = 4;
	d.yyyy = 2020;

	printf("Today's date is %d/%d/%d.\n",d.dd,d.mm,d.yyyy);

	return 0;
}
