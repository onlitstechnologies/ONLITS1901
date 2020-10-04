#include<iostream>

using namespace std;

using namespace test_space;

namespace test_space
{
	class test_class
		{
			int m;
		public:
			void display(int n)
			{
				m=n;
				cout<<m<<endl;
			}
		};
	namespace test_subspace				//Nesting of namespace
	{
		class test_class
		{
			int m;
		public:
			void display(int n)
			{
				m=n;
				cout<<m<<endl;
			}
		};
	}
}

namespace test_space2
{

	class test_class
	{
		int m;
		
	public:
		void display()
		{
			m=10;
			cout<<m<<endl;
		}
	};
}

int main()
{
	test_space::test_class t;
	
	t.display(20);
	
	test_space2::test_class t2;
	
	t2.display();
	
	test_space::test_subspace::test_class t3;
	
	t3.display(30);

	return 0;
}
