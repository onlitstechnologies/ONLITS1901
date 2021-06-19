/*
	Algorithm 4.1.: TRAVERSING A LINEAR ARRAY
*/
#include<iostream>

using namespace std;

int main()
{
	int lb=0, ub=9, k;
	int la[10] = {45, 3, 85, 96, 105};
	
	for(k=lb;k<=ub;k++)
	{
		cout<<la[k]<<endl;
	}
	
	la[14] = 97;
	cout<<la[14]<<endl;
	return 0;
}
