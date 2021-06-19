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
		scanf("%d",&hh);

		printf("Enter minutes: ");
		scanf("%d",&mm);

		printf("Enter seconds: ");
		scanf("%d",&ss);
	}


	void print()
	{
		printf("\nYou have entered the following time:\n");
		printf("%d:%d:%d\n",hh,mm,ss);
	}
};


int main()
{
	struct time t1;
	t1.input();
	t1.print();
	return 0;
}
