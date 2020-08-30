#include<iostream>
#include<cstdio>
#include<fstream>

using namespace std;

int main()
{
	string str;
	ofstream  fout;		//fin is an object of ofstream class
	
	//-------WRITING CONTENT TO A FILE
	fout.open("FirstFile.txt");
	cout<<"Please type some text below:"<<endl;
	getline(cin, str);
	//gets(str);
	//fflush(stdin);
	fout<<str;
	cout<<"Entered information successfully saved in the file: FirstFile"<<endl;		
	fout.close();
	
	
	//------READING CONTENT FROM A FILE
	cout<<"To view the content of FirstFile press any key..."<<endl;
	fflush(stdin);
	getchar();
	ifstream fin;
	fin.open("FirstFile.txt");
	cout<<"FirstFile contains the following text:"<<endl;
	getline(fin,str);
	cout<<str<<endl;	
	fin.close();
	
	return 0;
}






/*
	The difference between cout and fout is that cout is pre-defined whereas we have to define/create
	fout by our own.
	cout/cin are connected to console whereas fout/fin are connected to files.
	
	
	Functionally they are same.
*/
