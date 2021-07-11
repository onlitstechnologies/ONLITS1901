#include <iostream>
#include <cmath>
using namespace std;

class shape
{
public:
    const float PI = 3.14F;
    virtual void input() = 0; //pure virtual function
    virtual float area() = 0;
};

class circle : public shape
{
    float rad;

public:
    void input()
    {
        cout << "Enter radius: ";
        cin >> rad;
    }
    float area()
    {
        return PI * rad * rad;
    }
};

class rectangle : public shape
{
    float l, b;
public:
    void input()
    {
        cout<<"Enter length: ";
        cin>>l;
        cout<<"Enter breadth: ";
        cin>>b;
    }
    float area()
    {
        return l * b;
    }
};

class triangle : public shape
{
    float a, b, c, s;
public:
    void input()
    {
        cout<<"Enter the value of a: ";
        cin>>a;
        cout<<"Enter the value of b: ";
        cin>>b;
        cout<<"Enter the value of c: ";
        cin>>c;
    }

    float area()
    {
        s = (a + b + c)/2;
        return sqrt(s*(s-a) * (s-b) * (s-c));
    }
};

int main()
{
    shape *s = new circle();
    s->input();
    cout<<"The are of circle is "<<s->area()<<endl;

    s = new rectangle();
    s->input();
    cout<<"The area of rectangle is "<<s->area()<<endl;

    s = new triangle();
    s->input();
    cout<<"The area of triange is "<<s->area()<<endl;
}