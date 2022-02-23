#include <iostream>
#include <string>

using namespace std;

int main() {
    /*string firstName, lastName, town;
    double b1, b2, h;
    cin >> b1;
    cin >> b2;
    cin >> h;
    double area = (b1+b2)*h/2;
    cout << "Trapezoid area = " << area << endl;
    cin >> firstName;
    cin >> lastName;
    cin >> town;
    cout << "hello, " << firstName << " " << lastName << " from " << town << endl;
    */
    int num1, num2;
    string meter;
    cin >> num1;
    cin >> num2;
    if (num1>num2) {
        cout << "Bigger is " << num1 << endl;
    }
        else if (num1<num2)  {
            cout << "Bigger is " << num2 << endl;
        }
            else  {
            cout << "Numbers are equal" << endl;
            }
    return 0;
}