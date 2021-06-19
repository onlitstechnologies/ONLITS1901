/*Program to accept age of 5 students and find their average age*/


#include<stdio.h>

int main()
{
	int age, sum=0, avg, i;

	for(i=1; i<=5; i++)
	{
		printf("Enter age: ");
		scanf("%d",&age);
		sum = sum + age;
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
		1. All 5 ages are not available throughout the program.
*/

/*
	Data structure is a way of organising data in such a manner that it can be efficiently processed.
	The most basic datastructure is array.
	ADT: Abstract Data Types (Abstract means in breif without including details)
	Array, Queue, Stack, Linked List, Tree, Graph
	An average/mediocre programmer can become an expert programmer with the knowledge of data structure 
*/
