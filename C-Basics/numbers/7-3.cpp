#include <iostream.h>
int main()
{int count=0;
double average=0;
cout << "> ";
int number;
cin >> number;
while (number !=0)
{count++;
average=average+number;
cout << "> ";
cin >> number;
}
if (count !=0) average=average/count;
cout << "average= " <<average<< "\n";
return 0;
}