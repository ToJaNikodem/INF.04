#include <iostream>

using namespace std;

string plec(int PESEL[])
{
    int plec_p = PESEL[9];
    if (plec_p % 2 == 0)
    {
        return "k";
    }
    else
    {
        return "m";
    }
}

bool sum_kontr(int PESEL[])
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

    int pesel_array[11];

    for (int i = 0; i < pesel.length(); i++)
    {
        pesel_array[i] = pesel.at(i) - '0';
    }

    string sex = plec(pesel_array);
    cout << "Płeć: " << sex << endl;

    bool suma = sum_kontr(pesel_array);
    cout << "Suma kontrolna: " << suma << endl;

    return 0;
}