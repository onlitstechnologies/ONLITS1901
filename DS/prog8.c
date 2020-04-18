#include<stdio.h>

void input();
void print();

struct time
{
	int hh;
	int mm;
	int ss;


	void input()
	{
		printf("Enter hours: ");
		scanf("%d",&t1.hh);

		printf("Enter minutes: ");
		scanf("%d",&t1.mm);

		printf("Enter seconds: ");
		scanf("%d",&t1.ss);
	}


	void print()
	{
		printf("\nYou have entered the following time:\n");
		printf("%d:%d:%d\n",t1.hh,t1.mm,t1.ss);
	}
}t1;


int main()
{
	t1.input();
	t1.print();
	return 0;
}
