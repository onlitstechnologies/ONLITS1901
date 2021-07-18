#include <stdio.h>
#include <stdlib.h>

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
    int size = 0;
    int *arr = malloc(MAX * sizeof(int));
    menu(arr, &size);
    return 0;
}

void menu(int *arr, int *size)
{
    int in, no;
    int ch; //O(1)
    do
    {
        printf("**************************** MAIN MENU **********************************\n");
        printf("1. Display (Traverse)\n");
        printf("2. Insert (at the end)\n");
        printf("3. Insert (at a specified index)\n");
        printf("6. Search (Linear)\n");
        printf("13. Delete (from the end)\n");
        printf("14. Delete (from a specified index)\n");
        printf("Enter your choice (0 to exit): ");
        scanf("%d", &ch);
        switch (ch)
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
        case 3:
            printf("Enter index: ");
            scanf("%d", &in);
            insert_index(arr, size, in);
            break;
        case 6:
            printf("Enter number to search: ");
            scanf("%d", &no);
            search_linear(arr, size, no);
            break;
        case 13:
            delete_end(arr, size);
            break;
        case 14:
            printf("Enter index: ");
            scanf("%d", &in);
            delete_index(arr, size, in);
            break;
        default:
            printf("\nInvalid option!\n\n");
        }
    } while (1);
}

void display(int *arr, int *size) //O(N) - linear
{
    if (*size == 0) //O(1)
    {
        printf("\nThe array is empty. There is nothing to display!\n\n"); //O(1)
    }
    else //O(1)
    {
        printf("\nThe elements of the array are:\n"); //O(1)
        for (int i = 0; i < *size; i++)               //O(N)
        {
            printf("%d\n", arr[i]); //O(N)
        }
        printf("\n"); //O(1)
    }
}

void insert_end(int *arr, int *size) //O(1) - constant
{
    if (*size == MAX)
    {
        printf("\nThe array is full. Cannot insert anymore!\n\n");
    }
    else
    {
        printf("Enter a number: ");                       //O(1)
        scanf("%d", &arr[*size]);                         //O(1)
        printf("\nItem inserted at index %d\n\n", *size); //O(1)
        (*size)++;                                        //O(1)
    }
}

/*
    O(1) + O(1) + O(1) + O(1)   =   O(4 X 1) =  O(1)
*/

void insert_index(int *arr, int *size, const int in)
{
    if (*size == MAX)
    {
        printf("\nThe array is full. Cannot insert anymore!\n\n");
    }
    else if (in >= *size)
    {
        printf("\nIndex is out of range. Valid range is 0 to %d.\n\n", *size - 1);
    }
    else
    {
        for (int i = *size; i > in; i--)
        {
            arr[i] = arr[i - 1];
        }

        printf("Enter a number: ");
        scanf("%d", &arr[in]);
        printf("\nItem inserted at index %d\n\n", in);
        (*size)++;
    }
}

void search_linear(int *arr, int *size, const int val)
{
    for (int i = 0; i < *size; i++)
    {
        if(arr[i] == val)
        {
            printf("\n%d found at index %d.\n\n", val, i);
            break;
        }
    }
}

void delete_end(int *arr, int *size) //O(1)
{
    if (*size == 0) //O(1)
    {
        printf("\nThe array is empty. There is nothing to delete!\n\n"); //O(1)
    }
    else //O(1)
    {
        (*size)--;                                        //O(1)
        printf("\nItem at index %d deleted.\n\n", *size); //O(1)
    }
}

void delete_index(int *arr, int *size, const int in)
{
    if (*size == 0)
    {
        printf("\nThe array is empty. There is nothing to delete!\n\n"); //O(1)
    }
    else if (in >= *size)
    {
        printf("\nIndex is out of range. Valid range is 0 to %d.\n\n", *size - 1);
    }
    else
    {
        for (int i = in; i < *size; i++)
        {
            arr[i] = arr[i + 1];
        }
        (*size)--;
        printf("\nItem at index %d deleted.\n\n", in); //O(1)
    }
}