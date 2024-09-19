#include <iostream>

using namespace std;

string sexFinder(int PESEL[])
{
    int sexPosition = PESEL[9];
    if (sexPosition % 2 == 0)
    {
        return "k";
    }
    else
    {
        return "m";
    }
}

bool controlSum(int PESEL[])
{
    int suma = 0;
    int j = 1;
    for (int i = 0; i < 10; i++)
    {
        if (j == 1)
        {
            suma += PESEL[i] * 1;
        }
        else if (j == 2)
        {
            suma += PESEL[i] * 3;
        }
        else if (j == 3)
        {
            suma += PESEL[i] * 7;
        }
        else if (j == 4)
        {
            suma += PESEL[i] * 9;
            j = 0;
        }
        j++;
    }

    int m = suma % 10;
    int r;

    if (m == 0)
    {
        r = 0;
    }
    else
    {
        r = 10 - m;
    }

    if (r == PESEL[10])
    {
        return true;
    }
    else
    {
        return false;
    }
}

int main()
{
    string pesel;
    cout << "Podaj pesel: " << endl;
    cin >> pesel;

    int peselArray[11];

    for (int i = 0; i < pesel.length(); i++)
    {
        peselArray[i] = pesel.at(i) - '0';
    }

    string sex = sexFinder(peselArray);
    cout << "Płeć: " << sex << endl;

    bool suma = controlSum(peselArray);
    cout << "Suma kontrolna: " << suma << endl;

    return 0;
}