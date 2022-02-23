#include <math.h>
#include <iostream>
using namespace std;
int main()
{double a,b,c;
cout<<"Vavedete a= ";cin>>a;
cout<<"Vavedete b= ";cin>>b;
cout<<"Vavedete c= ";cin>>c;
bool x=a<=0 || b<=0 || a+b<=c || a+c<=b || b+c<=a;
if(x)
cout<<"No such triygylnik!"<<endl;
else if (a==b && b==c)
cout<<"Triygylnika e ravnostranen!"<<endl;
else if (a==b || b==c || a==c)
cout<<"Triygylnika e ravnobedren! \n"<<endl;
else
cout<<"Triygylnika e raznostranen! \n"<<endl;
return 0;
}