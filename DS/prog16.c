/*
	PROGRAM TO ACCEPT 5 INTEGER AND DISPLAY THE LARGEST ONE
*/

#include<stdio.h>

int main()
{
	int integers[5] = {25,100,7,67,152};
	int largest=integers[0], i;
	
	for(i=1; i<5; i++)
	{
		if(integers[i]>largest)
			largest = integers[i];
	}
	
	printf("The largest of ");
	
	for(i=0; i<5; i++)
	{
		printf("%d, ",integers[i]);
	}
	
	printf("is: %d.\n", largest);
	
	return 0;
}

/*
	Correct Answer:
	The largest of 25, 100, 7, 67, 52, is: 100
*/
