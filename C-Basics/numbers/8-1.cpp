#include <iostream.h>
int main()
{cout << "m= ";
int m;
cin >> m;
if (!cin)
{cout << "Error. Bad Input! \n";
return 1;
}
if (m<=0)
{cout<< "Incorrect Input! \n";
return 1;
}
cout << "n= ";
int n;
cin >> n;
if (!cin)
{cout<< "Error. Bad Input! \n";
return 1;
}
if (n<=0)
{cout<< "Incorrect Input! \n";
return 1;
}
if (m>n)
{cout<< "Incorrect Input! \n";
return 1;
}
int prod=1;
int i=m;
do
{prod=prod*i;
i++;
} while (i<=n);
cout <<prod<< "\n";
return 0;
}