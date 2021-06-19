/*
	Algorithm 4.1.: TRAVERSING A LINEAR ARRAY
*/
#include<stdio.h>

int main()
{
	int lb=0, ub=4, k;
	int la[] = {45, 3, 85, 96, 105};
	k=lb;
	while(k<=ub)
	{
		printf("%d\n", la[k]);
		k++;
	}
	return 0;
}
