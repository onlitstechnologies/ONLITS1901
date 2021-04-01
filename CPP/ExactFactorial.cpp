#include<iostream>
using namespace std;
int main()
{
	int i=1, f=1, n;
	cin>>n;
	while(i<=n)
	{
		f=f*i;
		i=i+1;
	}
	cout<<f;
}
