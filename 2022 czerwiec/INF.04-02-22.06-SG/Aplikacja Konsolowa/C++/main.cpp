#include <iostream>

using namespace std;

class Osoba
{
private:
    int id;
    string name;

public:
    static int count;

    Osoba()
    {
        id = 0;
        name = "";
        count++;
    }

    Osoba(int newId, string newName)
    {
        id = newId;
        name = newName;
        count++;
    }

    Osoba(const Osoba &other)
    {
        count++;
    }

    void showName(string otherName)
    {
        if (!name.empty())
        {
            cout << "Cześć " << otherName << ", mam na imię " << name << endl;
        }
        else
        {
            cout << "Brak danych!" << endl;
        }
    }
};

int Osoba::count = 0;

int main()
{
    Osoba *newOsoba = new Osoba(1, "Kamil");
    newOsoba->showName("Nikodem");

    return 0;
}
