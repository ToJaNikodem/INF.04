#include <iostream>

using namespace std;

class arraySorter
{
public:
    int numbers[10];

    void inputer()
    {
        cout << "Podaj tablicę" << endl;
        for (int i = 0; i < 10; i++)
        {
            cout << "Wprowadź element " << i << ": ";
            cin >> numbers[i];
        }
    }

    // function returns number when tactic = 0 and returns index when tactic = 1
    int sortAndFindMax(int tactic)
    {
        int index;

        for (int i = 0; i < 10; i++)
        {
            index = i;
            for (int j = i + 1; j < 10; j++)
            {
                if (numbers[j] < numbers[index])
                {
                    index = j;
                }

                swap(numbers[index], numbers[i]);
            }
        }

        return findMax(tactic);
    }

private:
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
    }
};

int main()
{
    arraySorter newArraySorter;

    int tactic = 0;

    newArraySorter.inputer();
    int max = newArraySorter.sortAndFindMax(tactic);

    if (tactic == 0) {
        cout << "Największa wartość w tablicy to: " << max;
    } else if (tactic == 1) {
        cout << "Index największego elementu w tablicy to: " << max;
    }

    return 0;
}
