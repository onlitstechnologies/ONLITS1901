//Program to demonstrate Pointer to two dimensional array using matrix example

#include<iostream>

using namespace std;

int main()
{
    int matrix[3][3], *p[3];

    p[0] = matrix[0];
    p[1] = matrix[1];
    p[2] = matrix[2];

    cout<<"Enter elements of a 3 X 3 matrix below:"<<endl;

    for(int i=0; i<3; i++)
    {
        for(int j=0; j<3; j++)
        {
            cout<<"["<<i<<"]["<<j<<"] ";
            cin>>*p[i];
            (*p[i])++;
        }
    }

    cout<<"The enter matrix is:"<<endl;

    for(int i=0; i<3; i++)
    {
        for(int j=0; j<3; j++)
        {
            cout<<*p[i]<<" "<<&matrix[i][j]<<" ";
            (*p[i])++;
        }
        cout<<endl;
    }

    return 0;
}