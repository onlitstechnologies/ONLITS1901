#include<stdio.h>

void input();
void print();

class time
{
	int hh;
	int mm;
	int ss;

	public:
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
	time t1;			//-----------------> here t1 is an object
	int a;   			//-----------------> here int is data type specifier (specification)
	t1.input();
	t1.print();
	return 0;
}


/*
	time t1;			data type specifier ------> time
	int a;				data type specifier ------> int

*/
