/*
	Algorithm 4.1.: TRAVERSING A LINEAR ARRAY
*/
#include<stdio.h>

int main()
{
	int lb=0, ub=9, k;
	int la[10] = {45, 3, 85, 96, 105};
	
	for(k=lb;k<=ub;k++)
	{
		printf("%d\n", la[k]);
	}
	
	la[14] = 97;
	printf("%d\n",la[14]);
	return 0;
}
