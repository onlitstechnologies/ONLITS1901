#include <iostream>
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
    cout<<"The are of circle is "<<s->area()<<endl;
}