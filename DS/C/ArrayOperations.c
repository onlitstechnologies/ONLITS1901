#include<stdio.h>
#include<stdlib.h>

#define MAX 100

void menu(int *arr, int *size);
void display(int *arr, int *size);
void insert_end(int *arr, int *size);
void insert_index(int *arr, int *size, const int in);
void insert_before(int *arr, int *size, const int ele);
void insert_after(int *arr, int *size, const int ele);
void search_linear(int *arr, int *size, const int val);
void search_binary(int *arr, int *size, const int val);
void sort_selection(int *arr, int *size);
void sort_bubble(int *arr, int *size);
void sort_insertion(int *arr, int *size);
void sort_merge(int *arr, int *size);
void sort_heap(int *arr, int *size);
void delete_end(int *arr, int *size);
void delete_index(int *arr, int *size, const int in);
void delete_before(int *arr, int *size, const int ele);
void delete_after(int *arr, int *size, const int ele);
void merge(int *arr1, int *size1, int *arr2, int *size2);

int main()
{
    int size=0;
    int *arr = malloc(MAX * sizeof(int));
    menu(arr, &size);
    return 0;

}

void menu(int *arr, int *size)
{
    int ch;
    do
    {
        printf("**************************** MAIN MENU **********************************\n");
        printf("1. Display (Traverse)\n");
        printf("2. Insert (at the end)\n");
        printf("Enter your choice (0 to exit): ");
        scanf("%d", &ch);
        switch(ch)
        {
            case 0:
                exit(0);
                break;
            case 1:
                display(arr, size);
                break;
            case 2:
                insert_end(arr, size);
                break;
            default:
                printf("\nInvalid option!\n\n");
        }
    } while (1);
    
}

void display(int *arr, int *size)
{
    if(*size == 0)
    {
        printf("\nThe array is empty. There is nothing to display!\n\n");
    }
    else
    {
        printf("\nThe elements of the array are:\n");
        for(int i=0; i < *size; i++)
        {
            printf("%d\n", arr[i]);
        }
        printf("\n");
    }
}

void insert_end(int *arr, int *size)
{

}