#include<iostream>
void swap(int x, int y);		//protype is very important

using namespace std;

int main()
{
    int a=20, b=10;
    swap(a, b);
    cout<<"Values of a and b after swapping "<<a<<", "<<b<<", respectively."<<endl;
}

void swap(int x, int y)
{
    int t = x;
    x = y;
    y = t;
    //cout<<"Values of a and b after swapping "<<x<<", "<<y<<", respectively."<<endl;
}

/*

	Swapping didn't occur as the the values of a and b we copied
	to x and y.

*/
