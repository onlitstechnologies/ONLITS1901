/*Program to accept age of 5 students and find their average age using array*/



#include<stdio.h>

int main()
{
	int age[5], sum=0, avg, i;

	a[0] = 10;

	for(i=0; i<5; i++)
	{
		printf("Enter age: ");
		scanf("%d",&age[i]);
		sum = sum + age[i];
	}
	avg = sum/5;

	printf("The average age is %d.",avg);

	return 0;
}


/*
	pros:
		1. Consumes less memory
		2. Simple
		3. Easily modifiable
	cons:
*/

/*
	Data structure is a way of organising data in such a manner that it can be efficiently processed.
	The most basic datastructure is array.
	ADT: Abstract Data Types (Abstract means in breif without including details)
	Array, Queue, Stack, Linked List, Tree, Graph
	An average/mediocre programmer can become an expert programmer with the knowledge of data structure 
*/


/*
	
*/
