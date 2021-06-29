#include<stdio.h>

void static_fun();          //function declaration/prototype

int main()
{
    int i;
    for(i=1; i<=5; i++)
        static_fun();          //function call
    return 0;
}

//function definition
void static_fun()
{
    static int a = 10;

    printf("The value of a is %d and its addres is %p.\n", a, &a);

    a++;
}