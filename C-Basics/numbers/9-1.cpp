#include <iostream.h>
int main()
{char c;
cin>>c;
if (c<'a'||c>'z')
{cout << "Incorrect Input \n";
return 1;
}
cout << (char)(c-'a'+'A')<< '\n';
return 0;
}