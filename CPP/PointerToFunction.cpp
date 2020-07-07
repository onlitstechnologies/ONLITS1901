//Program to demonstrate pointer to function
#include<iostream>
int add(int, int);
int subtract(int, int);

using namespace std;

int main()
{
    int (*p)(int, int);

    int s, d;

    p = add;

    s = (*p)(20,10);

    cout<<"The sum is "<<s<<endl;

    p = subtract;

    d = (*p)(20,10);   

    cout<<"The difference is "<<d<<endl; 

    return 0;
}

int add(int a, int b)
{
    return a + b;
}

int subtract(int a, int b)
{
    return a - b;
}