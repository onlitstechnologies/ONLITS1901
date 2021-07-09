#include<iostream>
using namespace std;

class shape
{
public:
    virtual void input() = 0;       //pure virtual function
    float area();
};

class circle : public shape
{
    float rad;
public:
    void input()
    {
        cout<<"Enter radius: ";
        cin>>rad;
    }

};

class rectangle
{


};

class triangle
{

};

int main()
{
    shape *s = new circle();
    s->input();
}