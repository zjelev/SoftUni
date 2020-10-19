#include <stdio.h>
int main(void)
{
    int i;    // i is an int
    int *p;   // this is a * in a type-name. It means p is a pointer-to-int
    p = &i;   // use & operator to get a pointer to i, assign that to p.
    *p = 4;   // use * operator to "dereference" p, meaning 4 is assigned to i. 
    printf("This is a pointer %i\n", *p);

    int x = 5; //5 is located in memory at, for example, 0xbffff804
    int *y = &x; //&x is the same thing as 0xbffff804, so y now points to that address
    printf("This is a pointer %i\n", &y);
    return 0;
}