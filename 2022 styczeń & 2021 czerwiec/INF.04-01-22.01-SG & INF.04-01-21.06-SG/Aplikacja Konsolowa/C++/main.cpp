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

    // function returns number when tactic = 0 and returns index when tactic = 1
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
    // function returns number when tactic = 0 and returns index when tactic = 1
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
