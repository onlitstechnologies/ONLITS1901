#include<iostream>
#include<fstream>
#include<iomanip>

using namespace std;

class INVENTORY
{
	int code;
	char name[10];
	float cost;
public:
	void readdata();
	void writedata();
};

void INVENTORY::readdata()
{
	cout<<"Enter item code: ";
	cin>>code;
	cout<<"Enter item name: ";
	cin>>name;
	cout<<"Enter cost: ";
	cin>>cost;
}
void INVENTORY::writedata()
{
	cout<<setw(10)<<code;
	cout<<setw(10)<<name;
	cout<<std::fixed<<setprecision(2)<<setw(10)<<cost;
	cout<<endl;
}


int main()
{
	INVENTORY item[3];
	
	fstream file;
	
	file.open("STOCK.DAT", ios::in | ios::out);
	
	cout<<"ENTER DETAILS FOR THREE ITEMS"<<endl;
	for(int i=0; i<3; i++)
	{
		item[i].readdata();
		
		file.write((char*) &item[i], sizeof(item[i]));				//Writing object to file
	}
	
	cout<<endl<<"OUTPUT"<<endl<<endl;
	
	for(int i=0; i<3; i++)
	{
		file.read((char*) &item[i], sizeof(item[i]));			//reading object from file
		item[i].writedata();
	}
	
	return 0;
}
