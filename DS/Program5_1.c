#include<stdio.h>

int LIST[20];
int LINK[20];
int START;
void PROCESS(int);

int main()
{
	int PTR;
	
	LIST[0] = 22; LIST[2] = 5; LIST[3] = 19; LIST[5] = 87; LIST[7] = 29; LIST[8] = 78;
	
	LINK[0] = 3; LINK[2] = 0; LINK[3] = 5; LINK[5] = 8 ; LINK[7] = -1; LINK[8] = 7;
	
	START = 2;
	
	PTR = START;
	
	printf("Initial List:\n");
	while(PTR!=-1)					//This is also traversal and here the process is display.
	{
		printf("%d\t", LIST[PTR]);
		PTR = LINK[PTR];
	}
	
	//------ printing modified list
	
	PTR = START;
	while(PTR!=-1)
	{
		PROCESS(PTR);				//Traversing LIST to apply PROCESS
		PTR = PTR[LINK];
	}
	
	
	PTR = START;
	printf("\nModified List:\n");
	while(PTR!=-1)					//This is also traversal and here the process is display.
	{
		printf("%d\t", LIST[PTR]);
		PTR = LINK[PTR];
	}
	
	return 0;	
}


void PROCESS(int P1)			//This is the traversal process as per the question
{
	LIST[P1] = LIST[P1] * 10;
}
