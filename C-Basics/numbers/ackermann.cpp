#include <iostream>
 
unsigned int ackermann(unsigned int m, unsigned int n) {
  if (m == 0) {
    return n + 1;
  }
  if (n == 0) {
    return ackermann(m - 1, 1);
  }
  return ackermann(m - 1, ackermann(m, n - 1));
}
 
int main() 
{
unsigned int p, q;
std::cout << "Vavedete m<4\n";
std::cin >> p;
if (p>=4) {
  std::cout << "Number is too big!!!\n";
  return 1;
}
else {
  std::cout << "Vavedete n<14\n";
  std::cin >> q;
  if (q>=14) {
  std::cout << "Number is too big!!!\n";
  return 1;
}
for (unsigned int m = 0; m < p; ++m) {
    for (unsigned int n = 0; n < q; ++n) {
      std::cout << "A(" << m << ", " << n << ") = " << ackermann(m, n) << "\n";
    }
  }
}
return q;
}