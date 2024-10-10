#include <iostream>

using namespace std;
/*
    * nazwa funkcji: findGCM
    * opis funkcji: oblicza największy wspólny dzielnik
    * parametry: a – pierwsza liczba
    *           b – druga liczba
    * zwracany typ i opis: największy wspólny dzielnik podanych liczb
    * autor: 00000000000
*/
int findGCM(int a, int b)
{
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
    return a;
}

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

    int result = findGCM(a, b);

    cout << "Największy wspóly dzielnik: " << result << endl;

    return 0;
}
