#include <iostream>

using namespace std;
/*
    * nazwa klasy: Film
    * pola: title - przechowuje tytuł filmu
    * loanCount - ilość wypożyczonych filmów
    * metody: titleSetter, brak zwracanej wartości – ustawia tytuł filmu na podany
    *         titleGetter, zwraca nazwę filmu - zwraca nazwę filmu
    *         loanCountGetter, zwraca ilość wypożyczonych filmów - zwraca ilość wypożyczonych filmów
    *         loanCountIncrementer, brak zwracanej wartości - inkrementuje ilośc wypożyczonych filmów 
    * informacje: klasa opisująca film
    * autor: 00000000000
*/
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