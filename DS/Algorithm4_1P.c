/*
	Algorithm 4.1.: TRAVERSING A LINEAR ARRAY
*/
#include<stdio.h>

int main()
{
	int lb=0, ub=5, k;
	int la[10] = {45, 3, 85, 96, 105};
	
	for(k=lb;k<ub;k++)
	{
		printf("%d\n", la[k]);
	}
	
	return 0;
}
