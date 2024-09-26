#include <iostream>

using namespace std;

string sexFinder(int PESEL[])
{
    int sexNumberPosition = PESEL[9];
    if (sexNumberPosition % 2 == 0)
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
    int sum = 0;
    int j = 1;
    for (int i = 0; i < 10; i++)
    {
        if (j == 1)
        {
            sum += PESEL[i] * 1;
        }
        else if (j == 2)
        {
            sum += PESEL[i] * 3;
        }
        else if (j == 3)
        {
            sum += PESEL[i] * 7;
        }
        else if (j == 4)
        {
            sum += PESEL[i] * 9;
            j = 0;
        }
        j++;
    }

    int m = sum % 10;
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

    bool sum = controlSum(peselArray);
    cout << "Suma kontrolna: " << sum << endl;

    return 0;
}