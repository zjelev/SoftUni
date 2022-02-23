#include <iostream.h>
int main()
{cout << "x= ";
double x;
cin >> x;
if (!cin)
{cout << "Error. Bad input! \n";
return 1;}
if (n<=0)
{cout << "Incorrect Input! \n";
return 1;}
int fact=1;
for (int i=1;i<=n;i++)
fact=fact*i;
cout <<n<< "!= " <<fact<< "\n";
return 0;
}