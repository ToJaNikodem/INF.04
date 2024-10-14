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

    Osoba(const Osoba &otherPerson)
    {
        id = otherPerson.id;
        name = otherPerson.name;
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
    cout << "Liczba zarejestrowanych osób to: " << Osoba::count << endl;

    Osoba osoba1;

    int id;
    string name;

    cout << "Podaj id osoby: ";
    cin >> id;
    cout << "Podaj imię osoby: ";
    cin >> name;

    Osoba osoba2(id, name);
    Osoba osoba3 = osoba2;

    osoba1.showName("Jan");
    osoba2.showName("Jan");
    osoba3.showName("Jan");

    cout << "Liczba zarejestrowanych osób to: " << Osoba::count << endl;

    return 0;
}
