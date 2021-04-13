#include<iostream>
using namespace std;
class node
{
	int number;
	node* left;
	node* right;
public:
	node()
	{
	
	}
	node(int n)
	{
		number=n;
		left = NULL;
		right = NULL;
	}
	node* create_node(int no, int left, int right);
	void display(node* r);
};

node* node :: create_node(int no, int left, int right)
{
	node* n = new node();
	n->number = no;
	n->left = new node(left);
	n->right = new node(right);
	return n;	
}

void node :: display(node* r)
{
	cout<<"   "<<r->number<<endl;
	cout<<" /    \\"<<endl;
	cout<<r->left->number<<"\t"<<r->right->number<<endl;
}

int main()
{
	node* root = root->create_node(10, 20, 30);
	//root->left = root->create_node(20);
	//root->right = root->create_node(30);
	root->display(root);
	return 0;
}
