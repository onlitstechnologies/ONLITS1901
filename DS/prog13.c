/*
	WAP to accept 5 integers and arrange them in ascending order.
*/

#include<stdio.h>
#include<string.h>

char* notoword(int x);

int main()
{
	//int in[5];
	int i,j,t,no=10;
	
	int in[no];
	
	char word[30];
	
	strcpy(word, notoword(no));
	
	printf("Please enter %s integers below:\n", word);
	
	//---Taking user input
	for(i=0;i<no;i++)
		scanf("%d",&in[i]);
	
	//--- Sorting using bubble sort
	for(i=0;i<no-1;i++)
	{
		for(j=0;j<no-1;j++)
		{
			if(in[j] > in[j+1])
			{
				t = in[j];
				in[j] = in[j+1];
				in[j+1] =  t;
			}
		}
	}
	
	//Display sorted array
	
	printf("The sorted array is:\n");
	for(i=0;i<no;i++)
		printf("%d\n",in[i]);
		
	return 0;
}

char* notoword(int x)
{
	switch(x)
	{
		case 5:
			return "five";
			
		case 10:
			return "ten";
	}
}

/*
	- Time consuming
	- Difficult to maintain
	
	
	
	Which way is more flexible: variable or array?
	
	WAP to accept an amout in figures and display it in words.
	
*/
