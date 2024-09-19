#include <iostream>
#include <random>

using namespace std;

class DiceThrow
{
public:
    int randomNumbers[10];

    void displayRandomNumbers(int numberOfDice)
    {
        for (int i = 0; i < numberOfDice; i++)
        {
            cout << "Kostka " << i + 1 << ": " << randomNumbers[i] << endl;
        }
    }

    void generateRandomNumbers(int numberOfDice)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> distr(1, 6);

        for (int i = 0; i < numberOfDice; i++)
        {
            randomNumbers[i] = distr(gen);
        }
    }

    int calculatePoints(int numberOfDice)
    {
        int points = 0;
        bool isRepeating = false;

        for (int i = 0; i < numberOfDice; i++)
        {
            for (int j = 0; j < numberOfDice; j++)
            {
                if (randomNumbers[i] == randomNumbers[j] && i != j)
                {
                    points += randomNumbers[j];
                    isRepeating = true;
                    randomNumbers[j] = 0;
                }
            }
            if (isRepeating == true)
            {
                points += randomNumbers[i];
                isRepeating = false;
            }
        }
        return points;
    }
};

int main()
{
    int numberOfDices;

    do
    {
        cout << "Ile kostek chcesz rzucić? (3 - 10)" << endl;
        cin >> numberOfDices;
    } while (numberOfDices < 3 || numberOfDices > 10);

    DiceThrow newDiceThrow;

    newDiceThrow.generateRandomNumbers(numberOfDices);
    newDiceThrow.displayRandomNumbers(numberOfDices);
    cout << "Liczba uzyskanych punktów: " << newDiceThrow.calculatePoints(numberOfDices) << endl;

    string userInput = "t";

    while (userInput != "t" || userInput != "n")
    {
        cout << "Jeszcze raz? (t/n)" << endl;
        cin >> userInput;
        if (userInput == "t")
        {
            newDiceThrow.generateRandomNumbers(numberOfDices);
            newDiceThrow.displayRandomNumbers(numberOfDices);
            cout << "Liczba uzyskanych punktów: " << newDiceThrow.calculatePoints(numberOfDices) << endl;
        }
        else
        {
            exit(0);
        }
    }

    return 0;
}