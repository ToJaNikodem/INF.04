#include <iostream>

using namespace std;

class Film
{
protected:
    string title = "";
    int loanCount = 0;

public:
    void titleSetter(string newTitle)
    {
        title = newTitle;
    }

    string titleGetter()
    {
        return title;
    }

    int loanCountGetter()
    {
        return loanCount;
    }

    void loanCountIncrementer()
    {
        loanCount++;
    }
};

int main()
{
    Film film1;

    cout << "Tytuł: " << film1.titleGetter() << endl;
    cout << "Liczba wypożyczeń: " << film1.loanCountGetter() << endl;

    film1.titleSetter("Harry Poter");
    film1.loanCountIncrementer();

    cout << "Tytuł: " << film1.titleGetter() << endl;
    cout << "Liczba wypożyczeń: " << film1.loanCountGetter() << endl;
}