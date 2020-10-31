/*Program to traverse a linear array*/

#include<stdio.h>

int main()
{
	int no[] = {56, 76, 5, 12, 99, 33, 20, 1, 101, 88};
	int i;
	
	printf("The array contains the following elements:\n");
	
	for(i=0; i<=10; i++)
	{
		if(i<10)		//validation
			printf("%d\n",no[i]);
	}
	
	return 0;
}


/*
In C array bound checking is not done by the compiler, hence,
programmers have to do it by themselves.
*/
