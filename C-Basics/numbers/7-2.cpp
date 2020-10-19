#include <iostream.h>
int main()
{cout << "n= ";
int n;
cin >> n;
if (!cin)
{cout << "Error. Bad input! \n";
return 1;
}
if (n<=0)
{cout << "Incorrect Input! \n";
return 1;
}
int fact=1;
int i=1;
while (i<=n)
{fact=fact*i;
i++;
}
cout <<n<< "!= " <<fact<< "\n";
return 0;
}