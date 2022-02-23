#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main() {
    double size; 
    string sourcMetric, destMetric, dummy;
    cout << "Vavedete chislo ";
    cin >> size;
    cout << "Vavedohte " << size << " m" << endl;
    getline(cin, dummy);
    cout << "Vavedete source ";
    getline(cin, sourcMetric);
    transform(sourcMetric.begin(), sourcMetric.end(), sourcMetric.begin(), ::tolower);
    cout << "vavedohte source: " << sourcMetric << endl;
    
    cout << "Vavedete dest ";
    getline(cin, destMetric);
    transform(destMetric.begin(), destMetric.end(), destMetric.begin(), ::tolower);
    cout << "vavedohte dest: " << destMetric << endl;
 
    if (sourcMetric == "km") {
    size=size*0.001;
    }
    else {
        cout << "Error km ";
    }
    if (destMetric == "ft") {
        size=size*3.2808399;
    }
    else {
        cout << "Error ft ";
    }
    cout << "\n" << size << " " << destMetric << endl;
    return 0;
}