#include <iostream>

using namespace std;

/*
    * klasa: Note
    * opis: klasa opisująca notatkę
    * pola: count - statyczne pole przechowujące ilośc notatek
    *       identifier - identyfikator notatki
    *       title - tytuł notatki
    *       text - treść notatki
    * autor: 00000000000
*/
class Note
{
private:
    static int count;
    int identifier;

protected:
    string title, text;

public:
    Note(string newNoteTitle, string newNoteText)
    {
        title = newNoteTitle;
        text = newNoteText;
        count++;
        identifier = count;
    }
    void displayNote()
    {
        cout << "Tytuł: " << title << endl;
        cout << "Treść notatki: " << text << endl;
    }
    void debug()
    {
        cout << "Licznik: " << count << "; Identifikator: " << identifier << "; Tytuł: ";
        cout << title << "; Treść: " << text << "; " << endl;
    }
};

int Note::count = 0;

int main()
{
    string newNoteTitle;
    string newNoteText;

    cout << "Podaj tytuł notatki: ";
    cin >> newNoteTitle;

    cout << "Podaj treść notatki: ";
    cin >> newNoteText;

    Note note1(newNoteTitle, newNoteText);

    note1.displayNote();
    note1.debug();

    cout << "\nPodaj tytuł notatki: ";
    cin >> newNoteTitle;

    cout << "Podaj treść notatki: ";
    cin >> newNoteText;

    Note note2(newNoteTitle, newNoteText);

    note2.displayNote();
    note2.debug();
}