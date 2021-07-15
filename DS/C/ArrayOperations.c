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
    int ch;       //O(1)
    do            
    {
        printf("**************************** MAIN MENU **********************************\n");
        printf("1. Display (Traverse)\n");
        printf("2. Insert (at the end)\n");
        printf("13. Delete (from the end)\n");
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
            case 13:
                delete_end(arr, size);
                break;
            default:
                printf("\nInvalid option!\n\n");
        }
    } while (1);
    
}

void display(int *arr, int *size)     //O(N) - linear
{
    if(*size == 0)      //O(1)
    {
        printf("\nThe array is empty. There is nothing to display!\n\n"); //O(1)
    }
    else      //O(1)
    {
        printf("\nThe elements of the array are:\n");     //O(1)
        for(int i=0; i < *size; i++)      //O(N)
        {
            printf("%d\n", arr[i]);       //O(N)
        }
        printf("\n");         //O(1)
    }
}

void insert_end(int *arr, int *size)    //O(1) - constant
{
    printf("Enter a number: ");     //O(1)
    scanf("%d", &arr[*size]);       //O(1)
    printf("\nItem inserted at index %d\n\n", *size);   //O(1)
    (*size)++;  //O(1)
}

/*
    O(1) + O(1) + O(1) + O(1)   =   O(4 X 1) =  O(1)
*/

void delete_end(int *arr, int *size)
{
    (*size)--;
    printf("\nItem at index %d deleted.\n\n", *size);
}