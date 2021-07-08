#include<iostream>
#include<cstdlib>
using namespace std;
int main()
{
    int n, *arr;
    cout<<"Enter the size of array: ";
    cin>>n;
    //arr = (int*)malloc(n * sizeof(int));        //C-Style Dynamic Memory Allocation
    arr = new int[n];                             //C++ - Style DMA
    cout<<"Enter "<<n<<" values below:"<<endl;
    for(int i=0; i<n; i++)
    {
        cin>>arr[i];
    }

    cout<<"The elements of the array are:"<<endl;
    for(int i=0; i<n; i++)
    {
        cout<<arr[i]<<endl;
    }
    return 0;
}