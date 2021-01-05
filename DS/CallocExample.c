#include<stdio.h>
#include<stdlib.h>

struct student
{
	char name[25];
	float age;
	int id_num;
};

typedef struct student record;	//declaration

record *st_ptr;				//declaration
//struct student *st_ptr;

int class_size = 5;			//declaration

int main()
{
	st_ptr = (record *)calloc(class_size, sizeof(record));
	
	printf("Enter Name: ");
	scanf("%[^\n]", st_ptr->name);
	
	printf("Enter age: ");
	scanf("%f", &st_ptr->age);
	
	printf("Enter Id Number: ");
	scanf("%d", &st_ptr->id_num);
	
	printf("The details you entered are:\n");
	printf("Enter Name: %s\n", st_ptr->name);
	printf("Enter age: %1.2f\n", (*st_ptr).age);
	printf("Enter Id Number: %d\n", st_ptr->id_num);
	
	free(st_ptr);
	
	return 0;	
}
