#include <iostream>
#include <random>

using namespace std;

void addNumbers(int numbers[])
{
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> distr(1, 100);

    for (int i = 0; i < 50; i++)
    {
        numbers[i] = distr(gen);
    }
}

/*
    * nazwa funkcji: lookFor
    * argumenty: number - szukana liczba
    *            numbers - przeszukiwana tablica
    * typ zwracany: int, indeks szukanej liczby w tablicy albo 100 w przypadku nie znalezienia liczby
    * informacje: <opis>
    * autor: 00000000000
*/
int lookFor(int number, int numbers[])
{
    int i = 0;

    while (numbers[i] != 0)
    {
        if (numbers[i] == number)
        {
            return ++i;
        }
        i++;
    }
    return 100;
}

int main()
{
    int n = 50;
    int numbers[n + 1];

    numbers[n] = 0;

    addNumbers(numbers);

    int number;

    cout << "Podaj szukaną liczbę: ";
    cin >> number;

    int result = lookFor(number, numbers);

    if (result == 100)
    {
        cout << "Liczba nieznaleziona!" << endl;
    }
    else
    {
        cout << "Liczba znaleziona na pozycji: " << result << endl;
    }

    cout << "Tablica: ";

    for (int i = 0; i < 50; i++)
    {
        cout << numbers[i] << ", ";
    }

    return 0;
}
