#include<stdio.h>
#include<stdlib.h>

void push();
void pop();
void display();
void menu();

int stack[10];
int size=0;

int main()
{
	menu();
	return 0;	
}

void menu()
{
	int ch;
	printf("Main Menu\n");
	printf("1. Push\n");
	printf("2. Pop\n");
	printf("3. Display\n");
	printf("4. Exit\n");
	printf("Enter choice: ");
	scanf("%d",&ch);
	
	switch(ch)
	{
		case 1:
			push();
			break;
		case 2:
			pop();
			break;
		case 3:
			display();
			break;
		case 4:
			exit(0);
			break;
		default:
			printf("Invalid option! Please retry!\n");
			menu();
	}
}

void push()
{
	int no, i;
	printf("Enter a number: ");
	scanf("%d", &no);
	
	if(size>10)
	{
		//stack overflow
	}
	
	if(size==0)
	{
		stack[0] = no;
	}
	else
	{
		for(i=size-1; i>=0;i--)
		{
			stack[i+1] = stack[i]; 
		}
		stack[0] = no;
	}
	size++;
	menu();
}

void pop()
{
	
	size--;
	menu();
}

void display()
{
	int i;
	printf("The stack status is:\n");
	for(i=0; i<size; i++)
	{
		printf("%d\n", stack[i]);
	}
	menu();
}
