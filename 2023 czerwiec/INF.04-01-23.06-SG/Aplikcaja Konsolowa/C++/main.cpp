#include <iostream>
#include <cmath>

using namespace std;

/*
    * nazwa funkcji: addNumbers
    * parametry wejściowe: numbers - tablica do której zostaną dodane liczby
    * wartość zwracana: brak
    * informacje: funkcja dodająca liczby do tablicy
    * autor: 00000000000
*/
void addNumbers(int numbers[])
{
    for (int i = 2; i <= 100; i++)
    {
        numbers[i - 2] = i;
    }
}

int main()
{
    int n = 100;
    int numbers[n - 1];

    addNumbers(numbers);

    for (int i = 2; i < sqrt(n); i++)
    {
        for (int j = 0; j < 99; j++)
        {
            if (numbers[j] % i == 0)
            {
                numbers[j] = false;
            }
        }
    }

    cout << "Liczby pierwsze: ";

    for (int i = 0; i < 99; i++)
    {
        if (numbers[i] != 0)
        {
            cout << numbers[i] << ", ";
        }
    }

    return 0;
}
