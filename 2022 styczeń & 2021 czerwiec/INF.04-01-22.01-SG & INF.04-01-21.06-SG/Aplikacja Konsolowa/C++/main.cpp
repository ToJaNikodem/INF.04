#include <iostream>

using namespace std;

class arraySorter
{
public:
    int numbers[10];

    void arrayInputer()
    {
        cout << "Podaj tablicę" << endl;
        for (int i = 0; i < 10; i++)
        {
            cout << "Wprowadź element " << i + 1 << ": ";
            cin >> numbers[i];
        }
    }

    /*
        * nazwa funkcji: sortArray
        * parametry wejściowe: brak
        * wartość zwracana: brak
        * autor: 00000000000
    */
    void sortArray()
    {
        int index;

        for (int i = 0; i < 10; i++)
        {
            index = i;
            for (int j = i + 1; j < 10; j++)
            {
                if (numbers[j] > numbers[index])
                {
                    index = j;
                }
            }
            swap(numbers[index], numbers[i]);
        }
    }

    int sortArrayAndFindMax(int tactic)
    {
        sortArray();

        return findMax(tactic);
    }

    void printArray()
    {
        cout << "Tablica: ";

        for (int i = 0; i < 10; i++)
        {
            cout << numbers[i] << ", ";
        }
    }

private:
    /*
        * nazwa funkcji: findMax
        * parametry wejściowe: tactic - parametr wybierający taktykę
        * wartość zwracana: dla taktyki 0 zwraca wartość maksymalną, a dla taktyki 1 zwraca indeks wartości maksymalne
        * autor: 00000000000
    */
    int findMax(int tactic)
    {
        int max = numbers[0];
        int maxIndex = 0;
        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }

        if (tactic == 0)
        {
            return max;
        }
        else if (tactic == 1)
        {
            return maxIndex;
        }
        return -1;
    }
};

int main()
{
    arraySorter newArraySorter;

    int tactic = 0;

    newArraySorter.arrayInputer();
    int max = newArraySorter.sortArrayAndFindMax(tactic);

    if (tactic == 0)
    {
        cout << "Największa wartość w tablicy to: " << max << endl;
    }
    else if (tactic == 1)
    {
        cout << "Index największego elementu w tablicy to: " << max << endl;
    }

    newArraySorter.printArray();

    return 0;
}
