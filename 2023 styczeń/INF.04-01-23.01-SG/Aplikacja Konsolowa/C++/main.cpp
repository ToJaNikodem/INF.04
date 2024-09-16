#include <iostream>

using namespace std;

int main()
{
    int a, b;

    cout << "Wprowadz pierwszą liczbę: ";
    cin >> a;

    cout << "Wprowadz drugą liczbę: ";
    cin >> b;

    if (!(a % 1 == 0 && b % 1 == 0 && a > 0 && b > 0))
    {
        cout << "Niepoprawne liczby!" << endl;
    }

    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }

    cout << "Największy wspóly dzielnik: " << a << endl;

    return 0;
}
