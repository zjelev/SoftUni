#include <iostream>
int main()
{int a,b,c;
std::cout<<"Vavedete a= ";std::cin>>a;
std::cout<<"Vavedete b= ";std::cin>>b;
std::cout<<"Vavedete c= ";std::cin>>c;
if(a>b && a>c)
std::cout<<"A is maximum!"<<"\n";
else if(b>a && b>c)
std::cout<<"B is maximum!"<<"\n";
else
std::cout<<"C is maximum!"<<"\n";
return 0;
}