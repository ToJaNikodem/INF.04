#include <iostream>
#include <random>

using namespace std;

void sorter(int numbers[])
{
    int temp;

    for (int i = 0; i < 99; i++)
    {
        for (int j = 0; j < 99 - i; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
}

int main()
{
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> distr(1, 100);

    int numbers[100];

    for (int i = 0; i < 100; i++)
    {
        numbers[i] = distr(gen);
    }

    sorter(numbers);

    cout << "Posortowana tablica: " << endl;

    for (int i = 0; i < 100; i++)
    {
        cout << numbers[i] << ", ";
    }

    return 0;
}